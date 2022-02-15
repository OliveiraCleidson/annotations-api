using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Controllers;

[Route("v1/hello")]
[ApiController]
public class HelloWorldController : Controller
{
  [HttpGet]
  public IActionResult Index()
  {
    using (var connection = new SqlConnection("Server=host.docker.internal,1440;;User=sa;Password=YourStrong-Passw0rd;Database=dapper"))
    {
      var orderDetails = connection.Query<Hello>("SELECT * FROM [HELLO]").ToList();

      return Ok(orderDetails);
    }
  }
}
