using Catalogo.API.Entities.Base;
using Integration.API.Entities.Base;

namespace Catalogo.API.Properties.Dto;

public record CatalogoDto
{
    public CATALOGO_BASE Catalogo { get; set; }
    public GENERO_BASE Genero { get; set; }
    public CLASSIFICACAO_BASE Classificacao { get; set; }
    public PARTICIPANTES_BASE Participantes { get; set; }
    public CATEGORIA_BASE Categoria { get; set; }
    public MIDIA_BASE Midia { get; set; }
    public TIPO_MIDIA_BASE TipoMidia { get; set; }
    public string PrecoExtenso { get; set; }
}
