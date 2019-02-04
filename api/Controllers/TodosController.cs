using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace api
{
  [Route("api/[controller]")]
  public class TodosController : ControllerBase
  {
    private TodoContext dbContext;
    public TodosController(TodoContext context)
    {
      dbContext = context;
    }

    // GET: api/todos
    [HttpGet]
    public IActionResult Get()
    {
      List<Todo> AllTodos = dbContext.Todos.ToList();
      return Ok(new JsonResult(AllTodos));
    }

    // GET: api/todos/5
    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
      Todo result = dbContext.Todos.FirstOrDefault(todo => todo.todo_id == id);
      return Ok(new JsonResult(result));
    }

    // POST: api/todos
    [HttpPost]
    public IActionResult Post([FromBody]Todo newTodo)
    {
      if(!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      dbContext.Add(newTodo);
      dbContext.SaveChanges();
      return CreatedAtAction("Get", new JsonResult(newTodo));
    }

    // PUT: api/todos/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {

    }

    // DELETE: api/todos/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
  }
}