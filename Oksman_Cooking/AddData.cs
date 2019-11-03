using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oksman_Cooking
{
    class AddData
    {
        public void AddReceipt(Receipt rec)
        {

            var Title = rec.RecTitle;
            var Description = rec.RecDescription;
            var Ingredients = rec.RecIngredients;
            int id = rec.CategoryID;

            string query;
            string DBConnection = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
            query = $"INSERT INTO Receipts (RecTitle,RecDescription,RecIngredients,CategoryID) VALUES ('{Title}','{Description}','{Ingredients}','{id}')";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DBConnection;
                conn.Open();
                SqlCommand Command = new SqlCommand(query, conn);
                Command.ExecuteNonQuery();

            }

        }

        public void UpdateReceipt(Receipt rec)
        {
            string query;
            string DBConnection = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
            query = $"UPDATE Receipts SET RecTitle='{rec.RecTitle}', RecDescription='{rec.RecDescription}', RecIngredients='{rec.RecIngredients}', CategoryID = {rec.CategoryID} where ReceiptID = {rec.ReceiptID}";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DBConnection;
                conn.Open();
                SqlCommand Command = new SqlCommand(query, conn);
                Command.ExecuteNonQuery();

            }


        }

        public void DeleteReceipt(int _ID)
        {

            string query;
            string DBConnection = "Data Source=.; Initial Catalog=Matlagning; Integrated Security=SSPI;";
            query = $"DELETE FROM Receipts WHERE ReceiptID = {_ID}";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DBConnection;
                conn.Open();
                SqlCommand Command = new SqlCommand(query, conn);
                Command.ExecuteNonQuery();

            }


        }
    }
}
