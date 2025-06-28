# Prototype Pattern

## Overview

**Definition:**  
The Prototype Pattern is a creational design pattern that enables the creation of new objects by copying an existing object, known as the prototype. Instead of instantiating new objects directly, the pattern provides a mechanism to clone objects, allowing for the creation of complex objects more efficiently.

**Intent:**  
The intent of the Prototype Pattern is to specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype. This approach is particularly useful when the cost of creating a new instance is more expensive than copying an existing one.

## How This Code Implements the Pattern

This code demonstrates the Prototype Pattern by defining an abstract base class for shapes, which declares a `Clone` method. Concrete shape classes, such as `Circle` and `Rectangle`, implement this method to return a copy of themselves. The `PrototypeExample` class shows how new shape objects can be created by cloning existing ones, rather than constructing them from scratch. This approach encapsulates the cloning logic within each shape, ensuring that the correct type and properties are duplicated.

## Benefits Demonstrated

- **Reduces Object Creation Complexity:** By cloning existing objects, the code avoids the complexity and potential errors of building new objects from scratch, especially when objects have many configuration options.
- **Promotes Code Reuse:** The cloning logic is encapsulated within each class, promoting reuse and reducing duplication.
- **Supports SOLID Principles:**  
  - *Single Responsibility Principle:* Each shape class is responsible for its own cloning logic.
  - *Open/Closed Principle:* New shape types can be added with their own cloning logic without modifying existing code.
- **Improves Performance:** Cloning can be more efficient than instantiating and configuring new objects, especially for objects that are costly to create.

## Usage

- **When object creation is costly:** Use the Prototype Pattern when creating a new object is resource-intensive, and a similar object already exists.
- **When objects have numerous configuration options:** If objects require many settings or initializations, cloning a pre-configured prototype can simplify the process.