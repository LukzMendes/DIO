namespace web.api.Business.Entiti
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public object Descricao { get; set; }
        public object CodigoUser { get; internal set; }

        private object user;

        public object GetUser()
        {
            return user;
        }

        internal void SetUser(object value)
        {
            user = value;
        }
    }
}
