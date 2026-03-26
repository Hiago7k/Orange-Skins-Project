using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orange_Skins_Project.Modelos;

internal class Skins
{
    [JsonPropertyName("name")]
    public string? NomeDaSkin { get;}
    [JsonPropertyName("description")]
    public string? DescricaoDaSkin { get;}

    [JsonPropertyName("id")]
    public string? Id { get;}
    [JsonPropertyName("category")]
    public string? Categoria { get;}
}
