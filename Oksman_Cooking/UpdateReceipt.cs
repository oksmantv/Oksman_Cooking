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
    public partial class UpdateReceipt : Form
    {
        private int _ID;
        public UpdateReceipt(int id)
        {
            _ID = id;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateReceipt_Load(object sender, EventArgs e)
        {
            var Data = new GetData();

            List<Receipt> Lista = Data.GetAllReceipts();
            Receipt Test = Lista.First(x => x.ReceiptID == _ID);

            NewTitle.Text = Test.RecTitle;
            NewDescription.Text = Test.RecDescription;
            NewIngredients.Text = Test.RecIngredients;

            NewCategories.DisplayMember = "CategoryName";
            NewCategories.ValueMember = "CategoryID";
            NewCategories.DataSource = Data.GetAllCategoryList();
            NewCategories.SelectedValue = Test.CategoryID;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var rec = new Receipt();
            var control = new ControlInput();

            if (!control.ControlStringInput(NewTitle.Text.ToString(), 100))
                return;

            if (!control.ControlStringInput(NewDescription.Text.ToString(), 300))
                return;

            if (!control.ControlStringInput(NewIngredients.Text.ToString(), 300))
                return;

            rec.ReceiptID = _ID;
            rec.RecTitle = NewTitle.Text.ToString();
            rec.RecDescription = NewDescription.Text.ToString();
            rec.RecIngredients = NewIngredients.Text.ToString();
            rec.CategoryID = int.Parse(NewCategories.SelectedValue.ToString());

            var Update = new AddData();
            Update.UpdateReceipt(rec);

            var Done = new CompleteMessage("Update ");
            Done.Show();
            this.Close();



        }
    }
}
