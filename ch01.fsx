(**
# Chapter 1. Introduction

F# is an open-source, cross-platform, functional-first programming language that empowers all levels of programmers to write simple, robust code for a huge range of practical purposes.
F# combines the succinctness, expressivity, efficiency, and robustness of functional programming - programming based on transformations of data - with the runtime support, libraries, interoperability, tools, and object models of modern programming frameworks.
F# is the safe choice for modern programming, embracing both enterprise quality through tools for a wide range of editors and operating systems, and openness, allowing you to contribute to the language and its ecosystem.

This book will help you become an expert in using F# for a broad range of practical problems.
F# is a "functional-first" language, where functional programming is the first option used for solving most programming problems.
However, F# differs from many functional languages in that it is both highly interoperable and embraces imperative and object-oriented (OO) programming where necessary.
It also provides the benefits of both compiled and dynamic languages, allowing both the rapid iteration typical of dynamic languages and the performance and robustness of a strongly-typed compiled language.

Functional programming has long inspired students and programmers alike with its simplicity and expressive power.
Applied functional programming is booming.
A new generation of functional languages is reaching maturity; some functional language constructs have been integrated into languages such as C#, Java, and Python, and there is now widespread expertise available in the pragmatic application of functional programming techniques.
There is also strong evidence that functional programming offers significant productivity gains in important application areas such as data access, ETL (Extract, Transform, Load) pipelines, enterprise architecture, financial modeling, machine learning, and analysis tools.
More recently, functional programming is part of the rise of declarative programming models, especially for data queries, concurrent programming, parallel programming, and reactive programming.

The F# designers have adopted a design philosophy that allows you to take the best and most productive aspects of these paradigms and combine them while still placing primary emphasis on simplicity.
This book will help you understand the power that F# offers through this combination.
The designer of the F# language, Don Syme, is one of the authors of this book.
This book benefits from his authority on F# and from all the authors' years of experience with F# and other programming languages.

F# benefits from a supportive and energetic worldwide community that is happy and willing to help you in your journey.
You can find them everywhere: on StackOverflow (tag fsharp), Twitter (#fsharp), LinkedIn, GitHub, Slack, Facebook, and more.
Most of all, you can find them via fsharp.org - the home of the F# Software Foundation, the non-profit foundation whose mission is to promote and protect the F# language and that acts as a strong voice for the language worldwide.
The F# community contributes to an ecosystem of free open-source components and tools, including important core tools such as FSharp.Data, that bridge to a host of other programming libraries and services.
F# also combines the best of openness and enterprise support: it is an open-source, cross-platform language under an OSS-approved license, and companies including Microsoft and Xamarin provide supported tooling for F# through tools such as Visual Studio and Xamarin Studio.
Combined with its technical features, this makes F# an exciting and safe choice for mainstream professional programming activities.

F# offers an approach to computing that will continue to surprise and delight, and mastering F# programming techniques will help you become a better and happier programmer regardless of the language you use.
There has been no better time to dive into the beautiful and productive world of F# programming, and F# offers the best route to learn and apply modern programming techniques so as to solve real-world problems.


## The Genesis of F#

F# began in 2002, when Don Syme and others decided to ensure that the "ML" approach to pragmatic functional language design found a high-quality expression for the .NET platform.
The project was closely associated with the design and implementation of Generics for the .NET Common Language Runtime.
The first stabilized, supported version of F# was F# 2.0 in 2010.
F# has always been open source and cross platform, and now adopts open engineering for all its components.
In 2015, F# 4.0 was finalized, including commits from both enterprise and community contributors.
This is the version of the language described in this book and is also the version included with Visual Studio 2015 and Xamarin Studio 5.0.

F# draws its core language from the programming language OCaml, which in turn comes from the ML family of programming languages, which dates back to 1974.
F# also draws from C# for its object model; from Haskell, with regard to two language features—sequence expressions and computation expressions; and from Python, with regard to its indentation-aware syntax.

Despite the similarities to OCaml and Haskell, programming with F# is quite different in practice.
In particular, the F# approach to object programming and dynamic language techniques is substantially different from other mainstream functional languages.
Programming in F# tends to be more object oriented than in other functional languages.
Programming also tends to be more flexible, as F# embraces techniques such as dynamic loading, dynamic typing, and reflection, and it adds techniques such as expression quotation, units-of-measure, type providers, and active patterns.
We will cover these topics in this book and use them in many application areas.

F# began as a .NET language interoperating with C# and .NET libraries, and is quickly and easily able to leverage the thousands of libraries and techniques developed by the broader .NET community.
However, F# is beginning to escape the .NET box; for example, it may also be compiled to Android, Apple iOS, Linux, JavaScript, and GPUs.
F# 4.0 can be compiled to JavaScript through the open-source toolkits FunScript and WebSharper (websharper.com).
Also, .NET is beginning to loosen its association with Windows, as the NET Core Framework is open source and cross platform, and you can contribute to it.
F# code can also be edited and executed directly in most web browsers through sites such as tryfsharp.org and cloudsharper.com.


## About this book
This book is structured in three parts.
Chapters 2 through 11 deal with the F# language and basic techniques such as functional, imperative, and object programming, followed by techniques to program with textual, structured, and numeric data, and then techniques for parallel, reactive, concurrent, and distributed programming.
Chapters 12 through 15 deal with a series of applied programming samples and topics.
Chapters 16 through 19 deal with more advanced F# programming techniques.

Throughout this book, we address both programming constructs and programming techniques.
Our approach is driven by examples: we show code, and then we explain it.
Frequently, we give reference material describing the constructs used in the code and related constructs you may use in similar programming tasks.
We've found that an example-driven approach helps bring out the essence of a language and the way the language constructs work together.
You can find a complete syntax guide in the appendix, and we encourage you to reference it while reading the book.

The book's chapters are as follows, starting with basic F# techniques:

Chapter 2, "Your First F# Program: Getting Started With F#," begins by introducing F# Interactive, a tool you can use to interactively evaluate F# expressions and declarations and that we encourage you to use while reading this book.
In this chapter, you will use F# Interactive to explore some basic F# and .NET constructs, and we introduce many concepts that are described in more detail in later chapters.

Chapter 3, "Introducing Functional Programming," focuses on the basic constructs of typed functional programming, including arithmetic and string primitives, type inference, tuples, lists, options, function values, aggregate operators, recursive functions, function pipelines, function compositions, and pattern matching.

Chapter 4, "Introducing Imperative Programming," introduces the basic constructs used for imperative programming in F#.
Although the use of imperative programming is often minimized with F#, it's used heavily in some programming tasks such as scripting.
You will learn about loops, arrays, mutability mutable records, locals and reference cells, the imperative .NET collections, exceptions, and the basics of .NET I/O.

Chapter 5, "Understanding Types in Functional Programming," covers types in more depth, especially topics of generics and subtyping.
You will learn techniques that you can use to make your code generic as well as how to understand and clarify type error messages reported by the F# compiler.

Chapter 6, "Programming with Objects," introduces object-oriented programming in F#.
You will learn how to define concrete object types so as to implement data structures, how to use the notational devices of object-programming such as method overloading with your F# types, and how to create objects with mutable state.
You will then learn how to define object interface types and a range of techniques to implement objects, including object expressions, constructor functions, delegation, and implementation inheritance.

Chapter 7, "Encapsulating and Organizing Your Code," shows the techniques you can use to hide implementation details through encapsulation and to organize your code with namespaces and modules.
You'll understand the benefits of F# requiring a file-ordering for code in your project and how it helps you avoid the spaghetti-dependencies of unrestricted programming.

Chapter 8, "Working with Textual Data," looks at techniques for formatting data, working with strings, tokenizing text, parsing text, and marshaling binary values.
You'll learn how to use the powerful FSharp.Data library to access CSV, JSON, and XML data in type-safe and scalable ways.

Chapter 9, "Working with Sequences and Structured Data," looks at two important sets of functional programming techniques.
In this chapter, you will learn succinct and compositional techniques for building, transforming, and querying in-memory data structures and sequences.
In addition, you will learn techniques for working with tree-structured data, especially abstract syntax representations; how to use F# active patterns to hide representations; and how to traverse large structured data without causing stack overflows through the use of tail calls.

Chapter 10, "Numeric Programming and Charting," looks at constructs and libraries for programming with numerical data in F#.
In this chapter, you will learn about basic numeric types; how to use library routines for summing, aggregating, maximizing and minimizing sequences; how to implement numeric algorithms; how to use the FSharpCharting library for charting; how to use units of measure in F# to give strong typing to numeric data; and how to use the powerful open-source Math.NET library for advanced vector, matrix, statistical, and linear algebra programming.

Chapter 11, "Reactive, Asynchronous, and Parallel Programming," shows how you can use F# for programs that have multiple logical threads of execution and that react to inputs and messages.
You will first learn how to construct basic background tasks that support progress reporting and cancellation.
You will then learn how to use F# asynchronous workflows to build scalable, massively concurrent reactive programs that make good use of the .NET thread pool and other .NET concurrency-related resources.
This chapter concentrates on message-passing techniques that avoid or minimize the use of shared memory.
However, you will also learn the fundamentals of concurrent programming with shared memory using .NET.

Chapters 12 to 15 deal with applied topics in F# programming.

Chapter 12, "Symbolic Programming with Structured Data," applies some of the techniques from Chapters 9 and 11 in two case studies.
The first is symbolic expression differentiation and rendering, an extended version of a commonly used case study in symbolic programming.
The second is verifying circuits with propositional logic; you will learn how to use symbolic techniques to represent digital circuits, specify properties of these circuits, and verify these properties using binary decision diagrams (BDDs).

Chapter 13, "Integrating External Data and Services," looks at several dimensions of querying and accessing data from F#.
You will first learn how to use the type-provider feature of F# to give fluent data scripting against databases and web services.
You will then learn how to use queries with F#, in particular the LINQ paradigm supported by .NET.
You will then look at how to use F# in conjunction with relational databases and how to use FSharp.Data to access REST services.

Chapter 14, "Build Smart Web Applications," shows how to use F# to write server-side scripts that respond to web requests, followed by how to serve webpage content using the Suave.io microservice framework.
We also describe how WebSharper lets you write cross-tier HTML5 web applications in F#.

Chapter 15, "Visualization and Graphical User Interfaces," shows how to design and build graphical user-interface applications using F# and the .NET Windows Forms and WPF libraries.
We also show how to design new controls using standard OO design patterns and how to script applications using the controls offered directly by the .NET libraries.

Chapters 16 to 19 deal with more advanced techniques in F# programming.

Chapter 16, "Language-Oriented Programming," looks at what is effectively a fourth programming paradigm supported by F#: the manipulation and representation of languages using a variety of concrete and abstract representations.
In this chapter, you will learn three advanced features of F# programming: computation expressions (also called workflows), reflection, and quotations.
These are also used in other chapters, particularly Chapters 11 and 12.

Chapter 17, "Libraries and Interoperability," shows how to use F# with other software libraries.
In particular, you will learn some of the many libraries available, look at how memory management works, and learn how to use the .NET Platform Invoke mechanisms from F#.

Chapter 18, "Developing and Testing F# Code," shows the primary tools and techniques you can use to eliminate bugs from your F# programs.
You will learn how to package your code into assemblies, how to share F# packages, how to use debugging tools with F#, how to use F# Interactive for exploratory development and testing, and how to use the NUnit and XUnit testing frameworks with F# code.

Chapter 19, "Designing F# Libraries," gives our advice on methodology and design issues for writing libraries in F#.
You will learn how to write interoperable F# libraries that make relatively little use of F# constructs at their boundaries in order to appear as natural as possible to other programmers.
We then cover functional programming design methodology and how to combine it with the OO design techniques.
The appendix, “F# Brief Language Guide,” gives a compact guide to all key F# language constructs and the key operators used in F# programming.
Because of space limitations, we only partially address some important aspects of programming with F#.
There are also hundreds of additional tools and libraries that can be readily used from F#, many explicitly designed for use with F#.
Quotation meta-programming and F# type providers are described only briefly in Chapter 16.
Also, some software-engineering issues such as performance tuning are largely omitted.


## Who This Book Is For

We assume you have some programming knowledge and experience.
If you don't have experience with F#, you'll still be familiar with many of the ideas it uses.
However, you may also encounter some new and challenging ideas.
For example, if you've been taught that OO design and programming are the only ways to think about software, then programming in F# may be a re-education.
F# fully supports OO development, but F# programming combines elements of both functional and OO design.
OO patterns such as implementation inheritance play a less prominent role than you may have previously experienced.
Chapter 6 covers many of these topics in depth.

The following notes will help you set a path through this book, depending on your background:

C++, C#, and Java: If you've programmed in a typed OO language, you may find that functional programming, type inference, and F# type parameters take a while to get used to.
However, you'll soon see how to use these to be a more productive programmer.
Be sure to read Chapters 2, 3, 5, and 6 carefully.

Python, Scheme, Ruby, and dynamically typed languages: F# is statically typed and type-safe.
As a result, F# development environments can discover many errors while you program, and the F# compiler can more aggressively optimize your code.
If you've primarily programmed in an untyped language such as Python, Scheme, or Ruby, you may think that static types are inflexible and wordy.
However, F# static types are relatively nonintrusive, and you'll find the language strikes a balance between expressivity and type safety.
You'll also see how type inference lets you recover succinctness despite working in a statically typed language.
Be sure to read Chapters 2 through 6 carefully, paying particular attention to the ways in which types are used and defined.

Typed functional languages: If you're familiar with Swift, Scala, Haskell, or OCaml, you'll find the core of F# readily familiar, with some syntactic differences. However, F# embraces .NET, including the .NET object model, and it may take you a while to learn how to use objects effectively and how to use the .NET libraries themselves.
This is best done by learning how F# approaches object programming in Chapter 6, and then exploring applied programming in Chapters 8 through 16, referring to earlier chapters as necessary.
Haskell programmers also need to learn the F# approach to imperative programming, described in Chapter 4, because many .NET libraries require a degree of imperative coding to create, configure, connect, and dispose of objects.

We strongly encourage you to use this book in conjunction with a development environment that supports F# 4.0 directly, such as Atom, Vim, Emacs, CloudSharper, Visual Studio 2015. or Xamarin Studio 5.0.
In particular, the interactive type inference in these environments is exceptionally helpful for understanding F# code; with a simple mouse movement, you can examine the inferred types of the sample programs.
These types play a key role in understanding the behavior of the code.


### Note

You can download and install F# from fsharp.org.
You can download all the code samples used in this book from A press; they were prepared and checked with F# 4.0.
As with all books, it's inevitable that minor errors may exist in the text.
An active errata and list of updates is maintained by the publishers.
*)
