# **📌 Passo a Passo do Projeto**

## **1️⃣ Construção da Interface dos Contatos (Sem Banco de Dados)**
1. Editar a **view `Index.cshtml`** para exibir a **tabela de contatos**. (feito)
   - Escolher um modelo de **tabela Bootstrap**. (feito)
   - Adicionar colunas para os dados dos contatos. (feito)
   - Criar pelo menos **dois contatos de exemplo** na tabela. (feito)
   - Adicionar um **botão “Adicionar Contato”** no canto superior direito. (feito)
   - Adicionar **ícones de editar e excluir** ao lado de cada contato. (feito)
2. Criar uma **view para adicionar um novo contato**. (feito)
3. Criar uma **view para editar um contato existente**. (feito)
4. Criar uma **view para excluir um contato existente** (pode ser um modal de confirmação).  (feito)

---

## **2️⃣ Criação da Classe `Participante`**
1. Criar a **classe `Contato`**.
2. Definir os atributos necessários para a classe.

---

## **3️⃣ Criar os Controllers dos Contatos**
1. Criar o **controller `ContatoController`**. (feito)
2. Implementar os métodos de redirecionamento entre as views (Criar, Editar, Excluir). (feito)
3. Testar a navegação entre as páginas. (feito)

---

## **4️⃣ Persistência dos Contatos no Banco de Dados (Entity Framework)**
1. Criar a **classe `Contato`** com os atributos necessários. (feito)
2. Criar a **classe `AppDbContext`** para gerenciar a conexão com o banco. (feito)
3. Configurar a **conexão com o banco de dados** no `appsettings.json`. (feito)
4. Criar as **interfaces e repositórios** para gerenciar os contatos. (feito)
5. Implementar os **métodos de CRUD** no `ContatoController`. (feito)
6. Atualizar a view para exibir os contatos do banco **dinamicamente** com `@model`. (feito)

---

## **5️⃣ Exibição Dinâmica dos Contatos**
1. **Atualizar a tabela** para exibir os contatos usando `@model`. (feito)
2. Testar as funcionalidades de **adicionar, editar e remover** contatos **dinamicamente**. 
3. Garantir que **não há redirecionamentos desnecessários**.

---

## **6️⃣ Implementação do Calendário**
1. Adicionar o **calendário** à página inicial (acima dos contatos).
2. Escolher uma **biblioteca de calendário** (ex: FullCalendar).
3. Garantir que o calendário é exibido corretamente.

---

## **7️⃣ Funcionalidades dos Eventos**
1. Criar um **pop-up** para adicionar um evento ao clicar em um dia do calendário.
2. Ao clicar em um evento já criado, exibir **uma caixa de detalhes** com:
   - Nome do evento
   - Data e horário
   - Descrição
   - Botões **Editar** e **Excluir**
3. Criar um pop-up de **edição de evento**.
4. Criar um pop-up de **confirmação de exclusão**.
5. Implementar **fechamento das caixas** ao clicar fora ou no botão `X`.

---

## **8️⃣ Criar o Controller e Classe dos Eventos**
1. Criar a **classe `Evento`** com os atributos necessários.
2. Criar o **controller `EventoController`** para gerenciar os eventos.
3. Implementar os métodos de navegação entre as views.

---

## **9️⃣ Persistência dos Eventos no Banco de Dados**
1. Configurar a **classe `Evento`** no banco de dados.
2. Criar os **repositórios e interfaces** para gerenciar os eventos.
3. Implementar os **métodos de CRUD** no `EventoController`.
4. Exibir os eventos cadastrados no **calendário dinamicamente**.

---

## **🔟 Implementação da Confirmação de Exclusão**
1. Adicionar **mensagem de confirmação** ao excluir um evento.
2. Se clicar em **"Apagar"**, remover o evento e atualizar a tela.
3. Se clicar em **"Cancelar"**, voltar à caixa de descrição do evento.

---

## **1️⃣1️⃣ Implementação do Menu**
1. Criar o **menu principal** com links para diferentes páginas.
2. Criar **sub-menus** dentro do Menu.
3. Criar os botões **"Menu" e "Aplicações"** no footer, que ao clicar exibem as listas de redirecionamento.

---

## **1️⃣2️⃣ Implementação do Footer**
1. No lado **direito**, adicionar:
   - Texto “Menu” e “Aplicações”, com listas ao serem clicados.
2. No lado **esquerdo**, adicionar:
   - Uma **imagem** + um **parágrafo** descritivo.
3. Adicionar **informações sobre o site e data de criação**.

---

✅ **Focar no funcionamento das páginas antes da persistência dos dados**.  
✅ **Testar cada etapa antes de seguir para a próxima**.  
✅ **Usar Bootstrap para criar uma interface bonita e responsiva**.  
✅ **Ao integrar com o banco, usar migrações para criar e atualizar as tabelas automaticamente**.