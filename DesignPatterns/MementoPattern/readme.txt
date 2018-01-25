Intent:
Without violating encapsulation, capture and externalize an object's internal state so that the object can be returned to this state later.
A magic cookie that encapsulates a "check point" capability.
Promote undo or rollback to full object status.

checklist:
1. Identify the roles of “caretaker” and “originator”.
2. Create a Memento class and declare the originator a friend.
3. Caretaker knows when to "check point" the originator.
4. Originator creates a Memento and copies its state to that Memento.
5. Caretaker holds on to (but cannot peek into) the Memento.
6. Caretaker knows when to "roll back" the originator.
7. Originator reinstates itself using the saved state in the Memento.