# Documentação da teste técnico - .net core - Api rest

## Como executar o código

- Abra a Solution e dê run*;
- Usando o navegador ou Postman, dê um get na url** https://localhost:44387/api/Petshop, passando os seguintes parâmetros:
  - dataDoBanho: Dia em que os cachorros serão levados para tomarem banho;
  - caesPequenos: Quantidade de caes pequenos;
  - caesGrande: Quantidade de caes grandes;
- Será retornado um Json contendo o nome do petshop com o melhor preço e a menor distância, o valor total do banho e a distância;

## Como executar os testes
- Abra a Solution;
- Clique com o botão direito em cima do projeto "ApiTest";
- Selecione a opção "Run Tests";
- Os resultados apareceram na aba "Test Explorer" (ou "Gerenciador de Testes" caso o seu visual studio esteja em português)

## Premissas assumidas
- O projeto tem que ser desenvolvido em .Net Core 2.0 ou superior
- O projeto deve possuir documentação;
- Os métodos utilizados devem conter testes;
- Deve ser retornado um JSON;
- Os parametros serão informados na URL;
- O parametro 'dataDoBanho', deve estar em um dos seguintes formatos:
    - dd/mm/aa;
    - dd/mm/aaaa;
    - aa/mm/dd;
    - aaaa/mm/dd;
- O projeto tem que ser desenvolvido de forma que, caso precise adicionar mais petshops, tenha que ser realizadas poucas alterações no código;

## Decisões de projeto
O projeto tem que verificar qual é o petshop mais barato e/ou o mais perto, com base no dia e na quantidade de caes a serem levados para tomarem banho;


## Observações
__* Infelizmente não sei fazer a publicação de uma publicação web ou web api__;

__** Os parâmetros devem ser passados via URL. Exemplo: https://localhost:44387/api/Petshop?dataDoBanho=16-07-2020&caesPequenos=2&caesGrandes=3 ;__ 
