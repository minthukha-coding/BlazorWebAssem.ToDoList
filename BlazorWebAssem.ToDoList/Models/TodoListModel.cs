namespace BlazorWebAssem.ToDoList.Models
{
    public class TodoListModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsCompleted { get; set; }
        public string TaskName { get; set; }
    }
}
