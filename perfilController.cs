namespace Controller
{
    public class perfilController
    {
        public static void CadastrarPerfil(string id, string tipoPerfil)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.perfilModel perfil = new Model.perfilModel(idConvert, tipoPerfil);
        }
    
        public static void AlterarPerfil(string id, string tipoPerfil)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.perfilModel.AlterarPerfil(idConvert, tipoPerfil);
        }

        public static void ExcluirPerfil(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.perfilModel.ExcluirPerfil(idConvert);
        }

        public static Model.perfilModel BuscarPerfil(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.perfilModel.BuscarPerfil(idConvert);
        }

        public static List<Model.perfilModel> ListarPerfis()
        {
            return Model.perfilModel.Perfis;
        }
    }
}