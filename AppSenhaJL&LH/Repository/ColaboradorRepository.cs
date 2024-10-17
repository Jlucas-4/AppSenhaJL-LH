namespace AppSenhaJL_LH.Repository
{
    public class ColaboradorRepository
    {
        private readonly string _conexaoMySQL;

        public ColaboradorRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
    }
}
