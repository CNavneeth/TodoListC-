using System.Data;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            toDoListView.DataSource = todoList;

        }
        private void label1_Click(object sender, EventArgs e) { }
        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            }
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing=false;
        }
    }
}
