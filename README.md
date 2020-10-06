# DesafioMiltec
 API para Busca e listagem de Livros por suas especificações.
 ____
 
 ## Ferramentas Necessárias
 ____
 
 Para Executar o projeto é necessário a utilização do Visual Studio Code, a versão .NET Core 2.2.104 instalada, Postman e/ou um Browser.
 
 
 ## Modo de Execução
 ____
 
 - Abra o Visual Code na pasta do projeto e execute no terminal o comando "node-run"
 - Após realizado o comando o programa será startado abrindo um navegador.
 - Preencha a url com o caminho que desejar seguir de acordo com seu método de busca:
 
   - Obs: Troque porta por sua porta no momento da execução.
   - Obs: No final da url digite o que deseja buscar retirando as chaves e o que está dentro dela
   
   - Listar todos os elementos digite:  https://localhost:[PORTA]/v1/listarlivros/todos
   - Busca por id:  https://localhost:[PORTA]/v1/id/{id} 
   - Busca por name:  https://localhost:[PORTA]/v1/name/{name}
   - Busca por price:  https://localhost:[PORTA]/v1/price/{price}
   - Busca por Originally published:  https://localhost:[PORTA]/v1/Originally_published/{Originallypublished}
   - Busca por Author:  https://localhost:[PORTA]/v1/Author/{Author}
   - Busca por Page count:  https://localhost:[PORTA]/v1/Page_count/{Pagecount}
   - Busca por Illustrator:  https://localhost:[PORTA]/v1/Illustrator/{Illustrator}
   - Busca por Genres:  https://localhost:[PORTA]/v1/Genres/{Genres}
   - Ordenação Crescente :  https://localhost:[PORTA]/v1/listarlivros/OC
   - Ordenação Decrescente:  https://localhost:[PORTA]/v1/listarlivros/OD
   - Calcula Frete https://localhost:[PORTA]/v1/listarlivros/frete

   Todos Listados acima realizam um GET
   
 ## O que foi solicitado
 ____
 
 - Criar uma API simples para buscar produtos no arquivo JSON disponibilizado.
 - Que seja possível buscar livros por suas especificações(autor, nome do livro ou outro atributo)
 - É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
 - Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.
 ____
 
 *_Autor: Ergon Zamarian Lima_*
 
 
