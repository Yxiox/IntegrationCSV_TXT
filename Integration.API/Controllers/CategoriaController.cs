using System.Net;
using Integration.API.Entities;
using Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;

namespace Integration.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerHelper
{
    private readonly ICATEGORIA_REPOSITORY _categoria_repository;

    public CategoriaController(ICATEGORIA_REPOSITORY categoria_repository)
    {
        _categoria_repository = categoria_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(
        CATEGORIA categoria,
        CancellationToken cancellationToken
    )
    {
        var result = await _categoria_repository.InsertAsync(categoria, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _categoria_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _categoria_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var categoria = await _categoria_repository.GetByIdAsync(id, cancellationToken);

        if (categoria is null)
            return NotFound();

        var result = await _categoria_repository.DeleteAsync(categoria, cancellationToken);

        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(
        CATEGORIA categoria,
        CancellationToken cancellationToken
    )
    {
        var result = await _categoria_repository.UpdateAsync(categoria, cancellationToken);
        return Handle(result);
    }
}
