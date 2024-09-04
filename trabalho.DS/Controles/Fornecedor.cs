using LiteDB;
using Modelos;

namespace Controles;

public class FornecedorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedorControle() : base()
  {
    NomeDaTabela = "Fornecedores";
  }
 public virtual Registro? Ler(int idFornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFornecedor);
  }
  //----------------------------------------------------------------------------

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return new List<Fornecedor>(tabela.FindAll());
  }
  public virtual void Apagar(int idFornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Delete(idFornecedor);
  }

  //----------------------------------------------------------------------------


  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedor c)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Upsert(c);
  }


  //----------------------------------------------------------------------------
}