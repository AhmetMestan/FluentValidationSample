using FluentValidationSample.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        AkademiİstanbulContext context;

        public StudentController()
        {
            context = new AkademiİstanbulContext();
        }



    }
}
