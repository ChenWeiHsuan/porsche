using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訂便當系統
{
    public partial class Student : BaseForm
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            var classroom = db.Classroom.Select(x => new
            {
                x.Class_Id,
                x.Class_Name
            }).ToList();// 轉換成List 

            cbClass.DataSource = classroom;
            cbClass.DisplayMember = "Class_Name"; //Key 
            cbClass.ValueMember = "Class_Id"; //Value
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Class = cbClass.SelectedIndex;//抓到筆數  0.1.2類似陣列
            var StudentName = db.Student.Where(x => x.Class_Id == Class).Select(x => new
            {
                x.Student_Id,
                x.Student_Name
            }).ToList();

            cbName.DataSource = StudentName;
            cbName.DisplayMember = "Student_Name";
            cbName.ValueMember = "Student_Id";
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stdClass = (int)cbClass.SelectedValue; // 抓到資料庫id
            var StdName = db.Student.Where(x => x.Class_Id == stdClass).Select(x => new
            {
                x.Student_Phone,
                x.Student_Address
            }).First();

            tbPhone.Text = StdName.Student_Phone;
            tbAddress.Text = StdName.Student_Address;
        }
    }
}
