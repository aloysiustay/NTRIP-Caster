using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CasterServer.Application;

namespace CasterServer.WebGUI
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasterController : ControllerBase
    {
        private readonly App m_Application;
        public CasterController(App _app) 
        {
            m_Application = _app;
        }

        [HttpGet("mountpoints")]
        public IActionResult GetClients()
        {
            
            return Ok(clients);
        }
    }
}
