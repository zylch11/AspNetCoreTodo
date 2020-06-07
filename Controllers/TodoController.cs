using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo.Controllers 
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index() 
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            // Get todo items from the database

            // Put the items into a model

            // Render view using the model
        }
    }
}