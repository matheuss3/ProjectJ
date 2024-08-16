using ProjectJ.Models;
using System.Data.SqlClient;
using ProjectJ.Database;
using System.Data;
using Newtonsoft.Json;

namespace ProjectJ.Dao
{
    public static class DaoProduct
    {
        public static List<Product> get()
        {
            string query = "SELECT 1";
            List<int> rows = new List<int>();
            SqlConnection conn = Connection.GetConnection();
            SqlCommand sCom = new SqlCommand(query, conn);
            DataTable dtTbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sCom);
            try
            {
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(dtTbl);
                rows = JsonConvert.DeserializeObject<List<int>>(JsonConvert.SerializeObject(dtTbl));
            }
            catch (Exception ex)
            {
                //GravaLog.gravar(ex, pastaLog, "DaoContato", "GetContatos");
                throw;
            }
            finally
            {
                sCom.Dispose();
                dtTbl.Dispose();
                da.Dispose();
                conn.Close();
            }
            return new List<Product>();
        }

        public static Product post(Product product)
        {
            return product;
        }

        public static void update(Product product)
        {
        }

        public static bool delete(Product product)
        {
            return true;
        }
    }
}
