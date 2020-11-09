using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace integration_backend.Controllers
{
    public class TodoItemsController : ControllerBase
    {

        [HttpGet("getalltodos")]
        public IActionResult GetAllTodoItems()
        {
            var todoItems = new List<string> { "Write a Blog post", "Do work out for an hour", "Get the stuff out of refridgerator" };
            return new OkObjectResult(todoItems);
        }
    }
}
