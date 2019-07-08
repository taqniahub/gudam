What are the trim functions in QTP?
Trims functions are used to remove blank spaces from the string.

There are 3 trim functions in QTP as mentioned below.

ltrim     - removes leading (at the beginning) spaces from the string
rtrim     - removes trailing (at the end )spaces from the string
trim       - removes leading and trailing spaces from the string


Example -

print ltrim("  hello Tester   ")
'it will print "hello Tester   "

print rtrim("  hello Tester   ")
'it will print "  hello Tester"

print trim("  hello Tester   ")
'it will print "hello Tester"
'Please note that it does not remove the spaces from the middle of the string.