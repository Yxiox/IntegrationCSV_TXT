using Catalogo.API.Entities.Base;

namespace Catalogo.API.Properties.Dto;

public record CatalogoDto
{
    public CATALOGO_BASE Catalogo { get; set; }
    public string PrecoExtenso { get; set; }
}
