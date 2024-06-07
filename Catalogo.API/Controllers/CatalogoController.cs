using Catalogo.API.Entities;
using Catalogo.API.Services;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;

namespace Catalogo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly ICatalogoService _catalogoService;

    public CatalogoController(ICatalogoService catalogoService)
    {
        _catalogoService = catalogoService;
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Ok(await _catalogoService.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetByIdAsync(string id, CancellationToken cancellationToken = default)
    {
        return Ok(await _catalogoService.GetByIdAsync(id, cancellationToken));
    }

    [Add]
    public async Task<IActionResult> AddAsync(CATALOGO catalogo, CancellationToken cancellationToken = default)
    {
        await _catalogoService.UpsertAsync(catalogo, true, cancellationToken);
        return Ok();
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(CATALOGO catalogo, CancellationToken cancellationToken = default)
    {
        await _catalogoService.UpsertAsync(catalogo, false, cancellationToken);
        return Ok();
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _catalogoService.DeleteAsync(id, cancellationToken);
        return Ok();
    }
}
