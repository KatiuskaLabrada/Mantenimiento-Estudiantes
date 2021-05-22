using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Estudiantes
{
    public partial class MantenimientoEstudiantes : Form
    {
        int matricula, matriculaSearch;
        string name, lastName, mail, career;
        Boolean insert, consult, update, delete;

        public MantenimientoEstudiantes()
        {
            InitializeComponent();
            labelAction.Visible = false;
            txtSearch.Visible = false;
            btnAction.Visible = false;
            btnAllRegisters.Visible = false;
            panelDetail.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            matricula = Convert.ToInt32(txtMat.Text);
            name = txtName.Text;
            lastName = txtLastName.Text;
            mail = txtMail.Text;
            career = cboCareer.Text;

            if (update) {
                this.estudianteTableAdapter.ModificarRegistro(matricula, name, lastName, mail, career);
                this.estudianteTableAdapter.Fill(this.institutoDataSet.Estudiante);
            } else if (insert)
            {
                this.estudianteTableAdapter.InsertarRegistro(matricula, name, lastName, mail, career);
                this.estudianteTableAdapter.Fill(this.institutoDataSet.Estudiante);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearField();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearField();
            panelDetail.Visible = false;
        }

        private void btnAddEstudent_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = true;
            labelAction.Visible = false;
            txtSearch.Visible = false;
            btnAction.Visible = false;
            btnAllRegisters.Visible = false;
            insert = true;
            consult = false;
            update = false;
            delete = false;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.RegularExpresionMat();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            matriculaSearch = Convert.ToInt32(txtSearch.Text);

            if (consult) { 
                this.estudianteTableAdapter.ConsultarRegistro(this.institutoDataSet.Estudiante, matriculaSearch); 
            } else if (delete) {
                this.estudianteTableAdapter.EliminarRegistro(matriculaSearch);
                this.estudianteTableAdapter.Fill(this.institutoDataSet.Estudiante);
            }
        }

        private void btnAllRegisters_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institutoDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.institutoDataSet.Estudiante);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            labelAction.Visible = true;
            txtSearch.Visible = true;
            btnAction.Visible = true;
            btnAllRegisters.Visible = true;
            panelDetail.Visible = false;
            consult = false;
            update = false;
            delete = true;
            insert = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            labelAction.Visible = false;
            txtSearch.Visible = false;
            btnAction.Visible = false;
            btnAllRegisters.Visible = false;
            panelDetail.Visible = true;
            consult = false;
            update = true;
            delete = false;
            insert = false;
        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {
            this.RegularExpresionMat();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            labelAction.Visible = true;
            txtSearch.Visible = true;
            btnAction.Visible = true;
            btnAllRegisters.Visible = true;
            panelDetail.Visible = false;
            consult = true;
            update = false;
            delete = false;
            insert = false;

        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.institutoDataSet);

        }

        private void MantenimientoEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institutoDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.institutoDataSet.Estudiante);

        }

        private void ClearField()
        {
            txtMat.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtMail.Clear();
            cboCareer.SelectedIndex = -1;

        }

        private void RegularExpresionMat()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMat.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo es permitido introducir números.");
                txtMat.Text = txtMat.Text.Remove(txtMat.Text.Length - 1);
            }

        }

    }
}
