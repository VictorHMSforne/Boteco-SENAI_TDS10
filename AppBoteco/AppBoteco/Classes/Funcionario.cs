using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppBoteco.Classes
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string cargo { get; set; }
        public string complemento { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\AppBoteco\\AppBoteco\\DbBoteco.mdf;Integrated Security=True");

        public List<Funcionario> listafuncionario()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = (int)dr["Id"];
                f.nome = dr["nome"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.bairro = dr["bairro"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.celular = dr["celular"].ToString();
                f.cep = dr["cep"].ToString();
                f.cargo = dr["cargo"].ToString();
                f.complemento = dr["complemento"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string cpf, string endereco, string bairro, string cidade, string celular, string cep, string cargo, string complemento)
        {
            string sql = "INSERT INTO Funcionario(nome,cpf,endereco,bairro,cidade,celular,cep,cargo,complemento) VALUES ('" + nome + "','" + cpf + "','"+endereco+"','"+bairro+"','"+cidade+"','"+celular+"','"+cep+"','"+cargo+"','"+complemento+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string cpf, string endereco, string bairro, string cidade, string celular, string cep, string cargo, string complemento)
        {
            string sql = "UPDATE Funcionario SET nome='" + nome + "',cpf='" + cpf + "',endereco='"+endereco+"',bairro='"+bairro+"',cidade='"+cidade+"',celular='"+celular+"',cep='"+cep+"',cargo='"+cargo+"',complemento='"+complemento+"' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                endereco = dr["endereco"].ToString();
                bairro = dr["bairro"].ToString();
                cidade = dr["cidade"].ToString();
                celular = dr["celular"].ToString();
                cep = dr["cep"].ToString();
                cargo = dr["cargo"].ToString();
                complemento = dr["complemento"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(string nome, string cpf)
        {
            string sql = "SELECT * FROM Funcionario WHERE nome='" + nome + "' AND cpf='"+cpf+"'";
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
