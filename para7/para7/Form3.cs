using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;

namespace para7
{
    public partial class Form3 : Form
    {
        private NpgsqlConnection con;
        private int id;
        public Form3(NpgsqlConnection connection, int id)
        {
            InitializeComponent();
            this.con = connection;
            this.id = id;
        }

        public Form3(NpgsqlConnection connection, int id, string nameP, string ed)
        {
            InitializeComponent();
            this.con = connection;
            this.id = id;

            textBoxName.Text = nameP;
            textBoxEd.Text = ed;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;

                if (id == -1)
                {
                    cmd.CommandText = "INSERT INTO \"Product\" (name, ed) VALUES (@name, @ed)";
                }
                else
                {
                    cmd.CommandText = "UPDATE \"Product\" SET name = @name, ed = @ed WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                }
                cmd.Parameters.AddWithValue("name", textBoxName.Text);
                cmd.Parameters.AddWithValue("ed", textBoxEd.Text);

                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
