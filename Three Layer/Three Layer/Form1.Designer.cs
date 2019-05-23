namespace Three_Layer
{
    partial class Form1
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label codeMelliLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label isAdminLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label personelIDLabel;
            System.Windows.Forms.Label unameLabel;
            System.Windows.Forms.Label upassLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeMelliTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.isAdminSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.personelIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.unameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.upassTextEdit = new DevExpress.XtraEditors.TextEdit();
            addressLabel = new System.Windows.Forms.Label();
            codeMelliLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            isAdminLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            personelIDLabel = new System.Windows.Forms.Label();
            unameLabel = new System.Windows.Forms.Label();
            upassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeMelliTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upassTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataSource = typeof(Model.TblUser);
            // 
            // tblUserDataGridView
            // 
            this.tblUserDataGridView.AutoGenerateColumns = false;
            this.tblUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tblUserDataGridView.DataSource = this.tblUserBindingSource;
            this.tblUserDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblUserDataGridView.Location = new System.Drawing.Point(0, 447);
            this.tblUserDataGridView.Name = "tblUserDataGridView";
            this.tblUserDataGridView.Size = new System.Drawing.Size(835, 220);
            this.tblUserDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonelID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PersonelID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodeMelli";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodeMelli";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Uname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Uname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Upass";
            this.dataGridViewTextBoxColumn8.HeaderText = "Upass";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IsAdmin";
            this.dataGridViewTextBoxColumn9.HeaderText = "IsAdmin";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TblEmployees";
            this.dataGridViewTextBoxColumn10.HeaderText = "TblEmployees";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(201, 44);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "Address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(265, 41);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(242, 20);
            this.addressTextEdit.TabIndex = 3;
            // 
            // codeMelliLabel
            // 
            codeMelliLabel.AutoSize = true;
            codeMelliLabel.Location = new System.Drawing.Point(201, 70);
            codeMelliLabel.Name = "codeMelliLabel";
            codeMelliLabel.Size = new System.Drawing.Size(59, 13);
            codeMelliLabel.TabIndex = 4;
            codeMelliLabel.Text = "Code Melli:";
            // 
            // codeMelliTextEdit
            // 
            this.codeMelliTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "CodeMelli", true));
            this.codeMelliTextEdit.Location = new System.Drawing.Point(265, 67);
            this.codeMelliTextEdit.Name = "codeMelliTextEdit";
            this.codeMelliTextEdit.Size = new System.Drawing.Size(242, 20);
            this.codeMelliTextEdit.TabIndex = 5;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(201, 96);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextEdit
            // 
            this.fullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "FullName", true));
            this.fullNameTextEdit.Location = new System.Drawing.Point(265, 93);
            this.fullNameTextEdit.Name = "fullNameTextEdit";
            this.fullNameTextEdit.Size = new System.Drawing.Size(242, 20);
            this.fullNameTextEdit.TabIndex = 7;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(201, 122);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 8;
            iDLabel.Text = "ID:";
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(265, 119);
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDSpinEdit.Size = new System.Drawing.Size(242, 20);
            this.iDSpinEdit.TabIndex = 9;
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(201, 148);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(50, 13);
            isAdminLabel.TabIndex = 10;
            isAdminLabel.Text = "Is Admin:";
            // 
            // isAdminSpinEdit
            // 
            this.isAdminSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "IsAdmin", true));
            this.isAdminSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.isAdminSpinEdit.Location = new System.Drawing.Point(265, 145);
            this.isAdminSpinEdit.Name = "isAdminSpinEdit";
            this.isAdminSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.isAdminSpinEdit.Size = new System.Drawing.Size(242, 20);
            this.isAdminSpinEdit.TabIndex = 11;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(201, 174);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(41, 13);
            mobileLabel.TabIndex = 12;
            mobileLabel.Text = "Mobile:";
            // 
            // mobileTextEdit
            // 
            this.mobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "Mobile", true));
            this.mobileTextEdit.Location = new System.Drawing.Point(265, 171);
            this.mobileTextEdit.Name = "mobileTextEdit";
            this.mobileTextEdit.Size = new System.Drawing.Size(242, 20);
            this.mobileTextEdit.TabIndex = 13;
            // 
            // personelIDLabel
            // 
            personelIDLabel.AutoSize = true;
            personelIDLabel.Location = new System.Drawing.Point(201, 200);
            personelIDLabel.Name = "personelIDLabel";
            personelIDLabel.Size = new System.Drawing.Size(65, 13);
            personelIDLabel.TabIndex = 14;
            personelIDLabel.Text = "Personel ID:";
            // 
            // personelIDTextEdit
            // 
            this.personelIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "PersonelID", true));
            this.personelIDTextEdit.Location = new System.Drawing.Point(265, 197);
            this.personelIDTextEdit.Name = "personelIDTextEdit";
            this.personelIDTextEdit.Size = new System.Drawing.Size(242, 20);
            this.personelIDTextEdit.TabIndex = 15;
            // 
            // unameLabel
            // 
            unameLabel.AutoSize = true;
            unameLabel.Location = new System.Drawing.Point(201, 226);
            unameLabel.Name = "unameLabel";
            unameLabel.Size = new System.Drawing.Size(44, 13);
            unameLabel.TabIndex = 16;
            unameLabel.Text = "Uname:";
            // 
            // unameTextEdit
            // 
            this.unameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "Uname", true));
            this.unameTextEdit.Location = new System.Drawing.Point(265, 223);
            this.unameTextEdit.Name = "unameTextEdit";
            this.unameTextEdit.Size = new System.Drawing.Size(242, 20);
            this.unameTextEdit.TabIndex = 17;
            // 
            // upassLabel
            // 
            upassLabel.AutoSize = true;
            upassLabel.Location = new System.Drawing.Point(201, 252);
            upassLabel.Name = "upassLabel";
            upassLabel.Size = new System.Drawing.Size(40, 13);
            upassLabel.TabIndex = 18;
            upassLabel.Text = "Upass:";
            // 
            // upassTextEdit
            // 
            this.upassTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblUserBindingSource, "Upass", true));
            this.upassTextEdit.Location = new System.Drawing.Point(265, 249);
            this.upassTextEdit.Name = "upassTextEdit";
            this.upassTextEdit.Size = new System.Drawing.Size(242, 20);
            this.upassTextEdit.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 667);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextEdit);
            this.Controls.Add(codeMelliLabel);
            this.Controls.Add(this.codeMelliTextEdit);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextEdit);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDSpinEdit);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.isAdminSpinEdit);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextEdit);
            this.Controls.Add(personelIDLabel);
            this.Controls.Add(this.personelIDTextEdit);
            this.Controls.Add(unameLabel);
            this.Controls.Add(this.unameTextEdit);
            this.Controls.Add(upassLabel);
            this.Controls.Add(this.upassTextEdit);
            this.Controls.Add(this.tblUserDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeMelliTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upassTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private System.Windows.Forms.DataGridView tblUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit codeMelliTextEdit;
        private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit;
        private DevExpress.XtraEditors.SpinEdit isAdminSpinEdit;
        private DevExpress.XtraEditors.TextEdit mobileTextEdit;
        private DevExpress.XtraEditors.TextEdit personelIDTextEdit;
        private DevExpress.XtraEditors.TextEdit unameTextEdit;
        private DevExpress.XtraEditors.TextEdit upassTextEdit;
    }
}

