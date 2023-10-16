using System.Reflection.Metadata.Ecma335;

namespace WebApplication_CSharp10
{
    public class TodoService
    {
        private readonly List<Todo> _todo;
        private int nextId;

        public TodoService()
        {
            _todo = new List<Todo>();
            nextId = 1;
        }

        public Todo Create(int id, string task)
        {
            var newTodo = new Todo
            {
                Id = id,
                Task = task,
            };

            _todo.Add(newTodo);
            return newTodo;
        }
        
    }
}
