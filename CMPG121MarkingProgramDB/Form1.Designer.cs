namespace CMPG121MarkingProgramDB
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbxPractical = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTestTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(790, 505);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 491);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFieldToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewFieldToolStripMenuItem
            // 
            this.addNewFieldToolStripMenuItem.Name = "addNewFieldToolStripMenuItem";
            this.addNewFieldToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNewFieldToolStripMenuItem.Text = "Add New field";
            this.addNewFieldToolStripMenuItem.Click += new System.EventHandler(this.addNewFieldToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testModeToolStripMenuItem
            // 
            this.testModeToolStripMenuItem.Name = "testModeToolStripMenuItem";
            this.testModeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.testModeToolStripMenuItem.Text = "Test Mode";
            this.testModeToolStripMenuItem.Click += new System.EventHandler(this.testModeToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(790, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(790, 116);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(121, 20);
            this.txtAdd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Student:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(787, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "<name>";
            // 
            // cmbxPractical
            // 
            this.cmbxPractical.FormattingEnabled = true;
            this.cmbxPractical.Location = new System.Drawing.Point(790, 80);
            this.cmbxPractical.Name = "cmbxPractical";
            this.cmbxPractical.Size = new System.Drawing.Size(121, 21);
            this.cmbxPractical.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Practical :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Mark:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stats for prac";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(790, 239);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(121, 38);
            this.btnComments.TabIndex = 12;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 518);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(669, 492);
            this.dataGridView2.TabIndex = 14;
            // 
            // txtTestTotal
            // 
            this.txtTestTotal.Enabled = false;
            this.txtTestTotal.Location = new System.Drawing.Point(790, 152);
            this.txtTestTotal.Name = "txtTestTotal";
            this.txtTestTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTestTotal.TabIndex = 14;
            this.txtTestTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Test Total:";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTestTotal);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxPractical);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem addNewFieldToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbxPractical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem testModeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTestTotal;
        private System.Windows.Forms.Label label4;
    }
}

