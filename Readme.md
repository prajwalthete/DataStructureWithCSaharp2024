# C# Collection Library

This document provides a comprehensive overview of the System.Collections namespace in C#, covering key components, commonly used methods, and lambda expressions.

## Key Components

The System.Collections namespace offers a rich set of classes and interfaces for managing and manipulating collections of data:

### Interfaces

* **ICollection:** Represents a generic collection, enabling adding, removing, and querying elements.
* **IList:** Extends ICollection for ordered collections, allowing indexing, inserting, and sorting.
* **IDictionary:** Represents a collection of key-value pairs, providing functions for adding, removing, and querying elements based on keys.
* **IEnumerable:** Supports iterating over a collection of objects.

### Classes

* *General-purpose collections:*
    * **ArrayList:** Dynamically resizable array.
    * **Hashtable:** Hash-based collection of key-value pairs.
    * **Queue:** First-in, first-out (FIFO) collection.
    * **Stack:** Last-in, first-out (LIFO) collection.
    * **HashSet:** Set of unique elements.
    * **LinkedList:** Doubly linked list.
* *Generic collections:*
    * **List<T>:** Strongly typed dynamic array.
    * **Dictionary<TKey, TValue>:** Generic collection of key-value pairs.
    * **Queue<T>:** Strongly typed FIFO collection.
    * **Stack<T>:** Strongly typed LIFO collection.
    * **HashSet<T>:** Generic set of unique elements.
    * **LinkedList<T>:** Generic doubly linked list.

### Utility Classes

* **Comparer:** Provides methods for comparing objects for equality.
* **DictionaryEntry:** Represents a key-value pair in a dictionary.
* **KeyCollection:** Represents a collection of keys in a dictionary.
* **ValueCollection:** Represents a collection of values in a dictionary.
* Thread-safe wrappers for Queue and Stack.

## Commonly Used Methods

Here are some frequently used methods in various collection types:

### General-purpose collections

* **Add:** Adds an element.
* **Remove:** Removes an element.
* **Contains:** Checks if an element exists.
* **Clear:** Removes all elements.
* **Count:** Gets the number of elements.
* **Sort:** Sorts elements (applicable to some collections).

### Dictionary

* **ContainsKey:** Checks if a key exists.
* **ContainsValue:** Checks if a value exists.
* **Keys:** Gets the collection of keys.
* **Values:** Gets the collection of values.

### Queue and Stack

* **Enqueue/Push:** Adds an element.
* **Dequeue/Pop:** Removes and returns the first/top element.
* **Peek:** Returns the first/top element without removing it.

### List

* **Insert:** Inserts an element at a specific index.
* **RemoveAt:** Removes an element at a specific index.

### HashSet

* **Union:** Combines elements from two sets.
* **Intersect:** Gets elements common to two sets.
* **Except:** Gets elements in one set but not in another.

These are just a few examples; each collection class provides additional methods and properties for specific functionalities.

## Lambda Expressions

Lambda expressions, introduced in C# 3.0, offer a concise and inline way to define anonymous functions. They are valuable for:

* *Readability and Conciseness:* Expressing functionality compactly compared to separate methods.
* *Inline Function Definition:* Defining functions on-the-fly, eliminating dedicated method creation.
* *Delegates and Functional Programming:* Working with delegates seamlessly, promoting functional programming concepts.
* *Functional Constructs:* Supporting filtering, mapping, and reducing data, commonly used with LINQ.

*Example:* Doubling elements in a list:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> doubledNumbers = numbers.Select(x => x * 2).ToList();