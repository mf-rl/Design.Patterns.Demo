# Interpreter Pattern

## Overview

**Definition:** The Interpreter pattern is a behavioral design pattern that defines a representation for a language's grammar along with an interpreter that uses the representation to interpret sentences in the language. It provides a way to evaluate language grammar or expressions by representing each grammar rule as a class.

**Intent:** Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. This pattern is useful for building simple languages, expression evaluators, and rule engines.

## How This Code Implements the Pattern

This implementation demonstrates the Interpreter pattern's essential structure with three key participants:

**Abstract Expression Interface:**
- **IExpression**: Defines the common interface that all expression nodes must implement. It declares the `Interpret()` method that each concrete expression must provide, establishing the contract for expression evaluation throughout the expression tree.

**Terminal Expressions:**
- **Number**: Represents the terminal symbols in the grammar that cannot be broken down further. These are the leaf nodes in the expression tree that contain actual values and provide the base case for recursive interpretation by simply returning their stored value.

**Non-Terminal Expressions:**
- **Add & Subtract**: Represent the non-terminal symbols in the grammar that define operations between other expressions. These classes implement the grammar rules for their respective operations and recursively interpret their child expressions to compute results. They form the internal nodes of the expression tree.

The pattern creates a tree structure where each node represents a grammar rule or terminal symbol. The interpretation process works recursively, with non-terminal expressions delegating to their child expressions and combining the results according to their specific operation rules. This creates a direct mapping between the language grammar and the object structure.

## Benefits Demonstrated

**Grammar Representation**: The pattern provides a clear and direct mapping between language grammar rules and class structures, making it easy to understand and modify the language definition.

**Extensible Language Definition**: New grammar rules and operations can be added by creating new expression classes without modifying existing code, supporting the Open/Closed Principle.

**Single Responsibility Principle (SRP)**: Each expression class has a focused responsibility for interpreting one specific grammar rule or terminal symbol, creating clear separation of concerns.

**Composite Structure**: The pattern naturally supports recursive composition, allowing complex expressions to be built from simpler ones while maintaining a uniform interface for interpretation.

**Easy Grammar Modification**: Changes to the language grammar can be implemented by adding, removing, or modifying expression classes without affecting the overall interpretation mechanism.

**Recursive Evaluation**: The tree structure enables natural recursive evaluation where complex expressions are broken down into simpler components, making the interpretation process intuitive and maintainable.

**Type Safety**: Each expression type can enforce specific constraints and provide compile-time validation of grammar rules, reducing runtime errors in expression evaluation.

## Usage

**Mathematical Expression Evaluators**: Building calculators or formula processors that need to parse and evaluate mathematical expressions with operators, functions, and variables. The pattern allows for easy extension with new mathematical operations and maintains clear separation between different types of expressions.

**Rule Engines and Business Logic**: Implementing business rule systems where complex business logic needs to be expressed in a domain-specific language. For example, pricing rules, validation constraints, or workflow conditions that can be defined declaratively and interpreted dynamically based on runtime data and context.
