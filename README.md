**Singleton Design Pattern:** A Singleton pattern ensures that a class has only one instance and provides a global point of access to it. This is useful when exactly one object is need to coordinate actions accross system. This pattern is useful when you need to manage a shared resource, such as a configuration manager, logging service, or caching mechanism and Reducing memory consumption by avoiding multiple object instances. 

Thread Safety ensures that multiple threads can access the singleton instance without conflicts. The best approach in .Net Core is using double-check locking or Lazy<T>. 

Code snippet : 

Public ClassName { 
private static ClassName _instance;
private static readonly object _lock = new object();

private ClassName() { };
Public ClassName GetInstance() { If(_instance =null) { lock(_lock) { if(_instance=null) {_instance= new ClassName} }}

return _instance;

}

![Singletonvs Static](https://github.com/user-attachments/assets/ab4f57a6-1b56-4df8-b6be-d973ac9027df)


