using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world";
        }
        [HttpPost("create")]
        public async System.Threading.Tasks.Task<string> PostAsync()
        {
            string type = Request.Headers.FirstOrDefault(x => x.Key == "Content-Type").Value;
            string data = "";
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                data = await reader.ReadToEndAsync();
            }
            try
            {
                IValidator validator = ValidatorFactory.createValidator(type);
                return validator.Validate(data);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}