# Flyweight Pattern

## Overview

**Definition:** The Flyweight pattern is a structural design pattern that minimizes memory usage by efficiently sharing common data among multiple similar objects. It separates intrinsic state (shared among objects) from extrinsic state (unique to each object context) to reduce the overall memory footprint.

**Intent:** Use sharing to support large numbers of fine-grained objects efficiently. The pattern reduces memory consumption by sharing common parts of object state between multiple objects instead of storing all data in each object.

## How This Code Implements the Pattern

This implementation demonstrates the Flyweight pattern's key structure with three essential participants:

**Flyweight Interface:**
- **IShape**: Defines the interface through which flyweights can receive and act on extrinsic state. It establishes the contract that all flyweight objects must follow, ensuring they can operate with externally provided context data.

**Concrete Flyweight:**
- **Circle**: Implements the flyweight interface and stores intrinsic state (color) that is shared among multiple instances. The intrinsic state is immutable and independent of the context in which the flyweight operates. The object accepts extrinsic state (coordinates) as parameters to methods rather than storing them internally.

**Flyweight Factory:**
- **ShapeFactory**: Manages flyweight instances and ensures that flyweights are shared appropriately. It maintains a pool of existing flyweight objects and returns existing instances when requested, creating new ones only when necessary. The factory uses the intrinsic state (color) as the key for object retrieval and sharing.

The pattern achieves memory efficiency by storing intrinsic state (color) once per unique flyweight and passing extrinsic state (coordinates) as method parameters. Multiple clients can share the same flyweight instance while providing their own context-specific data during method calls.

## Benefits Demonstrated

**Memory Efficiency**: Dramatically reduces memory consumption when dealing with large numbers of similar objects by sharing common data structures instead of duplicating them across instances.

**Object Reuse**: Promotes efficient object reuse through the factory pattern, reducing the overhead of object creation and garbage collection in memory-intensive applications.

**Single Responsibility Principle (SRP)**: The flyweight focuses solely on managing intrinsic state and operations, while the factory handles object lifecycle and sharing logic, creating clear separation of concerns.

**Open/Closed Principle (OCP)**: New flyweight types can be added without modifying existing flyweight classes or the factory infrastructure, making the system extensible.

**Performance Optimization**: Reduces object creation overhead and improves cache locality by minimizing the number of objects in memory, leading to better overall system performance.

**Scalability**: Enables applications to handle large datasets or complex scenarios that would otherwise be memory-prohibitive, making the system more scalable and robust.

**Separation of State**: Clearly distinguishes between intrinsic (shared) and extrinsic (contextual) state, promoting better design decisions about what data should be shared versus what should remain context-specific.

## Usage

**Game Development**: Managing large numbers of similar game objects like bullets, particles, or terrain tiles where many objects share common properties (sprite, behavior) but differ in position, velocity, or other contextual attributes. This allows games to render thousands of objects efficiently without exhausting memory.

**Text Processing and Document Rendering**: Representing characters or glyphs in text editors and document processors where each character type (font, size, style) is shared among multiple character instances, while position and formatting context remain extrinsic. This enables efficient handling of large documents with complex formatting.
