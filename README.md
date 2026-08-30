[![](https://img.shields.io/nuget/v/soenneker.dtos.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities.named/actions/workflows/codeql.yml)

# Soenneker.Dtos.Entities.Named

Adds a human-readable name to the shared entity DTO identity and timestamp fields.

## Installation

```bash
dotnet add package Soenneker.Dtos.Entities.Named
```

## Usage

```csharp
using Soenneker.Dtos.Entities.Named;

var status = new NamedEntityDto
{
    Id = "active",
    Name = "Active",
    CreatedAt = DateTimeOffset.UtcNow
};
```

The System.Text.Json wire shape uses `id`, `createdAt`, `modifiedAt`, and `name`. `ModifiedAt` defaults to null; `Id` and `Name` are not initialized by the parameterless constructor, and `CreatedAt` defaults to `default(DateTimeOffset)`.

All properties are virtual for specialized DTOs. `NamedEntityDto` is marked with `PublicOpenApiObject` for Soenneker OpenAPI discovery.

The model does not generate IDs or timestamps, validate names, enforce uniqueness, or normalize timestamps to UTC. Populate and validate it at the application boundary. Newtonsoft.Json naming follows the caller’s serializer configuration because these DTOs declare only System.Text.Json property-name attributes.
