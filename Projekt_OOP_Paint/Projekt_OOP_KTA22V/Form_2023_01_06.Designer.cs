
namespace Projekt_OOP_KTA22V
{
    partial class Form_2023_01_06
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
            this.AN_txt1 = new System.Windows.Forms.TextBox();
            this.AN_lbl1 = new System.Windows.Forms.Label();
            this.AN_lbl2 = new System.Windows.Forms.Label();
            this.AN_Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AN_Frame1
            // 
            this.AN_Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AN_Frame1.Controls.Add(this.AN_lbl2);
            this.AN_Frame1.Controls.Add(this.AN_lbl1);
            this.AN_Frame1.Controls.Add(this.AN_txt1);
            this.AN_Frame1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AN_Frame1.Location = new System.Drawing.Point(102, 40);
            this.AN_Frame1.Name = "AN_Frame1";
            this.AN_Frame1.Size = new System.Drawing.Size(528, 429);
            this.AN_Frame1.TabIndex = 0;
            this.AN_Frame1.TabStop = false;
            // 
            // AN_txt1
            // 
            this.AN_txt1.Location = new System.Drawing.Point(55, 48);
            this.AN_txt1.Name = "AN_txt1";
            this.AN_txt1.Size = new System.Drawing.Size(436, 44);
            this.AN_txt1.TabIndex = 0;
            this.AN_txt1.TextChanged += new System.EventHandler(this.AN_txt1_TextChanged);
            // 
            // AN_lbl1
            // 
            this.AN_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AN_lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AN_lbl1.Location = new System.Drawing.Point(63, 118);
            this.AN_lbl1.Name = "AN_lbl1";
            this.AN_lbl1.Size = new System.Drawing.Size(428, 50);
            this.AN_lbl1.TabIndex = 1;
            // 
            // AN_lbl2
            // 
            this.AN_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AN_lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AN_lbl2.Location = new System.Drawing.Point(62, 189);
            this.AN_lbl2.Name = "AN_lbl2";
            this.AN_lbl2.Size = new System.Drawing.Size(428, 50);
            this.AN_lbl2.TabIndex = 2;
            // 
            // Form_2023_01_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.AN_Frame1);
            this.Name = "Form_2023_01_06";
            this.Text = "Form_2023_01_06";
            this.AN_Frame1.ResumeLayout(false);
            this.AN_Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AN_Frame1;
        private System.Windows.Forms.Label AN_lbl1;
        private System.Windows.Forms.TextBox AN_txt1;
        private System.Windows.Forms.Label AN_lbl2;
    }
}