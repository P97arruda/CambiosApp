using CambiosApp.Modelos;
using Microsoft.Data.Sqlite;

namespace CambiosApp.Sevicos
{
    public class DataService
    {
        private SqliteConnection connection;

        private SqliteCommand command;

        private DialogService dialogoService;


        public DataService()
        {
            dialogoService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Rates.sqlite";

            try
            {
                connection = new SqliteConnection("Data Source=" + path);
                connection.Open();

                string sqlcommand = "create table if not exists rates(RateId int, Code varchar(5), TaxRate real, Name varchar(250))";

                command = new SqliteCommand(sqlcommand, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogoService.ShowMessage("Erro", e.Message);

            }
        }

        public void saveDate(List<Rate> Rates)
        {
            try
            {
                foreach (var rate in Rates)
                {
                    string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "insert into rates (RateId, Code, TaxRate, Name) values({0}, '{1}', {2}, '{3}')",
                            rate.RateId, rate.Code, rate.TaxRate, rate.Name);

                    // MessageBox.Show(sql);

                    command = new SqliteCommand(sql, connection);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception e)
            {
                dialogoService.ShowMessage("Erro", e.Message);
            }
        }

        public List<Rate> GetData()
        {
            List<Rate> rates = new List<Rate>();

            try
            {
                string sql = "select RateId, Code, TaxRate, Name from Rates";

                command = new SqliteCommand(sql, connection);

                //Lê cada registro
                SqliteDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    rates.Add(new Rate
                    {
                        RateId = Convert.ToInt32(reader["RateId"]),
                        Code = Convert.ToString(reader["Code"]),
                        Name = Convert.ToString(reader["Name"]),
                        TaxRate = Convert.ToDouble(reader["TaxRate"])

                    });
                }

                connection.Close();
                return rates;
            }

            catch (Exception e)
            {
                dialogoService.ShowMessage("Erro", e.Message);
                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sql = "delete from Rates";

                command = new (sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogoService.ShowMessage("Erro", e.Message);
            }
        }
    }
}
