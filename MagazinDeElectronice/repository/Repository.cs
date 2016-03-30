using System;
using System.Collections.Generic;
using MagazinCommon.model;
using System.Data.SqlClient;

namespace MagazinDeElectronice.repository
{
    public class Repository 
    {
        private string connectionString;
        public Repository()
        {
            connectionString =MagazinDeElectronice.Properties.Settings.Default.magazin_electroniceConnectionString;
        }
        public List<String> getCategorii()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string commandText = "SELECT nume from categorii";
            SqlCommand command = new SqlCommand(commandText, con);
            SqlDataReader reader = command.ExecuteReader();
            List<string> categorii = new List<string>();
            while (reader.Read())
                categorii.Add(reader[0].ToString());
            con.Close();
            return categorii;
        }
        public List<Produs> getProdusFilteredByCategorie(string categorie)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string commandText = "SELECT id,nume,cantitate,pret from produse where categorie=@categorie order by nume";
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@categorie", categorie);
            SqlDataReader reader = command.ExecuteReader();
            List<Produs> produse = new List<Produs>();
            while (reader.Read())
                produse.Add(new Produs(reader.GetInt32(0),reader[1].ToString(),categorie,reader.GetInt32(2), reader.GetInt32(3)));
            con.Close();

            return produse;
        }

        public Produs getProdusById(int id_produs)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string commandText = "SELECT nume,categorie,cantitate, pret FROM produse where id= @id";
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@id", id_produs);
            SqlDataReader reader = command.ExecuteReader();
            
            reader.Read();
            
            var produs = new Produs(id_produs, reader[0].ToString(), reader[1].ToString(), reader.GetInt32(2), reader.GetInt32(3));
            con.Close();
            return produs;
                
        }

        public void update(Produs produs)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string commandText = "UPDATE produse SET nume = @nume, categorie= @categorie, cantitate=@cantitate where id= @id";
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@id", produs.Id);
            command.Parameters.AddWithValue("@nume", produs.Name);
            command.Parameters.AddWithValue("@categorie", produs.Type);
            command.Parameters.AddWithValue("@cantitate", produs.Quantity);
            var res=command.ExecuteNonQuery();
            con.Close();
        }
    }
}
