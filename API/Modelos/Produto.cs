namespace API.Modelos;

//record Produto(string Nome, string Descricao);

public class Produto
{

    //contrutores
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public Produto
    (string nome, string descricao, double valor)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    // caracteristicas - atributos e propriedades 
    public string? Id {get; set;}
    public string? Nome {get; set; }
    public string? Descricao {get; set;}
    public double Valor{get; set;} 
    public DateTime CriadoEm {get; set;}

    // private string nome;

    // public void setNome(string nome)
    // {
    //     this.nome = nome;
    // }

    // public string getNome()
    // {
    //     return this.nome;
    // }
}