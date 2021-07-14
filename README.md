## Price calculation exercise
Create a customer basket that allows a customer to add products and provides a total cost of the basket including applicable discounts.
#### Available products:
Product: Cost <br/>
Butter: £0.80 <br/>
Milk: £1.15 <br/>
Bread: £1.00 <br/>
#### Offers
• Buy 2 Butter and get a Bread at 50% off <br/>
• Buy 3 Milk and get the 4th milk for free <br/>
### Scenarios
• Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total should be
£2.95 <br/>
• Given the basket has 2 butter and 2 bread when I total the basket then the total should be £3.10 <br/>
• Given the basket has 4 milk when I total the basket then the total should be £3.45 <br/>
• Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total should be <br/>
£9.00

### The solution should be in C#.
#### Pointers
While we are looking for a solution that shows a good understanding of the SOLID principles, objectoriented programming (or functional) and that displays a working knowledge of TDD (a git repository
will be appreciated!), please keep things simple- do not over-engineer anything, make sure your
code is manageable and easy to follow. We are not looking for submissions that contain UIs or
databases.
If you think your solution is too short, feel free to add some commentary to justify the decisions you
have taken, if possible, by quoting books, blog posts or talks that have influenced you in the way you
have coded.
Above all, code as if you're coding for yourself.

--------------------
### Points to remember in the solution:
- Product is a data and can be in the form of Bread,butter,milk,ets
- offer: is a form of product but can decrease the cost - injected the description and reduction
- IBasketService : basket consit of products plus behaviour of add()
- BasketService: new the List of products in cunstructor. Add the List of products.
- IApplyOfferService : is a tester (tester-doer pattern)- decides if offer applies on the products in the basket. Injected IBasket and has CanApply() , Apply()
- We can have as many offers as we like here indipendently (composition pattern). 
    - ThreeMilkAnd4thMilkIsFree : extends the IApplyOfferService, so has basket and list of products. In CanApply decides if this particular offer will apply. In Apply() applied the discount.
- IBasketTotalCalculator : is a doer (tester-doer), GetTotalPrice () calculates total of basket. passed IBasketService 
- TotalBasketCalculation : extends the IBasketTotalCalculator and we inject the IApplyOfferService in cunstructor. Here we get all the products in the basket and process all of them. 
