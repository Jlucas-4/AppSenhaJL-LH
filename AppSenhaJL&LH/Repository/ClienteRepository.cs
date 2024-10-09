﻿using AppSenhaJL_LH.Models;
using AppSenhaJL_LH.Repository.Contract;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppSenhaJL_LH.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string _conexaoMySQL;

        public ClienteRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }


        public Cliente Login(string Email, string Senha)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("select * from cliente where Email = @Email and Senha = @Senha", conexao);
                
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email; cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); MySqlDataReader dr;
                
                Cliente cliente = new Cliente();
                
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    cliente.Id = Convert.ToInt32(dr["Id"]);
                    cliente.Nome = Convert.ToString(dr["Nome"]);
                    cliente.Nascimento = Convert.ToDateTime(dr["Nascimento"]);
                    cliente.Sexo = Convert.ToString(dr["Sexo"]);
                    cliente.CPF = Convert.ToString(dr["CPF"]);
                    cliente.Telefone = Convert.ToString(dr["Telefone"]);
                    cliente.Situacao = Convert.ToString(dr["Situacao"]);
                    cliente.Email = Convert.ToString(dr["Email"]);
                    cliente.Senha = Convert.ToString(dr["Senha"]);
                }
                return cliente;
            }

        }


        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Cliente Login(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            throw new NotImplementedException();
        }
    }
}
