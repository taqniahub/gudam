
cd c:\gsrstools\pscript
$Servers = Get-Content “devservers.txt” 
$tmpFile = "c:\gsrstools\pscript\devhdinfo.txt"
echo '' > $tmpFile

foreach($Server in $Servers) 
 
{

#select fixed drives only by specifying a drive type of 3
$Drives=Get-WmiObject -class win32_logicaldisk -computer $Server| 
where {$_.DriveType -eq 3} 
write-Host -Fore green  "Server Name  `t `t `t Size (GB)`t FreeSpace (GB)`t FreeSpace (%)" 
out-file -filepath $tmpFile -inputobject "Server Name  `t  Size (GB) FreeSpace (GB)  FreeSpace (%)"  -append

foreach ($d in $Drives) {
      $free="{0:N2}" -f ($d.FreeSpace/1073741824)
      $size="{0:N0}" -f ($d.size/1073741824)
      $perc="{0:N0}" -f ($d.FreeSpace/1073741824/($d.size/1073741824)*100)
Write-Host $server $d.deviceID `t `t `t   $size `t `t `t $free `t  $perc
out-file -filepath $tmpFile -inputobject "$server $($d.deviceID) `t    $size `t  $free `t  $perc"  -append

}

}


$smtpServer = "mail.manulife.com"

$msg = New-Object system.net.mail.mailmessage

$smtp = new-object System.Net.Mail.SmtpClient($smtpServer)

$msg.From = "gsrsmonitor@manulife.com"
$msg.To.Add("nizam_mahmood@manulife.com")
$msg.Subject = "GSRS Prodcution Servers-Hard Disk Statistics"
$body = $(([System.IO.File]::ReadAllText($tmpFile)).trim())
$msg.Body = $body
Write-Output "Send E-Mail"
$smtp.Send($msg)

#remove-item $tmpFile -force






