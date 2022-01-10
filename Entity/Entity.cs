
namespace Entity
{
    public class Entity
    {
        #region "Field"
        string _file;
        string _Connection;

        
        #endregion

        #region "Property"
        public string File
        {
            get {
                if (!System.IO.File.Exists(_file))
                {
                   // System.Windows.Forms.MessageBox.Show("فایل اکسل در مسیر مورد نظر یافت نشد", "اخطار", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return "-1";
                }
                else
                {
                    return _file;
                }
            }
            set { _file = value; }
        }

        public string Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
        #endregion

    }
}
