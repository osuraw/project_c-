namespace Grocery_App
{
    partial class frmClose
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
            this.lblFormclose = new System.Windows.Forms.Label();
            this.lblFormclose2 = new System.Windows.Forms.Label();
            this.btnCloseyes = new System.Windows.Forms.Button();
            this.btnCloseno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormclose
            // 
            this.lblFormclose.AutoSize = true;
            this.lblFormclose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.lblFormclose.Location = new System.Drawing.Point(122, 72);
            this.lblFormclose.Name = "lblFormclose";
            this.lblFormclose.Size = new System.Drawing.Size(225, 22);
            this.lblFormclose.TabIndex = 1;
            this.lblFormclose.Text = "System is about to close";
            this.lblFormclose.Click += new System.EventHandler(this.lblFormclose_Click);
            // 
            // lblFormclose2
            // 
            this.lblFormclose2.AutoSize = true;
            this.lblFormclose2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormclose2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFormclose2.Location = new System.Drawing.Point(73, 98);
            this.lblFormclose2.Name = "lblFormclose2";
            this.lblFormclose2.Size = new System.Drawing.Size(307, 17);
            this.lblFormclose2.TabIndex = 1;
            this.lblFormclose2.Text = "Are you sure that you want to close the system";
            this.lblFormclose2.Click += new System.EventHandler(this.lblFormclose_Click);
            // 
            // btnCloseyes
            // 
            this.btnCloseyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.btnCloseyes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCloseyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.btnCloseyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseyes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseyes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseyes.Location = new System.Drawing.Point(155, 137);
            this.btnCloseyes.Name = "btnCloseyes";
            this.btnCloseyes.Size = new System.Drawing.Size(75, 31);
            this.btnCloseyes.TabIndex = 2;
            this.btnCloseyes.Text = "Yes";
            this.btnCloseyes.UseVisualStyleBackColor = false;
            this.btnCloseyes.Click += new System.EventHandler(this.btnCloseyes_Click);
            // 
            // btnCloseno
            // 
            this.btnCloseno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.btnCloseno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCloseno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.btnCloseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseno.Location = new System.Drawing.Point(236, 137);
            this.btnCloseno.Name = "btnCloseno";
            this.btnCloseno.Size = new System.Drawing.Size(75, 31);
            this.btnCloseno.TabIndex = 2;
            this.btnCloseno.Text = "No";
            this.btnCloseno.UseVisualStyleBackColor = false;
            this.btnCloseno.Click += new System.EventHandler(this.btnCloseno_Click);
            // 
            // frmClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(467, 242);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseno);
            this.Controls.Add(this.btnCloseyes);
            this.Controls.Add(this.lblFormclose2);
            this.Controls.Add(this.lblFormclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloseDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormclose;
        private System.Windows.Forms.Label lblFormclose2;
        private System.Windows.Forms.Button btnCloseyes;
        private System.Windows.Forms.Button btnCloseno;
    }
}