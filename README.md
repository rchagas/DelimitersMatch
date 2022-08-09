# Delimitadores Válidos

## Sobre

O presente projeto tem como objetivo verificar se certa ordem de delimitadores é válida ou nāo. Isso é feito verificando se os delimitadores sāo abertos e fechados na ordem correta.\
O programa retorna True caso a ordem seja válida e False caso contrário.

Para que uma sequencia de delimitadores seja considerada válida, são considerados os seguintes pontos:

- não tenha um demitador de fechamento antes de seu delimitador de abertura correspondente
- não contem delimitadores sem correspondencia;
- o subconjunto de delimitadores dentro dos limites de um par de delimitadores correspondente é também um par de delimitadores correspondentes.

São considerados delimitadores no programa: (), [], {}.

Os caracteres entre delimitadores que não são delimitadores foram desconsiderados para ser mais funcional.

## Funcionamento:

O presente programa foi feito utilizando C# com framework .Net versão 6.0. 

Para executar o programa rode o projeto passando as strings a serem validadas no array de argumento do programa

`dotnet run -- STRING...` 

Execute os testes de unidade do projeto com o comando
`dotnet test`