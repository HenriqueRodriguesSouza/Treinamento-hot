public class Teste
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario
        {
            Nome = "Pedro Alvez",
            Email = "alvezpedro1998@gmail.com",
            SenhaCriptografada = "avpedro1442",
            TipoDoUsuario = (TipoDeUsuarioEnum)1
        };

        Idioma idioma = new Idioma { Id = 2, Descricao = "Portugues-Br" };
        Pais pais = new Pais { Id = 1, Descricao = "Brasil" };
        Categoria categoria = new Categoria { Id = 12, Descricao = "Musica" };

        Produto produto = new Produto
        {
            Nome = "Aula de canto",
            Descricao = "Aulas de canto para inciantes",
            UsuarioCriador = usuario,
            IdiomaDoProduto = idioma,
            PaisDoProduto = pais,
            ImagemDoProdutoUrl = "Url da imagem",
            CategoriaDoProduto = categoria
        };

        System.Console.WriteLine("-----Dados do usuario-----");
        System.Console.WriteLine(usuario.Id);
        System.Console.WriteLine(usuario.Nome);
        System.Console.WriteLine(usuario.Email);
        System.Console.WriteLine(usuario.SenhaCriptografada);
        System.Console.WriteLine(usuario.TipoDoUsuario);
        System.Console.WriteLine(usuario.CriacaoDataHora);

        System.Console.WriteLine("-----Dados do produto-----");
        System.Console.WriteLine(produto.Id);
        System.Console.WriteLine(produto.UsuarioCriador.Id);
        System.Console.WriteLine(produto.Nome);
        System.Console.WriteLine(produto.Descricao);
        System.Console.WriteLine(produto.IdiomaDoProduto.Descricao);
        System.Console.WriteLine(produto.PaisDoProduto.Descricao);
        System.Console.WriteLine(produto.ImagemDoProdutoUrl);
        System.Console.WriteLine(produto.CategoriaDoProduto.Descricao);
    }
}

public class Usuario
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaCriptografada { get; set; } = string.Empty;
    public TipoDeUsuarioEnum? TipoDoUsuario { get; set; } = null;
    public DateTime? CriacaoDataHora { get; init; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public enum TipoDeUsuarioEnum
{
    vendedor,
    comprador
}

public class Produto
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Usuario? UsuarioCriador { get; init; } = null;
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Idioma? IdiomaDoProduto { get; set; } = null;
    public Pais? PaisDoProduto { get; set; } = null;
    public string ImagemDoProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaDoProduto { get; set; } = null;
    public DateTime? CriacaoDataHora { get; init; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; init; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; init; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; init; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}