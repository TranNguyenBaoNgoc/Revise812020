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
    public partial class CreateForm : Form
    {
        private LogicLayer Management;
        public CreateForm()
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += Create_Load;
        }

        void Create_Load(object sender, EventArgs e)
        {
            this.cbxClass.DataSource = this.Management.GetClasses();
            this.cbxClass.DisplayMember = "Classname";
            this.cbxClass.ValueMember = "Id";
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var gender = true;
            if (rdbFemale.Checked == true)
            {
                gender = false;
            }
            var birth = this.dtpBirthday.Value;
            var class_id = (int)this.cbxClass.SelectedValue;
            this.Management.CreateStudent(name, gender, birth, class_id);
            MessageBox.Show("Create successfully");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
