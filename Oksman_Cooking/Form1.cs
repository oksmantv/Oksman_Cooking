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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DescriptionBox.Text = "";
            IngredientsBox.Text = "";

            int id = int.Parse(CategoryBox.SelectedValue.ToString());

            var Text = SearchText.Text.ToString();
            var SearchTitle = new GetData();

            SearchBox.DisplayMember = "RecTitle";
            SearchBox.ValueMember = "ReceiptID";
            var List = SearchTitle.RecipeTitleCheck(Text,id);
            SearchBox.DataSource = List;

        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Data = new GetData();
            var Rec = new Receipt();
            Rec = Data.GetReceipt(int.Parse(SearchBox.SelectedValue.ToString()));
            DescriptionBox.Text = Rec.RecDescription;
            IngredientsBox.Text = Rec.RecIngredients;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var AddNew = new AddReceipt();
            AddNew.Show();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.SelectedValue == null)
                return;

            int id = int.Parse(SearchBox.SelectedValue.ToString());
            var Update = new UpdateReceipt(id);
            Update.Show();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.SelectedValue == null)
                return;

            int id = int.Parse(SearchBox.SelectedValue.ToString());
            var Remove = new DeleteReceipt(id);
            Remove.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var Data = new GetData();
            CategoryBox.DisplayMember = "CategoryName";
            CategoryBox.ValueMember = "CategoryID";
            CategoryBox.DataSource = Data.GetAllCategoryList();


        }
    }
}
