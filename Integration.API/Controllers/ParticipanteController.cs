using System.Net;
using Integration.API.Controllers;
using Integration.API.Entities;
using Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;

namespace stringegration.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ParticipanteController : ControllerHelper
{
    private readonly IPARTICIPANTES_REPOSITORY _participantes_repository;

    public ParticipanteController(IPARTICIPANTES_REPOSITORY participantes_repository)
    {
        _participantes_repository = participantes_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(
        PARTICIPANTES participante,
        CancellationToken cancellationToken
    )
    {
        var result = await _participantes_repository.InsertAsync(participante, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _participantes_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _participantes_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var participante = await _participantes_repository.GetByIdAsync(id, cancellationToken);

        if (participante is null)
            return NotFound();

        var result = await _participantes_repository.DeleteAsync(participante, cancellationToken);
        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(
        PARTICIPANTES participante,
        CancellationToken cancellationToken
    )
    {
        var result = await _participantes_repository.UpdateAsync(participante, cancellationToken);
        return Handle(result);
    }
}
