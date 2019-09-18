
namespace WinForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butReadTb = new System.Windows.Forms.Button();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.butAddPerson = new System.Windows.Forms.Button();
            this.txtAHeight = new System.Windows.Forms.TextBox();
            this.txtACity = new System.Windows.Forms.TextBox();
            this.txtAAge = new System.Windows.Forms.TextBox();
            this.txtASurname = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPg1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labTable = new System.Windows.Forms.Label();
            this.dGridPostgres = new System.Windows.Forms.DataGridView();
            this.butDeleteRow = new System.Windows.Forms.Button();
            this.tabPg2 = new System.Windows.Forms.TabPage();
            this.butAddExamples = new System.Windows.Forms.Button();
            this.tabPg3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labConnectionInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butCheckConnection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.labTypeOfServer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPg1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPostgres)).BeginInit();
            this.tabPg2.SuspendLayout();
            this.tabPg3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butReadTb
            // 
            this.butReadTb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butReadTb.Location = new System.Drawing.Point(4, 1);
            this.butReadTb.Name = "butReadTb";
            this.butReadTb.Size = new System.Drawing.Size(72, 20);
            this.butReadTb.TabIndex = 0;
            this.butReadTb.Text = "ReadTable";
            this.butReadTb.UseVisualStyleBackColor = true;
            this.butReadTb.Click += new System.EventHandler(this.butReadTb_Click);
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(64, 3);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(53, 20);
            this.txtDataBase.TabIndex = 2;
            this.txtDataBase.Text = "dbMark";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(155, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(53, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "sa";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(248, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(60, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "fgdghdfh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Schema:                          TableName:";
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(110, 20);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(53, 20);
            this.txtAName.TabIndex = 6;
            this.txtAName.Text = "Linford";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name       Surname      Age     City                 Height";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butAddPerson);
            this.panel1.Controls.Add(this.txtAHeight);
            this.panel1.Controls.Add(this.txtACity);
            this.panel1.Controls.Add(this.txtAAge);
            this.panel1.Controls.Add(this.txtASurname);
            this.panel1.Controls.Add(this.txtAName);
            this.panel1.Location = new System.Drawing.Point(4, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 44);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "New row to DataBase";
            // 
            // butAddPerson
            // 
            this.butAddPerson.Location = new System.Drawing.Point(6, 22);
            this.butAddPerson.Name = "butAddPerson";
            this.butAddPerson.Size = new System.Drawing.Size(72, 20);
            this.butAddPerson.TabIndex = 12;
            this.butAddPerson.Text = "Add Person";
            this.butAddPerson.UseVisualStyleBackColor = true;
            this.butAddPerson.Click += new System.EventHandler(this.butAddPerson_Click);
            // 
            // txtAHeight
            // 
            this.txtAHeight.Location = new System.Drawing.Point(333, 20);
            this.txtAHeight.Name = "txtAHeight";
            this.txtAHeight.Size = new System.Drawing.Size(32, 20);
            this.txtAHeight.TabIndex = 11;
            this.txtAHeight.Text = "184";
            this.txtAHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtACity
            // 
            this.txtACity.Location = new System.Drawing.Point(260, 20);
            this.txtACity.Name = "txtACity";
            this.txtACity.Size = new System.Drawing.Size(67, 20);
            this.txtACity.TabIndex = 10;
            this.txtACity.Text = "Stuttgart";
            // 
            // txtAAge
            // 
            this.txtAAge.Location = new System.Drawing.Point(228, 20);
            this.txtAAge.Name = "txtAAge";
            this.txtAAge.Size = new System.Drawing.Size(25, 20);
            this.txtAAge.TabIndex = 9;
            this.txtAAge.Text = "31";
            this.txtAAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtASurname
            // 
            this.txtASurname.Location = new System.Drawing.Point(169, 20);
            this.txtASurname.Name = "txtASurname";
            this.txtASurname.Size = new System.Drawing.Size(53, 20);
            this.txtASurname.TabIndex = 8;
            this.txtASurname.Text = "Christie";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPg1);
            this.tabControl1.Controls.Add(this.tabPg2);
            this.tabControl1.Controls.Add(this.tabPg3);
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 251);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPg1
            // 
            this.tabPg1.Controls.Add(this.panel4);
            this.tabPg1.Controls.Add(this.dGridPostgres);
            this.tabPg1.Controls.Add(this.panel1);
            this.tabPg1.Controls.Add(this.butDeleteRow);
            this.tabPg1.Location = new System.Drawing.Point(4, 22);
            this.tabPg1.Name = "tabPg1";
            this.tabPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg1.Size = new System.Drawing.Size(383, 225);
            this.tabPg1.TabIndex = 0;
            this.tabPg1.Text = "DataBase";
            this.tabPg1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.labTable);
            this.panel4.Controls.Add(this.butReadTb);
            this.panel4.Location = new System.Drawing.Point(4, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 22);
            this.panel4.TabIndex = 15;
            // 
            // labTable
            // 
            this.labTable.AutoSize = true;
            this.labTable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labTable.Location = new System.Drawing.Point(78, 4);
            this.labTable.Name = "labTable";
            this.labTable.Size = new System.Drawing.Size(37, 13);
            this.labTable.TabIndex = 9;
            this.labTable.Text = "Table ";
            // 
            // dGridPostgres
            // 
            this.dGridPostgres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridPostgres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridPostgres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridPostgres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridPostgres.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridPostgres.EnableHeadersVisualStyles = false;
            this.dGridPostgres.Location = new System.Drawing.Point(3, 5);
            this.dGridPostgres.Margin = new System.Windows.Forms.Padding(2);
            this.dGridPostgres.Name = "dGridPostgres";
            this.dGridPostgres.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dGridPostgres.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridPostgres.RowTemplate.Height = 16;
            this.dGridPostgres.Size = new System.Drawing.Size(376, 140);
            this.dGridPostgres.TabIndex = 56;
            // 
            // butDeleteRow
            // 
            this.butDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butDeleteRow.Location = new System.Drawing.Point(275, 149);
            this.butDeleteRow.Name = "butDeleteRow";
            this.butDeleteRow.Size = new System.Drawing.Size(99, 20);
            this.butDeleteRow.TabIndex = 10;
            this.butDeleteRow.Text = "Delete actual Row";
            this.butDeleteRow.UseVisualStyleBackColor = true;
            this.butDeleteRow.Click += new System.EventHandler(this.butDeleteRow_Click);
            // 
            // tabPg2
            // 
            this.tabPg2.Controls.Add(this.butAddExamples);
            this.tabPg2.Location = new System.Drawing.Point(4, 22);
            this.tabPg2.Name = "tabPg2";
            this.tabPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg2.Size = new System.Drawing.Size(383, 225);
            this.tabPg2.TabIndex = 1;
            this.tabPg2.Text = "Proposal";
            this.tabPg2.UseVisualStyleBackColor = true;
            // 
            // butAddExamples
            // 
            this.butAddExamples.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butAddExamples.Location = new System.Drawing.Point(7, 10);
            this.butAddExamples.Name = "butAddExamples";
            this.butAddExamples.Size = new System.Drawing.Size(128, 20);
            this.butAddExamples.TabIndex = 58;
            this.butAddExamples.Text = "Add 5 examples rows";
            this.butAddExamples.UseVisualStyleBackColor = true;
            this.butAddExamples.Click += new System.EventHandler(this.butAddExamples_Click);
            // 
            // tabPg3
            // 
            this.tabPg3.Controls.Add(this.panel2);
            this.tabPg3.Location = new System.Drawing.Point(4, 22);
            this.tabPg3.Name = "tabPg3";
            this.tabPg3.Size = new System.Drawing.Size(383, 225);
            this.tabPg3.TabIndex = 2;
            this.tabPg3.Text = "Login";
            this.tabPg3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtTableName);
            this.panel2.Controls.Add(this.txtSchema);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 136);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labConnectionInfo);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.butCheckConnection);
            this.panel5.Controls.Add(this.txtDataBase);
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Controls.Add(this.txtUser);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(6, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 79);
            this.panel5.TabIndex = 11;
            // 
            // labConnectionInfo
            // 
            this.labConnectionInfo.AutoSize = true;
            this.labConnectionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labConnectionInfo.ForeColor = System.Drawing.Color.Gray;
            this.labConnectionInfo.Location = new System.Drawing.Point(110, 58);
            this.labConnectionInfo.Name = "labConnectionInfo";
            this.labConnectionInfo.Size = new System.Drawing.Size(128, 13);
            this.labConnectionInfo.TabIndex = 14;
            this.labConnectionInfo.Text = "Connection Unknown";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtComp);
            this.panel3.Controls.Add(this.txtServer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(5, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 26);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "\\";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(56, 3);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(118, 20);
            this.txtComp.TabIndex = 6;
            this.txtComp.Text = "DESKTOP-B";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(187, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(91, 20);
            this.txtServer.TabIndex = 7;
            this.txtServer.Text = "SQLEXPRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Computer: ";
            // 
            // butCheckConnection
            // 
            this.butCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butCheckConnection.Location = new System.Drawing.Point(5, 54);
            this.butCheckConnection.Name = "butCheckConnection";
            this.butCheckConnection.Size = new System.Drawing.Size(99, 21);
            this.butCheckConnection.TabIndex = 10;
            this.butCheckConnection.Text = "Check Connection";
            this.butCheckConnection.UseVisualStyleBackColor = true;
            this.butCheckConnection.Click += new System.EventHandler(this.butCheckConnection_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DataBase:                      User:                      Pass:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(194, 27);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(60, 20);
            this.txtTableName.TabIndex = 9;
            this.txtTableName.Text = "Sprinters";
            this.txtTableName.TextChanged += new System.EventHandler(this.txtTableName_TextChanged);
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(70, 27);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(60, 20);
            this.txtSchema.TabIndex = 8;
            this.txtSchema.Text = "dbo";
            // 
            // labTypeOfServer
            // 
            this.labTypeOfServer.AutoSize = true;
            this.labTypeOfServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTypeOfServer.ForeColor = System.Drawing.Color.Green;
            this.labTypeOfServer.Location = new System.Drawing.Point(8, 3);
            this.labTypeOfServer.Name = "labTypeOfServer";
            this.labTypeOfServer.Size = new System.Drawing.Size(143, 17);
            this.labTypeOfServer.TabIndex = 14;
            this.labTypeOfServer.Text = "Microsoft SQL Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 291);
            this.Controls.Add(this.labTypeOfServer);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(414, 260);
            this.Name = "Form1";
            this.Text = "CRUD operations using the Entity Framework";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPg1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPostgres)).EndInit();
            this.tabPg2.ResumeLayout(false);
            this.tabPg3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReadTb;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butAddPerson;
        private System.Windows.Forms.TextBox txtAHeight;
        private System.Windows.Forms.TextBox txtACity;
        private System.Windows.Forms.TextBox txtAAge;
        private System.Windows.Forms.TextBox txtASurname;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPg1;
        private System.Windows.Forms.DataGridView dGridPostgres;
        private System.Windows.Forms.TabPage tabPg2;
        private System.Windows.Forms.Button butDeleteRow;
        private System.Windows.Forms.TabPage tabPg3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label labTypeOfServer;
        private System.Windows.Forms.Button butAddExamples;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labTable;
        private System.Windows.Forms.Button butCheckConnection;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labConnectionInfo;
    }
}

