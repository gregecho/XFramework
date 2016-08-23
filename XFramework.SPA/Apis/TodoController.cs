using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using XFramework.Models;
using XFramework.Services.Interfaces;

namespace XFramework.SPA.Apis
{
    //[Authorize]
    public class TodoController : ApiController
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        /// <summary>
        /// GET: api/Todo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/todo")]
        [ResponseType(typeof(List<Todo>))]
        public IHttpActionResult Get()
        {
            var todoList = todoService.Query();
            return Ok(todoList);

        }

        /// <summary>
        /// GET: api/Todo/5
        /// </summary>
        /// <param name="id">ID of Todo</param>
        /// <returns>Object of Todo</returns>
        [HttpGet]
        [Route("api/todo/id")]
        [ResponseType(typeof(Todo))]
        public Todo Get([FromUri]int id)
        {
            var todo = todoService.Get(id);
            return todo;
        }

        /// <summary>
        /// POST: api/Todo
        /// </summary>
        /// <param name="todo"></param>
        [Route("api/todo")]
        public IHttpActionResult Post(Todo todo)
        {
            todoService.Add(todo);
            return Ok();
        }

        // PUT: api/Todo/5
        [Route("api/todo")]
        public IHttpActionResult Put(Todo todo)
        {
            todoService.Update(todo);
            return Ok();
        }

        /// <summary>
        ///  DELETE: api/Todo/5
        /// </summary>
        /// <param name="id"></param>
        public IHttpActionResult Delete(int id)
        {
            todoService.Delete(id);
            return Ok();
        }
    }
}
