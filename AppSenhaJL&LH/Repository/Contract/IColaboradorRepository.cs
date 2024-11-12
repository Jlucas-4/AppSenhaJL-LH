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
            Colaborador ObterColaborador(int Id);
            IEnumerable<Colaborador> ObterTodosColaboradores();
            // IPagedList<cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}
