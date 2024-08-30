using LiteDB;
using Modelos;

namespace Controles;

public class MateriaisControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaisControle() : base()
  {
    NomeDaTabela = "Materiais";
  }
 public virtual Registro? Ler(int idMateriais)
  {
    var collection = liteDB.GetCollection<Materiais>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMateriais);
  }
  //----------------------------------------------------------------------------

  //----------------------------------------------------------------------------

  public virtual List<Materiais>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Materiais>(NomeDaTabela);
    return new List<Materiais>(tabela.FindAll());
  }
  public virtual void Apagar(int idMateriais)
  {
    var collection = liteDB.GetCollection<Materiais>(NomeDaTabela);
    collection.Delete(idMateriais);
  }

  //----------------------------------------------------------------------------


  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Materiais c)
  {
    var collection = liteDB.GetCollection<Materiais>(NomeDaTabela);
    collection.Upsert(c);
  }


  //----------------------------------------------------------------------------
}