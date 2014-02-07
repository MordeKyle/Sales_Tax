namespace Sales_Tax
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.salePriceTB = new System.Windows.Forms.TextBox();
            this.amountOfPurchaseLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxOutput = new System.Windows.Forms.Label();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.stateSalesTaxOutput = new System.Windows.Forms.Label();
            this.totalSalesTaxLabel = new System.Windows.Forms.Label();
            this.totalSalesTaxOutput = new System.Windows.Forms.Label();
            this.totalOfPurchaseLabel = new System.Windows.Forms.Label();
            this.totalOfPurchaseOutput = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salePriceTB
            // 
            this.salePriceTB.Location = new System.Drawing.Point(172, 21);
            this.salePriceTB.Name = "salePriceTB";
            this.salePriceTB.Size = new System.Drawing.Size(100, 20);
            this.salePriceTB.TabIndex = 0;
            this.salePriceTB.TextChanged += new System.EventHandler(this.salePriceTB_TextChanged);
            // 
            // amountOfPurchaseLabel
            // 
            this.amountOfPurchaseLabel.AutoSize = true;
            this.amountOfPurchaseLabel.Location = new System.Drawing.Point(12, 24);
            this.amountOfPurchaseLabel.Name = "amountOfPurchaseLabel";
            this.amountOfPurchaseLabel.Size = new System.Drawing.Size(103, 13);
            this.amountOfPurchaseLabel.TabIndex = 1;
            this.amountOfPurchaseLabel.Text = "Amount of Purchase";
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.AutoSize = true;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(12, 64);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(90, 13);
            this.countySalesTaxLabel.TabIndex = 2;
            this.countySalesTaxLabel.Text = "County Sales Tax";
            // 
            // countySalesTaxOutput
            // 
            this.countySalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countySalesTaxOutput.Location = new System.Drawing.Point(172, 60);
            this.countySalesTaxOutput.Name = "countySalesTaxOutput";
            this.countySalesTaxOutput.Size = new System.Drawing.Size(100, 23);
            this.countySalesTaxOutput.TabIndex = 3;
            this.countySalesTaxOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.AutoSize = true;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(12, 104);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(82, 13);
            this.stateSalesTaxLabel.TabIndex = 4;
            this.stateSalesTaxLabel.Text = "State Sales Tax";
            // 
            // stateSalesTaxOutput
            // 
            this.stateSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stateSalesTaxOutput.Location = new System.Drawing.Point(172, 100);
            this.stateSalesTaxOutput.Name = "stateSalesTaxOutput";
            this.stateSalesTaxOutput.Size = new System.Drawing.Size(100, 23);
            this.stateSalesTaxOutput.TabIndex = 5;
            // 
            // totalSalesTaxLabel
            // 
            this.totalSalesTaxLabel.AutoSize = true;
            this.totalSalesTaxLabel.Location = new System.Drawing.Point(12, 144);
            this.totalSalesTaxLabel.Name = "totalSalesTaxLabel";
            this.totalSalesTaxLabel.Size = new System.Drawing.Size(81, 13);
            this.totalSalesTaxLabel.TabIndex = 6;
            this.totalSalesTaxLabel.Text = "Total Sales Tax";
            // 
            // totalSalesTaxOutput
            // 
            this.totalSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesTaxOutput.Location = new System.Drawing.Point(172, 140);
            this.totalSalesTaxOutput.Name = "totalSalesTaxOutput";
            this.totalSalesTaxOutput.Size = new System.Drawing.Size(100, 23);
            this.totalSalesTaxOutput.TabIndex = 7;
            // 
            // totalOfPurchaseLabel
            // 
            this.totalOfPurchaseLabel.AutoSize = true;
            this.totalOfPurchaseLabel.Location = new System.Drawing.Point(12, 184);
            this.totalOfPurchaseLabel.Name = "totalOfPurchaseLabel";
            this.totalOfPurchaseLabel.Size = new System.Drawing.Size(106, 13);
            this.totalOfPurchaseLabel.TabIndex = 8;
            this.totalOfPurchaseLabel.Text = "Total Amount of Sale";
            // 
            // totalOfPurchaseOutput
            // 
            this.totalOfPurchaseOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOfPurchaseOutput.Location = new System.Drawing.Point(172, 180);
            this.totalOfPurchaseOutput.Name = "totalOfPurchaseOutput";
            this.totalOfPurchaseOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOfPurchaseOutput.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 227);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalOfPurchaseOutput);
            this.Controls.Add(this.totalOfPurchaseLabel);
            this.Controls.Add(this.totalSalesTaxOutput);
            this.Controls.Add(this.totalSalesTaxLabel);
            this.Controls.Add(this.stateSalesTaxOutput);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.countySalesTaxOutput);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.amountOfPurchaseLabel);
            this.Controls.Add(this.salePriceTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Sales Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salePriceTB;
        private System.Windows.Forms.Label amountOfPurchaseLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxOutput;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label stateSalesTaxOutput;
        private System.Windows.Forms.Label totalSalesTaxLabel;
        private System.Windows.Forms.Label totalSalesTaxOutput;
        private System.Windows.Forms.Label totalOfPurchaseLabel;
        private System.Windows.Forms.Label totalOfPurchaseOutput;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

