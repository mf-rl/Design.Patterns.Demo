# Bridge Pattern

## Overview

**Definition:** The Bridge pattern is a structural design pattern that separates an object's abstraction from its implementation so that both can be varied independently. It uses composition to bridge the gap between abstraction and implementation hierarchies.

**Intent:** Decouple an abstraction from its implementation so that the two can vary independently. This pattern is useful when you want to share an implementation among multiple objects, or when you want to switch implementations at runtime.

## How This Code Implements the Pattern

This implementation demonstrates the Bridge pattern's key structure with two separate hierarchies:

**Abstraction Hierarchy:**
- **Shape (Abstraction)**: Defines the abstract interface for shapes and maintains a reference to an implementor object (`IRenderer`). It delegates the actual rendering work to the implementation hierarchy.
- **CircleShape (Refined Abstraction)**: Extends the shape abstraction with specific circle-related functionality while still relying on the renderer for implementation details.

**Implementation Hierarchy:**
- **IRenderer (Implementor)**: Defines the interface for implementation classes, providing the `Render()` method that concrete implementations must implement.
- **VectorRenderer & RasterRenderer (Concrete Implementors)**: Provide specific implementations of the rendering functionality, each with their own approach (lines vs pixels).

The bridge is established through composition - the `Shape` class contains a reference to `IRenderer`, allowing the abstraction to delegate implementation-specific work. This separation enables both hierarchies to evolve independently without affecting each other.

## Benefits Demonstrated

**Separation of Concerns**: The pattern cleanly separates what an object does (shape functionality) from how it does it (rendering implementation), leading to better organized and maintainable code.

**Single Responsibility Principle (SRP)**: Each class has a focused responsibility - shapes handle shape-specific logic, while renderers handle rendering-specific logic.

**Open/Closed Principle (OCP)**: New shapes can be added without modifying existing renderers, and new rendering implementations can be added without changing existing shapes.

**Dependency Inversion Principle (DIP)**: High-level shape classes depend on the abstraction (`IRenderer`) rather than concrete rendering implementations, promoting loose coupling.

**Runtime Flexibility**: Implementations can be switched at runtime, allowing the same shape to be rendered using different techniques without changing the shape's code.

**Scalability**: Both abstraction and implementation hierarchies can grow independently. Adding new shapes doesn't require changes to renderers, and vice versa.

**Testability**: Mock implementations can be easily created for testing shape logic without involving actual rendering code.

## Usage

**Graphics and UI Frameworks**: When building cross-platform applications where the same UI components need to render differently on various platforms (Windows, macOS, Linux). The abstraction defines the component behavior while platform-specific implementations handle the actual rendering.

**Database Access Layers**: When designing data access objects that need to work with multiple database engines. The abstraction defines data operations while concrete implementations handle database-specific SQL dialects, connection management, and optimization strategies for different database systems (SQL Server, PostgreSQL, MongoDB).
