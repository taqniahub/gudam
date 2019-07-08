'In any QTP program related to regular expression, you will follow below steps.

'Create a regular expression object (RegExp)
'Define the pattern using RegExp object's pattern property.
'Use test method to check whether the given string matches with the pattern specified in step 2.
'Create the regular expression object

Set myRegEx = New RegExp 

'Specify the pattern (Regular Expression)
myRegEx.Pattern = "[a-z0-9]+@[a-z]+\.[a-z]+"

'Specify whether the matching is to be done with case sensitivity on or off.
myRegEx.IgnoreCase = True

'Use Test method to see if the given string is matching with the pattern
isMatched = myRegEx.Test("reply2sagar@gmail.com")

'Variable isMatched will be true if the string "reply2sagar@gmail.com" matches with the given pattern 
"[a-z0-9]+@[a-z]+\.[a-z]+"



How to use regular expression in descriptive programming in QTP?
As we know that there are 2 ways of descriptive programming.

Static
Dynamic
We can use  regular expression in both the ways as mentioned below. Please note that by default all the property values are considered as regular expressions by QTP.


' Regular Expressions in Static descriptive programming in QTP.

Browser("index:=0").page("title:=Google").Webedit("name:=q").set "sagar salunke"
Browser("creationtime:=0").page("title:=Google").Webbutton("name:=Google.*").Click

Please note that last statement uses regular expression to identify the button whose name starts with Google.
If your property value itself contains the special character then that should be escaped using \ character.

Example - Suppose you want to click on the link "+sagar".
Now this link contains the special character +. To click on this link, we can use below code
Browser("creationtime:=0").page("title:=Google").Link("innertext:=\+sagar").Click


' Regular Expressions in Dynamic descriptive programming in QTP.

Set descriptionObject = Description.Create()
descriptionObject("innertext").value = "+sgaar"
descriptionObject("innertext").RegularExpression = false

'Please note that we can specify whether the value is regular expression or not using RegularExpression property. By default it is true.

Browser("index:=0").page("title:=Google").Link(descriptionObject ).click

This is how we can use Regular Expressions in QTP


What are the metacharacters (special characters ) in regular expressions in QTP?
Below is the list of all meta characters in QTP. 


\ -  indicates that the next character would be a special character, a literal or a backreference

^  - Input String should be matched at the beginning. 

$  - Input String should be matched at the end. 

*  - Matches the preceding character zero or more times. It is same as {0,}.

+  -  Matches the preceding character one or more times.  It is same as {1,}.

?   - Matches the preceding character zero or one time.  It is same as {0,1}

{i} - Matches the previous character exactly i times. 

{i,} - Matches the previous character at least i times and at most any time. 

{i,j} -Matches the previous character at least i times and at the most j times. 

.     -  Matches any single character except "\n". 

(pattern) -  Matches pattern and captures the match that can be used in backreferences. 
 p|q  -  Matches either p or q. Please note that p and q could be more complex regular expressions

[pqr]  - A character set. Matches any one of the character inside the brackets.

[^pqr]  - A negative character set. Matches any character not inside the brackets. 

[p-z]   -  A range of characters. Matches any character in the specified range i.e p,q,r,....x,y,z. 

[^p-z]  -  A negative range characters. Matches any character not in the specified range i.e. a,b,c...m,n,o  

\b      -  Matches the boundary of the word

\B      -  Matches middle part of the word.

\d      -  Matches a digit character. same as [0-9]. 

\D      -  Matches a nondigit character. same as  [^0-9]. 

\f , \n and \r     -  Matches a form-feed character, newline and carriage character.

\s    - Matches any white space character including space, tab, form-feed. Equivalent to [ \f\n\r\t\v].

\S      - Matches any non-white space character. Equivalent to [^ \f\n\r\t\v]. 

\t  , \v   - Matches a horizontal and  vertical tab character. 

\w      - Matches alpha numeric character including underscore. Equivalent to '[A-Za-z0-9_]'. 

\W      - Matches any non - alpha numeric character. Equivalent to '[^A-Za-z0-9_]'. 

\number- A reference back to captured matches.

********************************************************************************** 

**********************************************************************************

Some examples on regular expressions:
To match the 10 digit mobile number ->  \d{10}
To match email address  -> \w+@\w+\.\w+

How to create the case insensitive regular expressions in QTP?
Many times we need to find the string in given file and we are not worried about the upper case or lower case. In such scenarios we can create case insensitive regular expressions in QTP.

Case Sensitive Search
'**********************************************
'With IgnoreCase = false
'**********************************************
  Set regExpObject = New RegExp   
  search_string = "Arjun tendulkar is the son of sachin tendulkar"
  regExpObject.Pattern = "Tendulkar"

  regExpObject.IgnoreCase = false

  set matches = regExpObject.execute(search_string)

   print matches.count
'**********************************************
'output is 0
'**********************************************

Case Insensitive Search
'**********************************************
'With IgnoreCase = true
'**********************************************
  Set regExpObject = New RegExp   
  search_string = "Arjun tendulkar is the son of sachin tendulkar"
  regExpObject.Pattern = "Tendulkar"

  regExpObject.IgnoreCase = true

  set matches = regExpObject.execute(search_string)

   print matches.count
'**********************************************
'output is 1

Explain RegExp Object in QTP
RegExp is a very important object in QTP that can be used to find the patterns in given string using regular expressions.

This object can be created using below syntax.
 Set regExpObject = New RegExp   

RegExp Object supports below properties.

Global Property     - a pattern should match all occurrences in string or just the first one
IgnoreCase Property - specifies if the search is case-sensitive or not
Pattern Property    - Sequence of literal characters and special characters (Meta Characters like *,?,+,\b,\d,\n etc)

RegExp Object supports below methods.

Test Method     - returns true if the pattern is found in the given string
Execute Method  - returns a Matches collection containing a Match object(having properties firstindex and value) for each match found in string.
Replace Method  - replaces the matched values in the given string by another value


Sample Example on Execute method.

'*******************************************************
 Set regExpObject = New RegExp   
  search_string = "MS dhoni is very lucky cricketer"
  regExpObject.Pattern = "lucky"

  regExpObject.Ignorecase = true
  regExpObject.Global = true
  
 Set matches  = regExpObject.execute(search_string)

 For each match in matches
  print  match.firstIndex & " - " & match.value
 Next


 Explain Global property of the RegExp object in QTP
Global property is used to tell how many matches should be found in the given string.

Examples to understand the global property are given below.

'**********************************************
'With global = false
'When we set the global property to false, we get only first match
'**********************************************
  Set regExpObject = New RegExp   
  search_string = "Arjun tendulkar is the son of sachin tendulkar"
  regExpObject.Pattern = "tendulkar"

  regExpObject.Global = false       

  set matches = regExpObject.execute(search_string)

   print matches.count

'**********************************************
'output is 1
'**********************************************



'**********************************************
'With global = true
'When we set the global property to true, we get all matches
'**********************************************
  Set regExpObject = New RegExp   
  search_string = "Arjun tendulkar is the son of sachin tendulkar"
  regExpObject.Pattern = "tendulkar"

  regExpObject.Global = true

  set matches = regExpObject.execute(search_string)

   print matches.count 

'**********************************************
'output is 2