using System;
public class Empresa
{
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
     
    public string NomeP { get; set; }

    public string CNPJ { get; set; }
    public string CPF { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string SituacaoCadastral { get; set; }
    public string NaturezaJuridica { get; set; }
    public double CapitalSocial { get; set; }
    public DateTime? DataInicial{ get; set; } 
    public string RegimeTributario { get; set; }

    public string Tipo { get; set; }
    public string PorteEmpresa { get; set; }

    public Empresa(string razaoSocial, string nomeFantasia, string nomeP, string cNPJ, string cPF, string estado, string cidade, string endereco, string telefone, string situacaoCadastral, string naturezaJuridica, double capitalSocial, DateTime dataInicial, string regimeTributario, string tipo, string porteEmpresa)
    {
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        NomeP = nomeP;
        CNPJ = cNPJ;
        CPF = cPF;
        Estado = estado;
        Cidade = cidade;
        Endereco = endereco;
        Telefone = telefone;
        SituacaoCadastral = situacaoCadastral;
        NaturezaJuridica = naturezaJuridica;
        CapitalSocial = capitalSocial;
        DataInicial = dataInicial;
        RegimeTributario = regimeTributario;
        Tipo = tipo;
        PorteEmpresa = porteEmpresa;
    }
    public Empresa()
    { }
}
