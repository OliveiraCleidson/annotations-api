using Microsoft.AspNetCore.Mvc;

namespace AnnotationApp.Domain.Repositories;

[Route("v1/annotations")]
[Produces("application/json")]
[ApiController]
public class AnnotationController : ControllerBase
{
    [HttpGet]
    public Task<IActionResult> Get()
    {
        return Task.FromResult<IActionResult>(Ok());
    }

    [HttpGet("{id:guid}")]
    public Task<IActionResult> GetById()
    {
        return Task.FromResult<IActionResult>(Ok());
    }

    [HttpPost]
    public Task<IActionResult> Post()
    {
        return Task.FromResult<IActionResult>(Ok());
    }

    [HttpPut("{id:guid}")]
    public Task<IActionResult> Put()
    {
        return Task.FromResult<IActionResult>(Ok());
    }

    [HttpPatch("{id:guid}")]
    public Task<IActionResult> Patch()
    {
        return Task.FromResult<IActionResult>(Ok());
    }

    [HttpDelete("{id:guid}")]
    public Task<IActionResult> Delete()
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}