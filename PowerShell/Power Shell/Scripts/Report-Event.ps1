# ==============================================================================================
# 
# Microsoft PowerShell Source File 
# 
# NAME: Report-Events.ps1
# 
# AUTHOR: Nizam Mahmood 
# DATE  : 11/26/2009

# USAGE EXAMPLES:
# PS C:\Scripts\> .\report-events.ps1
# PS C:\> get-content servers.txt | c:\scripts\report-events.ps1 
# 
# ==============================================================================================

Param([string]$report="$env:temp\EventLogReport.html",
      [int]$hours=24,
      [System.Management.Automation.PSCredential]$credential,
      [string]$smtp,
      [string]$SendTo,
      [string]$From,
      [string]$username,
      [string]$password,
      [switch]$debug
)


BEGIN {
    #if -debug is passed as a parameter, enable debug messages
    if ($debug) {
        $DebugPreference="Continue"
    }
    
    #delete report file if it exists
    if ((Get-Item $report -ea "Silentlycontinue").Exists) {
        Write-Debug "Deleting $report"
        Remove-Item $report
    }
    
    [datetime]$cutoff=(Get-Date).AddHours(-$hours)
    
    #convert $cutoff to a DMTF format. Not necessarily required
    #but I think it makes the WMI query a little faster
    $dmtf=[System.Management.ManagementDateTimeConverter]::ToDmtfDateTime($cutoff)
    
    $subject="Event Log Report: {0} to {1} " -f $cutoff,(Get-Date)
    Write-Debug "`$cutoff is $cutoff"
    Write-Debug "`$subject is $subject"
    Write-Debug "`$smtp is $smtp"
    Write-Debug "`$Sendto is $Sendto"
    Write-Debug "`$From is $From"
    
    if ($credential) {
        Write-Debug "Using PSCredential $($credential.username)"
    }
    
    #define an embedded style sheet
    $style="<style type=""text/css""> `
    body { font-family:Tahoma; color:Black; Font-Size:10pt }`
    .error {background-color:#FF0000;} `
    .audit {background-color:#FFFF66;} `
    .header {background-color:#CCCCCC;} `
    </style>"
    
    #create variable to hold all results
    $all=@()

} #end Begin scriptblock

PROCESS {
#my error handling traps
Trap {
    if ($_.Exception -match "RPC server is unavailable") {
        Write-Warning "$computername is not available via RPC."
        continue
    }
    
    elseif ($_.Exception -match "access is denied") {
        Write-Warning "Access denied to $computername."
        continue
    }
    else {
        Write-Warning "There was an error"
        Write-Warning $_
        continue
    }
}

#take pipelined input for computername
    if ($_) {
    $computername=$_.ToUpper()
    }
    else {
    #if nothing passed then use current computername
    $computername=$env:computername
    }
    Write-Debug "Processing $computername"

    $query="Select ComputerName,Message,TimeWritten,Type,SourceName,EventCode,Logfile from win32_NTLogEvent WHERE (Type='warning' OR Type='error' OR Type='Audit Failure') AND TimeWritten>'$dmtf'"
    Write-Debug $query
    
    $cmd='Get-WmiObject -ComputerName $computername -query $query'
    
    if ($credential) {
        $cmd=$cmd + " -credential `$credential"
    }
    
    Write-Debug $cmd
    
#get matching Event logs

    Write-Host "Querying event logs on $computername" -foregroundcolor Green
    
    $results=Invoke-Expression $cmd  | 
    select @{name="Computername";Expression={($_.ComputerName).ToUpper()}},Message,`
    @{name="TimeWritten";Expression={$_.ConvertToDateTime($_.TimeWritten)}},`
    Type,SourceName,EventCode,Logfile

    if ($results.count -gt 0) {
      Write-Debug "Returned $($results.count) events for $($computername)"
      $all+=$results
    }
    else {
    Write-Warning "No matching events found for $computername"
    }

#add to running results

} #end Process scriptblock

END {

if ($all.count -gt 0) {
    $footer="</table><br><Font Size=2><I>Report generated {0} by {1}\{2}</I></Font>" -f (Get-Date),$env:userdomain,$env:username
    
    #convert running results to an HTML file
    $html = $all | ConvertTo-Html -Title $subject -head $style
    
    #parse HTML file and add color highlighting
    $colorized=@()

    foreach ($line in $html) {
        Switch -regex ($line) {
          "<th>\w+</th>"  {
                            Write-Debug "Colorizing header"
                            $colorized+=$line.Replace("<tr>","<tr class=""header"">")
    
                            }   
          "<td>Error</td>"  {
                            Write-Debug "Colorizing Error"
                            $colorized+=$line.Replace("<tr>","<tr class=""error"">")
    
                            }   
    
          "<td>Audit Failure</td>"  {
                            Write-Debug "Colorizing Audit Failure"
                            $colorized+=$line.Replace("<tr>","<tr class=""audit"">")
    
                              }   
          "</table>"  {
                            Write-Debug "Adding footer $($footer)"
                            $colorized+=$line.Replace("</table>",$footer)
          }   
                                                     
        Default {
            $colorized+=$line
        }
       } #end Switch
    } 
    
    Write-Debug "Sending colorized output to $($report)"
    $colorized | Out-File $report
    
        #if a mail server was specified, send email
        If ($smtp) {
            #send mail function
            Function Send-NetMail {
                Param([string]$smtp="mail.sapien.com",
                     [string]$SendTo,
                     [string]$From,
                     [string]$subject,
                     [string]$body,
                     [string]$file,
                     [string]$username,
                     [string]$password
                    )
            #Create SMTP Client object        
            $mail = New-Object system.net.mail.smtpclient($smtp)
            
            #if credentials specifiec create NetworkCredential object
            if ($username -and $password) {
                $mailcred=New-Object system.net.NetworkCredential ($username,$password)
                $mail.credentials=$mailcred
            }
            
            $msg = New-Object system.Net.Mail.MailMessage ($From,$SendTo,$subject,$body)
            
            #if file attachment specified, add it to the message
            if ($file) {
                $attach=New-Object system.Net.Mail.Attachment $file
                $msg.Attachments.add($attach)
            }
            
            #send message
            $mail.send($msg)
            
            }       
          
            #validate other mail parameters
            if (! $SendTo -or ! $From) {
                Write-Warning "You forgot to specify either -SendTo and/or -From"
            }
            else {
                Write-Debug "Sending mail to $SendTo"
                $body="See the attached report for recent error events."
                Send-NetMail -smtp $smtp -Sendto $SendTo -from $From `
                -subject $subject -body $body -username $username `
                -password $password -file $report
                
                Write-Host "Sending mail to $SendTo" -foregroundcolor Green
            }
          
        }
    Write-Host  "Finished. See $report for results." -foregroundcolor Green

}
else {
    Write-Host "Finished. No results found." -foregroundcolor Magenta

 }
} #end End scriptblock



