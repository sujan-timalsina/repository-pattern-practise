using TodoApp.Repository.Domain;
using TodoApp.Services.STodoItem;
using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;
        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var customer = _todoItemService.GetById(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var customers = _todoItemService.GetAll();
            return Ok(customers);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] TodoItem model)
        {
            _todoItemService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] TodoItem model)
        {
            _todoItemService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] TodoItem model)
        {
            _todoItemService.Delete(model);
            return Ok();
        }

    }
}