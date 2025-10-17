using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTapNhom
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;
        private string _username;
        private string _role;
        public FrmMain(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void xácThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblTitle
                .Text = "Xin chào, " + _username + " (" + _role + ")";
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentManagement frmStudentManagement = new FrmStudentManagement();
            frmStudentManagement = new FrmStudentManagement();
            frmStudentManagement.Show();
            this.Hide();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccount
                FrmAccount = new FrmAccount();
            FrmAccount = new FrmAccount();
            FrmAccount.Show();
            this.Hide();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClass
                FrmClass = new FrmClass();
            FrmClass = new FrmClass();
            FrmClass.Show();
            this.Hide();
        }

        private void quảnLýPhụHuynhHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParent
                FrmParent = new FrmParent();
            FrmParent = new FrmParent();
            FrmParent.Show();
            this.Hide();
        }

        private void quảnLýVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRole
                FrmRole = new FrmRole();
            FrmRole = new FrmRole();
            FrmRole.Show();
            this.Hide();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubject
                FrmSubject = new FrmSubject();
            FrmSubject = new FrmSubject();
            FrmSubject.Show();
            this.Hide();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherManagement
                FrmTeacherManagement = new FrmTeacherManagement();
            FrmTeacherManagement = new FrmTeacherManagement();
            FrmTeacherManagement.Show();
            this.Hide();
        }
    }
}
