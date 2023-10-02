using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTaskController : ControllerBase
    {
        // GET: api/<ToDoTaskController>
        [HttpGet]

        public IEnumerable<ToDoTask> GetAll()
        {
            var tasks = ToDoTask.ReadAll();
            return tasks;
        }

        // GET api/<ToDoTaskController>/5
        [HttpGet("{id}")]
        public ToDoTask Get(int id)
        {
            return ToDoTask.Read(id);
        }

        // function to assign a person to a task
        [HttpGet("{id}/assign/{name}")]
        public ToDoTask Assign(int id, string name)
        {
            var task = ToDoTask.Read(id);
            task.AssignPerson(name);
            return task;
        }

        // function to finish a task
        [HttpGet("{id}/finish")]
        public ToDoTask Finish(int id)
        {
            var task = ToDoTask.Read(id);
            task.FinishTask();
            return task;
        }
        // POST api/<ToDoTaskController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<ToDoTaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoTaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
