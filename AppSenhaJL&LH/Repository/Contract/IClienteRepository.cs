using AppSenhaJL_LH.Models;

namespace AppSenhaJL_LH.Repository.Contract
{
    public interface IClienteRepository
    {
        // login Cliente 

        Cliente Login(string Email, string Senha);

        // CRUD
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int Id);
        Cliente ObterCliente (int Id);
        IEnumerable<Cliente> ObterTodosClientes();
        // IPagedList<cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}
