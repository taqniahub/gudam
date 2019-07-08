'How to extract the date part from the timestamp in QTP?
print datevalue("09-jan-1987 08:48 PM")

'To get the current system date you can use below syntax :-
print datevalue(now)

print monthname(month("09-jan-1986"))

print monthname(month("09-jan-1986"),true)

'how to find time difference in QTP
	time_stamp1 = datevalue("09-jan-1987 08:48 PM")
	time_stamp2 = datevalue(now)
	time_difference =datediff("n",time_stamp1, time_stamp2)   
	print time_difference


'It will print 20:48:00
	print timevalue("09-jan-1987 08:48 PM")


'To get the current system time you can use below syntax :-

	print timevalue(now)
	
	
	
print second("09:33:44")

print second(now)


'Syntax of DateAdd function in QTP.
'Dateadd(interval_Type, Interval_Units, date)
'Interval Type can be of below types.
'yyyy -  Year 
'm  - Month
'd  - Day
'h  - Hour 
'n  - Minute 
's  - Second

'Below statement will add 3 days to current date and return the date.
print dateadd("d",3,now) 

'This will calculate yesterday's date
print dateadd("d",-1,now)

'This will calculate tomorrow's date
print dateadd("d",1,now) 

'how to find future date in QTP
print DateAdd("d",2,date)  'print date (2 days ahead)


print date 
print year(now)


'1. Weekday(anyvalid_date)  -  returns the numeric representation of weekday.
'2. Weekdayname(intXs)         - returns human readable weekday name like monday, sunday etc

print weekdayname(weekday(now))

print weekdayname(weekday("09-jan-1986"))



'Below function will get the date in mm/dd/yyyy format.
Call Getdate("T") ''- will return todays date
Call Getdate("T+1")' - will return tommorrow's date 
Call Getdate("T-1")' - Will return previous day's date.

Function GetDate(byval curvalue)
   If  ucase(curvalue) = "T" Then
        curvalue = curvalue & "+0"
   End If


	If instr(1,curvalue,"+") > 0  Then
             arrdate = split(curvalue,"+")
             retDate = dateadd("d",arrdate(1),now)
             strmonth = month(cdate(retDate))
             strday = day(cdate(retDate))
             stryear = year(cdate(retDate))
             If len(strmonth) = 1 Then
                   strmonth = "0" & strmonth
             End If
                  If len(strday) = 1 Then
                            strday = "0" & strday
                       End If
Else

                        arrdate = split(curvalue,"-")
                        curDate = - cint(arrdate(1))
                       retDate = dateadd("d",curDate,now)
                    
                    
                       strmonth = month(cdate(retDate))
                       strday = day(cdate(retDate))
                       stryear = year(cdate(retDate))
                    
                       If len(strmonth) = 1 Then
                            strmonth = "0" & strmonth
                       End If
                    
                       If len(strday) = 1 Then
                            strday = "0" & strday
                       End If


End If
   
    If Ucase(strParameter1) = "YYYY-MM-DD" Then
        GetDate  = stryear & "-" & strmonth & "-" & strday
    Else
        GetDate  = strmonth & "/" & strday & "/" & stryear
    End If


End Function
	