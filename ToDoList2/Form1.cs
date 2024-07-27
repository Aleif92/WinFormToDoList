using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Creat columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point the dtagridview to our dtasource
            toDoListView.DataSource = todoList;
        }

        //Giving the buttons functionality

        private void button1_Click(object sender, EventArgs e)
        {
            titletextbox.Text = "";
            descriptiontexbox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isEditing = true;
            //Fill test fields with data from table
            titletextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptiontexbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        }
    } 
