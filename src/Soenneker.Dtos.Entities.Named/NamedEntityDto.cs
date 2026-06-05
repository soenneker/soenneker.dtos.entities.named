using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Entities.Named;

/// <summary>
/// A hard type mapping to NamedEntity
/// </summary>
[PublicOpenApiObject]
public class NamedEntityDto : EntityDto
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
