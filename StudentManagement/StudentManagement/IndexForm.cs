using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class IndexForm : Form
    {
        private LogicLayer Management;
        public IndexForm()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.BtnCreate.Click += BtnCreate_Click;
            this.BtnDelete.Click += BtnDelete_Click;
            this.Load += IndexForm_Load;
            this.grdStudent.DoubleClick += grdStudent_DoubleClick;
        }

        void grdStudent_DoubleClick(object sender, EventArgs e)
        {
            var stu = (View)this.grdStudent.SelectedRows[0].DataBoundItem;
            var update = new UpdateForm(stu.ID);
            update.ShowDialog();
            this.LoadAll();
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAll();
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdStudent.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    var stu = (View)this.grdStudent.SelectedRows[0].DataBoundItem;
                    this.Management.DeleteStudent(stu.ID);
                    MessageBox.Show("Delete successfully");
                    this.LoadAll();
                }
            }
        }

        void BtnCreate_Click(object sender, EventArgs e)
        {
            var create = new CreateForm();
            create.ShowDialog();
            this.LoadAll();
        }

        private void LoadAll()
        {
            var stu = this.Management.getStudents();
            var stuView = new View[stu.Length];
            for (int i = 0; i < stuView.Length; i++)
            {
                stuView[i] = new View(stu[i]);
            }
            this.grdStudent.DataSource = stuView;
        }
    }
}
