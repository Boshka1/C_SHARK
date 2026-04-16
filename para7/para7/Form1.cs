using Npgsql;

namespace para7
{
    public partial class Form1 : Form
    {
        public NpgsqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgres;Password=postpass;Database=Aaaaa");
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void òîâàðûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fp = new Form2(con);
            fp.ShowDialog();
        }
    }
}
