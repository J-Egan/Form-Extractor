namespace Form_Extractor
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
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(74, 48);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(57, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "Enter URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(137, 45);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(509, 20);
            this.txtURL.TabIndex = 1;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 166);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(776, 485);
            this.txtConsole.TabIndex = 2;
            this.txtConsole.Text = "";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(9, 150);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(48, 13);
            this.lblConsole.TabIndex = 3;
            this.lblConsole.Text = "Console:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(652, 43);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Button btnSubmit;
    }
}

