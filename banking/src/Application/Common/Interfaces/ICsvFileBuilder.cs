using banking.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace banking.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
