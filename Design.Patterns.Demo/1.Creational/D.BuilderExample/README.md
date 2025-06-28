# Builder Pattern

## Overview

**Definition:**  
The Builder Pattern is a creational design pattern that separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

**Intent:**  
The intent of the Builder Pattern is to provide a flexible solution to constructing complex objects step by step. It enables the creation of different types and representations of an object using the same construction process.

## How This Code Implements the Pattern

This code demonstrates the Builder Pattern by defining a process for constructing different types of "Meal" objects. The `IMealBuilder` interface specifies the steps required to build a meal (main dish, side dish, and drink). Concrete builder classes (`VegMealBuilder` and `NonVegMealBuilder`) implement these steps to create specific meal variations.

A `MealDirector` class orchestrates the construction process by invoking the builder's methods in a specific sequence. The client code interacts with the director and builder to produce either a vegetarian or non-vegetarian meal, demonstrating how the same construction process can yield different results.

## Benefits Demonstrated

- **Separation of Concerns:** The pattern separates the construction logic from the representation, making the code easier to maintain and extend.
- **Single Responsibility Principle (SRP):** Each class has a clear responsibility—builders construct parts, the director manages the process, and the product represents the result.
- **Open/Closed Principle (OCP):** New meal types can be added by creating new builder classes without modifying existing code.
- **Flexibility:** The construction process can be changed independently of the product's internal representation.
- **Reusability:** The same construction process can be reused for different product representations.

## Usage

- **Configurable Object Creation:** Use the Builder Pattern when you need to construct complex objects with many optional parts or configurations, such as assembling meals, building UI components, or creating complex documents.
- **Step-by-Step Construction:** It is useful when the construction process must allow different representations or when the object construction should be independent of the parts that make up the object and how they are assembled.