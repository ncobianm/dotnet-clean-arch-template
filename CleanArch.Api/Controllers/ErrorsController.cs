using Microsoft.AspNetCore.Mvc;


namespace CleanArch.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}