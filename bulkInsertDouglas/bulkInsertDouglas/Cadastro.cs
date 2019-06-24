using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace BulkInsert
{

    public class Cadastro
    {
        readonly Conexao connect = new Conexao();
        private readonly List<PedidoMestre> LstPedidos = new List<PedidoMestre>();

        public void inserir()
        {
            try
            {
                Console.WriteLine("Início for, Tempo: " + DateTime.Now);
                for (int i = 0; i < 40000; i++)
                {
                    LstPedidos.Add(new PedidoMestre());
                }
                Console.WriteLine("saiu do for , Tempo: " + DateTime.Now);
                using (var connection = new SqlConnection(connect.con.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    using (var bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                    {
                        bulkCopy.BatchSize = 13000;
                        bulkCopy.DestinationTableName = "dbo.PedidoMestre";
                        try
                        {
                            Console.WriteLine("Tentando inserir , quantidade: " + bulkCopy.BatchSize + "tempo: " + DateTime.Now);

                            DataTable dt = new DataTable();
                            dt = LstPedidos.AsDataTable();

                            foreach (DataColumn clmn in dt.Columns)
                            {
                                bulkCopy.ColumnMappings.Add(clmn.ColumnName, clmn.ColumnName);
                            }
                                                       

                            bulkCopy.WriteToServer(dt);
                            transaction.Commit();

                            Console.WriteLine("Finalizado" + bulkCopy.BatchSize + "tempo: " + DateTime.Now);
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                            transaction.Rollback();
                            connection.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.desconectar();
            }
        }                     

    }
}
