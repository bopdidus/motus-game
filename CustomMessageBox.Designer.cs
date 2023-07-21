namespace Motus
{
    partial class CustomMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voulez-vous continuer ?";
            // 
            // btnTerminer
            // 
            this.btnTerminer.AccessibleName = "btnOk";
            this.btnTerminer.BackColor = System.Drawing.Color.Red;
            this.btnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminer.ForeColor = System.Drawing.Color.White;
            this.btnTerminer.Image = global::Motus.Properties.Resources.close;
            this.btnTerminer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminer.Location = new System.Drawing.Point(29, 238);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(160, 53);
            this.btnTerminer.TabIndex = 1;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminer.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleName = "btnOk";
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = global::Motus.Properties.Resources.replay;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(328, 238);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 53);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Rejouer";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Motus.Properties.Resources.brick_wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 312);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.label1);
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.Button btnOk;
    }
}