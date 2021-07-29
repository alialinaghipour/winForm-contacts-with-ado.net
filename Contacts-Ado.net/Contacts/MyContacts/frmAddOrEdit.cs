using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository contactsRepository;

        public int id = 0;

        public frmAddOrEdit()
        {
            InitializeComponent();
            contactsRepository = new ContactsRepository();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if(id != 0)
            {
                this.Text = "ویرایش شخص";
                this.BackColor = Color.Blue;
                btnSubmit.Text = "ویرایش";
                DataTable dt = contactsRepository.GetById(id);
                txtFullName.Text = dt.Rows[0][1].ToString();
                txtMobile.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                txtDescription.Text = dt.Rows[0][4].ToString();
            }
        }

        //اعتبار سنجی ها
        bool isValid()
        {
            if (txtFullName.Text == "" || txtFullName.Text == " ")
            {
                RtlMessageBox.Show("لطفا نام را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtMobile.Text == "" || txtMobile.Text == " ")
            {
                RtlMessageBox.Show("لطفا موبایل را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEmail.Text == "" || txtEmail.Text == " ")
            {
                RtlMessageBox.Show("لطفا ایمیل را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //اعتبار سنجی ها - پایان

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                
                bool isSuccess;
                if (id == 0)
                {
                    isSuccess= contactsRepository.Insert(txtFullName.Text, txtMobile.Text, txtEmail.Text, txtDescription.Text);
                }
                else
                {
                    isSuccess = contactsRepository.Update(id, txtFullName.Text, txtMobile.Text, txtEmail.Text, txtDescription.Text);
                }
               if(isSuccess == true)
                {
                    RtlMessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("مشکلی پیش امد ، عملیات انجام نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
    }
}
