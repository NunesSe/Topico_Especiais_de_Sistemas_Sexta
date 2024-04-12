using API.Modelos;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Produto produto = new Produto();
//prod.setNome("Bolacha")
produto.Nome = "bolacha";
// Console.WriteLine(produto.getNome)
List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto("Celular", "IOS", 300));
produtos.Add(new Produto("Celular", "Android", 800));
produtos.Add(new Produto("Computador", "Windows 10", 90000000000));

//EndPoint - Funcionalidades
app.MapGet("/", () => "Minha API em C#!");

// GET Lista de produtos
app.MapGet("api/produto/listar", () => produtos);

// GET Lista de buscar id do produto
app.MapGet("api/produto/buscar/{id}", (string id) => 
{
    foreach (Produto produtoCadastrado in produtos){
        if(produtoCadastrado.Id == id){
            // retorar produto encontrado 
            return Results.Ok(produtoCadastrado);
        }
    }
    return Results.NotFound("Produto nao Encontrado");
});






// EXERCICIO 05/04/24
// 1) CADASTRAR UM PRODUTO
//
// a) pela URL
app.MapGet("api/produto/cadastrar/{nome}/{descricao}/{valor}", (string nome, string descricao, double valor) => 
{
    Produto novoProduto = new Produto(nome, descricao, valor);
    produtos.Add(novoProduto);
});

// b) pelo corpo da requisição

app.MapPost("api/produto/cadastrar", () => "Cadastro de produtos!");

// 2) Remover um produto
// 3) Alterar um produto

app.Run();