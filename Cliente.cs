namespace Modelos;
{


public class Cliente
{
    string nome;
    string cnpj;
    string senha;

     int64 id;
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
    public void SetSenha (string Senha)
    {
        this.SetSenha = Senha;
    }
    public string GetSenha()
    {
        return Senha;
    }
  }
  }
