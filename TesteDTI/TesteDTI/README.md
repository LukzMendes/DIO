# Documenta��o da teste t�cnico - .net core - Api rest

## Como executar o c�digo

- Abra a Solution e d� run*;
- Usando o navegador ou Postman, d� um get na url** https://localhost:44387/api/Petshop, passando os seguintes par�metros:
  - dataDoBanho: Dia em que os cachorros ser�o levados para tomarem banho;
  - caesPequenos: Quantidade de caes pequenos;
  - caesGrande: Quantidade de caes grandes;
- Ser� retornado um Json contendo o nome do petshop com o melhor pre�o e a menor dist�ncia, o valor total do banho e a dist�ncia;

## Como executar os testes
- Abra a Solution;
- Clique com o bot�o direito em cima do projeto "ApiTest";
- Selecione a op��o "Run Tests";
- Os resultados apareceram na aba "Test Explorer" (ou "Gerenciador de Testes" caso o seu visual studio esteja em portugu�s)

## Premissas assumidas
- O projeto tem que ser desenvolvido em .Net Core 2.0 ou superior
- O projeto deve possuir documenta��o;
- Os m�todos utilizados devem conter testes;
- Deve ser retornado um JSON;
- Os parametros ser�o informados na URL;
- O parametro 'dataDoBanho', deve estar em um dos seguintes formatos:
    - dd/mm/aa;
    - dd/mm/aaaa;
    - aa/mm/dd;
    - aaaa/mm/dd;
- O projeto tem que ser desenvolvido de forma que, caso precise adicionar mais petshops, tenha que ser realizadas poucas altera��es no c�digo;

## Decis�es de projeto
O projeto tem que verificar qual � o petshop mais barato e/ou o mais perto, com base no dia e na quantidade de caes a serem levados para tomarem banho;


## Observa��es
__* Infelizmente n�o sei fazer a publica��o de uma publica��o web ou web api__;

__** Os par�metros devem ser passados via URL. Exemplo: https://localhost:44387/api/Petshop?dataDoBanho=16-07-2020&caesPequenos=2&caesGrandes=3 ;__ 
