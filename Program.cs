public class Teste
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario {
            Nome = "Roberto Carlos" , 
            Email = "reirobertocarlos@gmail.com", 
            SenhaEncriptografada = "ladylaura123", 
            TipoDeUsuario = (TipoDeUsuarioEnum)0,              
        };

        Idioma idioma = new Idioma {
            Id = 1,
            Descricao ="Portugues",
        };

        Pais pais = new Pais {
            Id = 1,
            Descricao = "Brasil",
        };

        Categoria categoria = new Categoria{
            Id = 22, 
            Descricao = "Musica"
         };

         Produto produto = new Produto { 
            IdCriador = usuario,
            NomeDoProduto = "Aulas de canto com o Rei Roberto Carlos",
            DescricaoDoProduto = "Roberto Carlos ensina a voce criar e cantar suas musicas", 
            IdiomaProduto = idioma, 
            PaisPrincipal = pais, 
            ImagemProdutoUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2FRobertoCarlosOficial%2F&psig=AOvVaw3Sh-yQf3T_q6XXiPsB5SSC&ust=1693602385993000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCPjcn9bmh4EDFQAAAAAdAAAAABAE",
            CategoriaProduto = categoria,            
          };

        //Usuario
        System.Console.WriteLine(usuario.Id);
          System.Console.WriteLine(usuario.Nome);
          System.Console.WriteLine(usuario.Email);
          System.Console.WriteLine(usuario.SenhaEncriptografada);
          System.Console.WriteLine(usuario.TipoDeUsuario);
          System.Console.WriteLine(usuario.CriacaoDataHora);

        //produto
        System.Console.WriteLine(produto.Id);
        System.Console.WriteLine(produto.IdCriador.Id);
        System.Console.WriteLine(produto.NomeDoProduto);
        System.Console.WriteLine(produto.DescricaoDoProduto);
        System.Console.WriteLine(produto.IdiomaProduto.Descricao);
        System.Console.WriteLine(produto.PaisPrincipal.Descricao);
        System.Console.WriteLine(produto.ImagemProdutoUrl);
        System.Console.WriteLine(produto.CategoriaProduto.Descricao);
        System.Console.WriteLine(produto.CriacaoDataHora);
    }
}

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaEncriptografada { get; set; } = string.Empty;
    public TipoDeUsuarioEnum? TipoDeUsuario { get; set; } = null;
    public DateTime? CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;

}

public enum TipoDeUsuarioEnum
{
    vendedor,
    comprador,
}

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Usuario? IdCriador { get; set; } = null;
    public string NomeDoProduto { get; set; } = string.Empty;
    public string DescricaoDoProduto { get; set; } = string.Empty;
    public Idioma? IdiomaProduto { get; set; } = null;
    public Pais? PaisPrincipal { get; set; } = null;
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaProduto { get; set; } = null;
    public DateTime? CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;

}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime? AlteracaoDataHora { get; set; } = DateTime.UtcNow;
}