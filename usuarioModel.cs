using System;

namespace Model
{
   public class usuarioModel
   {
        public int Id{get; set; }
        public string Nome{get; set; }
        public string Email{get; set; }
        public string Senha{get; set; }

        public static List<usuarioModel> Usuarios {get; set; } =  new List<usuarioModel>();
        public usuarioModel(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;

            Usuarios.Add(this);
        }
        public override string ToString()
        {
            return $"Id: {Id} \r\nNome: {Nome} \r\nE-mail: {Email} \r\nSenha: {Senha} \r\n";
        }
        public static usuarioModel BuscarUsuario(int id)
        {
            usuarioModel? usuario = Usuarios.Find(x => x.Id == id);
            if (usuario == null) {
                throw new Exception("Usuário não encontrado");
            }

            return usuario;
        }
        public static void AlterarUsuario(int id, string nome, string email, string senha)
        {
            usuarioModel usuario = BuscarUsuario(id);
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;               
        }
        public static void ExcluirUsuario(int id)
        {
            usuarioModel usuario = BuscarUsuario(id);
            Usuarios.Remove(usuario);
        }
   }
}