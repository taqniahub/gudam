$Servers = Get-Content “devServers.txt” 

foreach($Server in $Servers) 

{ 

$wmi=Get-WmiObject -class Win32_OperatingSystem -computer $Server

$LBTime=$wmi.ConvertToDateTime($wmi.Lastbootuptime)

[TimeSpan]$uptime=New-TimeSpan $LBTime $(get-date)

Write-host $server “Uptime: ” $uptime.days “Days” $uptime.hours “Hours” $uptime.minutes “Minutes” $uptime.seconds “Seconds”


}






