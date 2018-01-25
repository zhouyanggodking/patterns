Intent:
1. Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by 
	keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
2. Design an intermediary to decouple many peers.
3. Promote the many-to-many relationships between interacting peers to "full object status".


checklist:
1. Identify a collection of interacting objects that would benefit from mutual decoupling.
2. Encapsulate those interactions in the abstraction of a new class.
3. Create an instance of that new class and rework all "peer" objects to interact with the Mediator only.
4. Balance the principle of decoupling with the principle of distributing responsibility evenly.
5. Be careful not to create a "controller" or "god" object.


Demo:
Multi-people online message system, group talking