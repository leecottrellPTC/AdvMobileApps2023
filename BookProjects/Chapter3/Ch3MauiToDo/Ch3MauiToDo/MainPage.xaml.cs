using Ch3MauiToDo.Data;
using Ch3MauiToDo.Models;
using System.Collections.ObjectModel;
namespace Ch3MauiToDo;

public partial class MainPage : ContentPage
{

    public ObservableCollection<TodoItem> Todos { get; set; } = new();
   // string _todoListData = string.Empty;

    readonly Database _database; 
	
	public MainPage()
	{
		InitializeComponent();
       // TodosCollection.ItemsSource = Todos;  //3.4 done in code
        _database = new Database();

        _ = Initialise();
    }

    private async Task Initialise()
    {
        var todos = await _database.GetTodos();

        foreach (var todo in todos)
        {
            //_todoListData += $"{todo.Title} - {todo.Due:f}{Environment.NewLine}";
            Todos.Add(todo);
        }

       // TodosLabel.Text = _todoListData;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var todo = new TodoItem
        {
            Due = DueDatepicker.Date,
            Title = TodoTitleEntry.Text
        };

        var inserted = await _database.AddTodo(todo);

        if (inserted != 0)
        {
            //_todoListData += $"{todo.Title} - {todo.Due:f}{Environment.NewLine}";

            //TodosLabel.Text = _todoListData;
            Todos.Add(todo);

            TodoTitleEntry.Text = String.Empty;
            DueDatepicker.Date = DateTime.Now;
        }
    }

}

