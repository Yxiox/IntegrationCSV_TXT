using Integration.API.Integration.API.Entities;
using Integration.API.Integration.API.Repositories;
using Integration.API.Integration.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Integration.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly CATEGORIA_REPOSITORY _categoria_repository;

    public CategoriaController(IDbConnection conn)
    {
        _categoria_repository = new(conn);
    }

    [HttpPost]
    public async Task<IActionResult> InserirAsync(CATEGORIA categoria)
    {
        var result = await _categoria_repository.InsertAsync(categoria);

        if (result > 0) return Ok();

        return BadRequest(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _categoria_repository.GetAllAsync());
    }
}
