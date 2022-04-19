
namespace PainelFotoDiversos
{
    partial class TelaFotos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbxFoto2 = new System.Windows.Forms.PictureBox();
            this.pbxFoto1 = new System.Windows.Forms.PictureBox();
            this.pbxFoto3 = new System.Windows.Forms.PictureBox();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pbxFoto2);
            this.panel1.Controls.Add(this.pbxFoto1);
            this.panel1.Controls.Add(this.pbxFoto3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(88, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(344, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageKey = "(nenhum)";
            this.button1.Location = new System.Drawing.Point(609, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxFoto2
            // 
            this.pbxFoto2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxFoto2.Location = new System.Drawing.Point(286, 18);
            this.pbxFoto2.Name = "pbxFoto2";
            this.pbxFoto2.Size = new System.Drawing.Size(200, 362);
            this.pbxFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto2.TabIndex = 2;
            this.pbxFoto2.TabStop = false;
            // 
            // pbxFoto1
            // 
            this.pbxFoto1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxFoto1.Location = new System.Drawing.Point(550, 18);
            this.pbxFoto1.Name = "pbxFoto1";
            this.pbxFoto1.Size = new System.Drawing.Size(200, 362);
            this.pbxFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto1.TabIndex = 1;
            this.pbxFoto1.TabStop = false;
            // 
            // pbxFoto3
            // 
            this.pbxFoto3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxFoto3.Location = new System.Drawing.Point(29, 18);
            this.pbxFoto3.Name = "pbxFoto3";
            this.pbxFoto3.Size = new System.Drawing.Size(200, 362);
            this.pbxFoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto3.TabIndex = 0;
            this.pbxFoto3.TabStop = false;
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialogFoto";
            // 
            // TelaFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TelaFotos";
            this.Text = "TelaFotos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxFoto2;
        private System.Windows.Forms.PictureBox pbxFoto1;
        private System.Windows.Forms.PictureBox pbxFoto3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
    }
}