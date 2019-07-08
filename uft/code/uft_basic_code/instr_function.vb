Give the example of instr function in QTP.
Instr function is used to check if String contains the given substring.

For Example -

If I want to check if IND is available in INDIA, I can do it using below code.

If instr(1,"INDIA","IND") > 0 then
   print "INDIA contains IND "
Else
  print "INDIA does not contain IND "
End IF

Syntax of Instr -

InStr(startOfSearch,String1,String2,ComparisonMethod)

startOfSearch -> From what position you have to start the search.
String1 -> String to be scanned
String2 -> String to find in String1
ComparisonMethod -> defaul 0 - means binary comparison - case sensitive
