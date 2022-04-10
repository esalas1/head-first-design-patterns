# The Template Method Pattern

The template methods provides common way to perform
a series of steps for subclasses that may have similar responsibilities.
The steps are generalized and included in a nonabstract method.
Any unique behavior can be implemented inside the "template's" 
abstract members. 

The Template Methods defines the skeleton to an algorithm.
It defers some steps to the subclasses but keeps any generalized and 
common parts of the algorithm as nonabstract members in the skeleton. 
Subclasses can redefine the abstract members of the template
to add unique, class subclass specific behavior. 

### *Hollywood Principle: Don't call us, we'll call you*
- High level components determine when lower level components
are needed.
- Depending on lower level components to call on higher level components
can result in dependency rot, where the system is intertwined in a 
manner that may not be clear or intuitive. 
- Dependency rot can make it difficult to clearly
see how the system is designed.