namespace AppTodo.Core.Models;
public record TodoModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    //public Spread<SubtaskModel> Subtasks { get; set; }

    public TodoModel(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
        IsCompleted = false;
    }
}
