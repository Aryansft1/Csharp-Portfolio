using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    List<string> products = new List<string>();
    List<double> prices = new List<double>();

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        products.Add(txtName.Text);
        prices.Add(Convert.ToDouble(txtPrice.Text));

        listBox1.Items.Add(txtName.Text + " - " + txtPrice.Text);
    }

    private void btnTotal_Click(object sender, EventArgs e)
    {
        double sum = 0;

        foreach (double p in prices)
            sum += p;

        MessageBox.Show("Total: " + sum);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        products.Clear();
        prices.Clear();
        listBox1.Items.Clear();
    }
}
