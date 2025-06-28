# Memento Pattern

## Overview

**Definition:** The Memento pattern is a behavioral design pattern that captures and externalizes an object's internal state without violating encapsulation, so that the object can be restored to this state later. It provides the ability to undo operations by storing snapshots of an object's state.

**Intent:** Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later. This pattern is useful for implementing undo mechanisms and state rollback functionality.

## How This Code Implements the Pattern

This implementation demonstrates the Memento pattern's essential structure with three key participants:

**Originator:**
- **Originator**: The object whose state needs to be saved and potentially restored. It creates memento objects containing snapshots of its current state and can restore its state from a given memento. The originator has exclusive access to the memento's contents, maintaining encapsulation while enabling state management.

**Memento:**
- **Memento**: Stores the internal state of the originator object. It acts as a snapshot that captures the originator's state at a specific point in time. The memento is designed to be opaque to objects other than the originator, protecting the state data from unauthorized access or modification.

**Caretaker:**
- **Caretaker**: Manages the memento objects but never operates on or examines their contents. It's responsible for storing, organizing, and providing mementos when needed for state restoration. The caretaker treats mementos as black boxes, maintaining a clear separation between state management and state storage.

The pattern creates a clear separation of responsibilities where the originator handles state creation and restoration, the memento safely stores state data, and the caretaker manages the collection and lifecycle of state snapshots without accessing their internal details.

## Benefits Demonstrated

**Encapsulation Preservation**: The pattern maintains object encapsulation by ensuring that only the originator can access the memento's internal state, protecting sensitive data from external manipulation while enabling state management.

**Undo/Redo Functionality**: Provides a robust foundation for implementing undo and redo operations by maintaining a history of object states that can be restored as needed, enhancing user experience and error recovery.

**Single Responsibility Principle (SRP)**: Each participant has a focused responsibility - the originator manages its state, the memento stores state snapshots, and the caretaker handles memento lifecycle management.

**Open/Closed Principle (OCP)**: New types of state information can be added to mementos without modifying existing caretaker or client code, making the system extensible while keeping existing components stable.

**State Isolation**: Each memento represents an independent state snapshot, preventing state corruption and ensuring that restoring to a previous state doesn't affect other stored states or current operations.

**Flexible State Management**: The pattern supports various state management strategies through different caretaker implementations, enabling features like limited history, state compression, or intelligent state selection.

**Simplified Rollback Logic**: Complex state restoration logic is encapsulated within the originator, simplifying client code and reducing the complexity of implementing rollback functionality.

## Benefits Demonstrated

**Encapsulation Preservation**: The pattern maintains object encapsulation by ensuring that only the originator can access the memento's internal state, protecting sensitive data from external manipulation while enabling state management.

**Undo/Redo Functionality**: Provides a robust foundation for implementing undo and redo operations by maintaining a history of object states that can be restored as needed, enhancing user experience and error recovery.

**Single Responsibility Principle (SRP)**: Each participant has a focused responsibility - the originator manages its state, the memento stores state snapshots, and the caretaker handles memento lifecycle management.

**Open/Closed Principle (OCP)**: New types of state information can be added to mementos without modifying existing caretaker or client code, making the system extensible while keeping existing components stable.

**State Isolation**: Each memento represents an independent state snapshot, preventing state corruption and ensuring that restoring to a previous state doesn't affect other stored states or current operations.

**Flexible State Management**: The pattern supports various state management strategies through different caretaker implementations, enabling features like limited history, state compression, or intelligent state selection.

## Usage

**Text Editors and Document Processing**: Implementing undo/redo functionality in word processors, code editors, or design applications where users need to revert changes to previous document states. The pattern enables sophisticated history management with features like branching undo trees and selective state restoration.

**Game State Management**: Saving and loading game states in video games, including checkpoint systems, save game functionality, and replay features. The pattern allows players to return to previous game states while maintaining performance through efficient state snapshot management and storage optimization.
