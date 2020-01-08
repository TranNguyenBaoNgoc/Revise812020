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
    public partial class UpdateForm : Form
    {
        private int stu_id;
        private LogicLayer Management;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.Management = new LogicLayer();
            this.stu_id = id;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var stu = this.Management.GetStudent(stu_id);
            this.txtName.Text = stu.FULLNAME;
            this.rdbFemale.Checked = true;
            if (stu.GENDER == true)
            {
                this.rdbMale.Checked = true;
            }
            this.dtpBirthday.Value = stu.BIRTHDAY;
            this.cbxClass.DataSource = this.Management.GetClasses();
            this.cbxClass.DisplayMember = "Classname";
            this.cbxClass.ValueMember = "Id";
            this.cbxClass.SelectedValue = stu.CLASS_ID;
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
            this.Management.UpdateStudent(this.stu_id, name, gender, birth, class_id);
            MessageBox.Show("Update successfully");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
