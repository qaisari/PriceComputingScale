namespace PriceComputingScale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            btApple = new Button();
            btBanana = new Button();
            btPear = new Button();
            btOrange = new Button();
            tbWeight = new TextBox();
            lbPrice = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btApple, 0, 0);
            tableLayoutPanel1.Controls.Add(btBanana, 0, 1);
            tableLayoutPanel1.Controls.Add(btPear, 1, 0);
            tableLayoutPanel1.Controls.Add(btOrange, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 365);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btApple
            // 
            btApple.Dock = DockStyle.Fill;
            btApple.Image = (Image)resources.GetObject("btApple.Image");
            btApple.Location = new Point(3, 3);
            btApple.Name = "btApple";
            btApple.Size = new Size(394, 176);
            btApple.TabIndex = 0;
            btApple.Text = "700";
            btApple.UseVisualStyleBackColor = true;
            btApple.Click += bt_Click;
            // 
            // btBanana
            // 
            btBanana.Dock = DockStyle.Fill;
            btBanana.Image = (Image)resources.GetObject("btBanana.Image");
            btBanana.Location = new Point(3, 185);
            btBanana.Name = "btBanana";
            btBanana.Size = new Size(394, 177);
            btBanana.TabIndex = 1;
            btBanana.Text = "600";
            btBanana.UseVisualStyleBackColor = true;
            btBanana.Click += bt_Click;
            // 
            // btPear
            // 
            btPear.Dock = DockStyle.Fill;
            btPear.Image = (Image)resources.GetObject("btPear.Image");
            btPear.Location = new Point(403, 3);
            btPear.Name = "btPear";
            btPear.Size = new Size(394, 176);
            btPear.TabIndex = 2;
            btPear.Text = "800";
            btPear.UseVisualStyleBackColor = true;
            btPear.Click += bt_Click;
            // 
            // btOrange
            // 
            btOrange.Dock = DockStyle.Fill;
            btOrange.Image = (Image)resources.GetObject("btOrange.Image");
            btOrange.Location = new Point(403, 185);
            btOrange.Name = "btOrange";
            btOrange.RightToLeft = RightToLeft.No;
            btOrange.Size = new Size(394, 177);
            btOrange.TabIndex = 3;
            btOrange.Text = "500";
            btOrange.UseVisualStyleBackColor = true;
            btOrange.Click += bt_Click;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(12, 392);
            tbWeight.Name = "tbWeight";
            tbWeight.PlaceholderText = "Enter weight in Kg";
            tbWeight.Size = new Size(132, 27);
            tbWeight.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(200, 395);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(17, 20);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 395);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Price:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbPrice);
            Controls.Add(tbWeight);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Price computing scale";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btApple;
        private Button btBanana;
        private Button btPear;
        private Button btOrange;
        private TextBox tbWeight;
        private Label lbPrice;
        private Label label1;
    }
}
