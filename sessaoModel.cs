using System;

namespace Model
{
   public class sessaoModel
   {
        public int Id{get; set; }
        public string Token{get; set; }
        public DateTime DataC{get; set; }
        public DateTime DataE{get; set; }

        public static List<sessaoModel> Sessoes {get; set; } =  new List<sessaoModel>();
        public sessaoModel(int id, string token, DateTime dataC, DateTime dataE)
        {
            Id = id;
            Token = token;
            DataC = dataC;
            DataE = dataE;

            Sessoes.Add(this);
        }
        public override string ToString()
        {
            return $"Id: {Id} \r\nNome: {Token} \r\nE-mail: {DataC} \r\nSenha: {DataE} \r\n";
        }
        public static sessaoModel BuscarSessao(int id)
        {
            sessaoModel? sessao = Sessoes.Find(x => x.Id == id);
            if (sessao == null) {
                throw new Exception("Usuário não encontrado");
            }

            return sessao;
        }
        public static void AlterarSessao(int id, string token, DateTime dataC, DateTime dataE)
        {
            sessaoModel sessao = BuscarSessao(id);
            sessao.Token = token;
            sessao.DataC = dataC;
            sessao.DataE = dataE;             
        }
        public static void ExcluirUsuario(int id)
        {
            sessaoModel sessao = BuscarSessao(id);
            Sessoes.Remove(sessao);
        }
   }
}