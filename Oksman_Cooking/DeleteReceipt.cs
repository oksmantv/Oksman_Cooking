using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oksman_Cooking
{
    public partial class DeleteReceipt : Form
    {
        private int _ID;
        public DeleteReceipt(int id)
        {
            _ID = id;
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            var Data = new AddData();
            Data.DeleteReceipt(_ID);
            var Done = new CompleteMessage("Removal ");
            Done.Show();
            this.Close();

        }
    }
}
