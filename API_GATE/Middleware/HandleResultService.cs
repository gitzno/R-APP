using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API_GATE.Middleware
{
    public class HandleResultService
    {
        public static IActionResult HandleResultServiceGlobal(ServiceResult result)
        {

            return Ok(200);
        }
    }
}
