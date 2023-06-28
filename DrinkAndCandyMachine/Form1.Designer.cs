namespace DrinkAndCandyMachine
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
            this.ChooseProduct = new System.Windows.Forms.Button();
            this.DryProduct = new System.Windows.Forms.Button();
            this.HotDrink = new System.Windows.Forms.Button();
            this.ColdDrink = new System.Windows.Forms.Button();
            this.Bisli = new System.Windows.Forms.Button();
            this.Choclate = new System.Windows.Forms.Button();
            this.Cola = new System.Windows.Forms.Button();
            this.Juice = new System.Windows.Forms.Button();
            this.Sugar = new System.Windows.Forms.Button();
            this.Coffee = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.ProductDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseProduct
            // 
            this.ChooseProduct.Location = new System.Drawing.Point(353, 12);
            this.ChooseProduct.Name = "ChooseProduct";
            this.ChooseProduct.Size = new System.Drawing.Size(139, 49);
            this.ChooseProduct.TabIndex = 0;
            this.ChooseProduct.Text = "Choose a product";
            this.ChooseProduct.UseVisualStyleBackColor = true;
            this.ChooseProduct.Click += new System.EventHandler(this.ChooseProduct_Click);
            // 
            // DryProduct
            // 
            this.DryProduct.Location = new System.Drawing.Point(615, 91);
            this.DryProduct.Name = "DryProduct";
            this.DryProduct.Size = new System.Drawing.Size(120, 50);
            this.DryProduct.TabIndex = 8;
            this.DryProduct.Text = "Dry candy";
            this.DryProduct.UseVisualStyleBackColor = true;
            this.DryProduct.Click += new System.EventHandler(this.DryProduct_Click);
            // 
            // HotDrink
            // 
            this.HotDrink.Location = new System.Drawing.Point(362, 91);
            this.HotDrink.Name = "HotDrink";
            this.HotDrink.Size = new System.Drawing.Size(120, 50);
            this.HotDrink.TabIndex = 9;
            this.HotDrink.Text = "Hot drink";
            this.HotDrink.UseVisualStyleBackColor = true;
            this.HotDrink.Click += new System.EventHandler(this.HotDrink_Click);
            // 
            // ColdDrink
            // 
            this.ColdDrink.Location = new System.Drawing.Point(116, 91);
            this.ColdDrink.Name = "ColdDrink";
            this.ColdDrink.Size = new System.Drawing.Size(120, 50);
            this.ColdDrink.TabIndex = 10;
            this.ColdDrink.Text = "cold drink";
            this.ColdDrink.UseVisualStyleBackColor = true;
            this.ColdDrink.Click += new System.EventHandler(this.ColdDrink_Click);
            // 
            // Bisli
            // 
            this.Bisli.AutoSize = true;
            this.Bisli.Location = new System.Drawing.Point(615, 163);
            this.Bisli.Name = "Bisli";
            this.Bisli.Size = new System.Drawing.Size(120, 31);
            this.Bisli.TabIndex = 11;
            this.Bisli.Text = "Bisli";
            this.Bisli.UseVisualStyleBackColor = true;
            this.Bisli.Click += new System.EventHandler(this.Bisli_Button);
            // 
            // Choclate
            // 
            this.Choclate.AutoSize = true;
            this.Choclate.Location = new System.Drawing.Point(615, 203);
            this.Choclate.Name = "Choclate";
            this.Choclate.Size = new System.Drawing.Size(120, 29);
            this.Choclate.TabIndex = 12;
            this.Choclate.Text = "Choclate";
            this.Choclate.UseVisualStyleBackColor = true;
            this.Choclate.Click += new System.EventHandler(this.Choclate_Button);
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Location = new System.Drawing.Point(116, 163);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(120, 31);
            this.Cola.TabIndex = 13;
            this.Cola.Text = "Cup of cola";
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.Click += new System.EventHandler(this.Cola_Button);
            // 
            // Juice
            // 
            this.Juice.AutoSize = true;
            this.Juice.Location = new System.Drawing.Point(116, 203);
            this.Juice.Name = "Juice";
            this.Juice.Size = new System.Drawing.Size(120, 29);
            this.Juice.TabIndex = 14;
            this.Juice.Text = "Cup of juice";
            this.Juice.UseVisualStyleBackColor = true;
            this.Juice.Click += new System.EventHandler(this.Juice_Button);
            // 
            // Sugar
            // 
            this.Sugar.Location = new System.Drawing.Point(362, 163);
            this.Sugar.Name = "Sugar";
            this.Sugar.Size = new System.Drawing.Size(120, 31);
            this.Sugar.TabIndex = 15;
            this.Sugar.Text = "Add sugar";
            this.Sugar.UseVisualStyleBackColor = true;
            this.Sugar.Click += new System.EventHandler(this.Sugar_Click);
            // 
            // Coffee
            // 
            this.Coffee.Location = new System.Drawing.Point(362, 203);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(120, 29);
            this.Coffee.TabIndex = 16;
            this.Coffee.Text = "Add coffee";
            this.Coffee.UseVisualStyleBackColor = true;
            this.Coffee.Click += new System.EventHandler(this.Coffee_Click);
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(353, 263);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(139, 50);
            this.Choose.TabIndex = 17;
            this.Choose.Text = "Go to payment";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // ProductDetails
            // 
            this.ProductDetails.AutoSize = true;
            this.ProductDetails.Location = new System.Drawing.Point(200, 470);
            this.ProductDetails.Name = "ProductDetails";
            this.ProductDetails.Size = new System.Drawing.Size(0, 15);
            this.ProductDetails.TabIndex = 18;
            this.ProductDetails.Click += new System.EventHandler(this.ProductDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 646);
            this.Controls.Add(this.ProductDetails);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Coffee);
            this.Controls.Add(this.Sugar);
            this.Controls.Add(this.Juice);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.Choclate);
            this.Controls.Add(this.Bisli);
            this.Controls.Add(this.ColdDrink);
            this.Controls.Add(this.HotDrink);
            this.Controls.Add(this.DryProduct);
            this.Controls.Add(this.ChooseProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChooseProduct;
        private Button DryProduct;
        private Button HotDrink;
        private Button ColdDrink;
        private Button Bisli;
        private Button Choclate;
        private Button Cola;
        private Button Juice;
        private Button Sugar;
        private Button Coffee;
        private Button Choose;
        private Label ProductDetails;
    }
}