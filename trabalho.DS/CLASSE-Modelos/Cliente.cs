namespace Modelos
{
    public class Cliente : Registro
    {
        private string nome;
        private string cnpj;
        private string senha;
        private long id;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetId(long id)
        {
            this.id = id;
        }

        public long GetId()
        {
            return id;
        }
    }
}