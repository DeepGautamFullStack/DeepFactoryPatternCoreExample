# DeepFactoryPatternCoreExample

Factory design pattern with and without factory implementation by Deep Gautam full stack developer.

**Problems without factory pattern:**
First, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
Secondly, if we add a new Credit Card, then also we need to modify the Main method by adding an extra if-else condition which not only overheads in the development but also in the testing process.

**Solution:**
Less control to consumer of class and less change in future when new product gets added.Also it reduces testing time because client not need to do special testing for newely added classes. Although there is no perfornce benifits.

**Drawback:**
If we need to add any new product (i.e. new credit card) then we need to add a new if else condition in the GetCreditCard method of the CreditCardFactory class. This violates the open/closed design principle.
We also have a tight coupling between the Factory (CreditCardFactory) class and product classes (MoneyBack, Titanium, and Platinum).


So inorder to resolve this problem from the root , the solution is** Factory Method Design Pattern **

Happy learning and enjoy the coding.

![image](https://user-images.githubusercontent.com/27567403/152548610-292cc037-91e1-4ed4-9329-a5d9966fdb8b.png)
