using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Dropbox.Api;
using System.Threading.Tasks;
using Entity;
using BLL;


namespace Dentist
{
    public partial class Form1 : Form
    {
        BllClientele ObjCrud = new BllClientele();
        PersianDate PersianDate = new PersianDate(DateTime.Now);
        MessageManager.MsgMngr MessageManager = new MessageManager.MsgMngr();
        public Form1()
        {
            InitializeComponent();
        }

        static async Task Run()
        {
            using (var dbx = new DropboxClient("YOUR ACCESS TOKEN"))
            {
                var full = await dbx.Users.GetCurrentAccountAsync();
                Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);
            }
        }

        async Task Upload(DropboxClient dbx, string folder, string file, string content)
        {
            using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                var updated = await dbx.Files.UploadAsync(
                    folder + "/" + file,
                    //WriteMode.Overwrite.Instance,
                    body: mem);
                Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblClock.Text = string.Format("امروز: {0} {1}", PersianDate.DayOfWeek, PersianDate.ToShortDateString());

            var user = new Users();
            if (user.User == null)
            {
                frmSplash frm = new frmSplash();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    dgv.DataSource = ObjCrud.Select(string.Empty);  // DAL.GetDocuments(txtSearch.Text.Trim());
                    Resize_DGV(dgv);
                    lblUser.Text = "کاربر: " + frm.User.User;
                    lblAvailableNumbers.Text = "آخرین شماره قابل ثبت :" + ObjCrud.GetMaxDocNumber().ToString();

                    this.Enabled = true;
                    this.WindowState = FormWindowState.Maximized;
                    ChangtoPersian();
                }
                else
                    this.Close();
            }
        }

        private void ChangtoPersian()
        {

            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        public void Resize_DGV(DataGridView dgv)
        {
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[0].Width = 50;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[1].Width = 00;
            dgv.Columns[1].Visible = false;



            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[2].Width = 150;


            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[3].Width = 150;


            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[4].Width = 150;


            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[5].Width = 100;


            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[6].Width = 100;


            dgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[7].Width = 150;

        }

        private void EditProfile()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmRegister frm = new frmRegister();
                frm.IsUpdate = true;
                int i = 0;
                if (int.TryParse(dgv.SelectedRows[0].Cells[0].Value.ToString(), out i))
                {
                    Document doc = ObjCrud.SelectUser(i);
                    if (doc != null)
                    {
                        string mem = dgv.SelectedRows[0].Cells[1].Value.ToString();
                        frm.LoadData(doc);
                        frm.ShowDialog();


                        dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());
                        lblAvailableNumbers.Text = "آخرین شماره قابل ثبت :" + ObjCrud.GetMaxDocNumber().ToString();

                        foreach (DataGridViewRow r in dgv.Rows)
                        {
                            if (Convert.ToInt32(r.Cells[0].Value) == frm.DocumentNumber)
                            {
                                dgv.CurrentCell = dgv.Rows[r.Index].Cells[0];
                                dgv.FirstDisplayedScrollingRowIndex = r.Index;
                                break;
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show(" ");
        }

        private void DeleteProfile()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ObjCrud.Delete(int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ثبتپروندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());

        }

        private void حذفپروندهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteProfile();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void makeXSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help frm = new Help();
            frm.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());
                lblAvailableNumbers.Text = "آخرین شماره قابل ثبت :" + ObjCrud.GetMaxDocNumber().ToString();
            }

            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Clear();
                dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());
            lblAvailableNumbers.Text = "آخرین شماره قابل ثبت :" + ObjCrud.GetMaxDocNumber().ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgv.DataSource = ObjCrud.Select(txtSearch.Text.Trim());
        }

        private void BackUpBtn_Click(object sender, EventArgs e)
        {
            var ObjFolderBrowser = new FolderBrowserDialog();
            if (DialogResult.OK == ObjFolderBrowser.ShowDialog())
            {
                var ObjSourcefile = new PresentDB();
                try
                {
                    string destination = ObjFolderBrowser.SelectedPath.ToString() + "\\Backup" + PersianDate.Year + "-" + PersianDate.Month + "-" + PersianDate.Day;
                    string destinationFile = PersianDate.Year + "-" + PersianDate.Month + "-" + PersianDate.Day + ".accdb";
                    Directory.CreateDirectory(destination);

                    File.Copy(ObjSourcefile.FullName, (destination) + "\\Backup" + destinationFile, true);
                    MessageManager.ShowMng(GeneralEnum.Msg.SuccesBackUp);

                    Process.Start(@destination);
                }
                catch (Exception)
                {
                    MessageManager.ShowMng(GeneralEnum.Msg.FailedBackUp);
                }
            }
        }

        private void btnDropBoxBackup_Click(object sender, EventArgs e)
        {

        }

        private void خذفپروندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageManager.ShowMng(GeneralEnum.Msg.DeleteAlert) == DialogResult.Yes)
            {
                int i = 0;
                if (dgv.SelectedRows.Count > 0)
                {
                    int.TryParse(dgv.SelectedRows[0].Cells[0].Value.ToString(), out i);
                    ObjCrud.Delete(i);
                    RefreshDataGridView();
                    MessageBox.Show("فایل مورد نظر پاک شد");
                }
            }
        }

        private void RefreshDataGridView()
        {
            dgv.DataSource = ObjCrud.Select(string.Empty);
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Add this
                dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Can leave these here - doesn't hurt
                dgv.Rows[e.RowIndex].Selected = true;
                dgv.Focus();
            }
        }
    }
}
