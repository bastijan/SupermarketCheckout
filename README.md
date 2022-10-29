# Supermarket Checkout

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



