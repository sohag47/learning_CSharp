# C# and .NET Learning Roadmap ✅

A complete roadmap to learn **C# programming** and **.NET development** from beginner to advanced level.  
This repository is designed to help anyone searching for a:

- 🚀 C# Roadmap
- 💻 .NET Roadmap
- 📘 C# Learning Path
- 🧠 C# Study Guide

📦 Covers: Basics → OOP → Collections → LINQ → Generics → ASP.NET Core → Entity Framework → Clean Architecture

> This guide is structured as a Markdown checklist and updated regularly as I learn.  

---

## ✅ Stage 1: C# Foundations
  ### 1.1 Input / Output processing & Variables.
    Console.Write("What is your name?"); // With newline
    string name = Console.ReadLine();
    Console.WriteLine(name);
  ### 1.2 Understand Predefined Types
  - [X] Value Types (int, float, char, etc.)
  - [X] Reference Types (string, object)
  
  ## 1.3 Type Conversions
    string input = "123";
    int number = Convert.ToInt32(input);
    double d = Convert.ToDouble("3.14");
    bool b = Convert.ToBoolean("true");
  ## 1.4 Nullable types
    int? number = null;
    int result = number ?? 0;
  ## 1.5 Control Flow Statements
  - [X] if-else
  - [X] switch
- [ ] Loops
  - [X] for
  - [X] foreach
  - [ ] while
  - [ ] do-while
 ## 1.6 Error Handling
  - [X] try-catch-finally
- [ ] Other Statements
  - [ ] using
  - [ ] lock
  - [ ] unsafe
  - [ ] yield
 ## 1.7 Operators
  - [X] Arithmetic
  - [X] Assignment
  - [X] Relational
  - [ ] Bitwise
  - [ ] Overflow/Underflow (checked/unchecked)

---

## 🔷 Stage 2: OOP in C#

- [ ] Classes and Objects
  - [ ] Fields (static, instance, readonly)
  - [X] Field, properties & Auto properties: { get; set; }
  - [X] Access Modifiers (public, private, protected, internal, protected internal, private protected)
  - [ ] Storage & Behavior Modifiers (static, const, required, readonly, volatile, unsafe)
  - [X] Methods (static, instance, override, abstract, virtual)
  - [X] Method Overloading
  - [ ] Method Override
  - [ ] Constructors (static, instance)
  - [X] Constructor, Destructor/Finalizer
  - [X] Constructor chaining
  - [X] Static Class
  - [X] Partial Class
  - [X] Abstract Class
- [ ] Structs
- [ ] Enums
- [ ] Inheritance and Polymorphism
- [ ] Interfaces and Delegates
- [X] Namespaces
- [ ] Using Generics
  - [ ] Generic Class, Constraints and  Generic Method
  - [ ] Built in Generic data structures (List<T>, Dictionary<K,V>, Queue<T>, Stack<T>, HashSet<T>, SortedList<K,V>, SortedDictionary<K,V>)
  - [ ] Concurrent Collections (for multithreading) (ConcurrentDictionary<K,V>,ConcurrentQueue<T>, ConcurrentStack<T>, BlockingCollection<T>)
  - [ ] Non-generics collection

---

## 🔶 Stage 3: Collections and Data Structures

- [ ] Generic Collections (System.Collections.Generic)
  - [X] List<T>
  - [X] Dictionary<TKey, TValue>
  - [ ] Queue<T>
  - [ ] Stack<T>
  - [ ] HashSet<T>
  - [ ] LinkedList<T>
- [ ] Non-generic Collections
  - [ ] ArrayList
  - [ ] Hashtable
  - [ ] SortedList
  - [ ] Stack
  - [ ] Queue
- [X] Arrays
  - [X] Single-dimensional Arrays
  - [X] Multi-dimensional Arrays

---

## 🟡 Stage 4: LINQ (Language Integrated Query)

- [X] Basic LINQ Concepts
  - [X] Select
  - [X] Where
  - [X] OrderBy
  - [X] GroupBy
- [X] Aggregation & Set Operations
  - [X] Sum
  - [X] Count
  - [X] Min/Max
  - [X] Intersect
  - [X] Union
  - [X] Except
- [X] Element Operators
  - [X] First
  - [X] Last
  - [X] Single
  - [X] ElementAt
- [X] Filtering and Conversion
  - [X] OfType
  - [X] Cast
  - [X] ToList
  - [X] ToArray
  - [X] ToDictionary

---

## 🔴 Stage 5: Advanced Concepts

- [ ] Lambda Expressions
- [ ] LINQ Projection & Quantification
  - [ ] SelectMany
  - [ ] All
  - [ ] Any
  - [ ] Contains

---
