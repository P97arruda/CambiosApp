using CambiosApp.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambiosApp.Sevicos
{
    public class DataService
    {
        private SQLiteConnection connection;

        private SQLiteCommand command;

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
                connection = new SQLiteConnection("Data Source=" + path);
                connection.Open();

                string sqlcommand = "create table if not exists rates(RateId int, Code varchar(5), TaxRate real, Name varchar(250))";

                command = new SQLiteCommand(sqlcommand, connection);

                command.ExecuteNonQuery();
            }
            catch(Exception e) 
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

                    command = new SQLiteCommand(sql, connection);

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

                command = new SQLiteCommand(sql, connection);

                //Lê cada registro
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    rates.Add(new Rate
                    {
                        RateId = (int)reader["RateId"],
                        Code = (string)reader["Name"],
                        Name = (string)reader["Name"],
                        TaxRate = (double)reader["TaxRate"]

                    });
                }

                connection.Close();
                return rates;
            }

            catch(Exception e) 
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

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e) 
            {
                dialogoService.ShowMessage("Erro", e.Message);
            }
        }
    }
}
