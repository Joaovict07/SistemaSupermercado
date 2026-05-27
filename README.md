
# Sistema de Supermercado

Aplicação desktop desenvolvida em C# com Windows Forms para controle básico de um supermercado.

O sistema permite cadastrar produtos, registrar compras e emitir uma nota simples com os itens comprados e o valor total da compra.

## 👥 Integrantes

- Beatriz de Oliveira Sanches Eusebio - RA 923115417
- Christian Ribeiro Gama Franco - RA 923115584
- Douglas de Almeida Nascimento - RA 923111247
- João Victor Silva Bulcão - RA 923116778

## 📌 Sobre o projeto

Este projeto foi desenvolvido com objetivo acadêmico, aplicando conceitos de programação em C#, interface gráfica com Windows Forms e integração com banco de dados MySQL.

A aplicação possui telas para gerenciamento de produtos, realização de compras e visualização da nota gerada ao final da venda.

## ⚙️ Funcionalidades

- Cadastro de produtos
- Atualização de produtos
- Exclusão de produtos
- Listagem de produtos
- Pesquisa de produtos
- Registro de compras
- Adição de produtos ao carrinho
- Cálculo automático do total da compra
- Emissão de nota simples da venda

## 🧰 Tecnologias utilizadas

- C#
- Windows Forms
- Visual Studio
- MySQL
- GitHub

## 🖥️ Estrutura das telas

### Produtos

Tela responsável pelo cadastro e gerenciamento dos produtos do supermercado.

Nesta tela é possível cadastrar, consultar, atualizar e excluir produtos.

### Compras

Tela responsável pelo registro de uma nova compra.

Nela, o usuário pode selecionar produtos cadastrados, informar a quantidade desejada e adicionar os itens ao carrinho. O sistema calcula o subtotal dos itens e o valor total da compra.

### Nota de compra

Tela responsável por exibir o resumo da compra finalizada.

A nota apresenta os produtos comprados, suas quantidades, valores unitários, subtotais e o valor total da compra.

## 🗄️ Banco de dados

O sistema utiliza MySQL para armazenar os dados dos produtos e das compras.

O script SQL necessário para criação do banco e das tabelas está disponível no arquivo `tabelaProdutos.sql`.

## 🔧 Como configurar o banco de dados

1. Abra o MySQL na sua máquina.
2. Execute os comandos SQL do arquivo `tabelaProdutos.sql`.
3. Verifique se o banco e as tabelas foram criados corretamente.
4. No projeto, abra o arquivo `DbContext.cs`.
5. Altere a senha da string de conexão conforme a senha do seu banco local.

## ▶️ Como executar o projeto

1. Clone ou baixe este repositório.
2. Abra o projeto no Visual Studio.
3. Configure a conexão com o banco de dados no arquivo `DbContext.cs`.
4. Compile o projeto.
5. Execute a aplicação pelo Visual Studio.


