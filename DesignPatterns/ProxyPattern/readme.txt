1. 远程代理：为一个对象在不同的地址空间提供局部代表
2. 虚代理：根据需要创建开销很大的对象
3. 保护代理：控制对始对象的访问，保护代理用于对象应该有不同的访问控制权的时候
4. 智能指针：取代了简单指针，它在访问对象的时候执行一些附加操作。


1. A remote proxy provides a local representative for an object that resides in a different address space. This is what the "stub" code in RPC and CORBA provides.
2. A virtual proxy is a placeholder for "expensive to create" objects. The real object is only created when a client first requests/accesses the object.
3. A protective proxy controls access to a sensitive master object. The "surrogate" object checks that the caller has the access permissions required prior to forwarding the request.
4. A smart proxy interposes additional actions when an object is accessed. Typical uses include: 
		Counting the number of references to the real object so that it can be freed automatically when there are no more references (aka smart pointer),
		Loading a persistent object into memory when it's first referenced,
		Checking that the real object is locked before it is accessed to ensure that no other 



checklist:

1. Identify the leverage or "aspect" that is best implemented as a wrapper or surrogate.
2. Define an interface that will make the proxy and the original component interchangeable.
3. Consider defining a Factory that can encapsulate the decision of whether a proxy or original object is desirable.
4. The wrapper class holds a pointer to the real class and implements the interface.
5. The pointer may be initialized at construction, or on first use.
6. Each wrapper method contributes its leverage, and delegates to the wrappee object.


Demo:
proctection proxy and virtual proxy

User must have right privilege to move weapon or destroy target

Proxy create expensive object on its first use