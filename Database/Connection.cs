using System.Data.SqlClient;
using System.Data;

namespace ProjectJ.Database
{
    internal class Connection
    {
        private static string strConexao = GetConnectionString();

        private static string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            switch (configuration["Environment"])
            {
                case "Dev":
                    return configuration.GetConnectionString("Dev");

                case "Homo":
                    return configuration.GetConnectionString("Homo");

                default:
                    return configuration.GetConnectionString("Prod");

            }
        }

        //private static SqlConnection scom = new SqlConnection(strConexao);

        private Connection() { }


        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection scom = new SqlConnection(strConexao);
                if (scom.State == ConnectionState.Closed)
                {
                    scom.Open();
                }
                return scom;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void CloseConnection(SqlConnection scom)
        {

            try
            {
                if (scom.State != ConnectionState.Closed)
                {
                    scom.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
