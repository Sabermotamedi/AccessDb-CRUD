using System.Data;
using System.Data.OleDb;
using System.IO;
using MessageManager;

namespace DAL
{
    public class DALMain
    {

        MsgMngr ObjMsg = new MsgMngr();
        private static string Address = Properties.Settings.Default.SourceFile;

        private static string ConnectionString = string.Format(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}", Address);

        public DALMain()
        {
            Attrib(Address);
        }

        #region ExecuteNoneQuery
        public int ExecuteNoneQuery(string commandText, params OleDbParameter[] CommandParams)
        {
            try
            {
                OleDbConnection MyConnection;
                OleDbCommand MyCommand = new OleDbCommand();
                MyConnection = new OleDbConnection(ConnectionString);
                MyCommand.Connection = MyConnection;
                MyCommand.Parameters.AddRange(CommandParams);
                MyCommand.CommandText = commandText;
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();

                return 1;
            }
            catch (System.Exception ex)
            {
                ObjMsg.ShowExection(ex.ToString());
                return 0;
            }
        }
        #endregion

        #region ExecuteDataAdapter
        public DataTable ExecuteDataAdapter(string commandText)
        {
            try
            {
                var dt = new DataTable();
                OleDbConnection MyConnection;
                OleDbDataAdapter MyCommand;
                MyConnection = new OleDbConnection(ConnectionString);
                MyCommand = new OleDbDataAdapter(commandText, MyConnection);
                MyCommand.Fill(dt);
                MyConnection.Close();
                return dt;
            }
            catch (System.Exception ex)
            {
                ObjMsg.ShowExection(ex.ToString());

                return null;
            }

        }
        #endregion

        private void Attrib(string address)
        {
            string patch;
            patch = address;

            if (File.Exists(patch))
            {
                FileAttributes attributes = File.GetAttributes(patch);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    FileInfo fileInfo = new FileInfo(patch);
                    fileInfo.IsReadOnly = false;
                }
            }
        }
    }
}
