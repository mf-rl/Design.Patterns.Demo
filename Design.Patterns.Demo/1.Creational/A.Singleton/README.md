# Singleton Pattern Example

## Overview

This project demonstrates the **Singleton** design pattern using C# 12 and .NET 8. The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance.

---

## Design Pattern Definition

**Singleton Pattern:**  
The Singleton pattern restricts the instantiation of a class to a single object. This is useful when exactly one object is needed to coordinate actions across the system, such as a logger, configuration manager, or connection pool.

---

## How This Example Follows the Singleton Pattern

- **Single Instance Guarantee:**  
  The implementation ensures that only one instance of the class exists throughout the application's lifecycle.

- **Global Access Point:**  
  The instance is accessible globally, allowing any part of the application to use the same object.

- **Controlled Instantiation:**  
  The constructor is private, preventing direct creation of instances from outside the class. The only way to access the instance is through a static property.

- **Thread Safety:**  
  The example uses locking to ensure that the singleton instance is created safely in multithreaded scenarios.

---

## Usage

The example demonstrates how to retrieve the singleton instance and use it to perform an action (such as logging a message). This approach ensures consistent behavior and resource management across the application.

---

## When to Use the Singleton Pattern

- When exactly one instance of a class is needed to coordinate actions across the system.
- When you need a global point of access to a shared resource.

---

## References

- [Singleton Pattern - Refactoring.Guru](https://refactoring.guru/design-patterns/singleton)
- [Microsoft Docs: Implementing Singleton in C#](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/singleton)