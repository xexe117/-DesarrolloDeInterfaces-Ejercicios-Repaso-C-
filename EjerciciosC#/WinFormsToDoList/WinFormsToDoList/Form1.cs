using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsToDoList
{
    public partial class Form1 : Form
    {
        BindingList<TodoItemModel> todoList = new BindingList<TodoItemModel>();
        TodoItemModel currentEdit = null;

        public Form1()
        {
            InitializeComponent();

            todoListBox.DataSource = todoList;
            todoListBox.DisplayMember = nameof(TodoItemModel.ToDisplay); 
        }

        private void AddItem(string todoText)
        {
            TodoItemModel todo = new TodoItemModel
            {
                PositionNumber = todoList.Count + 1,
                Todotxt = todoText
            };
            todoList.Add(todo);
        }

        private void ReorderTodos()
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                todoList[i].PositionNumber = (i + 1);
            }
        }

        private void Delete(TodoItemModel todo)
        {
            todoList.Remove(todo);
            ReorderTodos();
        }

        private void StartEditingItem(TodoItemModel todo)
        {
            currentEdit = todo;
            newItemLabel.Text = "Update todo item";
            ListaLabel.Text = "Edit ToDo Item";
            todoListBox.Text = currentEdit.Todotxt; 
        }

        private void CompleteEditingItem()
        {
            currentEdit.Todotxt = todoListBox.Text;
            currentEdit = null;
            newItemLabel.Text = "New todo item";
            ListaLabel.Text = "Add ToDo Item";

        }

        private void CompleteItem(TodoItemModel todo)
        {
            todo.IsComplet = true;
        }

        private void AddItemButt_Click(object sender, EventArgs e)
        {
            if (currentEdit == null)
            {
                AddItem(newItemBox.Text);
            }
            else
            {
                CompleteEditingItem();
            }

            newItemBox.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                StartEditingItem(todo);
;            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                Delete(todo);
            }
        }

        private void todoListBox_DoubleClick(object sender, EventArgs e)
        {
            if(todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                CompleteItem(todo);
            }
        }
    }
}
