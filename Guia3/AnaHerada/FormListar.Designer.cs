namespace AnaHerada
{
    partial class FormListar
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxListar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxListar
            // 
            this.tbxListar.Location = new System.Drawing.Point(33, 12);
            this.tbxListar.Multiline = true;
            this.tbxListar.Name = "tbxListar";
            this.tbxListar.Size = new System.Drawing.Size(330, 415);
            this.tbxListar.TabIndex = 2;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 523);
            this.Controls.Add(this.tbxListar);
            this.Controls.Add(this.button1);
            this.Name = "FormListar";
            this.Text = "FormListar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxListar;
        private System.Windows.Forms.Button button1;
    }
}