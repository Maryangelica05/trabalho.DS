namespace Modelos
{
    public class Fornecedor : Registro
    {
        private string nome;
        private string cnpj;
        private string telefone;
        private string materiaprima;
        private int id;

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

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetMateriaprima(string materiaprima)
        {
            this.materiaprima = materiaprima;
        }

        public string GetMateriaprima()
        {
            return materiaprima;
        }
    }
}
