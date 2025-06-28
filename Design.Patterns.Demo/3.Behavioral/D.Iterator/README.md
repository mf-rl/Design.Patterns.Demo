# Iterator Pattern

## Overview

**Definition:** The Iterator pattern is a behavioral design pattern that provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It encapsulates the traversal logic in a separate iterator object, allowing multiple traversals to proceed concurrently.

**Intent:** Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation. The pattern supports variations in traversal and decouples collection classes from traversal algorithms.

## How This Code Implements the Pattern

This implementation demonstrates the Iterator pattern's essential structure with four key participants:

**Iterator Interface:**
- **IIterator<T>**: Defines the interface for accessing and traversing elements. It declares the essential methods `HasNext()` for checking if more elements exist and `Next()` for retrieving the next element in the sequence, providing a standard contract for all iterator implementations.

**Concrete Iterator:**
- **NameIterator**: Implements the iterator interface and maintains the current position in the traversal of the aggregate object. It encapsulates the traversal algorithm and state management, knowing how to navigate through the specific collection structure while providing a uniform access interface.

**Aggregate Interface:**
- **IAggregate<T>**: Defines the interface for creating iterator objects. It declares the `CreateIterator()` method that concrete aggregates must implement to provide appropriate iterators for their internal structure.

**Concrete Aggregate:**
- **NameCollection**: Implements the aggregate interface and creates concrete iterator instances. It manages the collection's internal data structure while providing controlled access through iterators, maintaining encapsulation of its internal representation.

The pattern establishes a clear separation between collection management and traversal logic, allowing clients to iterate through collections without knowing their internal structure or implementation details.

## Benefits Demonstrated

**Encapsulation of Traversal Logic**: The pattern separates iteration logic from the collection's core functionality, allowing collections to focus on data management while iterators handle traversal concerns.

**Uniform Access Interface**: Different collection types can provide consistent iteration interfaces, making client code more flexible and reducing the need for type-specific iteration logic.

**Single Responsibility Principle (SRP)**: Collections handle data storage and management, while iterators focus solely on traversal logic, creating clear separation of concerns and improved maintainability.

**Open/Closed Principle (OCP)**: New iterator types can be added without modifying existing collections, and new collection types can be created without changing existing iterator interfaces.

**Multiple Concurrent Iterations**: Multiple iterators can traverse the same collection simultaneously without interfering with each other, enabling complex traversal scenarios and parallel processing.

**Polymorphic Iteration**: Clients can work with different collection types through the same iterator interface, promoting code reuse and simplifying algorithms that need to process various collection types.

**State Management**: Iterators maintain their own traversal state, allowing iteration to be paused, resumed, or reset independently of the collection's state or other concurrent iterations.

## Usage

**Data Structure Traversal**: Implementing consistent iteration mechanisms for custom data structures like trees, graphs, or specialized collections where the internal organization differs from standard arrays or lists, but clients need uniform access patterns.

**Database Result Set Processing**: Providing sequential access to query results where the underlying data may come from different sources (memory, disk, network) or require different fetching strategies, while presenting a consistent interface for result processing and pagination.
