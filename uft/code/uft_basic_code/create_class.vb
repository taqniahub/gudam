How to use class (user defined) in QTP
Here  is an example that shows how we can create a class in QTP.
Once we define the class, we can create its objects and then access its method and properties.


'declare the class viz. Book.

Class Book

    dim bn,bp
                  ' class has 2 variable members bn and bp.

    public Property Get bookname()
                               ' Get bookname property gets the book name of the object of Book
    bookname = bn
    End Property
  
    public Property Let  bookname(x)
    bn = x
                              ' Let  bookname property assigns value to the book name of the object of Book
    End Property
  
  
    public Property Get price()
    price = bp
    End Property
  
    public Property Let  price(x)
    bp = x
    End Property

  
   function  discountedPrice()
   print bp-20
                       'We can have functions and procedures inside class to process memeber variables
   End function

End Class

  Set b1 = new  Book
                'createing the object b2 of the class Book.

  b1.bookname = "QTP Tutorials"
  b1.price = 220
                'assigning value to the object b1

  print b1.bookname()
               'getting the value of the property bookname.

               'accessing the function in class
  b1.discountedPrice()

  Set b1 = nothing
