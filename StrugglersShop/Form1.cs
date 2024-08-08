namespace StrugglersShop
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int Index;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void GetStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel1.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0); 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            User Login1 = new User();
            Login1.Name = txtUser1.Text;
            Login1.Password = txtPassword1.Text;
            UserDB user = new UserDB();
            bool bOutput = user.CheckUser(Login1);
            if (bOutput)
            {
                MessageBox.Show("Thank you for login!");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You don't exits!");
                txtUser1.Focus();
            }

            
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Registering!");
            panel3.Visible = false;
            panel1.Visible = true;

            
        }

        private void txtUser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
