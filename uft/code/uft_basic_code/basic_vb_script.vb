
' How to find array size
print (ubound(arr) + 1)

How to Exit For Loop in QTP

 For ct = 1 to 3
             TempNum = mid(Tempstr,ct,1)
              If isnumeric(TempNum) Then
                LengthNum = LengthNum &TempNum
               Else
                  Exit For
               End If
            Next
        GetStrLenNumber = LengthNum
		
		
		Difference between sub and function in QTP

Sub and Functions are used to write a common code that can be called many times in a programm in QTP.

Difference between Sub and Function is that We can return a value from a function but In sub it is not possible to return value.

Example - 

Sub mysub(b)

 a= 8*b
 print a

End Sub 


Public Function RandomCharacters(CharLength)
   str = ""
   intHighNumber = 90
   intLowNumber = 65
    Randomize
    For i = 1 to CharLength
        RdNumber = Int((intHighNumber - intLowNumber + 1) * Rnd + intLowNumber)
        stch = chr(RdNumber)
        str =   str&stch
    Next
    Reporter.ReportEvent micPass,"Random Character Generated","Random Character "&str&" was generated"
    RandomCharacters = str   'return a value from function
End Function


How to find the data type of variable in QTP
Vartype function can be used to find out the data type of a variable in QTP.
  
 
Dim mytype
mytype= VarType(400)          ' Returns 2.  means integer.
mytype= VarType(#11/19/62#)   ' Returns 7. means date .
mytype= VarType("VBshjhcript")   ' Returns 8. means string.
 
 
'TypeName can be used to find the readable data type in QTP
 
MType = TypeName("myVBScript")   ' Returns "String".
MType = TypeName(43)            ' Returns "Integer".
MType = TypeName(32.50)        ' Returns "Double".


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
'Output will be " sdsd sd s" 

