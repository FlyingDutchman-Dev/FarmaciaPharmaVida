using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pageControle.SetPage(pageDashboard);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pageControle.SetPage(pageProdutos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pageControle.SetPage(pageClientes);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pageControle.SetPage(pageConfig);
        }
    }
}
