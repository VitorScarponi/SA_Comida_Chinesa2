# SA Comida Chinesa — CRUD no estilo das aulas (C# + MySQL + JSON)

Classes: `Conexao` (MySql.Data), `Produto` (atributos encapsulados com Set/Get + métodos do CRUD)
e o formulário `FrmProdutos`, montado por código, com o mesmo layout do FrmAlunos.

Fluxo: FrmProdutos -> Produto -> Conexao -> MySQL, e a cada Cadastrar/Alterar/Excluir
o sistema gera o `produtos.json` na pasta do site. Sem API.

## Passo a passo
1. Rode o `banco.sql` no MySQL Workbench (cria DB_SAComidaChinesa e a tabela tblProdutos).
2. Se sua senha do MySQL não for vazia, ajuste `pwd` na string de conexão em `Conexao.cs`.
3. Abra `ProjetoCRUD_SA.sln` no Visual Studio 2022 (.NET 8) e aperte F5. O pacote NuGet `MySql.Data` baixa sozinho.
4. Clique em "Procurar..." (rodapé) e escolha a pasta `SA_Comida_Chinesa_Colorido`.
5. Cadastre, altere ou exclua. Só pratos "Ativo" vão para o site.

## Abrindo o site
O navegador bloqueia a leitura do JSON em arquivo aberto direto. Use a extensão Live Server do VS Code.
Se o JSON não carregar, o site mostra o cardápio padrão.
