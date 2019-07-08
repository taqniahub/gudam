How to remove the spaces from string in QTP
Example -

To remove the spaces from string in QTP, you can use replace function.

print replace(" sdsd sd sd s "," ","")

' Output will be sdsdsdsds

If you want to remove only leading spaces from string then you can use ltrim function

print ltrim(" sdsd sd s ")
'Output will be "sdsd sd s " 

If you want to remove only trailing spaces from string then you can use rtrim function

print rtrim(" sdsd sd s ")
'Output will be " sdsd sd s