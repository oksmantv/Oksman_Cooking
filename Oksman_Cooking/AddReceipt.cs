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
    public partial class AddReceipt : Form
    {
        public AddReceipt()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddReceipt_Load(object sender, EventArgs e)
        {

                var Data = new GetData();
                CategoryBox.DisplayMember = "CategoryName";
                CategoryBox.ValueMember = "CategoryID";
                CategoryBox.DataSource = Data.GetAllCategoryList();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var control = new ControlInput();


            if (!control.ControlStringInput(TitleBox.Text.ToString(), 100))
                return;

            if (!control.ControlStringInput(DescriptionBox.Text.ToString(), 300))
                return;

            if (!control.ControlStringInput(IngredientsBox.Text.ToString(), 300))
                return;


            var Rec = new Receipt();
            Rec.RecTitle = TitleBox.Text.ToString();
            Rec.RecDescription = DescriptionBox.Text.ToString();
            Rec.RecIngredients = IngredientsBox.Text.ToString();
            Rec.CategoryID = int.Parse(CategoryBox.SelectedValue.ToString());

            var Test = new AddData();
            Test.AddReceipt(Rec);
                
            var Done = new CompleteMessage("Addition ");
            Done.Show();
            this.Close();

        }
    }
}
