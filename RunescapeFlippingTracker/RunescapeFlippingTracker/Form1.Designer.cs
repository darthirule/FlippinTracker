namespace RunescapeFlippingTracker
{
    partial class HomeForm
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblAverageBuyPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbBuyPrice = new System.Windows.Forms.TextBox();
            this.txtbAvgBuyPrice = new System.Windows.Forms.TextBox();
            this.txtbAmountPurchased = new System.Windows.Forms.TextBox();
            this.txtbAvgPurchased = new System.Windows.Forms.TextBox();
            this.txtbLTotalPurchased = new System.Windows.Forms.TextBox();
            this.txtbLifeTimeProfit = new System.Windows.Forms.TextBox();
            this.txtbSellPrice = new System.Windows.Forms.TextBox();
            this.txtbAvgSellPrice = new System.Windows.Forms.TextBox();
            this.txtbAmountSold = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(385, 41);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(178, 39);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "No Item Selected";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.Location = new System.Drawing.Point(232, 118);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(100, 23);
            this.lblBuyPrice.TabIndex = 1;
            this.lblBuyPrice.Text = "Buy Price:";
            // 
            // lblAverageBuyPrice
            // 
            this.lblAverageBuyPrice.AutoSize = true;
            this.lblAverageBuyPrice.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageBuyPrice.Location = new System.Drawing.Point(162, 141);
            this.lblAverageBuyPrice.Name = "lblAverageBuyPrice";
            this.lblAverageBuyPrice.Size = new System.Drawing.Size(170, 18);
            this.lblAverageBuyPrice.TabIndex = 2;
            this.lblAverageBuyPrice.Text = "Average Buy Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount Purchased:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average Purchased:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Life Time Total Purchased:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Life Time Profit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sell Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Average Sell Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(573, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Amount Sold:";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(217, 312);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(134, 36);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(585, 312);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(134, 36);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // txtbBuyPrice
            // 
            this.txtbBuyPrice.Location = new System.Drawing.Point(338, 118);
            this.txtbBuyPrice.Name = "txtbBuyPrice";
            this.txtbBuyPrice.ReadOnly = true;
            this.txtbBuyPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbBuyPrice.TabIndex = 13;
            // 
            // txtbAvgBuyPrice
            // 
            this.txtbAvgBuyPrice.Location = new System.Drawing.Point(338, 145);
            this.txtbAvgBuyPrice.Name = "txtbAvgBuyPrice";
            this.txtbAvgBuyPrice.ReadOnly = true;
            this.txtbAvgBuyPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbAvgBuyPrice.TabIndex = 14;
            // 
            // txtbAmountPurchased
            // 
            this.txtbAmountPurchased.Location = new System.Drawing.Point(338, 175);
            this.txtbAmountPurchased.Name = "txtbAmountPurchased";
            this.txtbAmountPurchased.ReadOnly = true;
            this.txtbAmountPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtbAmountPurchased.TabIndex = 15;
            // 
            // txtbAvgPurchased
            // 
            this.txtbAvgPurchased.Location = new System.Drawing.Point(338, 203);
            this.txtbAvgPurchased.Name = "txtbAvgPurchased";
            this.txtbAvgPurchased.ReadOnly = true;
            this.txtbAvgPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtbAvgPurchased.TabIndex = 16;
            // 
            // txtbLTotalPurchased
            // 
            this.txtbLTotalPurchased.Location = new System.Drawing.Point(339, 230);
            this.txtbLTotalPurchased.Name = "txtbLTotalPurchased";
            this.txtbLTotalPurchased.ReadOnly = true;
            this.txtbLTotalPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtbLTotalPurchased.TabIndex = 17;
            // 
            // txtbLifeTimeProfit
            // 
            this.txtbLifeTimeProfit.Location = new System.Drawing.Point(468, 264);
            this.txtbLifeTimeProfit.Name = "txtbLifeTimeProfit";
            this.txtbLifeTimeProfit.ReadOnly = true;
            this.txtbLifeTimeProfit.Size = new System.Drawing.Size(100, 20);
            this.txtbLifeTimeProfit.TabIndex = 18;
            // 
            // txtbSellPrice
            // 
            this.txtbSellPrice.Location = new System.Drawing.Point(695, 118);
            this.txtbSellPrice.Name = "txtbSellPrice";
            this.txtbSellPrice.ReadOnly = true;
            this.txtbSellPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbSellPrice.TabIndex = 19;
            // 
            // txtbAvgSellPrice
            // 
            this.txtbAvgSellPrice.Location = new System.Drawing.Point(696, 144);
            this.txtbAvgSellPrice.Name = "txtbAvgSellPrice";
            this.txtbAvgSellPrice.ReadOnly = true;
            this.txtbAvgSellPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbAvgSellPrice.TabIndex = 20;
            // 
            // txtbAmountSold
            // 
            this.txtbAmountSold.Location = new System.Drawing.Point(696, 173);
            this.txtbAmountSold.Name = "txtbAmountSold";
            this.txtbAmountSold.ReadOnly = true;
            this.txtbAmountSold.Size = new System.Drawing.Size(100, 20);
            this.txtbAmountSold.TabIndex = 21;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 370);
            this.Controls.Add(this.txtbAmountSold);
            this.Controls.Add(this.txtbAvgSellPrice);
            this.Controls.Add(this.txtbSellPrice);
            this.Controls.Add(this.txtbLifeTimeProfit);
            this.Controls.Add(this.txtbLTotalPurchased);
            this.Controls.Add(this.txtbAvgPurchased);
            this.Controls.Add(this.txtbAmountPurchased);
            this.Controls.Add(this.txtbAvgBuyPrice);
            this.Controls.Add(this.txtbBuyPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAverageBuyPrice);
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeForm";
            this.Text = "Flippin\' Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblAverageBuyPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbBuyPrice;
        private System.Windows.Forms.TextBox txtbAvgBuyPrice;
        private System.Windows.Forms.TextBox txtbAmountPurchased;
        private System.Windows.Forms.TextBox txtbAvgPurchased;
        private System.Windows.Forms.TextBox txtbLTotalPurchased;
        private System.Windows.Forms.TextBox txtbLifeTimeProfit;
        private System.Windows.Forms.TextBox txtbSellPrice;
        private System.Windows.Forms.TextBox txtbAvgSellPrice;
        private System.Windows.Forms.TextBox txtbAmountSold;
    }
}

