### In software engineering, behavioral design patterns are design patterns that identify common communication patterns between objects and realize these patterns. By doing so, these patterns increase flexibility in carrying out this communication.

## Mediator pattern
>This pattern is considered to be a behavioral pattern due to the way it can alter the program's running behavior.

>Usually a program is made up of a large number of classes. So the logic and computation is distributed among these classes. However, as more classes are developed in a program, especially during maintenance and/or refactoring, the problem of communication between these classes may become more complex. This makes the program harder to read and maintain. Furthermore, it can become difficult to change the program, since any change may affect code in several other classes.

>With the mediator pattern, communication between objects is encapsulated with a mediator object. Objects no longer communicate directly with each other, but instead communicate through the mediator. This reduces the dependencies between communicating objects, thereby lowering the coupling.

**Example**

```csharp

public interface IComponent
{
    void SetState(object state);
}

public class Component1 : IComponent
{
    public void SetState(object state)
    {
        throw new NotImplementedException();
    }
}

public class Component2 : IComponent
{
    public void SetState(object state)
    {
        throw new NotImplementedException();
    }
}

// Mediates the common tasks
public class Mediator
{
    public IComponent Component1 { get; set; }
    public IComponent Component2 { get; set; }

    public void ChangeState(object state)
    {
        this.Component1.SetState(state);
        this.Component2.SetState(state);
    }
}
```
## Strategy pattern
>the strategy pattern (also known as the policy pattern) is a software design pattern that enables an algorithm's behavior to be selected at runtime. The strategy pattern :

>defines a family of algorithms,

>encapsulates each algorithm, and

>makes the algorithms interchangeable within that family.


>Strategy lets the algorithm vary independently from clients that use it. Strategy is one of the patterns included in the influential book Design Patterns by Gamma et al. which popularized the concept of using patterns to describe software design.

>For instance, a class that performs validation on incoming data may use a strategy pattern to select a validation algorithm based on the type of data, the source of the data, user choice, or other discriminating factors. These factors are not known for each case until run-time, and may require radically different validation to be performed. The validation strategies, encapsulated separately from the validating object, may be used by other validating objects in different areas of the system (or even different systems) without code duplication.

>The essential requirement in the programming language is the ability to store a reference to some code in a data structure and retrieve it. This can be achieved by mechanisms such as the native function pointer, the first-class function, classes or class instances in object-oriented programming languages, or accessing the language implementation's internal storage of code via reflection.

**Example**

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
		CalculateClient client = new CalculateClient();
		
		client.SetCalculate(new Minus());
   		Console.WriteLine("Minus: " + client.Calculate(7, 1));

		client.SetCalculate(new Plus());	
   		Console.WriteLine("Plus: " + client.Calculate(7, 1));
	}
}

//The interface for the strategies
public interface ICalculate 
{  
   int Calculate(int value1, int value2);
}

//strategies
//Strategy 1: Minus
public class Minus : ICalculate 
{
    public int Calculate(int value1, int value2) 
    {
        return value1 - value2;
    }
}

//Strategy 2: Plus
public class Plus : ICalculate 
{
    public int Calculate(int value1, int value2) 
    {
        return value1 + value2;
    }
}

//The client
public class CalculateClient 
{
    private ICalculate strategy;

    //Executes the strategy
    public int Calculate(int value1, int value2) 
    {
        return strategy.Calculate(value1, value2);
    }
	
    //Change the strategy
    public void SetCalculate(ICalculate strategy){
        this.strategy = strategy;
    }
}
```