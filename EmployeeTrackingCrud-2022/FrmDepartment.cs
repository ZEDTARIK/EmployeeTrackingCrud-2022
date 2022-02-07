using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace EmployeeTrackingCrud_2022
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmListDepartment frmListDepartment = new FrmListDepartment();
            this.Visible = false;
            frmListDepartment.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmListDepartment frmListDepartment = new FrmListDepartment();

            if (txtDepartment.Text.Trim() == "")
                MessageBox.Show("Please Fill The input Filed");
            else
            {
                Department department = new Department();
                department.DepartmentName = txtDepartment.Text.Trim();
                DepartmentBLL.addDepartment(department);
                MessageBox.Show("New Department Was Inserted SuccessFully");
                txtDepartment.Text = "";
                
                this.Visible = false;
                frmListDepartment.Visible = true;
            }
        }
    }
}
