LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET to retrieve data from different sources and formats.
1. Query syntax 
2. Method syntax

Advantages of LINQ
Familiar language: Developers don’t have to learn a new query language for each type of data source or data format.
Less coding: It reduces the amount of code to be written as compared with a more traditional approach.
Readable code: LINQ makes the code more readable so other developers can easily understand and maintain it.
Standardized way of querying multiple data sources: The same LINQ syntax can be used to query multiple data sources.
Compile time safety of queries: It provides type checking of objects at compile time.
IntelliSense Support: LINQ provides IntelliSense for generic collections.
Shaping data: You can retrieve data in different shapes.

Most of the Linq methods are created using extension methods.
Extension methods
Extension methods in C# allow us to define a static method that appears to be a member of another type, any type, classes, interfaces, 
  structs, even sealed types that we can't extend using inheritance. 

Lambda expression
Lambda Expressions are just another way to create executable code. 
They are a way to define a method, but that method doesn't have to be an instance of method or a static named method on a class. 
It's something that can easily be in‑lined in a short expression

Deferred Execution Explained
Many LINQ operators are implemented using the yield return syntax.
And the operators that use this technique offer the behavior that we call deferred execution. 
Deferred execution is a fancy term, meaning LINQ is as lazy as possible. It does the least amount of work it can get away with. 
You can think of a LINQ query, like movies.Filter, as building a data structure, and there's no real work performed unless we force that query to execute. 
The line of code using our filter operator, or the LINQ where operator, 
you can think of that line of code as defining a query or building a data structure that knows what to do sometime in the future. 
But the filtering operation doesn't execute until we try to see the results of the query. In our program, we do that with a foreach statement.
What else would force a query to execute? Ultimately, any operation that inspects the results will force the query to execute.
So if we serialize the query results into JSON or XML, that will force execution. If we data bind the query results into a grid control, that will force execution. 
All of those operations ultimately have to iterate over the results that come out of the query. 
So one obvious question you might have is how do I know if a query operator like where offers deferred execution because not all the LINQ operators behave this way? 
Let me show you one way to know if an operator is deferred or not, and also show you why deferred execution can be good for us.

To know whether method is deferred execution:
Enumerable is a static class which implements all linq methods. In MSDN page of linq method if we scroll to the remarks.
Then we can see This method is implemented by using deferred execution.
