using IntroToMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace IntroToMVVM.ViewModels
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public string NewToDoText { get; set; }
        public Command AddToDoCommand => new Command(AddItem);
        public ToDoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>
            {
                new ToDoItem("ToDo 1", false),
                new ToDoItem("ToDo 2", false),
                new ToDoItem("ToDo 3", false),
            };
        }
        private void AddItem()
        {
            ToDoItems.Add(new ToDoItem(NewToDoText, false));
        }
    }
}
