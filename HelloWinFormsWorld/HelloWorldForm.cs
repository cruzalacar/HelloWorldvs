using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsWorld
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void OnSayHello(object sender, EventArgs e)
        {
            //obtain the name of the user
            string userName = _txtUserName.Text;

            //say hello to the user
            MessageBox.Show(String.Format("Hello {0}", userName), "Hello WinForm World");
        }
    }
}
