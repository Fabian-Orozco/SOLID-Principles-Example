# SOLID Principles - Vending Machine

This project demonstrates the SOLID principles in action, ensuring Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion.

## Single Responsibility Principle (SRP)

The `VendingMachine` class utilizes constructor dependency injection, separating concerns from `JsonMenuLoader` and `PriceTagMakers`.

## Open/Closed Principle (OCP)

By extending the `PriceTagMaker` class, extra charges for certain product types can be easily implemented without modifying existing code.

## Liskov Substitution Principle (LSP)

The `Extensions` class returns either a superclass or a subclass based on product type, maintaining price calculation regardless of subtype.

## Dependency Inversion Principle (DIP)

The `VendingMachine` class depends on an abstraction (`IMenuLoader`) instead of specific file readers, allowing high-level modules to remain independent of low-level ones.

## Interface Segregation Principle (ISP)

Interfaces like `IVendingMachine` allow different vending machine types to implement methods as needed, promoting code reuse and flexibility.

To execute: `dotnet run`.

Fabián Orozco Chaves - B95690
Example source: [Learn SOLID Principles by Building a Simple App](https://medium.com/@hdmdhr/learn-solid-principles-by-building-a-simple-app-2111184df426).
