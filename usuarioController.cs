namespace Controller
{
    public class usuarioController
    {
        public static void CadastrarUsuario(string id, string nome, string email, string senha)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.usuarioModel usuario = new Model.usuarioModel(idConvert, nome, email, senha);
        }
    
        public static void AlterarUsuario(string id, string nome, string email, string senha)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.usuarioModel.AlterarUsuario(idConvert, nome, email, senha);
        }

        public static void ExcluirUsuario(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }   catch (Exception)
                {
                    throw new Exception ("Id inválido");
                }
            Model.usuarioModel.ExcluirUsuario(idConvert);
        }

        public static Model.usuarioModel BuscarUsuario(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.usuarioModel.BuscarUsuario(idConvert);
        }

        public static List<Model.usuarioModel> ListarCidades()
        {
            return Model.usuarioModel.Usuarios;
        }
    }
}