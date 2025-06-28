# Mediator Pattern

## Overview

**Definition:** The Mediator pattern is a behavioral design pattern that defines how a set of objects interact with each other. Instead of objects communicating directly, they communicate through a central mediator object, which encapsulates the interaction logic and promotes loose coupling between components.

**Intent:** Define an object that encapsulates how a set of objects interact. The Mediator pattern promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

## How This Code Implements the Pattern

This implementation demonstrates the Mediator pattern's essential structure with four key participants:

**Mediator Interface:**
- **IMediator**: Defines the communication contract that concrete mediators must implement. It declares the `Send()` method that handles message routing between colleague objects, establishing a standard interface for all mediator implementations.

**Concrete Mediator:**
- **ConcreteMediator**: Implements the mediator interface and contains the interaction logic between colleague objects. It maintains references to all participating colleagues and orchestrates their communication by determining which colleagues should receive messages based on the sender and message content.

**Colleague Base Class:**
- **Colleague**: Provides the abstract foundation for all participating objects. It maintains a reference to the mediator and establishes the common structure that all colleague classes must follow, ensuring they can participate in mediated communication.

**Concrete Colleagues:**
- **ConcreteColleague1 & ConcreteColleague2**: Implement specific colleague behaviors and communicate exclusively through the mediator. They send messages by calling the mediator's `Send()` method and receive messages through their `Receive()` method, never communicating directly with other colleagues.

The pattern centralizes complex communication logic in the mediator, allowing colleague objects to remain focused on their core responsibilities while the mediator handles routing, filtering, and coordination of interactions between them.

## Benefits Demonstrated

**Reduced Coupling**: Colleague objects don't need direct references to each other, significantly reducing dependencies and making the system more maintainable and flexible for future changes.

**Centralized Communication Logic**: All interaction rules and routing logic are concentrated in the mediator, making complex communication patterns easier to understand, modify, and debug.

**Single Responsibility Principle (SRP)**: Colleagues focus on their core functionality while the mediator handles communication coordination, creating clear separation of concerns and improved code organization.

**Open/Closed Principle (OCP)**: New colleague types can be added and new interaction patterns can be implemented by extending or replacing mediators without modifying existing colleague classes.

**Reusable Components**: Colleague objects become more reusable since they're not tightly coupled to specific other colleagues, allowing them to be used in different contexts with different mediators.

**Simplified Object Protocols**: Complex many-to-many communication relationships are simplified into one-to-many relationships between colleagues and the mediator, reducing system complexity.

**Dynamic Behavior Configuration**: The mediator can implement different communication strategies or modify interaction patterns at runtime without requiring changes to colleague objects.

## Usage

**User Interface Dialog Management**: Coordinating interactions between form controls where changes in one component affect others. For example, enabling/disabling buttons based on form validation, updating dependent dropdown lists, or managing wizard-style workflows where the mediator orchestrates navigation and data validation between dialog components.

**Air Traffic Control Systems**: Managing communication between aircraft, ground control, and various airport systems where direct communication between all parties would create chaos. The air traffic control mediator coordinates takeoffs, landings, route changes, and emergency procedures while keeping aircraft from needing to communicate directly with each other.
