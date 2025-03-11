**Singleton Design Pattern:** A Singleton pattern ensures that a class has only one instance and provides a global point of access to it. This is useful when exactly one object is need to coordinate actions accross system. 

Thread Safety ensures that multiple threads can access the singleton instance without conflicts. The best approach in .Net Core is using double-check locking or Lazy<T>. 
