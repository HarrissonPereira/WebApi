/* 1. Quais alterações devemos fazer nessa estrutura para que o cliente consiga fazer mais de um serviço por solicitação?
Remover o ID Serviço da tabela Ordem de Serviço e criar uma nova tabela para relacionar o Serviço com a Ordem de Serviço.
Com essa nova tabela, teremos 'ID Serviço' e 'ID Ordem de Serviço', pois assim poderemos ter quantos serviços quisermos referenciando a mesma Ordem de Serviço.
Também cria-se uma coluna 'Quantidade' para incrementar cada vez que um serviço tiver ligação com a Ordem de Serviço e quando um serviço for selecionado.

===== Tabelas =====

Clientes			Serviços				Ordem de Serviços		Serviços Solicitados
ID (AI)				ID(AI)					ID(AI)					ID Ordem de Serviço
Nome				Nome Servico			ID Cliente				ID Serviço
Email				Valor Final				Data Contratação		
Data Nascimento		QuantidadeSolicitada	Data Execução
Telefone Celular							Quantidade Serviços
Telefone Casa */

-- A.  Selecione todos os clientes e a quantidade de ordem de serviços realizados.
select clientes.*,ordemservicos.* from clientes inner join ordemservicos on ordemservicos.id_cliente = clientes.id;

-- B.  Selecione todas as Ordens de Serviços com mais de um serviço 
select * from ordemservicos where ordemservicos.quantidadeservicos > 1;

-- C. Selecione os serviços mais vendidos
select * from servicos order by quantidadeselecionada desc;

-- D. Atualize o valor final de todos os serviços em 12%
update servicos set valorfinal = valorfinal+(valorfinal*0.12);

-- E. Remova a última ordem de serviço criada
-- Necessário remover de Serviços solicitados primeiro, devido a chave estrangeira.
delete from servicossolicitados where id_ordemservico = (select id from ordemservicos where datacontratacao = (select max(datacontratacao) from ordemservicos));
delete from ordemservicos where id = (select id where datacontratacao = (select max(datacontratacao)));

-- F. Insira um cliente
insert into clientes (nome, email, datanascimento, telefonecelular, telefoneresidencial) values ("Harrisson Pereira","pereiraharrisson@gmail.com",'1993-06-10', 31999251286, 3133123456);
