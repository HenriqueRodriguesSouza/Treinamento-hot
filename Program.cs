public class Teste
{
    public static void Main(string[] args)
    {
        Usuario usuario = new Usuario
        {
            Nome = "Pedro",
            Email = "pedrofraga@test.com",
            SenhaCriptografada = "senhasegura",
            TipoDoCliente = (TipoDoClienteEnum)0,
        };

        Idioma idioma = new Idioma { Id = 1, Descricao = "Portugues - BR" };
        Pais pais = new Pais { Id = 1, Descricao = "Brasil" };
        Categoria categoria = new Categoria { Id = 1, Descricao = "Direito" };

        Produto produto = new Produto
        {
            UsuarioCriadorDoProduto = usuario,
            NomeProduto = "Loren",
            DescricaoProduto = "Ipsum",
            IdiomaProduto = idioma,
            PaisProduto = pais,
            ImagemProdutoUrl = "https://chat.openai.com/c/4733d5cf-2ded-45d9-a13f-4959245c7b90",
            CategoriaProduto = categoria,
        };

        //Usuario
        System.Console.WriteLine(usuario.Id);
        System.Console.WriteLine(usuario.Nome);
        System.Console.WriteLine(usuario.Email);
        System.Console.WriteLine(usuario.SenhaCriptografada);
        System.Console.WriteLine(usuario.TipoDoCliente);

        //Produto
        System.Console.WriteLine(produto.Id);
        System.Console.WriteLine(produto.UsuarioCriadorDoProduto?.Nome);
        System.Console.WriteLine(produto.NomeProduto);
        System.Console.WriteLine(produto.DescricaoProduto);
        System.Console.WriteLine(produto.IdiomaProduto.Descricao);
        System.Console.WriteLine(produto.PaisProduto.Descricao);
        System.Console.WriteLine(produto.ImagemProdutoUrl);
        System.Console.WriteLine(produto.CategoriaProduto.Descricao);
    }
}

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaCriptografada { get; set; } = string.Empty;
    public TipoDoClienteEnum? TipoDoCliente { get; set; }
    public DateTime? HoraDataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? HoraDataAlteracao { get; set; } = DateTime.UtcNow;
}

public enum TipoDoClienteEnum
{
    Vendedor,
    Comprador
}

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Usuario? UsuarioCriadorDoProduto { get; set; } = null;
    public string NomeProduto { get; set; } = string.Empty;
    public string DescricaoProduto { get; set; } = string.Empty;
    public Idioma? IdiomaProduto { get; set; }
    public Pais? PaisProduto { get; set; }
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaProduto { get; set; }
    public DateTime? HoraDataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? HoraDataAlteracao { get; set; } = DateTime.UtcNow;
}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? HoraDataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? HoraDataAlteracao { get; set; } = DateTime.UtcNow;
}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? HoraDataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? HoraDataAlteracao { get; set; } = DateTime.UtcNow;
}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? HoraDataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? HoraDataAlteracao { get; set; } = DateTime.UtcNow;
}