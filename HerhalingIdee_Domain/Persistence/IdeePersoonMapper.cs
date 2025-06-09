using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HerhalingIdee_Domain.Business;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace HerhalingIdee_Domain.Persistence
{
    internal class IdeePersoonMapper
    {
        private string _connectionstring;
        public IdeePersoonMapper()
        {
            _connectionstring = "server=localhost; user=root; password=1234; database=herhaling_idee";
        }
        public void addIdeeToDb(IdeePersoon idee)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("insert into herhaling_idee.ideepersoon (naamPersoon, telPersoon, idee) values(@naam,@tel, @idee) ", conn);
            cmd.Parameters.AddWithValue("naam", idee.NaamPersoon);
            cmd.Parameters.AddWithValue("tel", idee.TelPersoon);
            cmd.Parameters.AddWithValue("idee", idee.Idee);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<IdeePersoon> GetIdeeFromDB()
        {
            List<IdeePersoon> returnList = new List<IdeePersoon>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionstring))
                {
                    conn.Open();
                    string command = "SELECT * FROM herhaling_idee.ideepersoon;";
                    using (MySqlCommand cmd = new MySqlCommand(command, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0;
                            string naam = reader["naamPersoon"] != DBNull.Value ? reader["naamPersoon"].ToString() : string.Empty;
                            string telefoonnummer = reader["telPersoon"] != DBNull.Value ? reader["telPersoon"].ToString() : string.Empty;
                            string idee = reader["idee"] != DBNull.Value ? reader["idee"].ToString() : string.Empty;

                            returnList.Add(new IdeePersoon(id, naam, telefoonnummer,idee));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fout", ex);
            }

            return returnList;
        }
        public void DeleteIdeeFromDB(IdeePersoon idee)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionstring))
                {
                    conn.Open();
                    string command = "DELETE FROM `herhaling_idee`.`ideepersoon` WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(command, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idee.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fout bij het verwijderen van het idee", ex);
            }
        }
    }
}
