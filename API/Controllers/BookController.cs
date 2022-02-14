﻿using System;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Services.Interfaces;
using API.Models.ViewModels;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        // GET: api/<BookController>
        [HttpGet]
        public async Task<ApiResponse<SubjectViewModel>> Get()
        {
            return new ApiResponse<SubjectViewModel>
            {
                Data = await _bookService.RetrieveWorksBySubject(""),
                Messages = Array.Empty<string>()
            };
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
