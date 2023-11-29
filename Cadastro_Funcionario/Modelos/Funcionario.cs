using System;

public class Funcionario
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Endereco { get; set; }

    public string Telefone { get; set; }
    public string Email { get; set; }

    public string EstadoCivil { get; set; }
    public string CPF { get; set; }

    public string RG { get; set; }

    public double Salario { get; set; }
    public DateTime? DataNascimento { get; set; }

    public Funcionario(string nome, string funcao, string estado, string cidade, string endereco, string telefone, string email, string estadoCivil, string cpf, string rg, double salario, DateTime dataNascimento)
    {
        Nome = nome;
        Funcao = funcao;
        Estado = estado;
        Cidade = cidade;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
        EstadoCivil = estadoCivil;
        CPF = cpf;
        RG = rg;
        Salario = salario;
        DataNascimento = dataNascimento;
    }

    public Funcionario() { }

}