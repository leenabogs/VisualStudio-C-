
namespace Projekt_OOP_KTA22V
{
    partial class Form_Main
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
            this.AN_btn1 = new System.Windows.Forms.Button();
            this.AN_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AN_btn1
            // 
            this.AN_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AN_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AN_btn1.ForeColor = System.Drawing.Color.Red;
            this.AN_btn1.Location = new System.Drawing.Point(51, 42);
            this.AN_btn1.Name = "AN_btn1";
            this.AN_btn1.Size = new System.Drawing.Size(261, 77);
            this.AN_btn1.TabIndex = 0;
            this.AN_btn1.Text = "06.01.2023";
            this.AN_btn1.UseVisualStyleBackColor = false;
            this.AN_btn1.Click += new System.EventHandler(this.AN_btn1_Click);
            // 
            // AN_btn2
            // 
            this.AN_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AN_btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AN_btn2.ForeColor = System.Drawing.Color.Red;
            this.AN_btn2.Location = new System.Drawing.Point(51, 137);
            this.AN_btn2.Name = "AN_btn2";
            this.AN_btn2.Size = new System.Drawing.Size(261, 77);
            this.AN_btn2.TabIndex = 1;
            this.AN_btn2.Text = "26.01.2023";
            this.AN_btn2.UseVisualStyleBackColor = false;
            this.AN_btn2.Click += new System.EventHandler(this.AN_btn2_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AN_btn2);
            this.Controls.Add(this.AN_btn1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AN_btn1;
        private System.Windows.Forms.Button AN_btn2;
    }
}

