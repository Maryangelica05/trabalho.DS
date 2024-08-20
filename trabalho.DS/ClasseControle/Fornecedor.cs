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

  //----------------------------------------------------------------------------

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return new List<Fornecedor>(tabela.FindAll());
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