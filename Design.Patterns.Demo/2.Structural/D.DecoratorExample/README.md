# Decorator Pattern

## Overview

**Definition:** The Decorator pattern is a structural design pattern that allows behavior to be added to objects dynamically without altering their existing structure. It provides a flexible alternative to subclassing for extending functionality by wrapping objects in a series of decorator classes.

**Intent:** Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality, allowing you to compose behaviors at runtime rather than compile time.

## How This Code Implements the Pattern

This implementation demonstrates the Decorator pattern's key structure with four essential participants:

**Component Interface:**
- **INotifier**: Defines the common interface that both concrete components and decorators must implement. It establishes the contract with the `Send()` method that all participants must follow.

**Concrete Component:**
- **EmailNotifier**: Provides the base implementation of the component interface. This is the core object to which additional responsibilities can be attached dynamically.

**Base Decorator:**
- **NotifierDecorator**: An abstract class that implements the component interface and maintains a reference to a component object (the wrappee). It provides default behavior by delegating operations to the wrapped component, serving as the foundation for concrete decorators.

**Concrete Decorators:**
- **SMSNotifier & FacebookNotifier**: Extend the base decorator to add specific behaviors. Each decorator calls the base implementation first (maintaining the chain) and then adds its own functionality, creating a layered approach to feature composition.

The pattern creates a chain of responsibility where each decorator wraps another component (either the base component or another decorator), allowing multiple behaviors to be composed dynamically. The client interacts with the decorated object through the same interface, remaining unaware of the decoration layers.

## Benefits Demonstrated

**Dynamic Composition**: Behaviors can be combined and modified at runtime without changing the original object's code, providing unprecedented flexibility in object configuration.

**Single Responsibility Principle (SRP)**: Each decorator has a focused responsibility for adding one specific behavior, promoting clean and maintainable code organization.

**Open/Closed Principle (OCP)**: New decorators can be added without modifying existing components or decorators, making the system extensible while keeping existing code stable.

**Flexible Alternative to Inheritance**: Instead of creating a complex inheritance hierarchy for every possible combination of features, decorators allow mixing and matching behaviors through composition.

**Transparent Enhancement**: Decorated objects maintain the same interface as the original object, allowing clients to use them interchangeably without knowing about the decoration layers.

**Layered Functionality**: Multiple decorators can be stacked to create complex combinations of behaviors, with each layer adding its own contribution to the overall functionality.

**Runtime Configuration**: The decoration chain can be built dynamically based on runtime conditions, user preferences, or configuration settings, providing adaptive behavior.

## Usage

**Stream Processing and I/O Operations**: Enhancing data streams with additional capabilities like compression, encryption, buffering, or logging. Each decorator adds a specific processing layer (e.g., compress then encrypt) while maintaining the same stream interface for seamless composition.

**UI Component Enhancement**: Adding visual effects, behaviors, or styling to user interface components. For example, decorating a basic button with hover effects, click animations, tooltips, or validation feedback without modifying the original button implementation, allowing for flexible and reusable UI enhancements.
