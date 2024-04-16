using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaCadastro
{
    public class ConexaoBanco
    {
        public SqlConnection mConexao;
        public ConexaoBanco()
        {
            //Ref da Conexão
            mConexao = new SqlConnection(@"Data Source=LEONARDO-NOTEAC\MSSQLSERVER02;Initial Catalog=Banco_Leo;Integrated Security=True".ToString());
            mConexao.Open();
            mConexao.Close();

        }

        public DataTable RetornaDados(string lstrSQL)
        {
            //Inicializando as variaveis
            SqlCommand mobjSQLDataCommand = new SqlCommand(lstrSQL, mConexao);
            mobjSQLDataCommand.CommandTimeout = 0;
            SqlDataAdapter mobjSQLDataAdapter = new SqlDataAdapter(mobjSQLDataCommand);
            DataTable mobjDataTable = new DataTable("RESULTADO");

            try
            {
                //Tentando estabelecer a conexão e executar a query
                mobjSQLDataAdapter.Fill(mobjDataTable);
                //Valor Retorno
                return mobjDataTable;
            }
            catch (Exception ex)
            {
                //Relançando a Exception
                throw new Exception(ex.Message);
            }
            finally
            {
                //Desaloca objetos
            }
        }

        //public void RetornaDados()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void RetornaDados()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object RetornaDados()
        //{
        //    throw new NotImplementedException();
        //}
    }


}