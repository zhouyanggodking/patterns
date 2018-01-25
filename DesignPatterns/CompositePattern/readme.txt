intent:
1) Compose objects into tree structures to represent part-whole hierarchies.
2) Composite lets clients treat individual objects and compositions of objects uniformly. Called recursive composition

Benifits
1) Make it easy to add new kinds of components
2) Make clients simpler, since they do not have to know if they are dealing with a leaf or a composite component

Liability
	Makes harder to restrict the type of components of a composite


Implementation Issues
1) A composite object knows its contained components, that is, its children. Should components maintain a reference to their parent component?
	Depends on application, but having these references supports the Chain of Responsibility pattern
2) Where should the child management methods - add(), remove(), getChild() be declared?
	In component class: gives transparency since all components can be treated the same. But not safe since clients can try to meaningless things to leaf componets at run-time
	In composite class: gives safety since any attempt to perform a child operation on a leaf component will be caught at compile time. But lose transparency,
	since now leaf and composite components have different interface.
3) Should component maintain the list of components that will be used by a composite object?
	Better to keep this part of Composite and avoid wasting the space in every leaf object