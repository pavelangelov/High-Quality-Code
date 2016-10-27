## Creditional Design Patterns
*In software engineering, structural design patterns are design patterns that ease the design by identifying a simple way to realize relationships between entities.*

**Examples:**
## Adapter pattern
*An adapter helps two incompatible interfaces to work together. This is the real world definition for an adapter. Interfaces may be incompatible but the inner functionality should suit the need. The Adapter design pattern allows otherwise incompatible classes to work together by converting the interface of one class into an interface expected by the clients.*

## Composite pattern
*In software engineering, the composite pattern is a partitioning design pattern. The composite pattern describes that a group of objects is to be treated in the same way as a single instance of an object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly.*

*Composite should be used when clients ignore the difference between compositions of objects and individual objects. If programmers find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice; it is less complex in this situation to treat primitives and composites as homogeneous.*

## Decorator pattern
*In object-oriented programming, the decorator pattern (also known as Wrapper, an alternative naming shared with the Adapter pattern) is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern.*

*The decorator pattern can be used to extend (decorate) the functionality of a certain object statically, or in some cases at run-time, independently of other instances of the same class, provided some groundwork is done at design time. This is achieved by designing a new Decorator class that wraps the original class. This wrapping could be achieved by the following sequence of steps:*
* Subclass the original "Component" class into a Decorator class.
* In the Decorator class, add a Component pointer as a field.
* Pass a Component to the Decorator constructor to initialize the Component pointer.
* In the Decorator class, forward all "Component" methods to the "Component" pointer.
* In the ConcreteDecorator class, override any Component method(s) whose behavior needs to be modified.