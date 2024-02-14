﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;
using BaseLibrary.DTOs;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController(IUserAccount accountInterface) : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<IActionResult> CreateAsync(Register user)
        {
            if (user == null) return BadRequest("Model is Empty");
            var result = await accountInterface.CreateAsync(user);
            return Ok(result);
        }
    }
}
