How to check if substring exists in a string in QTP
To find a substring in a string you can use 2 approach in QTP.
Regular Expressions
Instr - string function
The following code illustrates the use of the RegExp object in QTP.

Function RegExpTest(patrn, strng)

Dim regEx, Match, Matches 
' Create variable.
Set regEx = New RegExp ' Create a regular expression.
regEx.Pattern = patrn ' Set pattern. 
regEx.IgnoreCase = True ' Set case insensitivity.
regEx.Global = True ' Set global applicability. 
Set Matches = regEx.Execute(strng) ' Execute search. 
For Each Match in Matches ' Iterate Matches collection. 
RetStr = RetStr & "Match found at position " 
Exit For 
 Next 
RegExpTest = RetStr
End Function

MsgBox(RegExpTest("abc", "jsdjshdabcskjdklsdj"))

Below code will find substring using instr function

If instr(1,"mainstring","main") > 0 Then
msgbox "main found in mainstring"
end if