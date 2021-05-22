namespace Mantenimiento_Estudiantes
{
    partial class MantenimientoEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoEstudiantes));
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.cboCareer = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelAction = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddEstudent = new System.Windows.Forms.Button();
            this.institutoDataSet = new Mantenimiento_Estudiantes.InstitutoDataSet();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new Mantenimiento_Estudiantes.InstitutoDataSetTableAdapters.EstudianteTableAdapter();
            this.tableAdapterManager = new Mantenimiento_Estudiantes.InstitutoDataSetTableAdapters.TableAdapterManager();
            this.estudianteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estudianteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnAllRegisters = new System.Windows.Forms.Button();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).BeginInit();
            this.estudianteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(394, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(228, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Mantenimiento Estudiantes";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(840, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(155, 168);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDetail.Controls.Add(this.cboCareer);
            this.panelDetail.Controls.Add(this.btnClear);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnSave);
            this.panelDetail.Controls.Add(this.txtMail);
            this.panelDetail.Controls.Add(this.txtLastName);
            this.panelDetail.Controls.Add(this.txtName);
            this.panelDetail.Controls.Add(this.txtMat);
            this.panelDetail.Controls.Add(this.labelCarrera);
            this.panelDetail.Controls.Add(this.labelMail);
            this.panelDetail.Controls.Add(this.labelLastName);
            this.panelDetail.Controls.Add(this.labelName);
            this.panelDetail.Controls.Add(this.labelMatricula);
            this.panelDetail.Location = new System.Drawing.Point(66, 494);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(923, 274);
            this.panelDetail.TabIndex = 9;
            // 
            // cboCareer
            // 
            this.cboCareer.FormattingEnabled = true;
            this.cboCareer.Items.AddRange(new object[] {
            "Administración de Empresas",
            "Administración de Empresas y Derecho",
            "Arquitectura",
            "Artes y Diseño",
            "Biología, Bioquímica y Biotecnología",
            "Comercio y Marketing",
            "Comunicación, Imagen y Sonido",
            "Derecho y Criminología",
            "Economía",
            "Educación y Pedagogía",
            "Enfermería",
            "Filología, Lingüística y Literatura",
            "Hostelería y Turismo",
            "Informática Gerencial",
            "Ingeniería Agroalimentaria y del Medio Rural",
            "Ingeniería de Telecomunicaciones",
            "Ingeniería Desarrollo de Software",
            "Ingeniería Eléctrica",
            "Ingeniería Electrónica industrial y Automática",
            "Ingeniería Industrial",
            "Ingeniería Mecánica",
            "Ingeniería Química",
            "Medicina y Biomecánica",
            "Psicología y Psicopedagogía",
            "Química",
            "Relaciones Laborales y Recursos Humanos"});
            this.cboCareer.Location = new System.Drawing.Point(127, 226);
            this.cboCareer.Name = "cboCareer";
            this.cboCareer.Size = new System.Drawing.Size(376, 21);
            this.cboCareer.TabIndex = 14;
            this.cboCareer.Text = "Seleccione...";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(672, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 43);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(672, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(672, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(127, 174);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(376, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(376, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(376, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(127, 27);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(376, 20);
            this.txtMat.TabIndex = 7;
            this.txtMat.TextChanged += new System.EventHandler(this.txtMat_TextChanged);
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrera.Location = new System.Drawing.Point(22, 226);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(64, 16);
            this.labelCarrera.TabIndex = 6;
            this.labelCarrera.Text = "Carrera:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(22, 178);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(59, 16);
            this.labelMail.TabIndex = 5;
            this.labelMail.Text = "Correo:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(22, 127);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(70, 16);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Apellido:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(22, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nombre:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(22, 31);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(75, 16);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matricula:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(441, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Modificar Estudiante";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(629, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar Estudiante";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.Location = new System.Drawing.Point(63, 174);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(75, 16);
            this.labelAction.TabIndex = 12;
            this.labelAction.Text = "Matricula:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(253, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Consultar Estudiante";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddEstudent
            // 
            this.btnAddEstudent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddEstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddEstudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddEstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEstudent.Location = new System.Drawing.Point(66, 95);
            this.btnAddEstudent.Name = "btnAddEstudent";
            this.btnAddEstudent.Size = new System.Drawing.Size(149, 43);
            this.btnAddEstudent.TabIndex = 5;
            this.btnAddEstudent.Text = "Agregar Estudiante";
            this.btnAddEstudent.UseVisualStyleBackColor = false;
            this.btnAddEstudent.Click += new System.EventHandler(this.btnAddEstudent_Click);
            // 
            // institutoDataSet
            // 
            this.institutoDataSet.DataSetName = "InstitutoDataSet";
            this.institutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.institutoDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudianteTableAdapter = this.estudianteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mantenimiento_Estudiantes.InstitutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estudianteBindingNavigator
            // 
            this.estudianteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estudianteBindingNavigator.BindingSource = this.estudianteBindingSource;
            this.estudianteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estudianteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estudianteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estudianteBindingNavigatorSaveItem});
            this.estudianteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estudianteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estudianteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estudianteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estudianteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estudianteBindingNavigator.Name = "estudianteBindingNavigator";
            this.estudianteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estudianteBindingNavigator.Size = new System.Drawing.Size(1092, 25);
            this.estudianteBindingNavigator.TabIndex = 13;
            this.estudianteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // estudianteBindingNavigatorSaveItem
            // 
            this.estudianteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estudianteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estudianteBindingNavigatorSaveItem.Image")));
            this.estudianteBindingNavigatorSaveItem.Name = "estudianteBindingNavigatorSaveItem";
            this.estudianteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estudianteBindingNavigatorSaveItem.Text = "Save Data";
            this.estudianteBindingNavigatorSaveItem.Click += new System.EventHandler(this.estudianteBindingNavigatorSaveItem_Click);
            // 
            // estudianteDataGridView
            // 
            this.estudianteDataGridView.AutoGenerateColumns = false;
            this.estudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudianteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.estudianteDataGridView.DataSource = this.estudianteBindingSource;
            this.estudianteDataGridView.Location = new System.Drawing.Point(66, 227);
            this.estudianteDataGridView.Name = "estudianteDataGridView";
            this.estudianteDataGridView.Size = new System.Drawing.Size(923, 220);
            this.estudianteDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Carrera";
            this.dataGridViewTextBoxColumn5.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnAction
            // 
            this.btnAction.BackgroundImage = global::Mantenimiento_Estudiantes.Properties.Resources.buscar;
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAction.Location = new System.Drawing.Point(408, 165);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(42, 29);
            this.btnAction.TabIndex = 14;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAllRegisters
            // 
            this.btnAllRegisters.BackgroundImage = global::Mantenimiento_Estudiantes.Properties.Resources.grupo;
            this.btnAllRegisters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllRegisters.Location = new System.Drawing.Point(467, 165);
            this.btnAllRegisters.Name = "btnAllRegisters";
            this.btnAllRegisters.Size = new System.Drawing.Size(42, 29);
            this.btnAllRegisters.TabIndex = 15;
            this.btnAllRegisters.UseVisualStyleBackColor = true;
            this.btnAllRegisters.Click += new System.EventHandler(this.btnAllRegisters_Click);
            // 
            // MantenimientoEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 827);
            this.Controls.Add(this.btnAllRegisters);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.estudianteDataGridView);
            this.Controls.Add(this.estudianteBindingNavigator);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddEstudent);
            this.Controls.Add(this.labelTitle);
            this.Name = "MantenimientoEstudiantes";
            this.Text = "Mantenimiento Estudiantes";
            this.Load += new System.EventHandler(this.MantenimientoEstudiantes_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).EndInit();
            this.estudianteBindingNavigator.ResumeLayout(false);
            this.estudianteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAddEstudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ComboBox cboCareer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelAction;
        private InstitutoDataSet institutoDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private InstitutoDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private InstitutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estudianteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estudianteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView estudianteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAllRegisters;
    }
}

