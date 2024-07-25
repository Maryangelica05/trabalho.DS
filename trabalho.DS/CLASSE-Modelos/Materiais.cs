namespace Modelos
{
    public class Materiais:Registro
    {
        private string nomematerial;
        private string ativo;
        private string nomefornecedor;
        private int id;

        public void SetNomematerial(string nomematerial)
        {
            this.nomematerial = nomematerial;
        }

        public string GetNomematerial()
        {
            return nomematerial;
        }

        public void SetAtivo(string ativo)
        {
            this.ativo = ativo;
        }

        public string GetAtivo()
        {
            return ativo;
        }

        public void SetNomefornecedor(string nomefornecedor)
        {
            this.nomefornecedor = nomefornecedor;
        }

        public string GetNomefornecedor()
        {
            return nomefornecedor;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
    }
}