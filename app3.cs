using System;

public class Usuario
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string NomeCompletoUsuario {get; set;} = string.Empty;
    public string EmailUsuario {get; set;} = string.Empty;
    public string SenhaCriptografada {get; set;} = string.Empty;
    public UsuarioTipoEnum? TipoDeUsuario {get; set;} = null;
    public DateTime DataHoraCriacao {get; set;} = DateTime.UtcNow;
    public DateTime DataHoraAlteracao {get; set;} = DateTime.UtcNow;
}

public enum UsuarioTipoEnum
{
    Vendedor = 1;
    Comprador = 2;
}

public class produto
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string Nome {get; set;} = string.empty;
    public string Descricao {get; set;} = string.empty;
    public Idioma? IdiomaProduto {get; set;} = null;
    public Pais? PaisPrincipal {get; set;} = null;
    public string ImagemProdutoUrl {get; set;} = string.empty;
    public Categoria? CategoriaProduto {get; set;} = null;
    
}

public class Idioma
{
    public int Id {get; set;}
    public string Descricao {get; set;} = string.empty;
    public DateTime DataCriacao {get; set;} = DateTime.UtcNow;
    public DateTime AlteracaoDataHora {get; set;} = DateTime.UtcNow
    
}

public class Pais
{
    public int Id {get; set;}
    public string Descricao {get; set;} = string.empty;
    public DateTime DataCriacao {get; set;} = DateTime.UtcNow;
    public DateTime AlteracaoDataHora {get; set;} = DateTime.UtcNow
    
}

public class Categoria
{
    public int Id {get; set;}
    public string Descricao {get; set;} = string.empty;
    public DateTime DataCriacao {get; set;} = DateTime.UtcNow;
    public DateTime AlteracaoDataHora {get; set;} = DateTime.UtcNow
    
}