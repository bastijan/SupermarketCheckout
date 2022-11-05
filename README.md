# Supermarket Checkout

**Note**

I received the following comment on this code kata solution "checkout cart" (actually task is this problem http://codekata.com/kata/kata09-back-to-the-checkout/) - branch "v1":

```
There were few things we didn’t like in your approach.

Eg.:
•	Mixing the logic and the presentation layer in one class which is abusing the single responsible principle
•	Or pushing the user input directly to the services without any validation
```

I think that the focus on the shell or the structure of the program instead of the solution algorithm is a wrong focus.

Also, not even in any MSDN example of a console applied will you see a consistent application of the Single responsibility principle, and the logic and "presentation layer", i.e. simple output as a result of executing the business logic of the code, are in the same class.

Would this code better respect the Single responsibility principle if instead of a human-readable messages it returned a just number as a result, and then the principle would not be violated?

Is any validation required other than int.TryParse() other than to satisfy the form and purity of the code and not the substance?

```
The clean version without "mixing" is in the "Simple" folder. You can see how stupid it is to talk about mixed logic and the presentation layer - the "presentation" code (Console.WriteLine()) I added just to make the output more readable and more like a real shopping POS, just for fun. I expected the human being on the other side to understand it. I was wrong. Always expect someone who thinks mechanically to analyze your code.
```
Unfortunately, the most of today's programmers have a "programmed mind" and are unable to think beyond learned definitions, patterns, and blueprints, nothing more thoughtful than a trained dog.

The programmers who interpreted my code, which is not structurally perfect, because it was not an idea in the task for which it was planned to be solved in 1-2 hours with all unit tests and manual, but a demonstration of a creative and thoughtful way of thinking about the core of the problem, not about make-up.

I was wrong. I need to learn that good programming today is copy-paste of sterile forms and dogmatic respect for acronyms and principles without their essential understanding.

```
When I had my first programming exam at the university, I asked professor Litovski to check my work, 
so that I would know if I should study for the oral exam. 
He quickly looked at my solution and said "you failed". 
I asked him to take another look, because I'm sure I didn't.
Two days later, I got a score of 10, the highest possible.
I didn't solve the task the way he taught us. I found another, better way.
That is me. Whoever likes the way I think, ok, whoever not likes, ok too.
```

**Task**

Implement the code for a supermarket checkout that calculates the total price of a number of items. Goods are priced individually, however there are weekly special offers for when multiple items are bought. For example "Apples are 30 each or 2 for 45".

Weekly offers change frequently.

This week's rule:

| Item   |Price for 1 item | Offer                |
|--------|-----------------|----------------------|
| Apple  | 30              | 2 for 45             |
| Banana | 50              | 3 for 130            |
| Peach  | 60              |  -                   |

The checkout accepts the items in any order, so that if we scan an apple, a banana and another apple, we’ll recognise two apples and apply the discount of 2 for 45.

**Thinking**

There are a different way to solve this task.
Based on description, and od the fact that fractional rpices not exists (3 bananas for 130 means that is price for one Banana 130/3 and this is decimal number with infinity number of decimals, calle Infinite decimal expansion - A number written as a decimal fraction, such that there is no last digit), I conclude that is possible to have a different combination, for example:

3 Bananas + 3 Apples + x Peaches
and this means:

3 Bananas = Discount price for Bananas
3 Apples = One diskount pirce (package) fro 2 Bananas and one more babana per regular price.

**Solutions**

A) Addition approach (Price calculation during product addition):
   On Scan() check number of items. 

If number satisfy weekly discount current item that riches weekly quote for discount will be calculated by discount price:

DiscountPrice = NumberOfItems*RegularPrice - OfferPrice

Total is a simple the Sum of successive subtotals.

B) Calculate at the end:

Scan() added product to the List and at the end check how many product satisfy Weekly discount offer and calculate total price.

The firts thinks are that a simple foreach loop with switch statement can solve problem. But thete is a better wya, using LINQ to grouping products by productId and calculate number of products, and check how many discount packages are there and how many products remains by regular price, witha  simple Math.DivRem() function.

I choose this approach.

**update:** I added sub-total after each item scan(), just for display purpose

## Basic version
**Folder Structure**

**Simple** - simple solution
Based on Basic, but simplified. Wasting time for purity :)
Of course that is not 100% ideal. I know but I do not care about it.

**Basic** - basic solution, business logic separated of main program file
SeedProduct.cs - seed dummy data
ShoppingCart.cs - business logic, Scan(), ShowScan(), ShowTotal(), GetTotal(), ResetShoppingCart() methods
**Basic/Model** - models
Product.cs - Product model
Cart.cs - Shopping cart model

### Unit Tests
Unit tests are based on xUnit and use Facts and Theory.

## With Interface version
This verison is based on Basic but with interfaces that make separated runtime part of console application and business logic

## Features
Porgram shows folowing menu:
```
Scan a product:
1) Apple
2) Banana
3) Peach
C) Go to checkout
X) Break and exit

Select an option: 
```

Choosing 1, 2, or 3, program "scans" products and shows the subtotal, selected product, and content of the shopping cart, for example:

```
Product Apple added to the cart!
Subtotal: 95
Your shopping cart: Apple, Banana, Apple

Press Enter to return to Main Menu
```
If you choose "c" (lower or uppercase) program shows subtotal.

```
Select an option: c
Your shopping cart total: 95
```

After showing subtotal you can continue with adding product into cart and check total again by selection "c" option from the menu.

Option "x" break execution of the program.
