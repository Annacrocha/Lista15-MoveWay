using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoveWay_Lista15
{
    internal class Setores
    {
        List<Setores> listaSetores = new List<Setores>();
        private int id;
        private string nome;
        private string setor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public bool InserirSetor()
        {
            try
            {
                using MySqlConnection conexaoBanco = new conexaoBD().Conectar();
                {
                    string insert = "insert into setores (id, nome) values (@id, @nome)";

                    MySqlCommand comando = new MySqlCommand(insert, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int retorno = comando.ExecuteNonQuery();
                    if (retorno > 0)
                    {
                       // Console.WriteLine("Setor inserido com sucesso!");
                        return true;
                    }
                    else
                    {
                       // Console.WriteLine("Erro ao inserir setor.");
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir setor: " + ex.Message);
                return false;
            }
        }

        public bool AtualizarSetor()
        {
            try
            {
                using MySqlConnection conexaoBanco = new conexaoBD().Conectar();
                {
                    string update = "update setores set nome = @nome where id = @id";
                    
                    MySqlCommand comando = new MySqlCommand(update, conexaoBanco);
                    
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);
                   
                    int retorno = comando.ExecuteNonQuery();
                    if (retorno > 0)
                    {
                        // Console.WriteLine("Setor atualizado com sucesso!");
                        return true;
                    }
                    else
                    {
                        // Console.WriteLine("Erro ao atualizar setor.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar setor: " + ex.Message);
                return false;
            }
        }
        public bool ExcluirSetor()
        {
            try
            {
                using MySqlConnection conexaoBanco = new conexaoBD().Conectar();
                {
                    string delete = "delete from setores where id = @id";

                    MySqlCommand comando = new MySqlCommand(delete, conexaoBanco);

                    comando.Parameters.AddWithValue("@id", Id);

                    int retorno = comando.ExecuteNonQuery();
                    if (retorno > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir setor: " + ex.Message);
                return false;
            }
        }
        public List<Setores> ListarSetores()
        {
            try
            {
                using MySqlConnection conexaoBanco = new conexaoBD().Conectar();
                {
                    string select = "SELECT * FROM setores";

                    MySqlCommand comando = new MySqlCommand(select, conexaoBanco);

                    MySqlDataReader reader = comando.ExecuteReader();

                    List<Setores> setores = new List<Setores>();

                    while (reader.Read())
                    {
                        setores.Add(new Setores
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome")
                        });
                    }

                    return setores; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar setores: " + ex.Message);
                return null;
            }
        }
    }
}
