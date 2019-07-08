'In QTP we can create dynamic array with any dimension.

'Syntax -  To declare dynamic array is given below.

Dim a()

'As shown above, we do not specify any dimension of array. 

'To define the size of array we have to use below statement.
ReDim a(6,6)

'In above statement, we have set the size of 2 dimensional array.

'To preserve the existing data in array you must use below syntax.

'ReDim preserve a(6,6)

'Example to demonstrate 2 dimensional dynamic array is given below.


Dim a()

ReDim preserve a(6,6)

a(5,5) = array(12,33,454)

a(0,0) = array(2,3,4)

a(3,2) = 333

print a(5,5)(0)        ' prints 12


print a(3,2)        ' prints 333
