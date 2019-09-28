namespace Shapes.UserControls
{
    partial class UcCircleInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtCenterPointY = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(98, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 26);
            this.txtX.TabIndex = 1;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(13, 47);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "Y";
            // 
            // txtCenterPointY
            // 
            this.txtCenterPointY.Location = new System.Drawing.Point(98, 44);
            this.txtCenterPointY.Name = "txtCenterPointY";
            this.txtCenterPointY.Size = new System.Drawing.Size(100, 26);
            this.txtCenterPointY.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(13, 79);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(71, 20);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Bán kính";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(98, 76);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 26);
            this.txtRadius.TabIndex = 1;
            // 
            // UcCircleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtCenterPointY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcCircleInfo";
            this.Size = new System.Drawing.Size(218, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtCenterPointY;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
    }
}
