namespace СarShops
{
    partial class ProductForm
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
            this.SAVE = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelFuel = new System.Windows.Forms.Label();
            this.PurchaseCostTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellCostTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGearBox = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelConsumption = new System.Windows.Forms.Label();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.comboFuel = new System.Windows.Forms.ComboBox();
            this.comboGearBox = new System.Windows.Forms.ComboBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxConsumption = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(12, 409);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(776, 29);
            this.SAVE.TabIndex = 38;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(65, 97);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(36, 20);
            this.labelFuel.TabIndex = 39;
            this.labelFuel.Text = "Fuel";
            // 
            // PurchaseCostTb
            // 
            this.PurchaseCostTb.Location = new System.Drawing.Point(471, 61);
            this.PurchaseCostTb.Name = "PurchaseCostTb";
            this.PurchaseCostTb.Size = new System.Drawing.Size(125, 27);
            this.PurchaseCostTb.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Purchase Cost";
            // 
            // SellCostTb
            // 
            this.SellCostTb.Location = new System.Drawing.Point(471, 125);
            this.SellCostTb.Name = "SellCostTb";
            this.SellCostTb.Size = new System.Drawing.Size(125, 27);
            this.SellCostTb.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Sell Cost";
            // 
            // labelGearBox
            // 
            this.labelGearBox.AutoSize = true;
            this.labelGearBox.Location = new System.Drawing.Point(342, 34);
            this.labelGearBox.Name = "labelGearBox";
            this.labelGearBox.Size = new System.Drawing.Size(65, 20);
            this.labelGearBox.TabIndex = 53;
            this.labelGearBox.Text = "GearBox";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(217, 34);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 51;
            this.labelModel.Text = "Model";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(64, 34);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(48, 20);
            this.labelBrand.TabIndex = 49;
            this.labelBrand.Text = "Brand";
            // 
            // labelConsumption
            // 
            this.labelConsumption.AutoSize = true;
            this.labelConsumption.Location = new System.Drawing.Point(187, 97);
            this.labelConsumption.Name = "labelConsumption";
            this.labelConsumption.Size = new System.Drawing.Size(97, 20);
            this.labelConsumption.TabIndex = 57;
            this.labelConsumption.Text = "Consumption";
            // 
            // comboBrand
            // 
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(24, 59);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(125, 28);
            this.comboBrand.TabIndex = 64;
            this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.Brand_SelectedIndexChanged);
            // 
            // comboFuel
            // 
            this.comboFuel.FormattingEnabled = true;
            this.comboFuel.Location = new System.Drawing.Point(24, 124);
            this.comboFuel.Name = "comboFuel";
            this.comboFuel.Size = new System.Drawing.Size(125, 28);
            this.comboFuel.TabIndex = 65;
            // 
            // comboGearBox
            // 
            this.comboGearBox.FormattingEnabled = true;
            this.comboGearBox.Location = new System.Drawing.Point(317, 60);
            this.comboGearBox.Name = "comboGearBox";
            this.comboGearBox.Size = new System.Drawing.Size(125, 28);
            this.comboGearBox.TabIndex = 66;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(174, 61);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(125, 27);
            this.textBoxModel.TabIndex = 67;
            // 
            // textBoxConsumption
            // 
            this.textBoxConsumption.Location = new System.Drawing.Point(174, 125);
            this.textBoxConsumption.Name = "textBoxConsumption";
            this.textBoxConsumption.Size = new System.Drawing.Size(125, 27);
            this.textBoxConsumption.TabIndex = 68;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(317, 124);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(125, 27);
            this.textBoxVolume.TabIndex = 71;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(348, 101);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(59, 20);
            this.labelVolume.TabIndex = 72;
            this.labelVolume.Text = "Volume";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxConsumption);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboGearBox);
            this.Controls.Add(this.comboFuel);
            this.Controls.Add(this.comboBrand);
            this.Controls.Add(this.labelConsumption);
            this.Controls.Add(this.labelGearBox);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.SellCostTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PurchaseCostTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.SAVE);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SAVE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.TextBox PurchaseCostTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellCostTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGearBox;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelConsumption;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.ComboBox comboFuel;
        private System.Windows.Forms.ComboBox comboGearBox;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxConsumption;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label labelVolume;
    }
}