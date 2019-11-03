using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oksman_Cooking
{
    public partial class CompleteMessage : Form
    {
        private string _Text;
        public CompleteMessage(string task)
        {
            _Text = task;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompleteMessage_Load(object sender, EventArgs e)
        {
            TaskLabel.Text = _Text += "Completed";
        }
    }
}
