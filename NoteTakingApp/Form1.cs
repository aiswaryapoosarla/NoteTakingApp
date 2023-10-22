using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form

    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            Previousnotes.DataSource = notes;
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            Titlebox.Text = notes.Rows[Previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebox.Text = notes.Rows[Previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[Previousnotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void Newnotebutton_Click(object sender, EventArgs e)
        {
            Titlebox.Text = "";
            Notebox.Text = "";
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[Previousnotes.CurrentCell.RowIndex]["Title"] = Titlebox.Text;
                notes.Rows[Previousnotes.CurrentCell.RowIndex]["Note"] = Notebox.Text;
            }
            else
            {
                notes.Rows.Add(Titlebox.Text,Notebox.Text);
            }
            Titlebox.Text = "";
            Notebox.Text = "";
            editing = false;

        }

        private void Previousnotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Titlebox.Text = notes.Rows[Previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            Notebox.Text = notes.Rows[Previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
