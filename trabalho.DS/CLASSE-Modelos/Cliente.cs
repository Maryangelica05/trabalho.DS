namespace Modelos
{
    public class Cliente : Registro
    {
        public int Id { get;set;}
        public string Nome {get; set;}
        public string Cnpj {get; set;}
        public string Senha {get; set;}

    }
}