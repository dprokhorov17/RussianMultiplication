# Russian Peasant Multiplication

A WPF application demonstrating the Russian Peasant Multiplication method (also known as Egyptian Multiplication).

## Overview

This application implements an alternative algorithm for multiplying two numbers, which is historically significant and doesn't require multiplication tables. The algorithm only uses doubling, halving, and addition operations.

## Features

- User-friendly WPF interface
- Step-by-step visualization of the multiplication process
- Input validation
- Unit tests for quality assurance

## Technical Details

- Developed with C# and WPF
- Follows MVVM architecture pattern
- Uses NUnit for unit testing
- Target framework: .NET Framework

## Project Structure

```
RussianMultiplication/
├── Services/               # Core multiplication logic
├── Models/                # Data models
├── ViewModels/            # MVVM ViewModels
├── Commands/              # WPF commands
├── Validators/            # Input validation
└── Views/                 # WPF user interface

RussianMultiplication.UnitTests/
└── Tests.cs               # Unit tests
```

## Algorithm

The algorithm works as follows:
1. The first number is continuously divided by 2
2. The second number is continuously multiplied by 2
3. When the first number is odd, the second number is added to the result
4. The process continues until the first number reaches 0

## Installation

1. Clone the repository
2. Open the solution in Visual Studio or JetBrains Rider
3. Ensure all NuGet packages are restored
4. Build and run the application

## Tests

The project includes unit tests covering various scenarios:
- Multiplication of positive numbers
- Handling of zero values
- Validation of intermediate steps