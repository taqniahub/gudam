String Function:

'What are the different String functions in QTP?
'Here is the list of all string functions in QTP.

'String functions to extract the part of the string -

'left  - gets the specified number of characters from the left side of string
'mid -gets the specified number of characters from the given position of the string
'right - gets the specified number of characters from the right side of string

'String functions to remove the spaces from the string -

'ltrim - removes the blank spaces from the left side of the string
'rtrim - removes the blank spaces from the right side of the string
'trim  - removes the blank spaces from the left and right side of the string


'Other String functions - 

'String      - Returns a string of the given length with specified character.
'Space     - Returns the empty string with given length
'strReverse - Reverses the given string
'ucase      - Converst the string to upper case
'lcase       - Converts the string to lower case
'strComp - Compares 2 strings
'replace   -  replaces the given string str1 from input string say str with other string say str2
'len - gets the number of characters in given string
'split - splits the string into array using given delimiter
'join - forms the string from given array elements
'cstr - converts the data type of the variable into  String
'chr - gets the character corresponding to the given ascii value
'Asc - gets the ascii value of the given character.
'instr - searches for a substring in a given string and returns the position where the match is found.
'InStrRev- searches for a substring in a given string and returns the position where the match is found from the end of the string.



To remove the spaces from string in QTP, you can use replace function.

print replace(" sdsd sd sd s "," ","")

' Output will be sdsdsdsds

If you want to remove only leading spaces from string then you can use ltrim function

print ltrim(" sdsd sd s ")
'Output will be "sdsd sd s " 

If you want to remove only trailing spaces from string then you can use rtrim function

print rtrim(" sdsd sd s ")
'Output will be " sdsd sd s" 

How to extract digits from a given string in QTP?

Below example will show how to extract digits from a given string in QTP.


Mystr = "Order number is 3445456"
Set myRegExp = New RegExp
'Create a regular expression object

myRegExp.Global = True
myRegExp.Pattern = "[^\d]"

'set the pattern to non-digital characters

strDigits = myRegExp.Replace(Mystr, "")

'replace all non - digit characters by empty string.

Print strDigits

'Prints 3445456


How to get the first character in the string in QTP
Example -code to get the first character of the string in QTP.

print left("abcd",1)   ' This will print a

To get the first 2 characters, just pass 2 in the second parameter.


How to replace the string in QTP
Example -
Below code will be used to replace a prt of string with new part in QTP.

str = "abcd"

'Suppose you want to replace cd with mn.

print replace(str,"cd","mn")   ' output will be abmn

