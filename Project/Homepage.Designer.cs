namespace Project
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.writenote = new System.Windows.Forms.Button();
            this.editnotes = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writenote
            // 
            this.writenote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.writenote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writenote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.writenote.Location = new System.Drawing.Point(134, 105);
            this.writenote.Name = "writenote";
            this.writenote.Size = new System.Drawing.Size(425, 50);
            this.writenote.TabIndex = 0;
            this.writenote.Text = "Write New Note";
            this.writenote.UseVisualStyleBackColor = false;
            this.writenote.Click += new System.EventHandler(this.writenote_Click);
            // 
            // editnotes
            // 
            this.editnotes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.editnotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editnotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editnotes.Location = new System.Drawing.Point(134, 226);
            this.editnotes.Name = "editnotes";
            this.editnotes.Size = new System.Drawing.Size(425, 50);
            this.editnotes.TabIndex = 0;
            this.editnotes.Text = "View and Edit Notes";
            this.editnotes.UseVisualStyleBackColor = false;
            this.editnotes.Click += new System.EventHandler(this.editnotes_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(586, 387);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(186, 40);
            this.signout.TabIndex = 1;
            this.signout.Text = "Sign Out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.editnotes);
            this.Controls.Add(this.writenote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writenote;
        private System.Windows.Forms.Button editnotes;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Label label1;
    }
}