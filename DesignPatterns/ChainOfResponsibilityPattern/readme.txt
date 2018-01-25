Intent:
It avoids attaching the sender of a request to its receiver, giving this way other objects the possibility of handling the request too.
Launch-and-leave requests with a single processing pipeline that contains many possible handlers.
An object-oriented linked list with recursive traversal.


Check list

1. The base class maintains a "next" pointer.
2. Each derived class implements its contribution for handling the request.
3. If the request needs to be "passed on", then the derived class "calls back" to the base class, which delegates to the "next" pointer.
4. The client (or some third party) creates and links the chain (which may include a link from the last node to the root node).
5. The client "launches and leaves" each request with the root of the chain.
6. Recursive delegation produces the illusion of magic.



Demo:
This demo simulates the vocation request system.
Employee sends vocation request and multiple level manager could process it