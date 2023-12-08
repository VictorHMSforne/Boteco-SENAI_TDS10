using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppBoteco.Classes
{
    class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\AppBoteco\\AppBoteco\\DbBoteco.mdf;Integrated Security=True");

        public List<Cliente> listacliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.cpf = dr["cpf"].ToString();
                c.celular = dr["celular"].ToString();
                li.Add(c);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string cpf, string celular)
        {
            string sql = "INSERT INTO Cliente(nome,cpf,celular) VALUES ('"+nome+"','"+cpf+"','"+celular+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string cpf, string celular)
        {
            string sql = "UPDATE Cliente SET nome='"+nome+"',cpf='"+cpf+"',celular='"+celular+"' WHERE Id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Cliente WHERE Id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Cliente WHERE Id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                celular = dr["celular"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(string cpf)
        {
            string sql = "SELECT * FROM Cliente WHERE cpf='"+cpf+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
