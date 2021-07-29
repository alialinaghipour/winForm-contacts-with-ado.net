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
    public partial class FormContacts : Form
    {
        IContactsRepository contactsRepository;

        public FormContacts()
        {
            InitializeComponent();
            contactsRepository = new ContactsRepository();
        }

        private void BindGrid()
        {
            dgvContacts.AutoGenerateColumns = false;
            dgvContacts.DataSource = contactsRepository.GetAll();
        }

        private void FormContacts_Load(object sender, EventArgs e)
        {
            BindGrid();
        }     

        private void btnRefreshContacts_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAdd = new frmAddOrEdit();
            frmAdd.ShowDialog();
            if (frmAdd.DialogResult==DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                frmAddOrEdit frmEdit = new frmAddOrEdit();
                int contactId = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                frmEdit.id = contactId;
                if (dgvContacts.CurrentRow != null)
                {
                    frmEdit.ShowDialog();
                    if (frmEdit.DialogResult == DialogResult.OK)
                    {
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                string name = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                int id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogDelete = RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogDelete == DialogResult.Yes)
                {
                    contactsRepository.Delete(id);
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را انتخاب کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchContacts_TextChanged(object sender, EventArgs e)
        {
            dgvContacts.DataSource = contactsRepository.Serach(txtSearchContacts.Text);
        }
    }
}
