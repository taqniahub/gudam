$Servers = get-content C:\GSRSTools\PScript\servers.txt
$CounterList = Get-Content C:\GSRSTools\PScript\counters.txt
$sw = new-object system.IO.StreamWriter("C:\GSRSTools\PScript\perf.res",1)
$Counters = $CounterList | Get-content $Servers
foreach($counter in $counters)
{ $counter.ToString() 
foreach($sampleset in $counter.CounterSamples)
{       
$sw.writeline($sampleset.Timestamp.ToString()+','+$sampleset.Path + ',' +$sampleset.CookedValue )
}
}
$sw.close()

