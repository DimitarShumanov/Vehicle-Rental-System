# Vehicle Rental System
# Overview
This vehicle rental system is designed to manage the rental process for different types of vehicles, including cars, motorcycles, and cargo vans. The system calculates rental costs and insurance costs based on various rules and prints an invoice for the rentals. Each vehicle type has specific attributes that affect the rental and insurance calculations.

# Features
Supports multiple vehicle types: Cars, Motorcycles, and Cargo Vans.
Calculates rental costs based on the type of vehicle and rental period.
Calculates insurance costs with possible adjustments based on vehicle-specific attributes.
Applies discounts or surcharges on insurance based on safety ratings, rider age, and driver experience.
Generates a detailed invoice for each rental, including all costs and discounts.

# Classes and Structure
## Vehicle Class
An abstract base class that defines common properties and methods for all vehicle types. Each vehicle has a brand, model, price, rental period, and insurance-related properties.

## Car, Motorcycle, and CargoVan Classes
These classes inherit from the Vehicle class and implement the rental and insurance calculation methods specific to each type.

### Car: Insurance cost can be reduced based on the safety rating.
### Motorcycle: Insurance cost can be increased if the rider is under 25 years old.
### CargoVan: Insurance cost can be reduced based on the driver's experience.

## Rental Class
Represents a rental transaction. It includes the customer's name, reservation dates, actual return date, and the vehicle being rented. This class also prints the rental details, including all costs and any discounts applied.

## Invoice Class
Manages multiple rentals and prints a detailed invoice for each.

## Main Program
Creates instances of different vehicles and rentals, adds them to an invoice, and prints the invoice.

# Usage
Clone the Repository: Clone the repository to your local machine.
Open the Project: Open the project in your favorite C# IDE.
Run the Program: Run the program to see the detailed invoice for multiple rentals printed on the console.

# Conclusion
This vehicle rental system demonstrates a structured approach to managing vehicle rentals, calculating costs, and generating detailed invoices. The use of inheritance and polymorphism allows for flexible and maintainable code, accommodating different types of vehicles and their specific rental and insurance rules.
