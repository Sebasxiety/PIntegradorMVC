# PIntegradorMVC


This repository contains a minimal example of a service layer using Entity Framework Core.

## Structure

- `Models/` domain entities.
- `Data/` the `ApplicationDbContext` representing the EF Core context.
- `Services/` service interfaces and implementations.

Each service interface exposes asynchronous CRUD operations for its entity and
is implemented using `ApplicationDbContext`.

