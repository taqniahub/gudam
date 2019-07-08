'Ubound stands for upper bound. This functions is used to find the upper bound of the array.

'ubound(arrayname, dimension)

'It returns the upper bound of the arrayname and dimension used is specified in second parameter.
'By default dimension is 1.

'Single dimension array

Dim a(2)
'Declare an array with upper bound (index) as 2.

a(0) = 0
a(1) = 0
a(2) = 0

print ubound (a)           'will print 2
print ubound (a,1)        'will print 2

'This will print the value 2 as upper bound of the array is 2.

'Please note that size or length of the single dimension array is ubound + 1.

'Multi dimension array

Dim b(2,3,5)

print UBound(b, 1)           ' will print 2 

print UBound(b, 2)           '  will print 3 

print UBound(b, 3)           '  will print 5 