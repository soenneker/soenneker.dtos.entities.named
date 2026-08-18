using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Entities.Named;

/// <summary>
/// Represents an entity with a stable identifier, lifecycle timestamps, and a human-readable display name.
/// </summary>
[PublicOpenApiObject]
public class NamedEntityDto : EntityDto
{
    /// <summary>
    /// Human-readable display name of the entity.
    /// </summary>
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
