using System.Net;
using ApoioNegocio.Core.Entities;
using ApoioNegocio.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;

namespace ApoioNegocio.Core.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoMidiaController : ControllerHelper
{
    private readonly ITIPO_MIDIA_REPOSITORY _tipo_midia_repository;

    public TipoMidiaController(ITIPO_MIDIA_REPOSITORY tipo_midia_repository)
    {
        _tipo_midia_repository = tipo_midia_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(
        TIPO_MIDIA tipoMidia,
        CancellationToken cancellationToken
    )
    {
        var result = await _tipo_midia_repository.InsertAsync(tipoMidia, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _tipo_midia_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _tipo_midia_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var tipoMidia = await _tipo_midia_repository.GetByIdAsync(id, cancellationToken);

        if (tipoMidia is null)
            return NotFound();

        var result = await _tipo_midia_repository.DeleteAsync(tipoMidia, cancellationToken);
        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(
        TIPO_MIDIA tipoMidia,
        CancellationToken cancellationToken
    )
    {
        var result = await _tipo_midia_repository.UpdateAsync(tipoMidia, cancellationToken);
        return Handle(result);
    }
}
