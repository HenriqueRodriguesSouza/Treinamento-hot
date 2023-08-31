using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Teste
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario
        {
            Nome = "Roberto Carlos",
            Email = "robertoc@gmail.com",
            SenhaCriptograda = "ladylaura2512",
            TipoDoUsuario = 0,
        };

        Idioma idioma = new Idioma
        {
            Id = 1,
            Descricao = "Portugues - BR",
        };

        Pais pais = new Pais
        {
            Id = 1,
            Descricao = "Brasil",
        };

        Categoria categoria = new Categoria
        {
            Id = 1,
            Descricao = "Musica",
        };

        Produto produto = new Produto
        {
            NomeProduto = "Aulas de canto com o Rei",
            DescricaoProduto = "Aulas de canto ministrada pelo grande rei Roberto Carlos",
            IdiomaProduto = idioma,
            PaisProduto = pais,
            ImagemProdutoUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Ftwitter.com%2Frobertocarlos&psig=AOvVaw2eAwirO1utbh6fnzdA7ntj&ust=1693538102909000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCNjG8Jn3hYEDFQAAAAAdAAAAABAE",
            CategoriaProduto = categoria,
        };

        //Cliente
        System.Console.WriteLine(usuario.Nome);
        System.Console.WriteLine(usuario.Email);
        System.Console.WriteLine(usuario.SenhaCriptograda);
        System.Console.WriteLine(usuario.TipoDoUsuario);

        //Produto
        System.Console.WriteLine(produto.NomeProduto);
        System.Console.WriteLine(produto.DescricaoProduto);
        System.Console.WriteLine(produto.IdiomaProduto.Descricao);
        System.Console.WriteLine(produto.PaisProduto.Descricao);
        System.Console.WriteLine(produto.ImagemProdutoUrl);
        System.Console.WriteLine(produto.CategoriaProduto.Descricao);
        System.Console.WriteLine(produto.DataHoraCriacao);
    }
}

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaCriptograda { get; set; } = string.Empty;
    public TipoDeUsuarioEnum? TipoDoUsuario { get; set; }
    public DateTime? DataHoraCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? DataHoraAlteracao { get; set; }
}

public enum TipoDeUsuarioEnum
{
    Vendedor,
    Comprador
}

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NomeProduto { get; set; } = string.Empty;
    public string DescricaoProduto { get; set; } = string.Empty;
    public Idioma? IdiomaProduto { get; set; }
    public Pais? PaisProduto { get; set; }
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaProduto { get; set; }
    public DateTime? DataHoraCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? DataHoraAlteracao { get; set; }

}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? DataHoraCriacao { get; set; }
    public DateTime? DataHoraAlteracao { get; set; }

}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? DataHoraCriacao { get; set; }
    public DateTime? DataHoraAlteracao { get; set; }

}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? DataHoraCriacao { get; set; }
    public DateTime? DataHoraAlteracao { get; set; }

}