# Abstract Factory Pattern: Vehicle Factory 🚗🏍️

This repository contains a C# Console Application demonstrating the **Abstract Factory** design pattern. It simulates a vehicle manufacturing system that guarantees matching families of products (Cars and Bikes) based on a specific style (City or Sports).

## 📌 Project Overview

The goal of this project is to showcase object-oriented programming principles—specifically **Inheritance**, **Polymorphism**, and **Abstraction**—to solve the problem of creating families of related objects without specifying their concrete classes.

By using an Abstract Factory, the client code (the `Main` method) remains completely decoupled from the specific vehicle implementations. It only interacts with abstract templates, allowing the underlying vehicle types to be swapped dynamically at runtime without modifying the client logic.

## 🏗️ Architecture

The code is structured into four main components defined by the Abstract Factory pattern:

1. **Abstract Products:** 
   * `Car`: Defines the blueprint for all cars (requires a `Drive()` method).
   * `Bike`: Defines the blueprint for all bikes (requires a `Ride()` method).
   
2. **Concrete Products:** 
   * **City Family:** `CityCar`, `CityBike` (Designed for quiet, casual urban transport).
   * **Sports Family:** `SportsCar`, `SportsBike` (Designed for high-speed, aggressive performance).

3. **Abstract Factory:** 
   * `VehicleFactory`: The strict contract that mandates any inheriting factory must be able to create one `Car` and one `Bike`.

4. **Concrete Factories:** 
   * `CityVehicleFactory`: Assembles only City-style vehicles.
   * `SportsVehicleFactory`: Assembles only Sports-style vehicles.

## 🚀 How to Run

1. Open the project in **Visual Studio** or your preferred C# IDE.
2. Set the `Program.cs` file containing the `Main` method as the startup object.
3. Build and Run the application.
4. View the console output to see the polymorphic behavior in action.

## 💻 Example Output
```text
--- Testing the Sports Factory ---
V8 Engine roaring to life!
Accelerating rapidly down the highway in the Sports Car.

Dropping the visor and revving the throttle.
Hitting the apex of the corner on the Sports Bike!

--- Testing the City Factory ---
Starting the quiet hybrid engine...
Cruising smoothly through downtown traffic in the City Car.

Ringing the bicycle bell.
Pedaling casually along the park trail on a City Bike.