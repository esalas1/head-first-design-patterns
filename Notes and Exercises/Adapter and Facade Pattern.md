# Adapter and Facade Pattern

## Adapter Pattern
This pattern lets us convert the interface of one class to another class so it can be compatible with downstream processes. 

The adapter pattern lets us use a client with an incompatible interface by using an Adapter that performs the necessary conversion to the needed interface. 

The object adapter uses composition to pass the request to the Adaptee (The object that is getting disguised by the adapter)

## Facade Pattern

The purpose of the facade pattern is to simplify a subsystem. It decouples a client from the subsystem. 

The Facade Pattern unifies a subset of interfaces into one main interface. This pattern simplifies the user's interactions with the entire system while still allowing control either through the facade or directly through the subsystem's components. 

## *Design Principle: Talk to your immediate friends*

For example, the return to a method should not be used to call other methods. This increases the number of classes that our current class has to know about and decreases modularity. 

