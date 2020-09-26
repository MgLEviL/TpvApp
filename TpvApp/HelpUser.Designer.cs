namespace TpvApp
{
    partial class HelpUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpUser));
            this.buttonExitHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitHelp
            // 
            this.buttonExitHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitHelp.Image")));
            this.buttonExitHelp.Location = new System.Drawing.Point(1221, 12);
            this.buttonExitHelp.Name = "buttonExitHelp";
            this.buttonExitHelp.Size = new System.Drawing.Size(137, 95);
            this.buttonExitHelp.TabIndex = 4;
            this.buttonExitHelp.UseVisualStyleBackColor = true;
            this.buttonExitHelp.Click += new System.EventHandler(this.buttonExitHelp_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExitHelp);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.Text = "Help";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitHelp;
    }
}