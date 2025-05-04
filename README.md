# Publisher Subscriber Design Pattern

### Type
Behavioral Design Pattern

### What problem it solves?
In a tightly coupled system, component interact with each other directly. This makes making changes in code difficult. Publisher subscriber design pattern enables the loose coupling.

### How it solves the problem?
Publisher's instance is passed as an input to constructor of Subscriber. Then, inside Subscriber's code, its method is subscribed to an event handler of Publisher. After that, whenever, Publisher fires an event by invoking EventHandler, all methods subscribed to it will be called.

### Limitations
+ In case of high volume of events, Publisher Subscriber Design Pattern may face latency issues.
+ Comparitively complex debugging
