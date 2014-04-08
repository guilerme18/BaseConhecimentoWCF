using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmClientWCF : Form
    {
        public frmClientWCF()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adicionando referencia ao objeto do WCF
            ServiceReference1.CalcServiceClient objServiceWCF = new ServiceReference1.CalcServiceClient();            
            //Invocando o metodo
            txtResultado.Text = Convert.ToString(objServiceWCF.Add(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text)));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient objServiceWCF = new ServiceReference1.CalcServiceClient();
            txtResultado.Text = Convert.ToString(objServiceWCF.Subtract(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text)));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient objServiceWCF = new ServiceReference1.CalcServiceClient();
            txtResultado.Text = Convert.ToString(objServiceWCF.Multiply(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text)));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient objServiceWCF = new ServiceReference1.CalcServiceClient();
            txtResultado.Text = Convert.ToString(objServiceWCF.Multiply(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text)));
        }
    }
}
