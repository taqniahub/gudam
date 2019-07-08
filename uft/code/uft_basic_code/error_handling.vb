on error resume next
a = 2/0
'Above statement contains error - divide by zero.

if err.number <> 0 then
print "Error number is " & err.number & " "  & err.description
end if

'Remember that you can use on error resume next anywhere and any number of times in the code.
'To stop suppressing errors in QTP code you can use below statement.

On error goto 0
'After this statement, if any error occurs, script will prompt you with the error message.
b = 2/0

if err.number <> 0 then
print "Error number is " & err.number & " "  & err.description
end if

