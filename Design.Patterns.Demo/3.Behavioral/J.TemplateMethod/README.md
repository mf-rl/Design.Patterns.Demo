# Template Method Pattern

## Overview

**Definition:** The Template Method pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class and lets subclasses override specific steps without changing the algorithm's overall structure. It uses inheritance to enable code reuse while allowing customization of specific algorithm steps.

**Intent:** Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. The Template Method pattern lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure, promoting code reuse and consistent execution flow.

## How This Code Implements the Pattern

This implementation demonstrates the Template Method pattern's essential structure with two key participants:

**Abstract Class:**
- **AbstractClass**: Defines the template method that establishes the algorithm's skeleton and declares abstract and virtual methods for the individual steps. The template method (`TemplateMethod()`) controls the execution flow by calling the step methods in a predefined order, ensuring consistent algorithm structure across all implementations.

**Concrete Classes:**
- **ConcreteClassA & ConcreteClassB**: Inherit from the abstract class and provide specific implementations for the abstract steps while optionally overriding virtual steps. These classes customize the algorithm's behavior by implementing the required steps according to their specific needs while maintaining the overall algorithm structure.

The pattern creates a framework where the abstract class controls the algorithm's execution flow through the template method, while concrete classes provide the specific implementation details for each step. This design ensures that the algorithm's structure remains consistent while allowing customization of individual steps. The use of both abstract methods (that must be implemented) and virtual methods (that can be optionally overridden) provides flexibility in how subclasses participate in the algorithm.

## Benefits Demonstrated

**Code Reuse**: Common algorithm structure is defined once in the base class and reused by all subclasses, eliminating duplication and ensuring consistent execution patterns across different implementations.

**Controlled Customization**: Subclasses can only customize specific steps of the algorithm without being able to alter the overall structure or execution order, maintaining algorithmic integrity while enabling flexibility.

**Template Structure Enforcement**: The pattern ensures that all implementations follow the same algorithmic structure, providing predictable behavior and making the system easier to understand and maintain.

**Open/Closed Principle (OCP)**: New algorithm variations can be added by creating new subclasses without modifying the existing template or other concrete implementations, making the system extensible.

**Single Responsibility Principle (SRP)**: The abstract class focuses on defining the algorithm structure, while concrete classes focus on implementing specific step behaviors, creating clear separation of concerns.

**Polymorphic Algorithm Execution**: Different algorithm implementations can be used interchangeably through the base class interface, enabling flexible algorithm selection while maintaining consistent execution patterns.

**Hook Methods Support**: Virtual methods act as hooks that subclasses can optionally override to extend or modify the default behavior, providing fine-grained customization options.

## Usage

**Data Processing Pipelines**: Implementing data processing workflows where the overall process (read, validate, transform, write) remains consistent but specific steps vary based on data types or formats. For example, processing different file formats where each format requires specific parsing logic but follows the same general processing structure.

**Framework Development**: Building application frameworks where the framework defines the overall application lifecycle and flow (initialization, execution, cleanup) but allows developers to customize specific phases. Web frameworks often use this pattern to define request processing pipelines while letting developers implement specific request handling logic.
