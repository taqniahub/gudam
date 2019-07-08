Explain replace function in QTP with Example.
Replace function is used to replace the part of the given string with other sub string in QTP.

Example -


myString = "Sachin plays cricket"


print replace(myString,"Sachin","Dhoni")
'Will print Dhoni plays cricket

print replace(myString,"sachin","Dhoni")
'Will print Sachin plays cricket. Because we have used sachin in small case letter

print replace(myString,"sachin","Dhoni",1,-1,0)
'Will print Sachin plays cricket .....Same as above

print replace(myString,"sachin","Dhoni",1,-1,1)

'Will print Dhoni plays cricket....
'The last parameter of replace determines whether the replacement is case-sensitive or case-insensitive.
'If last parameter is 0, replacement is case-sensitive
'If last parameter is 1, replacement is case-insensitive

Syntax -

 replace(myString,"replacethis","replacewith",startat,count,comparisonmehtod)

Parameter1 - myString - > String to be scanned and modified
Parameter2 - replacethis- > String to be searched and replaced for
Parameter3 - replacewith- > String to be replaced with
Parameter4 - startat- > from what position the myString should be searched...Default is 1.
Parameter5 - count- > How many replacements should be done. Default is -1 - All occurrences
Parameter6 - comparisonmehtod- > Is comparison case-sensitive?..Default is 0 - binary comparison.