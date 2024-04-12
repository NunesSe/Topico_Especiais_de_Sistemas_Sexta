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
app.MapPost("api/produto/cadastrar/{nome}/{descricao}/{valor}", (string nome, string descricao, double valor) => 
{
    Produto novoProduto = new Produto(nome, descricao, valor);
    produtos.Add(novoProduto);

    return Results.Created("", novoProduto);
});

// b) pelo corpo da requisição

app.MapPost("api/produto/cadastrar", (Produto produto) => 
{
    produtos.Add(produto);
    return Results.Created("", produto);
});

// 2) Remover um produto pela URL

app.MapDelete("api/produto/deletar/{id}", (string id) => 
{
    foreach (Produto produtoCadastrado in produtos){
        if(produtoCadastrado.Id == id){
            produtos.Remove(produtoCadastrado);
            return Results.Ok(id);
        }
    }
    return Results.NotFound("Produto nao Encontrado");
});


// 3) Alterar um produto

app.MapPut("api/produto/modificar/{id}", (string id, Produto produtoNovo) =>
{
    foreach (Produto produtoCadastrado in produtos){
        if(produtoCadastrado.Id == id){
            produtos.Remove(produtoCadastrado);
            produtos.Add(produtoNovo);
            return Results.Ok(id);
        }
    }
    return Results.NotFound("Nao achado");
});


app.Run();