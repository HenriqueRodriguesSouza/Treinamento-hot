public class produto
{
    public Guid Id { get; set; }
    public Usuario? UsuarioCriadorDoProduto { get; set; } = null;
    public string Descricao { get; set; } = string.Empty;
    public Idioma? Idioma { get; set; } = null;
    public Pais? PrincipalPaisParaVenda { get; set; } = null;
    public string ImagemProdutoUrl { get; set; } = string.Empty;
    public Categoria? Categoria { get; set} = null;
    public DateTime? CriacaoDataHora { get; set}
    public DateTime? UltimaAlteracaoDataHora { get; set; }
}

public class Idioma
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; }
    public DateTime? UltimaAlteracaoDataHora { get; set; }

}

public class Pais
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; }
    public DateTime? UltimaAlteracaoDataHora { get; set; }

}

public class Categoria
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime? CriacaoDataHora { get; set; }
    public DateTime? UltimaAlteracaoDataHora { get; set; }

}

public class Usuario
{
    public Guid Id { get; set}
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaCriptografada { get; set; } = string.Empty
    public UsuarioTipoEnum? TipoUsuario { get; set; }
    public DateTime? CriacaoDataHora { get; set; }
    public DateTime? UltimaAlteracaoDataHora { get; set; }
}

public enum UsuarioTipoEnum
{
    Vendedor = 1;
    Comprador = 2;
}