using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using FastClean.Models;

namespace FastClean.Repository
{
    public class KlijentRepository
    {
        public static List<Klijent> GetKlijents()
        {
            var klijenti = new List<Klijent>();

            string sql = "SELECT * FROM Klijent";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Klijent korisnik = CreateObjects(reader);
                klijenti.Add(korisnik);
            }

            reader.Close();
            DB.CloseConnection();

            return klijenti;
        }

        public static List<Klijent> GetKlijent (string ime)
        {
            var klijenti = new List<Klijent>();
            string sql = $"SELECT * FROM Klijent WHERE Ime = '{ime}'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Klijent klijent = CreateObjects(reader);
                klijenti.Add(klijent);
            }

            reader.Close();
            DB.CloseConnection();

            return klijenti;
        }

        public void InsertKlijenta(string Ime, string Prezime, string Kontakt, string Email)
        {
            string sql = $"INSERT INTO Klijent (Ime, Prezime, Kontakt, Email) " +
                         $"VALUES ('{Ime}', '{Prezime}', '{Kontakt}', '{Email}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void DeleteKlijent (int Id)
        {
            string sql = $"DELETE FROM Klijent WHERE ID_Klijenta = {Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void UpdateKlijent(int Id, string Ime, string Prezime, string Kontakt, string Email)
        {
            string sql = $"UPDATE Klijent SET " +
                         $"Ime = '{Ime}', " +
                         $"Prezime = '{Prezime}', " +
                         $"Kontakt = '{Kontakt}', " +
                         $"Email = '{Email}' " +
                         $"WHERE ID_Klijenta = {Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Klijent CreateObjects(SqlDataReader reader)
        {
            int Id = int.Parse(reader["ID_Klijenta"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Kontakt = reader["Kontakt"].ToString();
            string Email = reader["Email"].ToString();

            var korisnik = new Klijent
            {
                IdKlijent = Id,
                Ime = Ime,
                Prezime = Prezime,
                Kontakt = Kontakt,
                Email = Email
            };
            return korisnik;
        }
    }
}
