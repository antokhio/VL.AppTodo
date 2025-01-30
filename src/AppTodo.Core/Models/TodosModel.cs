using VL.Lib.Collections;

namespace AppTodo.Core.Models;

public record TodosModel
{
    public Spread<TodoModel> Todos { get; set; }

    public TodosModel()
    {
        Todos = Spread<TodoModel>.Empty;
    }
}
