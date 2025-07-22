namespace ToDo.Models;

// /todos/overview
public class Todo
{
    public int Id { get; set; }
    public string Task { get; set; }
    public bool IsComplete { get; set; }
}