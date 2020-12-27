# Software Engineering - Design Patterns

references 
- Design Patterns Overview by Steve Smith
- https://www.ionos.co.uk/digitalguide/websites/web-development/strategy-pattern/
- Head First : Design Patterns by Eric Freeman

Design Pattern Origins - introduced at 1977 by Architect Christopher Alexander, followed by a design pattern book written in 1994.
Design patterns are general solutions to existing problems

Reasons of deign patterns
- Avoid reinventing wheels
- imrpove communication
- deliver better software
- advance your career

learning stage of design pattern : ignorance -> awakening -> oversealous -> mastery

T-Shaped Pattern Knowledge - study a broad knowledge of patters + some awakening and deep level of mastery in some set of patterns

A good patterns in c#
- strategy design pattern
- repository design pattern
- adapter design pattern
- factory design pattern
- proxy/decorator diegn pattern
- singleton design pattern


### strategy design pattern
 - Structure : Context - IStrategy - Strategy
 - Purpose : make the code more extensible and testable
 - Key Properties
   - Behaviour-based : behaviours and changes are easily implementable, and changes are possible during aprogram's runtime
   - Efficiency-oriented : simplify and optimise the code and maintenance by decoupling
   - Future-oriented : changes and optimisations are easy to implemented in a mid/long term
   - Extensible : independence of objects and classes
   - Reusable : multiple use of strategies
   
 - Actions
   - de-couple the changable parts from the class
   - create a behaviour class(s)
   - preapre a setter method to be changable in excution
   - express each behaviour to an interface, and it will be implemented in the behaviour classes
   - 

 - Examples
   - 
