create database Empresa;
use Empresa;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(300),
cpf_fun varchar(20),
rg_fun varchar(20),
data_nascimento_fun date,
funcao_fun varchar(300),
telefone_fun varchar(20),
email_fun varchar(100),
salario_fun double,
estado_civil_fun varchar(100),
estado_fun varchar(200),
cidade_fun varchar(200),
endereco_fun varchar(400)
);
select * from Funcionario;

create table Empresa(
id_emp int primary key auto_increment,
razao_social_emp varchar(300),
nome_fantasia_emp varchar(300),
cnpj_emp varchar(20),
nome_proprietario_emp varchar(200),
cpf_emp varchar(20),
telefone_emp varchar(30),
estado_emp varchar(200),
cidade_emp varchar(200),
endereco_emp varchar(400),
situacao_cadastral_emp varchar(200),
natureza_juridica_emp varchar(200),
data_inicial_emp varchar(200),
tipo_emp varchar(200),
regime_tributario_emp varchar(200),
porte_empresa_emp varchar(100),
capital_social_emp double
);

select * From Empresa;

