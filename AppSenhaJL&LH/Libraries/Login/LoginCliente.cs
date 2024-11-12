using AppSenhaJL_LH.Models;
using Newtonsoft.Json;

namespace AppSenhaJL_LH.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Cliente cliente)
        {
            //Serializar
            string clienteJSONString = JsonConvert.SerializeObject(cliente);

            _sessao.Cadastrar(Key, clienteJSONString);
        }
        public Cliente GetCliente()
        {
            //Deserializar
            if (_sessao.Existe(Key))
            {
                string clienteJSONstring = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJSONstring);
            }
            else
            {
                return null;
            }
        }
        //Remove a sessão e desloga o Cliente
        public void Logout()
        {
            _sessao.RemoverTodos();
        }

    }
}
