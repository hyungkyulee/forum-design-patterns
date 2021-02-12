# Software Engineering - Design Patterns

[ references ] 
- Design Patterns Overview by Steve Smith
- https://www.ionos.co.uk/digitalguide/websites/web-development/strategy-pattern/
- Head First : Design Patterns by Eric Freeman

### Overview
 - Design Pattern Origins - introduced at 1977 by Architect Christopher Alexander, followed by a design pattern book written by Gang in 1994 for Smalltalk and C++ which were dead or not much strong than before. 
 - some of the patterns have been incorporated into C#, Java, Ruby, etc
 - Design patterns are general solutions to existing problems

Reasons of deign patterns
- Avoid reinventing wheels
- imrpove communication
- deliver better software
- advance your career

learning stage of design pattern : ignorance -> awakening -> oversealous -> mastery

T-Shaped Pattern Knowledge - study a broad knowledge of patters + some awakening and deep level of mastery in some set of patterns

## SOLID Pattern
### Single Responsibility Principle
All of that module, class or function's services should be narrowly aligned with that responsibility.
[ref: Martin, Robert C. (2003). Agile Software Development, Principles, Patterns, and Practices. Prentice Hall. p. 95. ISBN 978-0135974445.]



## The category of Patterns
### Creational
 - Builder
 - Factories
   - Abstract Factory
   - Factory Method
 - Prototype
 - Singleton
 
### Structural
 - Adapter
 - Bridge
 - Caomposite
 - Decorator
 - Facade
 - Flyweight
 - Proxy
 
 ### Behavioural
 - Chain of Responsibility
 - Command
 - Interpreter
 - Iterator
 - Mediator
 - Memento
 - Null Object
 - Observer
 - State
 - Strategy
 - Template Method


[ A good patterns in c# ]
- strategy design pattern
- repository design pattern
- adapter design pattern
- factory design pattern
- proxy/decorator diegn pattern
- singleton design pattern


## strategy design pattern
 - Structure : Context - IStrategy - Strategy
 - Purpose : make the code more extensible and testable
 - Key Properties
   - Behaviour-based : behaviours and changes are easily implementable, and changes are possible during aprogram's runtime
   - Efficiency-oriented : simplify and optimise the code and maintenance by decoupling
   - Future-oriented : changes and optimisations are easy to implemented in a mid/long term
   - Extensible : independence of objects and classes
   - Reusable : multiple use of strategies
   
 - Actions
   1) de-couple the changeable parts from the main class
   2) express each behaviour to an interface
   3) implement behaviour classes via interface
   4) prepare a setter method to be changeable in a runtime
   5) simulate a model (create a context)

 - Examples
   [please see the project source : DesignPatterns -> StrategyPattern]
   
 - Test Result
 ```shell
 ~/ref-sweng-design-patterns/DesignPatterns/StrategyPattern/bin/Debug/netcoreapp3.1/StrategyPattern.dll
 ========== STRATEGY PATTERN ==========
 A duct is flying by its wing.
 Quack Quack -!!!
 I'm a real duck and able to fly...
 
 The duck is hurt, and NOT able to fly.
 Quiet -!!!

 Process finished with exit code 0.
 ```

## observer design pattern
 - Structure : Subject - IObserver - Observer
 - Purpose : enables a subscriber to register with and receive notifications from a provider (scenario that requires push-based noti and pull-based notification.)
 - Key Properties
   - Behaviour-based : behaviours and changes are easily implementable, and changes are possible during aprogram's runtime
   - Efficiency-oriented : simplify and optimise the code and maintenance by decoupling
   - Future-oriented : changes and optimisations are easy to implemented in a mid/long term
   - Extensible : independence of objects and classes
   - Reusable : multiple use of strategies
   
 - Actions
   1) de-couple the changeable parts from the main class
   2) express each behaviour to an interface
   3) implement behaviour classes via interface
   4) prepare a setter method to be changeable in a runtime
   5) simulate a model (create a context)

 - Examples
   [please see the project source : DesignPatterns -> StrategyPattern]
   
 - Test Result
 ```shell
