using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Isql;
using System.Data;

namespace ClasseGenerator.Classes
{
    public class ClsBancoFirebird
    {
        private static FbConnection fbConn;
        public class DadosConexao
        {
            public string sDataSource { get; set; } = "localhost";
            public string sDatabase { get; set; }
            public string sUserName { get; set; } = "SYSDBA";
            public string sPassword { get; set; } = "masterkey";
            public string sCharset { get; set; } = "ISO8859_1";
        }

        public static void MontaStringConexao(string sdatasource, string sdatabase)
        {
            var sStringConexao = new DadosConexao();
            sStringConexao.sDataSource = sdatasource;
            sStringConexao.sDatabase = sdatabase;
            string sConex = $"DataSource={sStringConexao.sDataSource};Database={sStringConexao.sDatabase};" +
                $"username={sStringConexao.sUserName};password={sStringConexao.sPassword};" +
                $"Charset={sStringConexao.sCharset};Connection lifetime=2";
            fbConn = new FbConnection(sConex);
        }

        public class DadosTabela
        {
            public string sTable { get; set; }
            public DadosCampos[] DadosCampos { get; set; }

        }
        public class DadosCampos
        {
            public string sPK { get; set; }
            public string sFK { get; set; }
            public string sUNQ { get; set; }
            public string sName { get; set; }
            public string sTipe { get; set; }
            public string sDomian { get; set; }
            public string sSize { get; set; }
            public string sNotNull { get; set; }
            public string sDescription { get; set; }
        }

        public static bool TestaConecao(string sdatasource, string sdatabase)
        {
            MontaStringConexao(sdatasource, sdatabase);
            try
            {
                fbConn.Open();
                {
                    if (fbConn.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    {
                        fbConn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataSet FU_ListaTabelas(string sdatasource, string sdatabase)
        {
            string sScript = " "; 
            DataSet DS = new DataSet();
            if (TestaConecao(sdatasource, sdatabase))
            {
                FbCommand cmd = new FbCommand(sScript, fbConn);
                FbDataAdapter DA = new FbDataAdapter(cmd);
                try
                {
                    fbConn.Open();
                    DA.Fill(DS);
                    fbConn.Close();
                    return DS;
                }
                catch 
                {
                    fbConn.Close();
                    return DS;
                }
                finally
                {
                    fbConn.Close();
                }
            }
            else
            {
                DS = null;
                return DS;
            }
        }

        public static DataSet FU_ListaCampos(string sdatasource, string sdatabase, string sTabela)
        {
            string sScript = $"SELECT RR.rdb$field_name AS \"Nome_Campo\", " +
               "RR.RDB$RELATION_NAME AS \"Nome_Tabela\", " +
               "RF.RDB$FIELD_LENGTH AS \"Tamanho\", " +
               "CASE RF.RDB$FIELD_TYPE " +
               "WHEN 261 THEN 'BLOB' " +
               "WHEN 14 THEN 'CHAR' " +
               "WHEN 40 THEN 'CSTRING' " +
               "WHEN 11 THEN 'D_FLOAT' " +
               "WHEN 27 THEN 'DOUBLE' " +
               "WHEN 10 THEN 'FLOAT' " +
               "WHEN 16 THEN 'INT64' " +
               "WHEN 8 THEN 'INTEGER' " +
               "WHEN 9 THEN 'QUAD' " +
               "WHEN 7 THEN 'SMALLINT' " +
               "WHEN 12 THEN 'DATE' " +
               "WHEN 13 THEN 'TIME' " +
               "WHEN 35 THEN 'TIMESTAMP' " +
               "WHEN 37 THEN 'VARCHAR' " +
               "ELSE 'UNKNOWN' " +
               "END AS \"Tipo\" " +
               "FROM RDB$RELATION_FIELDS RR " +
               "join RDB$FIELDS RF ON RR.RDB$FIELD_SOURCE = RF.RDB$FIELD_NAME " +
               $"WHERE RR.RDB$RELATION_NAME='{sTabela}'";
            DataSet DS = new DataSet();
            if (TestaConecao(sdatasource, sdatabase))
            {
                FbCommand cmd = new FbCommand(sScript, fbConn);
                FbDataAdapter DA = new FbDataAdapter(cmd);
                try
                {
                    fbConn.Open();
                    DA.Fill(DS);
                    fbConn.Close();
                    return DS;
                }
                catch (Exception ex)
                {
                    fbConn.Close();
                    return DS;
                }
                finally
                {
                    fbConn.Close();
                }

            }
            else
            {
                DS = null;
                return DS;
            }
        }
    }
}
