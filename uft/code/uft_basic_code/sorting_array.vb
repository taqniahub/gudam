a = array("bangalore","surat","Pune",1)

  For i=0 to ubound(a)
 
  For j=0 to ubound(a)
   If strComp(a(i),a(j),1) < 0  Then
    temp = a(i)
    a(i) = a(j)
    a(j) = temp
   End If
  Next
 
 Next

For i=0 to  ubound(a)

   print a(i)
  'It will print 1,bangalore, Pune, surat

Next


Please note that above example will sort the array in ascending order. To sort the array in descending order, you have to use below Code.

a = array("bangalore","surat","Pune",1)

  For i=0 to ubound(a)
 
  For j=0 to ubound(a)
   If strComp(a(i),a(j),1) > 0  Then
    temp = a(i)
    a(i) = a(j)
    a(j) = temp
   End If
  Next
 
 Next

For i=0 to  ubound(a)

   print a(i)
  'It will print  Pune, surat,bangalore,1

Next