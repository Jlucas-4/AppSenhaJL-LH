using AppSenhaJL_LH.Models;

namespace AppSenhaJL_LH.Repository.Contract
{
    public interface IColaboradorRepository
    {
   
            // login Cliente 

            Colaborador Login(string Email, string Senha);

            // CRUD
            void Cadastrar(Colaborador colaborador);
            void Atualizar(Colaborador colaborador);
            void Excluir(int Id);
            Colaborador ObterCliente(int Id);
            IEnumerable<Colaborador> ObterTodosClientes();
            // IPagedList<cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}
