namespace TpvApp
{
    partial class FormInitOrtder
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
            this.buttonInitOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInitOrder
            // 
            this.buttonInitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInitOrder.Location = new System.Drawing.Point(0, 1);
            this.buttonInitOrder.Name = "buttonInitOrder";
            this.buttonInitOrder.Size = new System.Drawing.Size(1371, 776);
            this.buttonInitOrder.TabIndex = 19;
            this.buttonInitOrder.Text = "Pulsa para Iniciar nuevo Pedido";
            this.buttonInitOrder.UseVisualStyleBackColor = true;
            this.buttonInitOrder.Click += new System.EventHandler(this.buttonInitOrder_Click);
            // 
            // FormInitOrtder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.buttonInitOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInitOrtder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInitOrder;
    }
}