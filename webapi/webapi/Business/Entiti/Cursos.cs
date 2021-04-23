namespace web.api.Business.Entiti
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoUser  { get; set; }
        public string User { get; set; }
        public object Login { get; internal set; }
        public object Senha { get; internal set; }
        public object Email { get; internal set; }
    }
}
