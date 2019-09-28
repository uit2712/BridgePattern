namespace Shapes
{
    partial class FrmShapes
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.cbbShape = new System.Windows.Forms.ComboBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.cbbStyleDrawing = new System.Windows.Forms.ComboBox();
            this.lblStyle = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Location = new System.Drawing.Point(19, 18);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(277, 366);
            this.pnlView.TabIndex = 0;
            // 
            // cbbShape
            // 
            this.cbbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShape.FormattingEnabled = true;
            this.cbbShape.Items.AddRange(new object[] {
            "Hình tròn",
            "Hình chữ nhật"});
            this.cbbShape.Location = new System.Drawing.Point(380, 18);
            this.cbbShape.Name = "cbbShape";
            this.cbbShape.Size = new System.Drawing.Size(138, 28);
            this.cbbShape.TabIndex = 1;
            this.cbbShape.SelectedIndexChanged += new System.EventHandler(this.cbbShape_SelectedIndexChanged);
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(315, 21);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(42, 20);
            this.lblShape.TabIndex = 2;
            this.lblShape.Text = "Hình";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(315, 93);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 20);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Màu";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.Black;
            this.pnlColor.Location = new System.Drawing.Point(380, 87);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(30, 30);
            this.pnlColor.TabIndex = 3;
            this.pnlColor.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // cbbStyleDrawing
            // 
            this.cbbStyleDrawing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStyleDrawing.FormattingEnabled = true;
            this.cbbStyleDrawing.Items.AddRange(new object[] {
            "Liền nét",
            "Đứt nét"});
            this.cbbStyleDrawing.Location = new System.Drawing.Point(380, 52);
            this.cbbStyleDrawing.Name = "cbbStyleDrawing";
            this.cbbStyleDrawing.Size = new System.Drawing.Size(138, 28);
            this.cbbStyleDrawing.TabIndex = 1;
            this.cbbStyleDrawing.SelectedIndexChanged += new System.EventHandler(this.cbbStyleDrawing_SelectedIndexChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(315, 55);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(60, 20);
            this.lblStyle.TabIndex = 2;
            this.lblStyle.Text = "Kiểu vẽ";
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Location = new System.Drawing.Point(319, 354);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(199, 30);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Vẽ";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // FrmShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 408);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.cbbStyleDrawing);
            this.Controls.Add(this.cbbShape);
            this.Controls.Add(this.pnlView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmShapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ hình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ComboBox cbbShape;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.ComboBox cbbStyleDrawing;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Button btnDraw;
    }
}

