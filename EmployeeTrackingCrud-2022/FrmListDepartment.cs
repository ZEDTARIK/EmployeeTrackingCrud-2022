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
    public partial class FrmListDepartment : Form
    {
        List<Department> list = new List<Department>();

        public FrmListDepartment()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            this.Visible = false;
            frmDepartment.Visible = true;
        }

        private void FrmListDepartment_Load(object sender, EventArgs e)
        {

            list = BLL.DepartmentBLL.getDepartments();
            dataGridViewOfDepartment.DataSource = list;
            dataGridViewOfDepartment.Columns[0].HeaderText = "Department Id";
            dataGridViewOfDepartment.Columns[1].HeaderText = "Department Name";
        }
    }
}
