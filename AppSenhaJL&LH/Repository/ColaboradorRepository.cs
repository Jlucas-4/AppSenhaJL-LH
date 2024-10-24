namespace AppSenhaJL_LH.Repository;

using AppSenhaJL_LH.Models;
using AppSenhaJL_LH.Repository.Contract;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

public class ColaboradorRepository  :IColaboradorRepository
    {
        private readonly string _conexaoMySQL;

        public ColaboradorRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

    public void Atualizar(Colaborador colaborador)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Colaborador colaborador)
    {
        using (var conexao = new MySqlConnection(_conexaoMySQL))
        {
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Colaborador (Nome, CPF, Telefone, Email, Senha, Tipo) " + "values (@Nome, @CPF, @Telefone, @Email, @Senha, @Tipo)", conexao);
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = colaborador.Nome;
            cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = colaborador.CPF; cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = colaborador.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = colaborador.Email;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = colaborador.Senha;
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
    }

    public void Excluir(int Id)
    {
        throw new NotImplementedException();
    }

    public Colaborador Login(string Email, string Senha)
    {
        using (var conexao = new MySqlConnection(_conexaoMySQL))
        {
            conexao.Open();

            MySqlCommand cmd = new MySqlCommand("select * from Colaborador where Email = @Email and Senha = @Senha", conexao);

            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd); 
            MySqlDataReader dr;

            Colaborador colaborador = new Colaborador();

            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                colaborador.Id = (Int32)(dr["Id"]);
                colaborador.Nome = (string)(dr["Nome"]);
                colaborador.Email = (string)(dr["Email"]);
                colaborador.Senha = (string)(dr["Senha"]);
                colaborador.Tipo = (string)(dr["Tipo"]);
            }
            return colaborador;
        }
    }

    public Colaborador ObterCliente(int Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Colaborador> ObterTodosClientes()
    {
        throw new NotImplementedException();
    }
}

