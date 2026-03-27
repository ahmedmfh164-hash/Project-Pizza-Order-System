namespace Project_Pizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ckExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckMushrooms = new System.Windows.Forms.CheckBox();
            this.ckTomatoes = new System.Windows.Forms.CheckBox();
            this.ckOnion = new System.Windows.Forms.CheckBox();
            this.ckOlives = new System.Windows.Forms.CheckBox();
            this.ckGreenPeppers = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labSize = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblPriceOfPiece = new System.Windows.Forms.Label();
            this.lblNumberOfPizzaValue = new System.Windows.Forms.Label();
            this.lblNumberOfPizza = new System.Windows.Forms.Label();
            this.lblPriceOfPieceValue = new System.Windows.Forms.Label();
            this.labWhereToEatValue = new System.Windows.Forms.Label();
            this.labCrustValue = new System.Windows.Forms.Label();
            this.labToppingsValue = new System.Windows.Forms.Label();
            this.labSizeValue = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(41, 100);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(151, 161);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(31, 95);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(65, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(31, 58);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(79, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(31, 24);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(64, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(41, 284);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(168, 110);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(31, 71);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(102, 20);
            this.rbThick.TabIndex = 3;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbCrustType_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(31, 30);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(94, 20);
            this.rbThin.TabIndex = 2;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbCrustType_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.ckExtraCheese);
            this.gbToppings.Controls.Add(this.ckMushrooms);
            this.gbToppings.Controls.Add(this.ckTomatoes);
            this.gbToppings.Controls.Add(this.ckOnion);
            this.gbToppings.Controls.Add(this.ckOlives);
            this.gbToppings.Controls.Add(this.ckGreenPeppers);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(229, 100);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(297, 161);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // ckExtraCheese
            // 
            this.ckExtraCheese.AutoSize = true;
            this.ckExtraCheese.Location = new System.Drawing.Point(6, 27);
            this.ckExtraCheese.Name = "ckExtraCheese";
            this.ckExtraCheese.Size = new System.Drawing.Size(118, 20);
            this.ckExtraCheese.TabIndex = 3;
            this.ckExtraCheese.Tag = "5";
            this.ckExtraCheese.Text = "Extra Cheese";
            this.ckExtraCheese.UseVisualStyleBackColor = true;
            this.ckExtraCheese.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // ckMushrooms
            // 
            this.ckMushrooms.AutoSize = true;
            this.ckMushrooms.Location = new System.Drawing.Point(6, 61);
            this.ckMushrooms.Name = "ckMushrooms";
            this.ckMushrooms.Size = new System.Drawing.Size(105, 20);
            this.ckMushrooms.TabIndex = 4;
            this.ckMushrooms.Tag = "5";
            this.ckMushrooms.Text = "Mushrooms";
            this.ckMushrooms.UseVisualStyleBackColor = true;
            this.ckMushrooms.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // ckTomatoes
            // 
            this.ckTomatoes.AutoSize = true;
            this.ckTomatoes.Location = new System.Drawing.Point(6, 98);
            this.ckTomatoes.Name = "ckTomatoes";
            this.ckTomatoes.Size = new System.Drawing.Size(96, 20);
            this.ckTomatoes.TabIndex = 5;
            this.ckTomatoes.Tag = "5";
            this.ckTomatoes.Text = "Tomatoes";
            this.ckTomatoes.UseVisualStyleBackColor = true;
            this.ckTomatoes.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // ckOnion
            // 
            this.ckOnion.AutoSize = true;
            this.ckOnion.Location = new System.Drawing.Point(143, 27);
            this.ckOnion.Name = "ckOnion";
            this.ckOnion.Size = new System.Drawing.Size(66, 20);
            this.ckOnion.TabIndex = 6;
            this.ckOnion.Tag = "5";
            this.ckOnion.Text = "Onion";
            this.ckOnion.UseVisualStyleBackColor = true;
            this.ckOnion.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // ckOlives
            // 
            this.ckOlives.AutoSize = true;
            this.ckOlives.Location = new System.Drawing.Point(143, 61);
            this.ckOlives.Name = "ckOlives";
            this.ckOlives.Size = new System.Drawing.Size(70, 20);
            this.ckOlives.TabIndex = 7;
            this.ckOlives.Tag = "5";
            this.ckOlives.Text = "Olives";
            this.ckOlives.UseVisualStyleBackColor = true;
            this.ckOlives.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // ckGreenPeppers
            // 
            this.ckGreenPeppers.AutoSize = true;
            this.ckGreenPeppers.Location = new System.Drawing.Point(143, 98);
            this.ckGreenPeppers.Name = "ckGreenPeppers";
            this.ckGreenPeppers.Size = new System.Drawing.Size(131, 20);
            this.ckGreenPeppers.TabIndex = 8;
            this.ckGreenPeppers.Tag = "5";
            this.ckGreenPeppers.Text = "Green Peppers";
            this.ckGreenPeppers.UseVisualStyleBackColor = true;
            this.ckGreenPeppers.CheckedChanged += new System.EventHandler(this.ckToppings_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(229, 284);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(274, 110);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(143, 32);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(88, 20);
            this.rbTakeOut.TabIndex = 4;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbWhereToEat_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(16, 32);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(64, 20);
            this.rbEatIn.TabIndex = 5;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbWhereToEat_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(235, 471);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(152, 45);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(438, 471);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(150, 45);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(12, 24);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(45, 21);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size:";
            this.labSize.UseWaitCursor = true;
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(12, 57);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(85, 21);
            this.labToppings.TabIndex = 1;
            this.labToppings.Text = "Toppings:";
            this.labToppings.UseWaitCursor = true;
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.Location = new System.Drawing.Point(12, 138);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(94, 21);
            this.labCrustType.TabIndex = 2;
            this.labCrustType.Text = "Crust Type:";
            this.labCrustType.UseWaitCursor = true;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.Location = new System.Drawing.Point(12, 301);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(91, 21);
            this.labTotalPrice.TabIndex = 3;
            this.labTotalPrice.Text = "TotalPrice:";
            this.labTotalPrice.UseWaitCursor = true;
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(12, 167);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(112, 21);
            this.labWhereToEat.TabIndex = 4;
            this.labWhereToEat.Text = "Where to Eat:";
            this.labWhereToEat.UseWaitCursor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.SystemColors.Control;
            this.gbOrderSummary.Controls.Add(this.lblTotalPriceValue);
            this.gbOrderSummary.Controls.Add(this.lblPriceOfPiece);
            this.gbOrderSummary.Controls.Add(this.lblNumberOfPizzaValue);
            this.gbOrderSummary.Controls.Add(this.lblNumberOfPizza);
            this.gbOrderSummary.Controls.Add(this.lblPriceOfPieceValue);
            this.gbOrderSummary.Controls.Add(this.labWhereToEatValue);
            this.gbOrderSummary.Controls.Add(this.labCrustValue);
            this.gbOrderSummary.Controls.Add(this.labToppingsValue);
            this.gbOrderSummary.Controls.Add(this.labSizeValue);
            this.gbOrderSummary.Controls.Add(this.labSize);
            this.gbOrderSummary.Controls.Add(this.labToppings);
            this.gbOrderSummary.Controls.Add(this.labCrustType);
            this.gbOrderSummary.Controls.Add(this.labWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labTotalPrice);
            this.gbOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(595, 100);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Padding = new System.Windows.Forms.Padding(0);
            this.gbOrderSummary.Size = new System.Drawing.Size(331, 377);
            this.gbOrderSummary.TabIndex = 6;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            this.gbOrderSummary.UseWaitCursor = true;
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(108, 323);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(108, 37);
            this.lblTotalPriceValue.TabIndex = 6;
            this.lblTotalPriceValue.Text = "label6";
            this.lblTotalPriceValue.UseWaitCursor = true;
            // 
            // lblPriceOfPiece
            // 
            this.lblPriceOfPiece.AutoSize = true;
            this.lblPriceOfPiece.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOfPiece.Location = new System.Drawing.Point(19, 265);
            this.lblPriceOfPiece.Name = "lblPriceOfPiece";
            this.lblPriceOfPiece.Size = new System.Drawing.Size(117, 21);
            this.lblPriceOfPiece.TabIndex = 12;
            this.lblPriceOfPiece.Text = "Price of piece:";
            this.lblPriceOfPiece.UseWaitCursor = true;
            // 
            // lblNumberOfPizzaValue
            // 
            this.lblNumberOfPizzaValue.AutoSize = true;
            this.lblNumberOfPizzaValue.Location = new System.Drawing.Point(159, 233);
            this.lblNumberOfPizzaValue.Name = "lblNumberOfPizzaValue";
            this.lblNumberOfPizzaValue.Size = new System.Drawing.Size(57, 20);
            this.lblNumberOfPizzaValue.TabIndex = 11;
            this.lblNumberOfPizzaValue.Text = "label4";
            this.lblNumberOfPizzaValue.UseWaitCursor = true;
            // 
            // lblNumberOfPizza
            // 
            this.lblNumberOfPizza.AutoSize = true;
            this.lblNumberOfPizza.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizza.Location = new System.Drawing.Point(17, 233);
            this.lblNumberOfPizza.Name = "lblNumberOfPizza";
            this.lblNumberOfPizza.Size = new System.Drawing.Size(141, 21);
            this.lblNumberOfPizza.TabIndex = 10;
            this.lblNumberOfPizza.Text = "Number of Pizza:";
            this.lblNumberOfPizza.UseWaitCursor = true;
            // 
            // lblPriceOfPieceValue
            // 
            this.lblPriceOfPieceValue.AutoSize = true;
            this.lblPriceOfPieceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOfPieceValue.Location = new System.Drawing.Point(142, 265);
            this.lblPriceOfPieceValue.Name = "lblPriceOfPieceValue";
            this.lblPriceOfPieceValue.Size = new System.Drawing.Size(67, 20);
            this.lblPriceOfPieceValue.TabIndex = 9;
            this.lblPriceOfPieceValue.Text = "label11";
            this.lblPriceOfPieceValue.UseWaitCursor = true;
            // 
            // labWhereToEatValue
            // 
            this.labWhereToEatValue.AutoSize = true;
            this.labWhereToEatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEatValue.Location = new System.Drawing.Point(89, 200);
            this.labWhereToEatValue.Name = "labWhereToEatValue";
            this.labWhereToEatValue.Size = new System.Drawing.Size(61, 18);
            this.labWhereToEatValue.TabIndex = 8;
            this.labWhereToEatValue.Text = "label10";
            this.labWhereToEatValue.UseWaitCursor = true;
            // 
            // labCrustValue
            // 
            this.labCrustValue.AutoSize = true;
            this.labCrustValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustValue.Location = new System.Drawing.Point(109, 140);
            this.labCrustValue.Name = "labCrustValue";
            this.labCrustValue.Size = new System.Drawing.Size(52, 18);
            this.labCrustValue.TabIndex = 7;
            this.labCrustValue.Text = "label9";
            this.labCrustValue.UseWaitCursor = true;
            // 
            // labToppingsValue
            // 
            this.labToppingsValue.AutoSize = true;
            this.labToppingsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppingsValue.Location = new System.Drawing.Point(14, 80);
            this.labToppingsValue.MaximumSize = new System.Drawing.Size(300, 0);
            this.labToppingsValue.Name = "labToppingsValue";
            this.labToppingsValue.Size = new System.Drawing.Size(52, 18);
            this.labToppingsValue.TabIndex = 6;
            this.labToppingsValue.Text = "label8";
            this.labToppingsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labToppingsValue.UseWaitCursor = true;
            // 
            // labSizeValue
            // 
            this.labSizeValue.AutoSize = true;
            this.labSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSizeValue.Location = new System.Drawing.Point(51, 24);
            this.labSizeValue.Name = "labSizeValue";
            this.labSizeValue.Size = new System.Drawing.Size(52, 18);
            this.labSizeValue.TabIndex = 5;
            this.labSizeValue.Text = "label7";
            this.labSizeValue.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(438, 418);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 29);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCrustType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ckExtraCheese;
        private System.Windows.Forms.CheckBox ckMushrooms;
        private System.Windows.Forms.CheckBox ckTomatoes;
        private System.Windows.Forms.CheckBox ckOnion;
        private System.Windows.Forms.CheckBox ckOlives;
        private System.Windows.Forms.CheckBox ckGreenPeppers;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblPriceOfPieceValue;
        private System.Windows.Forms.Label labWhereToEatValue;
        private System.Windows.Forms.Label labCrustValue;
        private System.Windows.Forms.Label labToppingsValue;
        private System.Windows.Forms.Label labSizeValue;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfPizza;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblPriceOfPiece;
        private System.Windows.Forms.Label lblNumberOfPizzaValue;
    }
}

