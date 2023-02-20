
namespace Projekt_OOP_KTA22V
{
    partial class Form_2023_01_26
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
            this.AN_Frame1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AN_rbtn5 = new System.Windows.Forms.RadioButton();
            this.AN_rbtn4 = new System.Windows.Forms.RadioButton();
            this.AN_rbtn3 = new System.Windows.Forms.RadioButton();
            this.AN_rbtn2 = new System.Windows.Forms.RadioButton();
            this.AN_rbtn1 = new System.Windows.Forms.RadioButton();
            this.AN_pic1 = new System.Windows.Forms.PictureBox();
            this.AN_Menu = new System.Windows.Forms.MenuStrip();
            this.AN_File = new System.Windows.Forms.ToolStripMenuItem();
            this.AN_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.AN_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.AN_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AN_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AN_Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_pic1)).BeginInit();
            this.AN_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AN_Frame1
            // 
            this.AN_Frame1.BackColor = System.Drawing.Color.LightYellow;
            this.AN_Frame1.Controls.Add(this.label1);
            this.AN_Frame1.Controls.Add(this.AN_rbtn5);
            this.AN_Frame1.Controls.Add(this.AN_rbtn4);
            this.AN_Frame1.Controls.Add(this.AN_rbtn3);
            this.AN_Frame1.Controls.Add(this.AN_rbtn2);
            this.AN_Frame1.Controls.Add(this.AN_rbtn1);
            this.AN_Frame1.Controls.Add(this.AN_pic1);
            this.AN_Frame1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AN_Frame1.Location = new System.Drawing.Point(98, 89);
            this.AN_Frame1.Name = "AN_Frame1";
            this.AN_Frame1.Size = new System.Drawing.Size(1338, 455);
            this.AN_Frame1.TabIndex = 0;
            this.AN_Frame1.TabStop = false;
            this.AN_Frame1.Text = "Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size Mode";
            // 
            // AN_rbtn5
            // 
            this.AN_rbtn5.AutoSize = true;
            this.AN_rbtn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AN_rbtn5.Location = new System.Drawing.Point(27, 272);
            this.AN_rbtn5.Name = "AN_rbtn5";
            this.AN_rbtn5.Size = new System.Drawing.Size(80, 27);
            this.AN_rbtn5.TabIndex = 5;
            this.AN_rbtn5.Text = "Zoom";
            this.AN_rbtn5.UseVisualStyleBackColor = true;
            this.AN_rbtn5.CheckedChanged += new System.EventHandler(this.AN_rbtn5_CheckedChanged);
            // 
            // AN_rbtn4
            // 
            this.AN_rbtn4.AutoSize = true;
            this.AN_rbtn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AN_rbtn4.Location = new System.Drawing.Point(27, 227);
            this.AN_rbtn4.Name = "AN_rbtn4";
            this.AN_rbtn4.Size = new System.Drawing.Size(106, 27);
            this.AN_rbtn4.TabIndex = 4;
            this.AN_rbtn4.Text = "Center";
            this.AN_rbtn4.UseVisualStyleBackColor = true;
            this.AN_rbtn4.CheckedChanged += new System.EventHandler(this.AN_rbtn4_CheckedChanged);
            // 
            // AN_rbtn3
            // 
            this.AN_rbtn3.AutoSize = true;
            this.AN_rbtn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AN_rbtn3.Location = new System.Drawing.Point(27, 180);
            this.AN_rbtn3.Name = "AN_rbtn3";
            this.AN_rbtn3.Size = new System.Drawing.Size(132, 27);
            this.AN_rbtn3.TabIndex = 3;
            this.AN_rbtn3.Text = "AutoSize";
            this.AN_rbtn3.UseVisualStyleBackColor = true;
            this.AN_rbtn3.CheckedChanged += new System.EventHandler(this.AN_rbtn3_CheckedChanged);
            // 
            // AN_rbtn2
            // 
            this.AN_rbtn2.AutoSize = true;
            this.AN_rbtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AN_rbtn2.Location = new System.Drawing.Point(27, 133);
            this.AN_rbtn2.Name = "AN_rbtn2";
            this.AN_rbtn2.Size = new System.Drawing.Size(119, 27);
            this.AN_rbtn2.TabIndex = 2;
            this.AN_rbtn2.Text = "Stretch";
            this.AN_rbtn2.UseVisualStyleBackColor = true;
            this.AN_rbtn2.CheckedChanged += new System.EventHandler(this.AN_rbtn2_CheckedChanged);
            // 
            // AN_rbtn1
            // 
            this.AN_rbtn1.AutoSize = true;
            this.AN_rbtn1.Checked = true;
            this.AN_rbtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AN_rbtn1.Location = new System.Drawing.Point(27, 88);
            this.AN_rbtn1.Name = "AN_rbtn1";
            this.AN_rbtn1.Size = new System.Drawing.Size(106, 27);
            this.AN_rbtn1.TabIndex = 1;
            this.AN_rbtn1.TabStop = true;
            this.AN_rbtn1.Text = "Normal";
            this.AN_rbtn1.UseVisualStyleBackColor = true;
            this.AN_rbtn1.CheckedChanged += new System.EventHandler(this.AN_rbtn1_CheckedChanged);
            // 
            // AN_pic1
            // 
            this.AN_pic1.BackColor = System.Drawing.Color.White;
            this.AN_pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AN_pic1.Location = new System.Drawing.Point(211, 74);
            this.AN_pic1.Name = "AN_pic1";
            this.AN_pic1.Size = new System.Drawing.Size(461, 360);
            this.AN_pic1.TabIndex = 0;
            this.AN_pic1.TabStop = false;
            this.AN_pic1.Click += new System.EventHandler(this.AN_pic1_Click);
            this.AN_pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AN_pic1_MouseDown);
            this.AN_pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AN_pic1_MouseMove);
            this.AN_pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AN_pic1_MouseUp);
            // 
            // AN_Menu
            // 
            this.AN_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AN_File});
            this.AN_Menu.Location = new System.Drawing.Point(0, 0);
            this.AN_Menu.Name = "AN_Menu";
            this.AN_Menu.Size = new System.Drawing.Size(1501, 31);
            this.AN_Menu.TabIndex = 1;
            this.AN_Menu.Text = "menuStrip1";
            // 
            // AN_File
            // 
            this.AN_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AN_Open,
            this.AN_Save});
            this.AN_File.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AN_File.ForeColor = System.Drawing.Color.Red;
            this.AN_File.Name = "AN_File";
            this.AN_File.Size = new System.Drawing.Size(74, 27);
            this.AN_File.Text = "File";
            // 
            // AN_Open
            // 
            this.AN_Open.ForeColor = System.Drawing.Color.Red;
            this.AN_Open.Name = "AN_Open";
            this.AN_Open.Size = new System.Drawing.Size(197, 28);
            this.AN_Open.Text = "Open file";
            this.AN_Open.Click += new System.EventHandler(this.AN_Open_Click);
            // 
            // AN_Save
            // 
            this.AN_Save.Enabled = false;
            this.AN_Save.ForeColor = System.Drawing.Color.Red;
            this.AN_Save.Name = "AN_Save";
            this.AN_Save.Size = new System.Drawing.Size(197, 28);
            this.AN_Save.Text = "Save file";
            // 
            // AN_openFileDialog
            // 
            this.AN_openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(105, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(242, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // Form_2023_01_26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AN_Frame1);
            this.Controls.Add(this.AN_Menu);
            this.MainMenuStrip = this.AN_Menu;
            this.Name = "Form_2023_01_26";
            this.Text = "Form_2023_01_26";
            this.AN_Frame1.ResumeLayout(false);
            this.AN_Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_pic1)).EndInit();
            this.AN_Menu.ResumeLayout(false);
            this.AN_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AN_Frame1;
        private System.Windows.Forms.PictureBox AN_pic1;
        private System.Windows.Forms.MenuStrip AN_Menu;
        private System.Windows.Forms.ToolStripMenuItem AN_File;
        private System.Windows.Forms.ToolStripMenuItem AN_Open;
        private System.Windows.Forms.ToolStripMenuItem AN_Save;
        private System.Windows.Forms.OpenFileDialog AN_openFileDialog;
        private System.Windows.Forms.SaveFileDialog AN_saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AN_rbtn5;
        private System.Windows.Forms.RadioButton AN_rbtn4;
        private System.Windows.Forms.RadioButton AN_rbtn3;
        private System.Windows.Forms.RadioButton AN_rbtn2;
        private System.Windows.Forms.RadioButton AN_rbtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}