# Adapter Pattern

## Overview

**Definition:** The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to collaborate. It acts as a bridge between two incompatible interfaces by wrapping an existing class with a new interface.

**Intent:** Convert the interface of a class into another interface that clients expect. The Adapter pattern lets classes work together that couldn't otherwise because of incompatible interfaces.

## How This Code Implements the Pattern

This implementation demonstrates the classic Adapter pattern structure:

- **Target Interface (`ITarget`)**: Defines the domain-specific interface that the client uses. It declares a `Request()` method that the client expects to call.

- **Adaptee (`Adaptee`)**: Contains the existing functionality that needs to be adapted. It has a `SpecificRequest()` method with useful behavior but an incompatible interface.

- **Adapter (`Adapter`)**: Implements the target interface and holds a reference to an instance of the adaptee. It translates calls from the target interface to the adaptee's interface, effectively bridging the gap between what the client expects and what the existing code provides.

- **Client (`AdapterExample.Run()`)**: Works with objects through the target interface, remaining unaware of the adaptation process happening behind the scenes.

The pattern follows the composition approach where the adapter contains an instance of the adaptee and delegates the actual work to it while providing the expected interface to the client.

## Benefits Demonstrated

**Interface Compatibility**: Enables integration of classes with incompatible interfaces without modifying their source code, promoting code reuse and reducing duplication.

**Single Responsibility Principle (SRP)**: Each class has a single, well-defined responsibility - the adapter solely focuses on interface translation, the adaptee handles specific functionality, and the target defines the expected contract.

**Open/Closed Principle (OCP)**: The system is open for extension (new adapters can be added) but closed for modification (existing classes remain unchanged).

**Dependency Inversion Principle (DIP)**: The client depends on the abstraction (`ITarget`) rather than concrete implementations, promoting loose coupling and flexibility.

**Maintainability**: Changes to the adaptee's implementation don't affect the client code, as long as the adapter interface remains consistent.

**Testability**: Each component can be tested independently, and mock adapters can be easily created for unit testing.

## Usage

**Legacy System Integration**: When integrating modern applications with legacy systems that have outdated APIs. For example, adapting an old payment processing system's interface to work with a new e-commerce platform.

**Third-Party Library Integration**: When working with external libraries that don't match your application's interface expectations. For instance, adapting different logging frameworks (NLog, Serilog, log4net) to work with a unified logging interface in your application.
