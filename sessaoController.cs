namespace Controller
{
    public class sessaoController
    {
        public static void CadastrarSessao(string id, string token, string dataC, string dataE)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.sessaoModel perfil = new Model.sessaoModel(idConvert, token, dataC, dataE);
        }
    
        public static void AlterarSessao(string id, string token, string dataC, string dataE)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.sessaoModel.AlterarSessao(idConvert, token, dataC, dataE);
        }

        public static void ExcluirSessao(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.sessaoModel.ExcluirSessao(idConvert);
        }

        public static Model.sessaoModel BuscarSessao(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.sessaoModel.BuscarSessao(idConvert);
        }

        public static List<Model.sessaoModel> ListarPerfis()
        {
            return Model.sessaoModel.Sessoes;
        }
    }
}