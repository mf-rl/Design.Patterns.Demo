# Command Pattern

## Overview

**Definition:** The Command pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations. It decouples the invoker of a request from the object that performs the action.

**Intent:** Encapsulate a request as an object, thereby letting you parameterize objects with different requests, queue or log requests, and support undoable operations. This pattern promotes loose coupling between the sender and receiver of a request.

## How This Code Implements the Pattern

This implementation demonstrates the Command pattern's essential structure with four key participants:

**Command Interface:**
- **ICommand**: Defines the contract that all concrete commands must follow by declaring the `Execute()` method. This interface ensures that all commands can be invoked uniformly, regardless of their specific implementation details.

**Concrete Commands:**
- **TurnOnCommand & TurnOffCommand**: Implement the command interface and encapsulate specific actions along with the receiver objects needed to perform those actions. Each command maintains a reference to the receiver (Light) and translates the `Execute()` call into the appropriate method call on the receiver.

**Receiver:**
- **Light**: Represents the object that knows how to perform the actual work. It contains the business logic for the operations (turning on/off) but remains completely decoupled from the invokers and commands that trigger these operations.

**Invoker:**
- **RemoteControl**: Acts as the sender that triggers command execution without knowing the specifics of what action will be performed or which receiver will handle it. The invoker can store, queue, and execute commands on demand, providing a flexible control mechanism.

The pattern creates a clear separation where commands encapsulate actions, receivers perform the work, and invokers trigger execution without tight coupling between any of these components.

## Benefits Demonstrated

**Decoupling of Invoker and Receiver**: The invoker (remote control) doesn't need to know about specific receivers (light) or their methods, promoting loose coupling and making the system more flexible and maintainable.

**Parameterization of Requests**: Different commands can be passed to the same invoker, allowing dynamic behavior configuration without changing the invoker's code structure.

**Single Responsibility Principle (SRP)**: Each command class has a single, focused responsibility for encapsulating one specific action, while receivers focus on their core business logic.

**Open/Closed Principle (OCP)**: New commands can be added without modifying existing invokers, receivers, or other commands, making the system highly extensible.

**Command Queuing and Logging**: Commands can be stored, queued for later execution, or logged for audit purposes, enabling advanced features like batch processing and operation history.

**Undo/Redo Support**: The pattern naturally supports undoable operations by allowing commands to maintain state and implement reverse operations, though not demonstrated in this basic example.

**Macro Commands**: Multiple commands can be combined into composite commands, enabling complex operations to be treated as single units while maintaining the same interface.

## Usage

**GUI Applications and User Interfaces**: Implementing menu items, toolbar buttons, and keyboard shortcuts where the same action can be triggered from multiple sources. Commands encapsulate actions like copy, paste, save, or undo, allowing these operations to be invoked consistently across different UI elements.

**Task Scheduling and Automation Systems**: Building systems that need to queue, schedule, or batch process operations. Commands can represent tasks that need to be executed at specific times, in particular orders, or based on certain conditions, enabling flexible workflow management and automation.
