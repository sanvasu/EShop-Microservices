# EShopMicroservice

.NET 8 Microservices Web API – Clean Architecture with DDD, CQRS, and SOLID Principles
This project is a modern .NET 8 Web API implementation that follows Vertical Slice Architecture using Feature folders, and is built around Domain-Driven Design (DDD) and Clean Architecture best practices. It uses CQRS with MediatR, Entity Framework Core, and PostgreSQL, all containerized via Docker for consistent and scalable development and deployment.

<h1>**Key Technologies and Patterns Used**</h1>
.NET 8 Web API

Vertical Slice Architecture using Feature folders

CQRS Pattern using MediatR

DDD (Domain-Driven Design)

Clean Architecture to enforce separation of concerns

Entity Framework Core for ORM

Marten DB for transactional NoSQL (PostgreSQL-backed) document storage

PostgreSQL database with containerized environment

Docker & Docker Compose for multi-container orchestration

Auto EF Core migration to SQL Server on application startup (when configured)

<h1>**Architecture Overview**</h1>
API Layer – Handles HTTP requests and responses.

Application Layer – Contains CQRS commands/queries and business logic via MediatR.

Domain Layer – Contains core domain entities, value objects, and interfaces (pure business rules).

Infrastructure Layer – Implements data access logic, external services, and repositories.

Persistence Layer – Handles configuration of EF Core and Marten for database interactions.

<h1>**SOLID Principles in Action**</h1>
This solution applies the SOLID principles throughout the project:

S – Single Responsibility Principle (SRP)
Each class has one reason to change. For example, commands handle only user actions, and repositories only manage data access.

O – Open/Closed Principle (OCP)
The system is open to extension but closed for modification. New features are added via new feature folders without altering existing logic.

L – Liskov Substitution Principle (LSP)
Interfaces are designed so that any implementation (e.g., ICustomerRepository) can be replaced without affecting client code.

I – Interface Segregation Principle (ISP)
Interfaces are small and focused (e.g., separating read and write repositories), avoiding "fat" interfaces.

D – Dependency Inversion Principle (DIP)
High-level modules (business logic) depend on abstractions, not on infrastructure details. Dependency Injection is used throughout the application.

<h1>**Features Implemented**</h1>
Feature-based Vertical Slice structure for modular development

CQRS with Command and Query Handlers via MediatR

Auto EF Core migrations at startup (SQL Server compatible)

Transactional Document DB setup using Marten on PostgreSQL

Fully containerized with Dockerfile and docker-compose.yml

Clean separation of business logic, infrastructure, and API concerns
