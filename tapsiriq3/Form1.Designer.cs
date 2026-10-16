namespace tapsiriq3
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCix = new System.Windows.Forms.Button();
            this.btnVur = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblNetice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(67, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(195, 50);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 1;
            // 
            // btnCix
            // 
            this.btnCix.Location = new System.Drawing.Point(112, 96);
            this.btnCix.Name = "btnCix";
            this.btnCix.Size = new System.Drawing.Size(55, 51);
            this.btnCix.TabIndex = 3;
            this.btnCix.Text = "-";
            this.btnCix.UseVisualStyleBackColor = true;
            this.btnCix.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVur
            // 
            this.btnVur.Location = new System.Drawing.Point(195, 96);
            this.btnVur.Name = "btnVur";
            this.btnVur.Size = new System.Drawing.Size(54, 51);
            this.btnVur.TabIndex = 4;
            this.btnVur.Text = "x";
            this.btnVur.UseVisualStyleBackColor = true;
            this.btnVur.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(284, 96);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(51, 51);
            this.btnBol.TabIndex = 5;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(30, 96);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(52, 51);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            // 
            // lblNetice
            // 
            this.lblNetice.AutoSize = true;
            this.lblNetice.Location = new System.Drawing.Point(45, 187);
            this.lblNetice.Name = "lblNetice";
            this.lblNetice.Size = new System.Drawing.Size(0, 16);
            this.lblNetice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNetice);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnVur);
            this.Controls.Add(this.btnCix);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCix;
        private System.Windows.Forms.Button btnVur;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblNetice;
    }
}

