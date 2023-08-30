public class Teste
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario
        {
            Nome = "Joao",
            Email = "joapedro@test.com",
            SenhaEncriptografada = "senhasegura",
            TipoDeUsuario = (UsuarioTipoEnum)0,
        };

        Categoria categoria = new Categoria { Id = 1, Descricao = "Direito" };
        Idioma idioma = new Idioma { Id = 1, Descricao = "Portugues - Brasileiro" };
        Pais pais = new Pais { Id = 1, Descricao = "Brasil" };


        Produto produto = new Produto
        {   
            UsuarioCriador = usuario,
            Nome = "Produto1",
            Descricao = "Descricao",
            CategoriaProduto = categoria, 
            IdiomaDoProduto = idioma , 
            PrincipalPais = pais ,
        };

        System.Console.WriteLine(produto.Id);
        System.Console.WriteLine(produto.Nome);
        System.Console.WriteLine(produto.UsuarioCriador?.Nome);
        System.Console.WriteLine(produto.CategoriaProduto?.Descricao);
        System.Console.WriteLine(produto.PrincipalPais?.Descricao);
        System.Console.WriteLine(produto.IdiomaDoProduto?.Descricao);
        System.Console.WriteLine(usuario.Id);
        System.Console.WriteLine(usuario.TipoDeUsuario);
    }
}

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaEncriptografada { get; set; } = string.Empty;
    public UsuarioTipoEnum? TipoDeUsuario { get; set; }
    public DateTime? DataHoraCriacao { get; set; }
    public DateTime? DataHoraAlteracao { get; set; }
}

public enum UsuarioTipoEnum
{
    Comprador,
    Vendedor,
}

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Usuario? UsuarioCriador { get; set; } = null;
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Idioma? IdiomaDoProduto { get; set; }
    public Pais? PrincipalPais { get; set; }
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaProduto { get; set; }
    public DateTime? DataHoraCriacao { get; set; }
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


