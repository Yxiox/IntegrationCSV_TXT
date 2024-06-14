using Catalogo.API.Entities;
using Catalogo.API.Entities.Base;

namespace Catalogo.API.Dto;

public record CatalogoDto
{
    public CATALOGO Catalogo { get; set; }
    public GENERO Genero { get; set; }
    public CLASSIFICACAO Classificacao { get; set; }
    public PARTICIPANTES Participantes { get; set; }
    public CATEGORIA Categoria { get; set; }
    public MIDIA Midia { get; set; }
    public TIPO_MIDIA TipoMidia { get; set; }
}
