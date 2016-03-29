using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace naoFazSentido.Banco
{
    class AcessoBancoDados
    {
        //Conjunto de Atributos da Classe

        //Atributo para guardar a conexão com o banco de dados
        private MySqlConnection conn;

        //Atributo para guardar uma tabela de dados
        private DataTable data;

        //Atributo para auxiliar a conversão de dados no formato adaptado ao formato genérico de dados do ADO.net que é o DataTable
        private MySqlDataAdapter da;

        //Atributos para a conexão com o Banco de Dados
        private String server = "192.168.2.250"; //Servidor, pode ser tanto a sua máquina local quanto um servidor de verdade
        private String user = "pinovacao"; //Usuário do banco de dados
        private String password = "senai"; //Senha do usuário para acessar o banco de dados
        private String database = "Car"; //Banco de Dados


        //Operações da Camada de Dados

        //Procedimento para estabelecer a conexão com o Banco de Dados
        public void Conectar()
        {
            /*Verifica se o objeto conexão "conn" está em memória. Caso positivo, efetua-se o fechamento da conexão 
            com o banco de dados, pois toda operação executa a conexão e não é permitido abrir uma conexão que já está aberta.
             */
            if (conn != null)
                conn.Close();

            //Cria a variável "connStr" com a String de Conexão (informações necessárias para que o MySQL consiga estabeler uma conexão com algum banco de dados
            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);

            //Tratamento de Exceção padrão para tentar estabelecer a conexão com o banco
            try
            {
                //Concretiza a criação do objeto "conn". Observe o uso da palavrinha "new".
                //Observe a passagem do parâmetro "connStr" para o construtor da classe "MySqlConnection"
                conn = new MySqlConnection(connStr);
                conn.Open(); //Invoca o método "Open()" da classe "MySqlConnection"
            }
            catch (MySqlException ex) //Se chegar aqui é porque a conexão não pôde ser estabelecida e uma exceção do tipo MySqlException será exibida
            {
                throw new Exception(ex.Message);
            }
        }

        //Procedimento para executar um comando SQL no Banco de Dados
        //Os comandos permitidos são: INSERT, UPDATE e DELETE 
        public void ExecutarComandoSQL(string comandoSql)
        {
            //Concretiza a criação do objeto "comando"
            //Observe a passagem de dois parâmetros para o construtor da classe "MySqlCommand".
            //O primeiro parâmetro representa o comando a ser executado, já o segundo representa a conexão pela qual o comando vai passar
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery(); //Chama o método "ExecuteNonQuery()" da classe "MySqlCommand" para execução do comando
            conn.Close(); //Garante o fechamento da conexão com o banco de dados
        }

        //Função responsável pelo retorno de um objeto "DataTable" (tabela de dados) dado que um comando SQL é passado como parâmetro
        //NOTA: Aqui só pode chegar comando do tipo SELECT
        public DataTable RetDataTable(string sql)
        {
            //Como a função retorna um objeto DataTable, precisamos garantir um objeto que será retornado.
            //Concretiza-se a criação do objeto "data" do tipo DataTable
            data = new DataTable();

            //Concretiza a criação do objeto "da". Observe que os parâmetros "sql" e "conn" são passados para o construtor da classe "MySqlDataAdapter"
            da = new MySqlDataAdapter(sql, conn);

            //Preenche o objeto "data" com os dados que estão no objeto "da"
            da.Fill(data);

            //Retorna o objeto "data" já preenchido
            return data;
        }

        //Função responsável pelo retorno do objeto MySqlDataReader dado que um comando "SELECT" é enviado
        public MySqlDataReader RetDataReader(string sql)
        {
            //Concretiza a criação do objeto "comando" 
            //Observe que os parâmetros "sql" e "conn" são passados para o construtor da classe "MySqlCommand"
            MySqlCommand comando = new MySqlCommand(sql, conn);

            //Agora que o objeto "comando" está criado, basta executá-lo de modo que ele retorno um objeto do tipo "MySqlDataReader" 
            //Observe a criação e ao mesmo tempo a atribuição de valor para o objeto dr
            MySqlDataReader dr = comando.ExecuteReader();

            //O objeto precisa ser lido para liberar seu uso
            dr.Read();

            //Retorno do objeto "dr" já preenchido
            return dr;
        }
    }
}
