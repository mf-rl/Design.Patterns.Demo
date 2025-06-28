## Singleton Pattern

**Definition:**  
The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.

**Intent:**  
The intent of the Singleton pattern is to control object creation, limiting the number of instances to one. This is useful when exactly one object is needed to coordinate actions across the system.

## How This Code Implements the Pattern

This implementation uses a private static field to hold the single instance of the `Logger` class. The constructor is private, preventing external instantiation. The `Instance` property provides a thread-safe way to access the single instance, using a lock to ensure that only one instance is created even in multithreaded scenarios. The `Logger` class exposes a `Log` method, and the `SingletonExample` class demonstrates how to access and use the singleton instance.

## Benefits Demonstrated

- **Controlled Access to Sole Instance:** The pattern ensures that only one instance of the `Logger` exists, preventing inconsistent state or resource conflicts.
- **Lazy Initialization:** The instance is created only when first accessed, optimizing resource usage.
- **Thread Safety:** The locking mechanism ensures that the singleton instance is safely created in multithreaded environments.
- **Adherence to SOLID Principles:**  
  - *Single Responsibility Principle:* The `Logger` class is responsible only for logging and managing its own instance.
  - *Open/Closed Principle:* The class can be extended (e.g., by adding new logging methods) without modifying the instantiation logic.
- **Global Access Point:** The singleton provides a global access point to the logger, simplifying usage across the application.

## Usage

- **Logging Services:** Use a singleton logger to ensure all parts of an application write to the same log file or output, avoiding conflicts and duplicated resources.
- **Configuration Management:** Maintain a single configuration object that is accessed throughout the application, ensuring consistency and centralized control.