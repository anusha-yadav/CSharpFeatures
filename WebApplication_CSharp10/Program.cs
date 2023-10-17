namespace WebApplication_CSharp10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapPost("/todos/{id}", (TodoService todoService, int id, string task = "foo") =>
            {
                var todo = todoService.Create(id, task);
                return Results.Created($"/todos/{todo.Id}",todo);
            });
            app.MapGet("/", () => "Hello World!");
            app.Run();
        }
    }
}