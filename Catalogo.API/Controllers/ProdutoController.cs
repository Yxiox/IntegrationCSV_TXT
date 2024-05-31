using Microsoft.AspNetCore.Mvc;
using QuickKit.AspNetCore.Attributes;

namespace Catalogo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    [GetAll]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken) { }

    [GetById]
    public async Task<IActionResult> GetByIdAsync(CancellationToken cancellationToken) { }

    [Add]
    public async Task<IActionResult> AddAsync(CancellationToken cancellationToken) { }

    [Update]
    public async Task<IActionResult> UpdateAsync(CancellationToken cancellationToken) { }

    [Delete]
    public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken) { }

    [HttpGet("detalhes")]
    public async Task<IActionResult> GetDetalhesAsync(CancellationToken cancellationToken) { }
}
