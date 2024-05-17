using Integration.API.Entities;
using Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;
using System.Net;

namespace Integration.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassificacaoController : ControllerHelper
{
    private readonly ICLASSIFICACAO_REPOSITORY _classificacao_repository;

    public ClassificacaoController(ICLASSIFICACAO_REPOSITORY classificacao_repository)
    {
        _classificacao_repository = classificacao_repository;
    }

    [Add]
    public async Task<IActionResult> InserirAsync(CLASSIFICACAO classificacao, CancellationToken cancellationToken)
    {
        var result = await _classificacao_repository.InsertAsync(classificacao, cancellationToken);
        return Handle(result);
    }

    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        return Ok(await _classificacao_repository.GetAllAsync(cancellationToken));
    }

    [GetById]
    public async Task<IActionResult> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _classificacao_repository.GetByIdAsync(id, cancellationToken);
        return Handle(() => result is not null, failure: HttpStatusCode.NotFound, data: result);
    }

    [Delete]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var classificacao = await _classificacao_repository.GetByIdAsync(id, cancellationToken);

        if (classificacao is null) return NotFound();

        var result = await _classificacao_repository.DeleteAsync(classificacao, cancellationToken);
        return Handle(result);
    }

    [Update]
    public async Task<IActionResult> UpdateAsync(CLASSIFICACAO classificacao, CancellationToken cancellationToken)
    {
        var result = await _classificacao_repository.UpdateAsync(classificacao, cancellationToken);
        return Handle(result);
    }
}
