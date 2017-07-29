using System.ComponentModel;
using System.Windows.Forms;
using _3000_Verify.ChineseStudyDataSetTableAdapters;

namespace _3000_Verify
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMainCharacter = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.gridOneMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEseq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zhuyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traditional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEquals = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFEsequence = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkByPass = new System.Windows.Forms.CheckBox();
            this.btnSetUserCredentials = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFindMain = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.chineseStudyDataSet = new _3000_Verify.ChineseStudyDataSet();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3000_CharactersTableAdapter = new _3000_Verify.ChineseStudyDataSetTableAdapters._3000_CharactersTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFound = new System.Windows.Forms.TextBox();
            this.ShowLanguages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOneMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chineseStudyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainCharacter
            // 
            this.txtMainCharacter.Font = new System.Drawing.Font("MingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainCharacter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMainCharacter.Location = new System.Drawing.Point(919, 389);
            this.txtMainCharacter.Name = "txtMainCharacter";
            this.txtMainCharacter.Size = new System.Drawing.Size(34, 36);
            this.txtMainCharacter.TabIndex = 1;
            this.txtMainCharacter.TabStop = false;
            this.txtMainCharacter.Click += new System.EventHandler(this.txtMainCharacter_Click);
            this.txtMainCharacter.Enter += new System.EventHandler(this.txtMainCharacter_Enter);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(577, 391);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(123, 53);
            this.btnContains.TabIndex = 3;
            this.btnContains.TabStop = false;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // gridOneMain
            // 
            this.gridOneMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOneMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FEseq,
            this.Zhuyin,
            this.Traditional,
            this.English});
            this.gridOneMain.Location = new System.Drawing.Point(12, 12);
            this.gridOneMain.Name = "gridOneMain";
            this.gridOneMain.Size = new System.Drawing.Size(1170, 361);
            this.gridOneMain.TabIndex = 3;
            this.gridOneMain.TabStop = false;
            this.gridOneMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOneMain_CellContentClick);
            this.gridOneMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOneMain_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "int";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 75;
            // 
            // FEseq
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEseq.DefaultCellStyle = dataGridViewCellStyle2;
            this.FEseq.HeaderText = "FEseq";
            this.FEseq.Name = "FEseq";
            // 
            // Zhuyin
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zhuyin.DefaultCellStyle = dataGridViewCellStyle3;
            this.Zhuyin.HeaderText = "Zhuyin";
            this.Zhuyin.Name = "Zhuyin";
            this.Zhuyin.Width = 250;
            // 
            // Traditional
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traditional.DefaultCellStyle = dataGridViewCellStyle4;
            this.Traditional.HeaderText = "Traditional";
            this.Traditional.Name = "Traditional";
            // 
            // English
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English.DefaultCellStyle = dataGridViewCellStyle5;
            this.English.HeaderText = "English";
            this.English.Name = "English";
            this.English.Width = 600;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(577, 450);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(123, 53);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "Equals";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(14, 520);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(93, 517);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(890, 31);
            this.Status.TabIndex = 6;
            this.Status.TabStop = false;
            this.Status.Click += new System.EventHandler(this.Status_TextChanged);
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            this.Status.Enter += new System.EventHandler(this.Status_TextChanged);
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllabel1.Location = new System.Drawing.Point(744, 435);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(95, 25);
            this.lbllabel1.TabIndex = 7;
            this.lbllabel1.Text = "F E Seq:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Main Character:";
            // 
            // txtFEsequence
            // 
            this.txtFEsequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFEsequence.Location = new System.Drawing.Point(845, 432);
            this.txtFEsequence.Name = "txtFEsequence";
            this.txtFEsequence.Size = new System.Drawing.Size(146, 31);
            this.txtFEsequence.TabIndex = 1;
            this.txtFEsequence.Click += new System.EventHandler(this.txtFEsequence_Click);
            this.txtFEsequence.Enter += new System.EventHandler(this.txtFEsequence_Enter);
            this.txtFEsequence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFEsequence_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 53);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkByPass
            // 
            this.chkByPass.AutoSize = true;
            this.chkByPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByPass.Location = new System.Drawing.Point(731, 476);
            this.chkByPass.Name = "chkByPass";
            this.chkByPass.Size = new System.Drawing.Size(110, 29);
            this.chkByPass.TabIndex = 11;
            this.chkByPass.TabStop = false;
            this.chkByPass.Text = "By Pass";
            this.chkByPass.UseVisualStyleBackColor = true;
            // 
            // btnSetUserCredentials
            // 
            this.btnSetUserCredentials.Location = new System.Drawing.Point(189, 391);
            this.btnSetUserCredentials.Name = "btnSetUserCredentials";
            this.btnSetUserCredentials.Size = new System.Drawing.Size(123, 53);
            this.btnSetUserCredentials.TabIndex = 12;
            this.btnSetUserCredentials.TabStop = false;
            this.btnSetUserCredentials.Text = "Set User Credentials";
            this.btnSetUserCredentials.UseVisualStyleBackColor = true;
            this.btnSetUserCredentials.Click += new System.EventHandler(this.btnSetUserCredentials_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 53);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFindMain
            // 
            this.btnFindMain.Location = new System.Drawing.Point(382, 391);
            this.btnFindMain.Name = "btnFindMain";
            this.btnFindMain.Size = new System.Drawing.Size(123, 53);
            this.btnFindMain.TabIndex = 2;
            this.btnFindMain.Text = "Find Main";
            this.btnFindMain.UseVisualStyleBackColor = true;
            this.btnFindMain.Click += new System.EventHandler(this.btnFindMain_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(847, 471);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(143, 34);
            this.btnScan.TabIndex = 13;
            this.btnScan.TabStop = false;
            this.btnScan.Text = "Sanity";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // chineseStudyDataSet
            // 
            this.chineseStudyDataSet.DataSetName = "ChineseStudyDataSet";
            this.chineseStudyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "3000-Characters";
            this.charactersBindingSource.DataSource = this.chineseStudyDataSet;
            // 
            // _3000_CharactersTableAdapter
            // 
            this._3000_CharactersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1018, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 31);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "012345";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtFound
            // 
            this.txtFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFound.Location = new System.Drawing.Point(1018, 472);
            this.txtFound.Name = "txtFound";
            this.txtFound.Size = new System.Drawing.Size(146, 31);
            this.txtFound.TabIndex = 15;
            this.txtFound.TabStop = false;
            this.txtFound.TextChanged += new System.EventHandler(this.txtFound_TextChanged);
            this.txtFound.Enter += new System.EventHandler(this.txtFound_TextChanged);
            // 
            // ShowLanguages
            // 
            this.ShowLanguages.Location = new System.Drawing.Point(1018, 388);
            this.ShowLanguages.Name = "ShowLanguages";
            this.ShowLanguages.Size = new System.Drawing.Size(143, 36);
            this.ShowLanguages.TabIndex = 16;
            this.ShowLanguages.TabStop = false;
            this.ShowLanguages.Text = "Show Languages";
            this.ShowLanguages.UseVisualStyleBackColor = true;
            this.ShowLanguages.Click += new System.EventHandler(this.ShowLanguages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 579);
            this.Controls.Add(this.ShowLanguages);
            this.Controls.Add(this.txtFound);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnFindMain);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSetUserCredentials);
            this.Controls.Add(this.chkByPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFEsequence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllabel1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.gridOneMain);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.txtMainCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOneMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chineseStudyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMainCharacter;
        private Button btnContains;
        private ChineseStudyDataSet chineseStudyDataSet;
        private BindingSource charactersBindingSource;
        private _3000_CharactersTableAdapter _3000_CharactersTableAdapter;
        private DataGridView gridOneMain;
        private Button btnEquals;
        private Label lblStatus;
        private TextBox Status;
        private Label lbllabel1;
        private Label label1;
        private TextBox txtFEsequence;
        private Button btnExit;
        private CheckBox chkByPass;
        private Button btnSetUserCredentials;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FEseq;
        private DataGridViewTextBoxColumn Zhuyin;
        private DataGridViewTextBoxColumn Traditional;
        private DataGridViewTextBoxColumn English;
        private Button btnUpdate;
        private Button btnFindMain;
        private Button btnScan;
        private TextBox textBox1;
        private TextBox txtFound;
        private Button ShowLanguages;
        private InputLanguage[] _myLanguages = new InputLanguage[10];
    }
}

