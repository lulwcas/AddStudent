namespace AddStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Certeza?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtTri.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtEnrollment.Text != "" && txtDepartment.Text != "" && txtTri.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
            String name = txtName.Text;
            String enrollment = txtEnrollment.Text;
            String department = txtDepartment.Text;
            String tri = txtTri.Text;
            Int64 mobile = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-E4UJ6RE\\SQLEXPRESS; database = library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connetion = con;

            cmd.Open();
            cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enrollment + "','" + department + "','" + tri + "','" + mobile + "','" + email + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Infos salvas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos", "Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}