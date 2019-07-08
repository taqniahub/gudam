$servers = gc servers.txt

foreach ($server in $servers)
{
 
  $AppLog = Get-EventLog -LogName Application -EntryType Error -computer $server -Newest 5
  $SecLog = Get-EventLog -LogName Security -EntryType Error -computer $server -Newest 5 -ea Silentlycontinue
  $SysLog = Get-EventLog -LogName System -EntryType Error -computer $server -Newest 5
  foreach ($Cat in $AppLog,$Syslog,$Seclog)
  {
    if ($cat -is [array])
    {
      if ($AppLog -contains $cat[0]) {$Catname = "Application"}
      if ($SecLog -contains $cat[0]) {$Catname = "Security"}
      if ($SysLog -contains $cat[0]) {$Catname = "System"}
      
    }
  }
}