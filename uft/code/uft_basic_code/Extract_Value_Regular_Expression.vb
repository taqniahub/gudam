Dim text_value, extract_value, i, convert_value, sp_string

text_value= "24,999 or less 25,000 to 49,999 50,000 to 79,999 80,000 to 99,999 1000,000 or more"

'Split string value with space
sp_string = split(text_value," ")

'Create RegExp object 
Set myRegExp = new  RegExp
myRegExp.Global = True

'Set the patter to non-digit character 
myRegExp.pattern ="[^\d]" 

'Replace all non digit character to empty string
For i = 0 To ubound(sp_string) Step 1      
  extract_value = myRegExp.replace(sp_string(i),"")	
 
  If extract_value <> "" Then
  		convert_value = CDbl(extract_value)
  		print "value is " &  convert_value
  Else
		print "Not a digit value " 
	 
 End If
   
Next