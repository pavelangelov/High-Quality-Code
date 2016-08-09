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

  ## Class - Cosmetics.Products.Toothpaste

### Test cases:

  - Constructor should throw IndexOutOfRangeException, if any Ingredient.Length is invalid.
  - Constructor should set Ingredients, if passed parameter is correct.

  ## Class - Cosmetics.Products.ShoppingCart

### Test cases:

  - AddProduct should throw NullReferenceException, if passed parameter is null.
  - AddProduct should add product, if passed parameter is correct.
  - RemoveProduct should throw NullReferenceException, if passed parameter is null.
  - RemoveProduct should remove product, if passed parameter is correct.
  - TotalPrice should return right result.

  ## Class - Cosmetics.Engine.CosmeticsFactory

### Test cases:

  - CreateCategory should return new Category.
  - CreateShampoo should return new Shampoo and all properties must have correct value.
  - CreateToothpaste should return new Thoothpaste and all properties must have correct value.
  - ShoppingCart should return new ShoppingCart.

  ## Class - Cosmetics.Engine.CosmeticsEngine

### Test cases:

  - CreateCategory should call CreateCategory from factory, if input string is passed correctly.
  - AddToCategory should call AddCosmetics from Category.
  - RemoveFromCategory should call RemoveCosmetics from Category, if product exist.
  - RemoveFromCategory shouldn`t call RemoveCosmetics from Category, if product or category doesn`t exist.
  - ShowCategory should call Print from category.
  - CreateShampoo should call CreateShampoo from factory.
  - CreateToothpaste should call CreateToothpaste from factory.
  - AddToShoppingCart should call AddProduct from shoppingCart.
  - RemoveFromShoppingCart should call RemoveProduct from shoppingCart, if product exist.
  - RemoveFromShoppingCart shouldn`t call RemoveProduct from shoppingCart, if product doesn`t exist.