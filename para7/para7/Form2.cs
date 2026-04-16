using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace para7
{
    public partial class Form2 : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Form2(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        public void UpdateData()
        {
            string sql = "SELECT * FROM \"Product\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);

            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "Ед. измерения";

            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            this.UpdateData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3(con);
            af.ShowDialog();

            UpdateData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                try
                {
                    string sql = "DELETE FROM \"Product\" WHERE id = @id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery();
                    UpdateData();
                    MessageBox.Show("udalil");
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }
    }
}
