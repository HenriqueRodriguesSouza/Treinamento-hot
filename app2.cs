using System;
public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NomeUsuario { get; set; } = string.Empty;
    public string EmailUsuario { get; set; } = string.Empty;
    public string SenhaCriptografada { get; set; } = string.Empty;
    public UsuarioTipoEnum? TipoUsuario { get; set; }
    public DateTime? DataCriacao {get; set; }
    public DateTime? DataAlteracao {get; set;}

}

public enum UsuarioTipoEnum
{
    Comprador = 1;
    Vendedor = 2;
}

public class produto
{
    public Guid Id {get; set;}

    public Usuario? UsuarioCriador {get; set;} = null; 
    public string NomeProduto {get; set;} = string.Empty;
    public string DescricaoProduto {get; set;} = string.Empty;
    public Idioma? IdiomaProduto {get; set;} = null;
    public Pais? PrincipalPaisProduto {get; set;} = null
    public string ImagemProdutoUrl {get; set;} = string.Empty;
    public Categoria? CategoriaProduto {get; set;} = null;
}

public class Idioma
{
    public Guid Id {get; set;}
    public string Descricao {get; set;} = string.Empty
    public DateTime? DataCriacao {get; set; }
    public DateTime? DataAlteracao {get; set;}
}

public class Pais
{
    public Guid Id {get; set;}
    public string Descricao {get; set;} = string.Empty
    public DateTime? DataCriacao {get; set; }
    public DateTime? DataAlteracao {get; set;}
}

public class Categoria
{
    public Guid Id {get; set;}
    public string Descricao {get; set;} = string.Empty
    public DateTime? DataCriacao {get; set; }
    public DateTime? DataAlteracao {get; set;}
}

