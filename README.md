# CSharpBasicsAssignment

A C# console application created for **C# Basics — Module 1-1, Assignment 4: Console Apps, Types & Memory Model**.

## Overview

This project practices the main C# concepts covered in the assignment:

- Project and `.csproj` structure
- Variables and C# data types
- Implicit and explicit casting
- Integer division
- Boxing and unboxing
- Parsing and `TryParse`
- Value types vs. reference types
- Struct copy semantics
- Class reference semantics
- Stack and heap concepts
- Scope
- Compound assignment operators
- Bitwise operators: `&`, `|`, and `^`
- XOR and the Single Number problem

## Project Structure

```text
CSharpBasicsAssignment/
├── CSharpBasicsAssignment.csproj
├── Program.cs
├── Order.cs
├── STACK_HEAP.md
├── README.md
└── Answers.md
```

### Main Files

- **`Program.cs`** — Contains the main demonstrations and exercises for the assignment.
- **`Order.cs`** — Contains the `Order` reference type used to demonstrate reference semantics and heap identity.
- **`STACK_HEAP.md`** — Contains the stack and heap diagrams.
- **`Answers.md`** — Contains the short-answer questions from Part G.
- **`CSharpBasicsAssignment.csproj`** — Contains the project configuration, including the target framework and nullable settings.

## Technologies

- C#
- .NET 10
- Console Application

## How to Run

From the project directory:

```bash
dotnet run
```

To build the project:

```bash
dotnet build
```

## Topics Demonstrated

### Types and Casting

The project demonstrates:

- `int`
- `long`
- `double`
- `decimal`
- `bool`
- `char`
- `string`
- `var`

It also demonstrates implicit conversion, explicit casting, `Convert.ToInt32`, boxing/unboxing, parsing, and `TryParse`.

### Value vs. Reference Types

A `struct` is used to demonstrate value-copy behavior, while the `Order` class demonstrates reference-copy behavior.

The project also demonstrates assigning an `Order` reference to an `object` variable and casting it back without creating a new `Order` object.

### Bitwise Operators

The project demonstrates:

```text
&  Bitwise AND
|  Bitwise OR
^  Bitwise XOR
```

The XOR operation is also used to solve the **Single Number** problem in linear time with constant extra space.

## Assignment Context

This project is part of the C# Basics module and focuses on the concepts covered up through **Casting** in Lecture 01.
