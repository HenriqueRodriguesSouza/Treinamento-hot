// See https://aka.ms/new-console-template for more information
Console.WriteLine("teste");

var teste1 = (UsuarioTipoEnum)0;
Console.WriteLine(teste1);

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NomeCompletoUsuario { get; set; } = string.Empty;
    public string EmailUsuario { get; set; } = string.Empty;
    public string SenhaCriptografada { get; set; } = string.Empty;
    public UsuarioTipoEnum? TipoDeUsuario { get; set; } = null;
    public DateTime CriacaoDataHora { get; set; } = DateTime.UtcNow;
    public DateTime DataHoraAlteracao { get; set; } = DateTime.UtcNow;
}

public enum UsuarioTipoEnum
{
    Vendedor,
    Comprador,
}


public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Usuario? UsuarioCriador { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Idioma? IdiomaProduto { get; set; } = null;
    public Pais? PaisPrincipal { get; set; } = null;
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? CategoriaProduto { get; set; } = null;

}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime AlteracaoDataHora { get; set; } = DateTime.UtcNow;

}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime AlteracaoDataHora { get; set; } = DateTime.UtcNow;

}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime AlteracaoDataHora { get; set; } = DateTime.UtcNow;

}

