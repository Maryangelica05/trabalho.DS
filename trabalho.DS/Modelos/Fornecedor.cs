namespace Modelos;
{


public class Fornecedor
{
    string nome;
    string cnpj;
    string telefone;
    string materiaprima
     int id;
     
    public void SetNome ( string nome)
  {
    this.nome = nome;
  }
    public string GetNome()
  {
    return nome;
  }
    public void SetCnpj ( string Cnpj)
    {
        this.SetCnpj = Cnpj; 
    }
    public string GetCnpj()
    {
        return Cnpj;
    }
    public void SetTelefone (string Telefone)
    {
        this.Telefone = Telefone;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
     public void SetMateriaprima(string Materiaprima)
   {
        this.Materiaprima = Materiaprima;
    }
     public string GetMateriaprima ()
     {
        return Materiaprima
     }

  }
  }
