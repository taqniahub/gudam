$current = get-date

$oldDate = $current.adddays(-30)

get-eventlog -logname applicatoin -computername gtsw01 | where{$_.timegenerated -gt $olddate}

