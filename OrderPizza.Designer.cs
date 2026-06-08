namespace My_Pizza_Project
{
    partial class PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pgSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkGreenPaper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExraCheese = new System.Windows.Forms.CheckBox();
            this.rbEat_In = new System.Windows.Forms.RadioButton();
            this.rbTake_out = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSet_Toppings = new System.Windows.Forms.Label();
            this.lblSet_Place = new System.Windows.Forms.Label();
            this.lblSet_CrustType = new System.Windows.Forms.Label();
            this.lblSet_Size = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnClosePizzaOrder = new System.Windows.Forms.Button();
            this.pgSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(151, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(921, 111);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // pgSize
            // 
            this.pgSize.BackColor = System.Drawing.Color.Transparent;
            this.pgSize.Controls.Add(this.rbSmall);
            this.pgSize.Controls.Add(this.rbMeduim);
            this.pgSize.Controls.Add(this.rbLarge);
            this.pgSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.pgSize.ForeColor = System.Drawing.Color.Orange;
            this.pgSize.Location = new System.Drawing.Point(196, 152);
            this.pgSize.Name = "pgSize";
            this.pgSize.Size = new System.Drawing.Size(148, 135);
            this.pgSize.TabIndex = 4;
            this.pgSize.TabStop = false;
            this.pgSize.Text = "Size";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbSmall.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbSmall.Location = new System.Drawing.Point(14, 102);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(79, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.btnSmall_CheckedChanged_1);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.BackColor = System.Drawing.Color.Transparent;
            this.rbMeduim.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbMeduim.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbMeduim.Location = new System.Drawing.Point(14, 72);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(98, 23);
            this.rbMeduim.TabIndex = 0;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = false;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.btnMeduim_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbLarge.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbLarge.Location = new System.Drawing.Point(14, 42);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(80, 23);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.btnLarge_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblPrice.Location = new System.Drawing.Point(174, 326);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 52);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Tag = "20";
            this.lblPrice.Text = "$0";
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThinCrust.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbThinCrust.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbThinCrust.Location = new System.Drawing.Point(14, 45);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(118, 23);
            this.rbThinCrust.TabIndex = 6;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThickCrust.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbThickCrust.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbThickCrust.Location = new System.Drawing.Point(14, 75);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(126, 23);
            this.rbThickCrust.TabIndex = 7;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = false;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbCrustType.ForeColor = System.Drawing.Color.Orange;
            this.gbCrustType.Location = new System.Drawing.Point(196, 324);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(148, 112);
            this.gbCrustType.TabIndex = 8;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.chkGreenPaper);
            this.gbTopping.Controls.Add(this.chkOlives);
            this.gbTopping.Controls.Add(this.chkOnion);
            this.gbTopping.Controls.Add(this.chkTomato);
            this.gbTopping.Controls.Add(this.chkMushrooms);
            this.gbTopping.Controls.Add(this.chkExraCheese);
            this.gbTopping.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbTopping.ForeColor = System.Drawing.Color.Orange;
            this.gbTopping.Location = new System.Drawing.Point(397, 152);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(374, 135);
            this.gbTopping.TabIndex = 14;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Toppings";
            // 
            // chkGreenPaper
            // 
            this.chkGreenPaper.AutoSize = true;
            this.chkGreenPaper.BackColor = System.Drawing.Color.Transparent;
            this.chkGreenPaper.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkGreenPaper.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkGreenPaper.Location = new System.Drawing.Point(205, 103);
            this.chkGreenPaper.Name = "chkGreenPaper";
            this.chkGreenPaper.Size = new System.Drawing.Size(137, 23);
            this.chkGreenPaper.TabIndex = 18;
            this.chkGreenPaper.Tag = "5";
            this.chkGreenPaper.Text = "Green Paper";
            this.chkGreenPaper.UseVisualStyleBackColor = false;
            this.chkGreenPaper.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.Transparent;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkOlives.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkOlives.Location = new System.Drawing.Point(205, 74);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(84, 23);
            this.chkOlives.TabIndex = 18;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkOnion.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkOnion.Location = new System.Drawing.Point(205, 43);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(82, 23);
            this.chkOnion.TabIndex = 18;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.BackColor = System.Drawing.Color.Transparent;
            this.chkTomato.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkTomato.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkTomato.Location = new System.Drawing.Point(35, 106);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(98, 23);
            this.chkTomato.TabIndex = 18;
            this.chkTomato.Tag = "5";
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = false;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkMushrooms.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkMushrooms.Location = new System.Drawing.Point(35, 74);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(127, 23);
            this.chkMushrooms.TabIndex = 18;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // chkExraCheese
            // 
            this.chkExraCheese.AutoSize = true;
            this.chkExraCheese.BackColor = System.Drawing.Color.Transparent;
            this.chkExraCheese.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chkExraCheese.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkExraCheese.Location = new System.Drawing.Point(35, 43);
            this.chkExraCheese.Name = "chkExraCheese";
            this.chkExraCheese.Size = new System.Drawing.Size(143, 23);
            this.chkExraCheese.TabIndex = 17;
            this.chkExraCheese.Tag = "5";
            this.chkExraCheese.Text = "Extra Cheese";
            this.chkExraCheese.UseVisualStyleBackColor = false;
            this.chkExraCheese.CheckedChanged += new System.EventHandler(this.gbTopping_CheckedChange);
            // 
            // rbEat_In
            // 
            this.rbEat_In.AutoSize = true;
            this.rbEat_In.BackColor = System.Drawing.Color.Transparent;
            this.rbEat_In.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbEat_In.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbEat_In.Location = new System.Drawing.Point(40, 40);
            this.rbEat_In.Name = "rbEat_In";
            this.rbEat_In.Size = new System.Drawing.Size(81, 23);
            this.rbEat_In.TabIndex = 15;
            this.rbEat_In.TabStop = true;
            this.rbEat_In.Tag = "0";
            this.rbEat_In.Text = "Eat in";
            this.rbEat_In.UseVisualStyleBackColor = false;
            this.rbEat_In.CheckedChanged += new System.EventHandler(this.rbEat_In_CheckedChanged);
            // 
            // rbTake_out
            // 
            this.rbTake_out.AutoSize = true;
            this.rbTake_out.BackColor = System.Drawing.Color.Transparent;
            this.rbTake_out.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rbTake_out.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbTake_out.Location = new System.Drawing.Point(127, 40);
            this.rbTake_out.Name = "rbTake_out";
            this.rbTake_out.Size = new System.Drawing.Size(109, 23);
            this.rbTake_out.TabIndex = 16;
            this.rbTake_out.TabStop = true;
            this.rbTake_out.Text = "Take Out";
            this.rbTake_out.UseVisualStyleBackColor = false;
            this.rbTake_out.CheckedChanged += new System.EventHandler(this.rbTake_out_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTake_out);
            this.gbWhereToEat.Controls.Add(this.rbEat_In);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbWhereToEat.ForeColor = System.Drawing.Color.Orange;
            this.gbWhereToEat.Location = new System.Drawing.Point(397, 347);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(242, 89);
            this.gbWhereToEat.TabIndex = 17;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Tag = "0";
            this.gbWhereToEat.Text = "Where to Eat";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Orange;
            this.lblCount.Location = new System.Drawing.Point(653, 355);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(76, 22);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "Count :";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtCount.ForeColor = System.Drawing.Color.White;
            this.txtCount.Location = new System.Drawing.Point(735, 355);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(53, 27);
            this.txtCount.TabIndex = 18;
            this.txtCount.Tag = "1";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Orange;
            this.lblTotalPrice.Location = new System.Drawing.Point(18, 326);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(157, 29);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.flowLayoutPanel1);
            this.gbOrderSummary.Controls.Add(this.lblSet_Place);
            this.gbOrderSummary.Controls.Add(this.lblSet_CrustType);
            this.gbOrderSummary.Controls.Add(this.lblSet_Size);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblPrice);
            this.gbOrderSummary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Orange;
            this.gbOrderSummary.Location = new System.Drawing.Point(794, 152);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(433, 399);
            this.gbOrderSummary.TabIndex = 21;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblSet_Toppings);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 84);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // lblSet_Toppings
            // 
            this.lblSet_Toppings.AutoSize = true;
            this.lblSet_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.lblSet_Toppings.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSet_Toppings.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSet_Toppings.ForeColor = System.Drawing.Color.LightGray;
            this.lblSet_Toppings.Location = new System.Drawing.Point(3, 0);
            this.lblSet_Toppings.Name = "lblSet_Toppings";
            this.lblSet_Toppings.Size = new System.Drawing.Size(121, 24);
            this.lblSet_Toppings.TabIndex = 28;
            this.lblSet_Toppings.Text = "No Toppings";
            // 
            // lblSet_Place
            // 
            this.lblSet_Place.AutoSize = true;
            this.lblSet_Place.BackColor = System.Drawing.Color.Transparent;
            this.lblSet_Place.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSet_Place.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSet_Place.ForeColor = System.Drawing.Color.LightGray;
            this.lblSet_Place.Location = new System.Drawing.Point(179, 263);
            this.lblSet_Place.Name = "lblSet_Place";
            this.lblSet_Place.Size = new System.Drawing.Size(37, 29);
            this.lblSet_Place.TabIndex = 30;
            this.lblSet_Place.Text = "   ";
            // 
            // lblSet_CrustType
            // 
            this.lblSet_CrustType.AutoSize = true;
            this.lblSet_CrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblSet_CrustType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSet_CrustType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSet_CrustType.ForeColor = System.Drawing.Color.LightGray;
            this.lblSet_CrustType.Location = new System.Drawing.Point(163, 206);
            this.lblSet_CrustType.Name = "lblSet_CrustType";
            this.lblSet_CrustType.Size = new System.Drawing.Size(28, 24);
            this.lblSet_CrustType.TabIndex = 29;
            this.lblSet_CrustType.Text = "   ";
            // 
            // lblSet_Size
            // 
            this.lblSet_Size.AutoSize = true;
            this.lblSet_Size.BackColor = System.Drawing.Color.Transparent;
            this.lblSet_Size.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSet_Size.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSet_Size.ForeColor = System.Drawing.Color.LightGray;
            this.lblSet_Size.Location = new System.Drawing.Point(106, 46);
            this.lblSet_Size.Name = "lblSet_Size";
            this.lblSet_Size.Size = new System.Drawing.Size(85, 29);
            this.lblSet_Size.TabIndex = 26;
            this.lblSet_Size.Text = "         ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereToEat.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblWhereToEat.ForeColor = System.Drawing.Color.LightGray;
            this.lblWhereToEat.Location = new System.Drawing.Point(6, 263);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(173, 27);
            this.lblWhereToEat.TabIndex = 25;
            this.lblWhereToEat.Text = "Where to eat ?";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCrustType.ForeColor = System.Drawing.Color.LightGray;
            this.lblCrustType.Location = new System.Drawing.Point(7, 206);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(131, 24);
            this.lblCrustType.TabIndex = 24;
            this.lblCrustType.Text = "Curst Type :";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblToppings.ForeColor = System.Drawing.Color.LightGray;
            this.lblToppings.Location = new System.Drawing.Point(6, 89);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(127, 27);
            this.lblToppings.TabIndex = 23;
            this.lblToppings.Text = "Toppings :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSize.ForeColor = System.Drawing.Color.LightGray;
            this.lblSize.Location = new System.Drawing.Point(6, 46);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(78, 29);
            this.lblSize.TabIndex = 22;
            this.lblSize.Text = "Size :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Tomato;
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Location = new System.Drawing.Point(350, 510);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(260, 79);
            this.btnOrderPizza.TabIndex = 22;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnClosePizzaOrder
            // 
            this.btnClosePizzaOrder.BackColor = System.Drawing.Color.Tomato;
            this.btnClosePizzaOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClosePizzaOrder.ForeColor = System.Drawing.Color.Black;
            this.btnClosePizzaOrder.Location = new System.Drawing.Point(1, -1);
            this.btnClosePizzaOrder.Name = "btnClosePizzaOrder";
            this.btnClosePizzaOrder.Size = new System.Drawing.Size(107, 39);
            this.btnClosePizzaOrder.TabIndex = 1;
            this.btnClosePizzaOrder.Text = "Close";
            this.btnClosePizzaOrder.UseVisualStyleBackColor = false;
            this.btnClosePizzaOrder.Click += new System.EventHandler(this.btnClosePizzaOrder_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1240, 694);
            this.Controls.Add(this.btnClosePizzaOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.pgSize);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "PizzaOrder";
            this.Text = "Pizza_Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.pgSize.ResumeLayout(false);
            this.pgSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbTake_out;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblSet_Size;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblSet_Place;
        private System.Windows.Forms.Label lblSet_CrustType;
        private System.Windows.Forms.Label lblSet_Toppings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClosePizzaOrder;
        public System.Windows.Forms.GroupBox pgSize;
        public System.Windows.Forms.GroupBox gbCrustType;
        public System.Windows.Forms.GroupBox gbTopping;
        public System.Windows.Forms.GroupBox gbWhereToEat;
        public System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.TextBox txtCount;
        public System.Windows.Forms.Button btnOrderPizza;
        public System.Windows.Forms.RadioButton rbThinCrust;
        public System.Windows.Forms.CheckBox chkMushrooms;
        public System.Windows.Forms.CheckBox chkExraCheese;
        public System.Windows.Forms.CheckBox chkTomato;
        public System.Windows.Forms.CheckBox chkGreenPaper;
        public System.Windows.Forms.CheckBox chkOlives;
        public System.Windows.Forms.CheckBox chkOnion;
        public System.Windows.Forms.RadioButton rbSmall;
        protected System.Windows.Forms.RadioButton rbMeduim;
        public System.Windows.Forms.RadioButton rbEat_In;
    }
}

