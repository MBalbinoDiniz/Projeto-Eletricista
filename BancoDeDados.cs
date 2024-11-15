using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEletricista
{
    public class BancoDeDados
    {
        private SqlConnection connection;

        public BancoDeDados()
        {
            // Substitua "SEU_SERVIDOR" e "SEU_BANCO" com o nome do seu servidor SQL Server e banco de dados.
            string connectionString = "Server=ACER-NITRO\\MSSQLSERVER01;Database=ProjetoEletricista;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            CriarTabelas();
        }

        public void TestarConexao()
        {
            try
            {
                AbrirConexao();
                Console.WriteLine("Conexão bem-sucedida!");
                FecharConexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco: " + ex.Message);
            }
        }

        // Método para abrir a conexão
        public void AbrirConexao()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Método para fechar a conexão
        public void FecharConexao()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Método para criar a tabela de histórico de cálculos
        public void CriarTabelas()
        {
            string queryTensao = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CalculoTensao' AND xtype='U')
            CREATE TABLE CalculoTensao (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Corrente FLOAT,
            Resistencia FLOAT,
            Tensao FLOAT,
            DataHora DATETIME
            );";

            string queryResistencia = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CalculoResistencia' AND xtype='U')
            CREATE TABLE CalculoResistencia (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Tensao FLOAT,
            Corrente FLOAT,
            Resistencia FLOAT,
            DataHora DATETIME
            );";

            string queryCorrente = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CalculoCorrente' AND xtype='U')
            CREATE TABLE CalculoCorrente (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Tensao FLOAT,
            Resistencia FLOAT,
            Corrente FLOAT,
            DataHora DATETIME
            );";

            AbrirConexao();
            using (SqlCommand command = new SqlCommand(queryTensao, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand(queryResistencia, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand(queryCorrente, connection))
            {
                command.ExecuteNonQuery();
            }
            FecharConexao();
            }

        // Método para inserir um cálculo no histórico
        public void InserirCalculoTensao(double corrente, double resistencia, double tensao)
        {
            string query = @"
        INSERT INTO CalculoTensao (Corrente, Resistencia, Tensao, DataHora)
        VALUES (@corrente, @resistencia, @tensao, @dataHora);";

            try
            {
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@corrente", corrente);
                    command.Parameters.AddWithValue("@resistencia", resistencia);
                    command.Parameters.AddWithValue("@tensao", tensao);
                    command.Parameters.AddWithValue("@dataHora", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir cálculo: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void InserirCalculoResistencia(double tensao, double corrente, double resistencia)
        {
            string query = @"
          INSERT INTO CalculoResistencia (Tensao, Corrente, Resistencia, DataHora)
          VALUES (@tensao, @corrente, @resistencia, @dataHora);";
            try
            { 
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tensao", tensao);
                    command.Parameters.AddWithValue("@corrente", corrente);
                    command.Parameters.AddWithValue("@resistencia", resistencia);
                    command.Parameters.AddWithValue("@dataHora", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir cálculo: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void InserirCalculoCorrente(double tensao, double resistencia, double corrente)
        {
            string query = @"
         INSERT INTO CalculoCorrente (Tensao, Resistencia, Corrente, DataHora)
         VALUES (@tensao, @resistencia, @corrente, @dataHora);";
            try
            { 
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tensao", tensao);
                    command.Parameters.AddWithValue("@resistencia", resistencia);
                    command.Parameters.AddWithValue("@corrente", corrente);
                    command.Parameters.AddWithValue("@dataHora", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir cálculo: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método para recuperar todos os cálculos do histórico
        public void RecuperarHistoricoTensao(Action<string> exibirResultado)
        {
            string query = "SELECT * FROM CalculoTensao";

            try
            {
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultado = $"{reader["DataHora"]}: Corrente: {((double)reader["Corrente"]).ToString("F2")}A, Resistencia: {((double)reader["Resistencia"]).ToString("F2")}Ω, Tensão: {((double)reader["Tensao"]).ToString("F2")}V";
                        exibirResultado(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao recuperar histórico: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void RecuperarHistoricoResistencia(Action<string> exibirResultado)
        {
            string query = "SELECT * FROM CalculoResistencia";

            try 
            { 
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultado = $"{reader["DataHora"]}: Tensão: {((double)reader["Tensao"]).ToString("F2")}V, Corrente: {((double)reader["Corrente"]).ToString("F2")}A, Resistência: {((double)reader["Resistencia"]).ToString("F2")}Ω";
                        exibirResultado(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao recuperar histórico: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void RecuperarHistoricoCorrente(Action<string> exibirResultado)
        {
            string query = "SELECT * FROM CalculoCorrente";

            try 
            { 
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultado = $"{reader["DataHora"]}: Tensão: {((double)reader["Tensao"]).ToString("F2")}V, Resistencia: {((double)reader["Resistencia"]).ToString("F2")}V, Corrente: {((double)reader["Corrente"]).ToString("F2")}A";
                        exibirResultado(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao recuperar histórico: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void LimparHistorico()
        {
            string query = "DELETE FROM CalculoTensao; DELETE FROM CalculoResistencia; DELETE FROM CalculoCorrente;";

            try
            {
                AbrirConexao();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao limpar o histórico: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
