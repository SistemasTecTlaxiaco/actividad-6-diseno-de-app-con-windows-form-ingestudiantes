namespace App_Club
{
    partial class Form10
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRegresar_f10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(151, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(485, 217);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "\n\n\n       Tu solicitud ha sido enviada con éxito!\n\n        Mantente al tanto de t" +
    "u confirmación";
            // 
            // btnRegresar_f10
            // 
            this.btnRegresar_f10.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegresar_f10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegresar_f10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar_f10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar_f10.Location = new System.Drawing.Point(281, 330);
            this.btnRegresar_f10.Name = "btnRegresar_f10";
            this.btnRegresar_f10.Size = new System.Drawing.Size(186, 77);
            this.btnRegresar_f10.TabIndex = 2;
            this.btnRegresar_f10.Text = "Regresar al Menú Principal";
            this.btnRegresar_f10.UseVisualStyleBackColor = false;
            this.btnRegresar_f10.Click += new System.EventHandler(this.btnRegresar_f10_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(786, 522);
            this.Controls.Add(this.btnRegresar_f10);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRegresar_f10;
    }
}