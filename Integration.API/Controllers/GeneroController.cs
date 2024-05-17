using Integration.API.Entities;
using Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;
using System.Net;

namespace Integration.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GeneroController : ControllerHelper
{
    private readonly IGENERO_REPOSITORY _genero_repository;

    public GeneroController(IGENERO_REPOSITORY genero_repository)
    {
        _genero_repository = genero_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(GENERO genero, CancellationToken cancellationToken)
    {
        var result = await _genero_repository.InsertAsync(genero, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _genero_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _genero_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var genero = await _genero_repository.GetByIdAsync(id, cancellationToken);

        if (genero is null) return NotFound();

        var result = await _genero_repository.DeleteAsync(genero, cancellationToken);
        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(GENERO genero, CancellationToken cancellationToken)
    {
        var result = await _genero_repository.UpdateAsync(genero, cancellationToken);
        return Handle(result);
    }
}
