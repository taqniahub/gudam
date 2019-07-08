'Dictionary object is used to store the data in key-item pairs in qtp.

'A Dictionary object is just like an associative array.
'It stores the data in the form of key-item pairs.
'Each key has some data item associated with it.
'Key can be integer or string format.
'Data item can be integer or string or array of variants. It may contain other dictionary itself.

'Methods of Dictionary Object

'Add -------> Adds new key-item pair in the dictionary object
'Exists ----> returns true if the given key exists in the dictionary object
'Items -----> returns the array containing all items in the dictionary object
'Keys ------> returns the array containing all keys in the dictionary object
'Remove ----> removes the key-item pair with given key from the dictionary object
'RemoveAll -> removes all key-item pairs from the dictionary object

'Properties of Dictionary Object

'Count--------> returns the total number of keys in the dictionary object
'Item---------> assigns or returns the item value with given key from the dictionary object
'Key----------> sets the new key value for the given key
'CompareMode -> assigns or returns the comparison mode for comparing string keys in a Dictionary object.

'Example with dictionary object in QTP

'create new dictionary object
Set dictionaryObject = CreateObject("Scripting.Dictionary")

'add some key-item pairs
dictionaryObject.Add "1", "Sagar"  
dictionaryObject.Add "2", "Amol"
dictionaryObject.Add "3", "Ganesh"

'Display data in the dictionary
for each k in dictionaryObject.keys

 print k & " - " & dictionaryObject.item(k)

next


'Remove the key-item pair with key = 1  from the dictionary object
dictionaryObject.Remove("1")

'Remove all key-item pairs from the dictionary object
dictionaryObject.RemoveAll

'Release the object
Set dictionaryObject = nothing