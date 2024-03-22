var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto("Celular", "IOS"));
produtos.Add(new Produto("Celular", "Android"));
produtos.Add(new Produto("Computador", "Windows 10"));

//EndPoint - Funcionalidades
app.MapGet("/", () => "Minha API em C#!");
// GET Lista de produtos
app.MapGet("api/produto/listar", () => produtos);
// POST Cadastro de produtos
app.MapPost("api/produto/cadastrar", () => "Cadastro de produtos!");

app.Run();

record Produto(string Nome, string Descricao);
