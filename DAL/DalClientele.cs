using Entity;
using System;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class DalClientele
    {
        DALMain ObjDalMain = new DALMain();
        public DataTable SelectByQuery(string Query)
        {
            DataTable dt = ObjDalMain.ExecuteDataAdapter(Query);
            if (dt != null || dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public int GetMaxDocNumber()
        {
            DataTable dt = ObjDalMain.ExecuteDataAdapter("select MAX([ID]) from [Clientele]");
            if (dt != null && dt.Rows.Count > 0)
                return (Convert.ToInt32(dt.Rows[0][0])) + 1;
            return 0;
        }

        public Document GetUserDocument(int ID)
        {
            string Query = @"SELECT [ID]
                              
                              ,[Code_melli]
                              ,[FirstName]
                              ,[LastName]
                              ,[FatherName]
                              ,[PICNumber]
                              ,[PhoneNumber]
                              ,[MobileNumber]
                              ,[Description]
                              ,[Created_at]     
                              ,[Updated_at]
                              
                              FROM [Clientele] where [ID] = " + ID + " ";
            var ObjDocument = new Document();
            DataTable dt = ObjDalMain.ExecuteDataAdapter(Query);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ObjDocument.DocNO = (int)dr["ID"];
                ObjDocument.NatCode = dr["Code_melli"].ToString().Trim();
                ObjDocument.Name = dr["FirstName"].ToString().Trim();
                ObjDocument.Lastname = dr["LastName"].ToString().Trim();
                ObjDocument.Father = dr["FatherName"].ToString().Trim();
                ObjDocument.PicNumber = dr["PICNumber"].ToString().Trim();
                ObjDocument.Phonenumber = dr["PhoneNumber"].ToString().Trim();
                ObjDocument.Mobile = dr["MobileNumber"].ToString().Trim();
                ObjDocument.Dec = dr["Description"].ToString().Trim();
            }
            return ObjDocument;

        }

        public int InsertRow(Document doc)
        {

            string Query = @"INSERT INTO [Clientele]
                               ( [ID]
                                ,[Code_Melli]
                                ,[FirstName]
                                ,[LastName]
                                ,[FatherName]
                                ,[PICNumber]
                                ,[PhoneNumber]
                                ,[MobileNumber]
                                ,[Description]
                                ,[Created_at]
                                ,[Updated_at]) VALUES 
                                (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@10,@11)";

            int dt = ObjDalMain.ExecuteNoneQuery(Query, new OleDbParameter[] { new OleDbParameter("@p1", doc.DocNO),
            new OleDbParameter("@p2", doc.NatCode),
            new OleDbParameter("@p3", doc.Name),
            new OleDbParameter("@p4", doc.Lastname),
            new OleDbParameter("@p5", doc.Father),
            new OleDbParameter("@p6", doc.PicNumber),
            new OleDbParameter("@p7", doc.Phonenumber),
            new OleDbParameter("@p8", doc.Mobile),
            new OleDbParameter("@p9", doc.Dec),
            new OleDbParameter("@p10", doc.Created_at),
            new OleDbParameter("@p11", doc.Updateed_at) });

            if (dt == 1)
                return 1;
            return 0;
        }

        public int UpdateRow(int ID, Document doc)
        {
            string Query = @"UPDATE [Clientele]
                             SET [ID] = @p1
                            ,[Code_melli] = @p2
                            ,[FirstName] = @p3
                            ,[LastName] = @p4
                            ,[FatherName] = @p5
                            ,[PICNumber]= @p6
                            ,[PhoneNumber] = @p7
                            ,[MobileNumber] = @p8
                            ,[Description] = @p9
                            ,[Created_at] = @p10
                            ,[Updated_at] = @p11
                             WHERE [ID] =  " + ID.ToString() + " ";
            int dt = ObjDalMain.ExecuteNoneQuery(Query, new OleDbParameter[] {

            new OleDbParameter("@p1", doc.DocNO),
            new OleDbParameter("@p2", doc.NatCode),
            new OleDbParameter("@p3", doc.Name),
            new OleDbParameter("@p4", doc.Lastname),
            new OleDbParameter("@p5", doc.Father),
            new OleDbParameter("@p6", doc.PicNumber),
            new OleDbParameter("@p7", doc.Phonenumber),
            new OleDbParameter("@p8", doc.Mobile),
            new OleDbParameter("@p9", doc.Dec),
            new OleDbParameter("@p10", doc.Created_at),
            new OleDbParameter("@p11", doc.Updateed_at) });
            if (dt == 1)
                return 1;
            return 0;

        }

        public int DeleteRow(int ID)
        {
            string sql = @"DELETE FROM [Clientele]
                               WHERE [ID] =  " + ID.ToString() + " ";

            int dt = ObjDalMain.ExecuteNoneQuery(sql);
            if (dt == 1)
                return 1;
            return 0;
        }
    }
}
