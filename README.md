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

## 1: C# Foundations
  ### 1.1 Input / Output processing & Variables.
    Console.Write("What is your name?"); // With newline
    string name = Console.ReadLine();
    Console.WriteLine(name);
  ### 1.2 Understand Predefined Types
  - [X] Value Types (int, float, char, etc.)
  - [X] Reference Types (string, object)
  
  ### 1.3 Type Conversions
    string input = "123";
    int number = Convert.ToInt32(input);
    double d = Convert.ToDouble("3.14");
    bool b = Convert.ToBoolean("true");
  ### 1.4 Nullable types
    int? number = null;
    int result = number ?? 0;
  ### 1.5 Control Flow Statements
  - [X] if-else
  - [X] switch
- [ ] Loops
  - [X] for
  - [X] foreach
  - [ ] while
  - [ ] do-while
 ### 1.6 Error Handling
  - [X] try-catch-finally
- [ ] Other Statements
  - [ ] using
  - [ ] lock
  - [ ] unsafe
  - [ ] yield
 ### 1.7 Operators
  - [X] Arithmetic
  - [X] Assignment
  - [X] Relational
  - [ ] Bitwise
  - [ ] Overflow/Underflow (checked/unchecked)

---

## 2: OOP in C#

  - [X] Classes and Objects
  - [X] Constructor, Destructor/Finalizer
  - [ ] Inheritance
  - [ ] Polymorphism (compile time & run time)
  - [ ] this & base keyword
  - [ ] Fields (static, instance, readonly)
  - [X] Field, properties & Auto properties: { get; set; }
  - [X] Access Modifiers (public, private, protected, internal, protected internal, private protected)
  - [ ] Storage & Behavior Modifiers (static, const, required, readonly, volatile, unsafe)
  - [X] Methods (static, instance, override, abstract, virtual)
  - [X] Method Overloading
  - [ ] Method Override
  - [ ] Constructors (static, instance)
  - [X] Constructor chaining
  - [X] Static Class
  - [X] Partial Class & Partial Methods
  - [X] Abstract Class
  
- [ ] Structs
- [ ] Enums

- [ ] Interfaces and Delegates
- [X] Namespaces
- [ ] Using Generics
  - [ ] Generic Class, Constraints and  Generic Method
  - [ ] Built in Generic data structures (List<T>, Dictionary<K,V>, Queue<T>, Stack<T>, HashSet<T>, SortedList<K,V>, SortedDictionary<K,V>)
  - [ ] Concurrent Collections (for multithreading) (ConcurrentDictionary<K,V>,ConcurrentQueue<T>, ConcurrentStack<T>, BlockingCollection<T>)
  - [ ] Non-generics collection

---

## 3: Collections and Data Structures

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
## 4: Exception Handling
  - [X] try, catch, finally
  - [X] Custom Exceptions
  - [X] throw keyword
  - [ ] Exception filters
---

## 5: LINQ (Language Integrated Query)

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
- [ ] LINQ Projection & Quantification
  - [ ] SelectMany
  - [ ] All
  - [ ] Any
  - [ ] Contains
- [ ] yield return
---

## 6: Advanced Concepts
- [X] Lambda Expressions
- [ ] Delegates
- [ ] Events
- [ ] Extension Methods
- [ ] Anonymous Methods
- [ ] ref, out, in keyword
- [ ] params keyword
- [ ] Nullable reference types (?, ??, ??=, ?.)
- [ ] Pattern Matching (with is, switch, etc.)
---
## 7. Multithreading and Asynchronous Programming
- [X] async / await
- [X] Tasks and Task<T>
- [ ] Threads
- [ ] Thread.Sleep, Task.Delay
- [ ] lock keyword
- [ ] Parallel.For, Parallel LINQ (PLINQ)
- [ ] CancellationToken
---
## 8. Reflection & Attributes
- [ ] System.Reflection
- [ ] Reading metadata
- [ ] Custom Attributes
- [ ] typeof, GetType()
---
## 9. Memory Management
- [ ] Value Types vs Reference Types
- [ ] Stack vs Heap
- [ ] Garbage Collection
- [ ] IDisposable and using statement
- [ ] Finalizers
---
## 10. Miscellaneous
- [ ] Tuples
- [ ] Records (C# 9+)
- [ ] Dynamic Type
- [ ] var, dynamic, object differences
- [ ] enum and struct
- [ ] nameof operator
- [ ] Top-level statements (C# 9+)
---
## 11. File I/O and Serialization
- [ ] Reading/Writing Files (System.IO)
- [ ] StreamReader / StreamWriter
- [ ] Binary and XML Serialization
- [ ] JSON Serialization (System.Text.Json, Newtonsoft.Json)
---
# 2 .NET Topics
## 2.1 .NET Fundamentals
  - [X] What is .NET / .NET Core / .NET 5/6/7/8?
  - [X] CLR (Common Language Runtime)
  - [X] CTS, CLS (Common Type System, Common Language Specification)
  - [X] Project Types: Console App, Class Library, ASP.NET Web App
  - [X] Solution (.sln) and Project (.csproj) files
  - [X] Understanding the build and run lifecycle
## 2.2 Working with Projects
  - [X] Creating and running projects with dotnet CLI
  - [X] Adding NuGet packages (dotnet add package)
  - [X] appsettings.json configuration
  - [ ] Environments (Development, Production, etc.)
## 2.3 ASP.NET Core Web Applications
  - [X] MVC Pattern (Model-View-Controller)
  - [X] Razor Views & Razor Pages
  - [ ] Middleware and Request Pipeline
  - [X] Routing and Endpoints
  - [ ] Static Files and Hosting

## 2.4 Web APIs with ASP.NET Core
  - [X] Creating RESTful APIs with Controllers
  - [X] Attribute Routing ([HttpGet], [HttpPost])
  - [X] Model Binding and Validation ([FromBody], ModelState)
  - [X] JSON Serialization (System.Text.Json)
  - [X] Swagger/OpenAPI Integration
## 2.5 Dependency Injection (DI)
  - [ ] Constructor Injection
  - [ ] AddTransient, AddScoped, AddSingleton
  - [ ] Registering and Resolving Services
## 2.6 Configuration and Settings
  - [ ] IConfiguration and IOptions<T>
  - [ ] Reading from appsettings.json, environment variables
  - [ ] Strongly Typed Configuration

# 3. Advanced .NET Topics
## 3.1 Entity Framework Core (EF Core)
  - [X] Code First vs Database First
  - [X] DbContext and DbSet
  - [X] Migrations (Add-Migration, Update-Database)
  - [X] Relationships (1:1, 1:N, M:N)
  - [X] LINQ with EF
  - [ ] Eager vs Lazy Loading
  - [ ] Raw SQL Queries

## 3.2 Authentication & Authorization
  - [ ] ASP.NET Core Identity
  - [ ] OAuth
  - [ ] Identity Server
  - [ ] Access Mechanism
  - [ ] Role-Based and Policy-Based Authorization
  - [ ] JWT Authentication
  - [ ] Custom Authentication Handlers
  - [ ] Claims and Identity Management

## 3.3 Middleware and Filters
  - [ ] Creating Custom Middleware
  - [ ] Exception Handling Middleware
  - [ ] Action Filters, Result Filters

## 3.4 Logging and Monitoring
  - [ ] ILogger<T>
  - [ ] Logging providers: Console, Debug, File, Serilog
  - [ ] Application Insights

## 3.5 Hosting and Deployment
  - [ ] Kestrel Web Server
  - [ ] IIS Integration
  - [ ] Publishing with dotnet publish
  - [ ] Dockerizing .NET Apps
  - [ ] CI/CD basics with GitHub Actions, Azure DevOps, etc.

## 3.6 Testing
  - [X] Unit Testing with xUnit / NUnit / MSTest
  - [ ] Mocking with Moq
  - [ ] Integration Testing (TestServer)
  - [ ] Testing EF Core

## 3.7 Advanced Web API Topics
  - [ ] API Versioning
  - [ ] Rate Limiting
  - [ ] Throttling
  - [ ] Caching (In-memory, Distributed)
  - [ ] Uploading/Downloading files in APIs

## 3.8 Bonus: Architecture & Design Patterns in .NET
  - [ ] Clean Architecture / Onion Architecture
  - [ ] Repository and Unit of Work Patterns
  - [ ] CQRS & Mediator Pattern
  - [ ] SOLID Principles
  - [ ] Minimal APIs (introduced in .NET 6)
