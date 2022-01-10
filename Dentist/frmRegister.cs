using BLL;
using Entity;
using System;
using System.Windows.Forms;


namespace Dentist
{
    public partial class frmRegister : Form
    {
        #region "Fiald"

        BllClientele ObjCrud = new BllClientele();
        Document doc = new Document();
        int IsCommited = 0;
        
        bool _dataPopulated = false;
        int _docNO;
        bool _bolUpdate = false;

        public bool IsUpdate
        {
            get { return _bolUpdate; }
            set
            {
                _bolUpdate = value;
                if (_bolUpdate && DocumentNumber != 0)
                    _docNO = DocumentNumber;
            }
        }

        public int DocumentNumber
        {
            get
            {
                int i = 0;
                int.TryParse(txtDocNo.Text, out i);
                return i;
            }
            set
            {
                if (_bolUpdate)
                    _docNO = value;
                txtDocNo.Text = value.ToString();
            }
        }

        #endregion

        #region "Method"
        public frmRegister()
        {
            InitializeComponent();
            txtDocNo.Text = ObjCrud.GetMaxDocNumber().ToString();
        }

        private void ClearFields()
        {

            txtFather.Text = "";
            txtID.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPicNum.Text = "";
            txtMobile.Text = "";
            txtDec.Text = "ندارد";

            int i = 0;
            if (int.TryParse(txtDocNo.Text.Trim(), out i))
            {
                if (i != 0)
                {
                    txtDocNo.Text = (++i).ToString();
                    txtDocNo.Focus();
                    txtDocNo.SelectAll();
                }
                else
                    txtID.Focus();
            }

            txtPhoneNumber.Text = "";

        }

        public void LoadData(Document doc)
        {
            if (!_dataPopulated)
                _bolUpdate = true;
            _docNO = doc.DocNO;

            txtDocNo.Text = _docNO.ToString();

            txtID.Text = doc.NatCode;
            txtName.Text = doc.Name;
            txtLastName.Text = doc.Lastname;
            txtFather.Text = doc.Father;
            txtPicNum.Text = doc.PicNumber;
            txtPhoneNumber.Text = doc.Phonenumber;
            txtMobile.Text = doc.Mobile;
            txtDec.Text = doc.Dec;
            int i;
        }

        private void FillDocoument()
        {
            doc.DocNO = int.Parse(txtDocNo.Text);
            doc.NatCode = txtID.Text.Trim();
            doc.Name = txtName.Text.Trim();
            doc.Lastname = txtLastName.Text.Trim();
            doc.Father = txtFather.Text.Trim();
            doc.Phonenumber = txtPhoneNumber.Text;
            doc.Mobile = txtMobile.Text;
            doc.PicNumber = txtPicNum.Text.Trim();
            doc.Dec = txtDec.Text;
        }

        private void CheckCommited()
        {
            if (IsCommited == 0)
                MessageBox.Show("مشکلی در ثبت پرونده به وجود آمده است.");
            else
            {
                if (!_bolUpdate)
                {
                    DialogResult result = MessageBox.Show(string.Format("پرونده به شماره {0} ثبت شد", txtDocNo.Text), "", MessageBoxButtons.OK);
                    ClearFields();
                    btn_Cancel.Text = "خروج";
                }
                else
                {
                    DialogResult result = MessageBox.Show(string.Format("پرونده به شماره {0} بروز رسانی شد", _docNO), "", MessageBoxButtons.OK);
                    Close();
                }
            }
        }
        #endregion

        #region "Event"
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txtDocNo.Text.Trim().Length > 0)
                FillDocoument();

            if (!_bolUpdate)
                IsCommited = ObjCrud.InsertRow(doc);
            else
                IsCommited = ObjCrud.UpdateRow(_docNO, doc);

            CheckCommited();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion
    }
}
