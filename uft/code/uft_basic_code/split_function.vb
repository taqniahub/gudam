Explain split function in QTP with example.
We can use split function to break the string using a delimiter.

For example -

Consider a string "pune*chennai*delhi*mumbai"

Now if you want to break the string you can do it using split function.

cities = "pune*chennai*delhi*mumbai"
arrayOfCities = split(cities,"*")

'Split function returns the sub strings in the form of array - (here arrayOfCities ).

For i=0 to ubound(arrayOfCities)

Print arrayOfCities(i)

next



The syntax of Split function is given below - 

Split(Stringtosplit ,delimiter, occurence_Count, comparison_method)

In this function last 3 parameters are optional.

Default delimiter is space.
occurence_Count ->how many substrings should be returned in the array.

comparison_method -> This parameter will tell what kind of comparison should be used. i.e binary(case-sensitive) or textual (case-insensitive).
