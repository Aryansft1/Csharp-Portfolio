using System;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string pass = txtPass.Text;

        if (user == "admin" && pass == "1234")
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Login Failed!");
        }
    }
}
