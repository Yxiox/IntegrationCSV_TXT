using Integration.API.Entities;
using Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;
using System.Net;

namespace Integration.API.Controllers;

[ApiController]
[Route("controller")]
public class MidiaController : ControllerHelper
{
    private readonly IMIDIA_REPOSITORY _midia_repository;

    public MidiaController(IMIDIA_REPOSITORY midia_repository)
    {
        _midia_repository = midia_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(MIDIA midia, CancellationToken cancellationToken)
    {
        var result = await _midia_repository.InsertAsync(midia, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _midia_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _midia_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var midia = await _midia_repository.GetByIdAsync(id, cancellationToken);

        if (midia is null) return NotFound();

        var result = await _midia_repository.DeleteAsync(midia, cancellationToken);
        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(MIDIA midia, CancellationToken cancellationToken)
    {
        var result = await _midia_repository.UpdateAsync(midia, cancellationToken);
        return Handle(result);
    }
}
