# Tests Requirements

## Class - Cosmetics.Products.Category

### Test cases:

 - Constructor should throw NullReferenceException, when the Name is null.
 - Constructor should throw IndexOutOfRangeException, when the Name.Length is smaller than 2. 
 - Constructor should throw IndexOutOfRangeException, when the Name.Length is greather than 15.
 - Constructor should set Name, if passed parameter is correct.
 - AddCosmetics should throw NullReferenceException, when passed parameter is null.
 - AddCosmetics should add product, if passed parameter is correct.
 - RemoveCosmetics should throw NullReferenceException, when passed parameter is null.
 - RemoveCosmetics should throw InvalidOperationException, if collection does`t contain the product.
 - RemoveCosmetics should remove product, if passed parameter is correct.

 ## Class - Cosmetics.Products.Product

### Test cases:

 - Constructor should throw NullReferenceException, when the Name is null.
 - Constructor should throw IndexOutOfRangeException, when the Name.Length is smaller than 3. 
 - Constructor should throw IndexOutOfRangeException, when the Name.Length is greather than 10.
 - Constructor should throw NullReferenceException, when the Branch is null.
 - Constructor should throw IndexOutOfRangeException, when the Branch.Length is smaller than 2. 
 - Constructor should throw IndexOutOfRangeException, when the Branch.Length is greather than 10.
 - Constructor should create object with all properties, if passed parameters are correct.