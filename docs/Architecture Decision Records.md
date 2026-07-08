# Architecture Decision Records

# Documentation# ADR 001: Use SQL Server as the Database System
```YAML
## Status
Accepted

## Context
GymFlow needs a reliable database to store member information, attendance records, payments, membership plans, trainers, and product data.

## Decision
We decided to use Microsoft SQL Server as the database management system.

## Consequences

### Positive
- Reliable storage and data management.
- Supports structured relational data.
- Provides strong integration with VB.NET applications.

### Negative
- Requires SQL Server installation and configuration.
- May require additional resources compared to lightweight databases.
```