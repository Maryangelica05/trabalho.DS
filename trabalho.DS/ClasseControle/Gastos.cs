using LiteDB;
using Modelos;

namespace Controles
{
    public class GastosControle : BaseControle
    {
        //----------------------------------------------------------------------------

        public GastosControle() : base()
        {
            NomeDaTabela = "Gastos";
        }

        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------

        public virtual List<Gastos>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Gastos>(NomeDaTabela);
            return new List<Gastos>(tabela.FindAll());
        }

        public virtual void Apagar(int idGastos)
        {
            var collection = liteDB.GetCollection<Gastos>(NomeDaTabela);
            collection.Delete(idGastos);
        }

        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------

        public virtual void CriarOuAtualizar(Gastos c)
        {
            var collection = liteDB.GetCollection<Gastos>(NomeDaTabela);
            collection.Upsert(c);
        }

        //----------------------------------------------------------------------------
    }
}
