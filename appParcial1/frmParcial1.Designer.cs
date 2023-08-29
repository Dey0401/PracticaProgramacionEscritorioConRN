
namespace appParcial1
{
    partial class frmParcial1
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
            this.textFloat = new System.Windows.Forms.TextBox();
            this.textInt2 = new System.Windows.Forms.TextBox();
            this.textInt1 = new System.Windows.Forms.TextBox();
            this.MensajError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textFloat
            // 
            this.textFloat.Location = new System.Drawing.Point(210, 50);
            this.textFloat.Name = "textFloat";
            this.textFloat.Size = new System.Drawing.Size(100, 20);
            this.textFloat.TabIndex = 0;
            // 
            // textInt2
            // 
            this.textInt2.Location = new System.Drawing.Point(210, 183);
            this.textInt2.Name = "textInt2";
            this.textInt2.Size = new System.Drawing.Size(100, 20);
            this.textInt2.TabIndex = 1;
            // 
            // textInt1
            // 
            this.textInt1.Location = new System.Drawing.Point(210, 116);
            this.textInt1.Name = "textInt1";
            this.textInt1.Size = new System.Drawing.Size(100, 20);
            this.textInt1.TabIndex = 2;
            // 
            // MensajError
            // 
            this.MensajError.BackColor = System.Drawing.SystemColors.GrayText;
            this.MensajError.Location = new System.Drawing.Point(26, 409);
            this.MensajError.Multiline = true;
            this.MensajError.Name = "MensajError";
            this.MensajError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MensajError.Size = new System.Drawing.Size(341, 29);
            this.MensajError.TabIndex = 3;
            // 
            // frmParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.MensajError);
            this.Controls.Add(this.textInt1);
            this.Controls.Add(this.textInt2);
            this.Controls.Add(this.textFloat);
            this.Name = "frmParcial1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFloat;
        private System.Windows.Forms.TextBox textInt2;
        private System.Windows.Forms.TextBox textInt1;
        private System.Windows.Forms.TextBox MensajError;
    }
}

