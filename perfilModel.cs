using System;

namespace Model
{
   public class perfilModel
   {
        public int Id{get; set; }
        public string TipoPerfil{get; set; }
        

        public static List<perfilModel> Perfis {get; set; } =  new List<perfilModel>();
        public perfilModel(int id, string tipoPerfil)
        {
            Id = id;
            TipoPerfil = tipoPerfil;

            Perfis.Add(this);
        }
        public override string ToString()
        {
            return $"Id: {Id} \r\nPerfil: {TipoPerfil}\r\n";
        }
        public static perfilModel BuscarPerfil(int id)
        {
            perfilModel? perfil = Perfis.Find(x => x.Id == id);
            if (perfil == null) {
                throw new Exception("Perfil não encontrado");
            }

            return perfil;
        }
        public static void AlterarPerfil(int id, string tipoPerfil)
        {
            perfilModel perfil = BuscarPerfil(id);
            perfil.TipoPerfil = tipoPerfil;            
        }
        public static void ExcluirPerfil(int id)
        {
            perfilModel perfil = BuscarPerfil(id);
            Perfis.Remove(perfil);
        }
   }
}