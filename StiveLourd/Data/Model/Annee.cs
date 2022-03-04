using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Pages
{
    
    class Annee
    {
    public int AnneeId { get; set; }
    public int Number { get; set; }

        //String connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
        private static void ConnectionControl()
        {
            SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static List<Annee> GetAll()
        {
            SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            //ConnectionControl();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Annee> annees = new List<Annee>();

            while (reader.Read())
            {
                Annee annee = new Annee
                {
                    AnneeId = Convert.ToInt32(reader["AnneeId"]),
                    Number = Convert.ToInt32(reader["Number"]),
                };
                annees.Add(annee);
            }

            reader.Close();
            con.Close();
            return annees;
        }


    }


}
