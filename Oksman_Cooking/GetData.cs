using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oksman_Cooking
{
    class GetData
    {
        //public GetData()
        //{
        //    string DBConnection = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
        //}
        public List<Receipt> RecipeTitleCheck(string titel, int id)
        {
            var List = new List<Receipt>();
            string query;
            if (titel.Length < 1 && id == 1)
            {
                query = "Select * from Receipts";
            }
            else if (titel.Length < 1 && id != 1)
            {
                query = $"Select * from Receipts as R INNER JOIN Categories as C on R.CategoryID = C.CategoryID where R.CategoryID = {id}";
            }
            else if (titel.Length > 0 && id == 1)
            {
                query = $"Select * from Receipts WHERE (lower(RecTitle) like '{titel}%' or lower(RecTitle) like '%{titel}' or lower(RecTitle) like '%{titel}%')";
            }
            else
            {
                query = $"Select * from Receipts WHERE (lower(RecTitle) like '{titel}%' or lower(RecTitle) like '%{titel}' or lower(RecTitle) like '%{titel}%') AND CategoryID = {id}";
            };

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Receipt = new Receipt();
                    Receipt.ReceiptID = int.Parse(reader["ReceiptID"].ToString());
                    Receipt.RecTitle = reader["RecTitle"].ToString();
                    Receipt.RecDescription = reader["RecDescription"].ToString();
                    Receipt.RecIngredients = reader["RecIngredients"].ToString();
                    Receipt.CategoryID = int.Parse(reader["CategoryID"].ToString());

                    List.Add(Receipt);

                }

            }

            return List;
        }

        public List<Receipt> GetAllReceipts()
        {
            var Lista = new List<Receipt>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
                conn.Open();

                SqlCommand command = new SqlCommand("Select * from Receipts", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Receipt = new Receipt();
                    Receipt.ReceiptID = int.Parse(reader["ReceiptID"].ToString());
                    Receipt.RecTitle = reader["RecTitle"].ToString();
                    Receipt.RecDescription = reader["RecDescription"].ToString();
                    Receipt.RecIngredients = reader["RecIngredients"].ToString();
                    Receipt.CategoryID = int.Parse(reader["CategoryID"].ToString());

                    Lista.Add(Receipt);

                }
                return Lista;
            }
        }

        public List<Category> GetAllCategoryList()
        {
            var Lista = new List<Category>();
            string query = $"Select CategoryID,CategoryName from Categories";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Cat = new Category();
                    Cat.CategoryName = reader["CategoryName"].ToString();
                    Cat.CategoryID = int.Parse(reader["CategoryID"].ToString());

                    Lista.Add(Cat);

                }
            }

            return Lista;
        }

        public Receipt GetReceipt(int id)
        {
            var rec = new Receipt();
            string query = $"Select * from Receipts R where R.ReceiptID = {id}";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                var Receipt = new Receipt();

                while (reader.Read())
                {                 
                    Receipt.ReceiptID = int.Parse(reader["ReceiptID"].ToString());
                    Receipt.RecTitle = reader["RecTitle"].ToString();
                    Receipt.RecDescription = reader["RecDescription"].ToString();
                    Receipt.RecIngredients = reader["RecIngredients"].ToString();
                    Receipt.CategoryID = int.Parse(reader["CategoryID"].ToString());

                }
                return Receipt;

            }

        }

    }

}
