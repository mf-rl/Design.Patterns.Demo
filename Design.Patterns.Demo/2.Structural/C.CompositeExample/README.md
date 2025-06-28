# Composite Pattern

## Overview

**Definition:** The Composite pattern is a structural design pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

**Intent:** Compose objects into tree structures to represent part-whole hierarchies. The Composite pattern lets clients treat individual objects and compositions of objects uniformly, allowing recursive composition and simplified client code.

## How This Code Implements the Pattern

This implementation demonstrates the classic Composite pattern structure with three key participants:

**Component (Abstract Base Class):**
- **Component**: Defines the common interface for all objects in the composition, both simple and complex elements. It declares the `Display()` method that all participants must implement and provides a base structure with a `Name` property.

**Leaf (Simple Elements):**
- **Leaf**: Represents leaf objects in the composition that have no children. These are the basic building blocks that implement the component interface and perform the actual work. In this case, they simply display their name with appropriate indentation.

**Composite (Complex Elements):**
- **Composite**: Defines behavior for components having children and stores child components. It implements the component interface and delegates operations to its children. The composite can contain both leaf objects and other composite objects, enabling the recursive tree structure.

The pattern creates a unified interface where clients can work with both individual elements (leaves) and collections of elements (composites) through the same `Component` abstraction. The tree structure is built through the `Add()` and `Remove()` methods on composite objects, and operations are performed recursively through the hierarchy.

## Benefits Demonstrated

**Uniform Treatment**: Clients can treat individual objects and compositions identically through the common `Component` interface, simplifying client code and eliminating the need for type checking.

**Recursive Composition**: The pattern naturally supports recursive structures where composites can contain other composites, enabling arbitrarily complex tree hierarchies without additional complexity.

**Open/Closed Principle (OCP)**: New types of components can be added without modifying existing code. The system is open for extension (new leaf or composite types) but closed for modification.

**Single Responsibility Principle (SRP)**: Each class has a clear, focused responsibility - leaves handle individual element behavior, composites manage child collections, and the base component defines the common interface.

**Simplified Client Code**: Clients don't need to distinguish between simple and complex elements, reducing conditional logic and making the code more maintainable and easier to understand.

**Flexible Structure Management**: The pattern makes it easy to add, remove, and rearrange elements in the tree structure at runtime, providing dynamic composition capabilities.

**Polymorphic Operations**: Operations can be performed on the entire tree structure through polymorphism, with each element handling the operation appropriately for its type.

## Usage

**File System Management**: Representing file system hierarchies where files are leaves and directories are composites. Both files and directories can be treated uniformly for operations like copy, move, delete, or calculate size, with directories recursively applying operations to their contents.

**User Interface Component Trees**: Building complex UI layouts where simple widgets (buttons, labels) are leaves and container widgets (panels, windows, forms) are composites. This allows uniform handling of layout operations, event propagation, and rendering across all UI elements regardless of their complexity.
