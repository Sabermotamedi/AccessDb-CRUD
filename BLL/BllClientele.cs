using System;
using System.Data;
using Entity;

namespace BLL
{
    public class BllClientele
    {
        public static DAL.DalClientele ObjDalClientele = new DAL.DalClientele();

        public DataTable dt = new DataTable();

        public DataTable Select(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                string str = @"SELECT [ID]                       
                              ,[Code_Melli]
                              ,[FirstName]
                              ,[LastName]
                              ,[FatherName]
                              ,[PICNumber]
                              ,[PhoneNumber]
                              ,[MobileNumber]
                              ,[Description]
                              
                              FROM [Clientele]";

                if (keyword.Trim().Length > 0)

                    if (keyword.Trim().Length > 0)
                    {
                        str += " Where ";
                        string[] parts = keyword.Split(' ');
                        foreach (string p in parts)
                        {
                            int i = 0;
                            str += string.Format("([FirstName] like '%{0}%' or [LastName] like '%{0}%' or [Code_melli] like '%{0}%' or [ID] like '%{0}%' ) and ", p, i);
                        }

                        if (str.Trim().Length > 5)
                        {
                            str = str.Substring(0, str.Length - 4);
                        }

                    }
                str += " order by [ID]";
                dt = ObjDalClientele.SelectByQuery(str);

                dt.Columns[0].ColumnName = "پرونده";
                dt.Columns[1].ColumnName = "کد ملی";
                dt.Columns[2].ColumnName = "نام";
                dt.Columns[3].ColumnName = "نام خانوادگی";
                dt.Columns[4].ColumnName = "نام پدر";
                dt.Columns[5].ColumnName = "شماره عکس";
                dt.Columns[6].ColumnName = "شماره تماس";
                dt.Columns[7].ColumnName = "شماره دوم تماس";
                dt.Columns[8].ColumnName = "توضیحات";
            }
            catch { }

           

            return dt;
        }
        
        public Document SelectUser(int i)
        {
            Document doc;
            doc = ObjDalClientele.GetUserDocument(i);
            return doc;
        }

        public int Delete(int docnum)
        {
            int i = ObjDalClientele.DeleteRow(docnum);
            return i;
        }

        public int GetMaxDocNumber()
        {
            return ObjDalClientele.GetMaxDocNumber();
        }

        public int InsertRow(Document doc)
        {
            int num = ObjDalClientele.InsertRow(doc);
            return num;

        }

        public int UpdateRow(int DocNO, Document doc)
        {
            int num = ObjDalClientele.UpdateRow(DocNO, doc);
            return num;
        }
    }
}
