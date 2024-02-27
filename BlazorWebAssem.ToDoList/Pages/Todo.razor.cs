using BlazorWebAssem.ToDoList.Models;

namespace BlazorWebAssem.ToDoList.Pages
{
    public partial class Todo
    {
        public static List<TodoListModel> List { get; set; } = new List<TodoListModel>();
        public TodoListModel reqModel { get; set; } = new TodoListModel();

        private void Add()
        {
            if (reqModel == null)
            {
                return;
            }
            List.Add(reqModel);
            reqModel = new TodoListModel();
        }
    }
}
