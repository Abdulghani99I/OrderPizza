namespace OrderPizza
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
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radMeduim = new System.Windows.Forms.RadioButton();
            this.radLarg = new System.Windows.Forms.RadioButton();
            this.gboSize = new System.Windows.Forms.GroupBox();
            this.gboCrustType = new System.Windows.Forms.GroupBox();
            this.radThinCrust = new System.Windows.Forms.RadioButton();
            this.radThikCrust = new System.Windows.Forms.RadioButton();
            this.gboWhereToEat = new System.Windows.Forms.GroupBox();
            this.radEatIn = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.butOrderPizza = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.gboToppings = new System.Windows.Forms.GroupBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gboSize.SuspendLayout();
            this.gboCrustType.SuspendLayout();
            this.gboWhereToEat.SuspendLayout();
            this.gboToppings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(47, 47);
            this.radSmall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(66, 23);
            this.radSmall.TabIndex = 0;
            this.radSmall.Tag = "10";
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // radMeduim
            // 
            this.radMeduim.AutoSize = true;
            this.radMeduim.Checked = true;
            this.radMeduim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMeduim.Location = new System.Drawing.Point(47, 90);
            this.radMeduim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radMeduim.Name = "radMeduim";
            this.radMeduim.Size = new System.Drawing.Size(83, 23);
            this.radMeduim.TabIndex = 1;
            this.radMeduim.TabStop = true;
            this.radMeduim.Tag = "20";
            this.radMeduim.Text = "Meduim";
            this.radMeduim.UseVisualStyleBackColor = true;
            this.radMeduim.CheckedChanged += new System.EventHandler(this.radMeduim_CheckedChanged);
            // 
            // radLarg
            // 
            this.radLarg.AutoSize = true;
            this.radLarg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarg.Location = new System.Drawing.Point(47, 126);
            this.radLarg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLarg.Name = "radLarg";
            this.radLarg.Size = new System.Drawing.Size(58, 23);
            this.radLarg.TabIndex = 2;
            this.radLarg.Tag = "30";
            this.radLarg.Text = "Larg";
            this.radLarg.UseVisualStyleBackColor = true;
            this.radLarg.CheckedChanged += new System.EventHandler(this.radLarg_CheckedChanged);
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.radSmall);
            this.gboSize.Controls.Add(this.radLarg);
            this.gboSize.Controls.Add(this.radMeduim);
            this.gboSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSize.Location = new System.Drawing.Point(14, 72);
            this.gboSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboSize.Name = "gboSize";
            this.gboSize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboSize.Size = new System.Drawing.Size(298, 210);
            this.gboSize.TabIndex = 3;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // gboCrustType
            // 
            this.gboCrustType.Controls.Add(this.radThinCrust);
            this.gboCrustType.Controls.Add(this.radThikCrust);
            this.gboCrustType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCrustType.Location = new System.Drawing.Point(14, 306);
            this.gboCrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboCrustType.Name = "gboCrustType";
            this.gboCrustType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboCrustType.Size = new System.Drawing.Size(298, 210);
            this.gboCrustType.TabIndex = 4;
            this.gboCrustType.TabStop = false;
            this.gboCrustType.Text = "Crust Type";
            // 
            // radThinCrust
            // 
            this.radThinCrust.AutoSize = true;
            this.radThinCrust.Checked = true;
            this.radThinCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThinCrust.Location = new System.Drawing.Point(47, 47);
            this.radThinCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radThinCrust.Name = "radThinCrust";
            this.radThinCrust.Size = new System.Drawing.Size(101, 23);
            this.radThinCrust.TabIndex = 0;
            this.radThinCrust.TabStop = true;
            this.radThinCrust.Tag = "10";
            this.radThinCrust.Text = "Thin Crust";
            this.radThinCrust.UseVisualStyleBackColor = true;
            this.radThinCrust.CheckedChanged += new System.EventHandler(this.radThinCrust_CheckedChanged);
            // 
            // radThikCrust
            // 
            this.radThikCrust.AutoSize = true;
            this.radThikCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThikCrust.Location = new System.Drawing.Point(47, 90);
            this.radThikCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radThikCrust.Name = "radThikCrust";
            this.radThikCrust.Size = new System.Drawing.Size(107, 23);
            this.radThikCrust.TabIndex = 1;
            this.radThikCrust.Tag = "20";
            this.radThikCrust.Text = "Thick Crust";
            this.radThikCrust.UseVisualStyleBackColor = true;
            this.radThikCrust.CheckedChanged += new System.EventHandler(this.radThikCrust_CheckedChanged);
            // 
            // gboWhereToEat
            // 
            this.gboWhereToEat.Controls.Add(this.radEatIn);
            this.gboWhereToEat.Controls.Add(this.radTakeOut);
            this.gboWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboWhereToEat.Location = new System.Drawing.Point(349, 325);
            this.gboWhereToEat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboWhereToEat.Name = "gboWhereToEat";
            this.gboWhereToEat.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboWhereToEat.Size = new System.Drawing.Size(322, 138);
            this.gboWhereToEat.TabIndex = 5;
            this.gboWhereToEat.TabStop = false;
            this.gboWhereToEat.Text = "Where To Eat";
            // 
            // radEatIn
            // 
            this.radEatIn.AutoSize = true;
            this.radEatIn.Checked = true;
            this.radEatIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEatIn.Location = new System.Drawing.Point(21, 69);
            this.radEatIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radEatIn.Name = "radEatIn";
            this.radEatIn.Size = new System.Drawing.Size(69, 23);
            this.radEatIn.TabIndex = 0;
            this.radEatIn.TabStop = true;
            this.radEatIn.Text = "Eat In";
            this.radEatIn.UseVisualStyleBackColor = true;
            this.radEatIn.CheckedChanged += new System.EventHandler(this.radEatIn_CheckedChanged);
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTakeOut.Location = new System.Drawing.Point(184, 69);
            this.radTakeOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(92, 23);
            this.radTakeOut.TabIndex = 1;
            this.radTakeOut.TabStop = true;
            this.radTakeOut.Text = "Take Out";
            this.radTakeOut.UseVisualStyleBackColor = true;
            this.radTakeOut.CheckedChanged += new System.EventHandler(this.radTakeOut_CheckedChanged);
            // 
            // butOrderPizza
            // 
            this.butOrderPizza.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrderPizza.Location = new System.Drawing.Point(349, 469);
            this.butOrderPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butOrderPizza.Name = "butOrderPizza";
            this.butOrderPizza.Size = new System.Drawing.Size(121, 43);
            this.butOrderPizza.TabIndex = 7;
            this.butOrderPizza.Text = "Order Pizza";
            this.butOrderPizza.UseVisualStyleBackColor = true;
            this.butOrderPizza.Click += new System.EventHandler(this.butOrderPizza_Click);
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(554, 469);
            this.butReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(117, 43);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "Reset Form";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(13, 47);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(111, 23);
            this.chkExtraChees.TabIndex = 6;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(13, 90);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(110, 23);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(13, 140);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(98, 23);
            this.chkTomatoes.TabIndex = 8;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // gboToppings
            // 
            this.gboToppings.Controls.Add(this.chkOnion);
            this.gboToppings.Controls.Add(this.chkGreenPeppers);
            this.gboToppings.Controls.Add(this.chkExtraChees);
            this.gboToppings.Controls.Add(this.chkOlives);
            this.gboToppings.Controls.Add(this.chkTomatoes);
            this.gboToppings.Controls.Add(this.chkMushrooms);
            this.gboToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboToppings.Location = new System.Drawing.Point(349, 72);
            this.gboToppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboToppings.Name = "gboToppings";
            this.gboToppings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboToppings.Size = new System.Drawing.Size(322, 216);
            this.gboToppings.TabIndex = 9;
            this.gboToppings.TabStop = false;
            this.gboToppings.Text = "Toppings";
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(158, 47);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(71, 23);
            this.chkOnion.TabIndex = 10;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(158, 140);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(131, 23);
            this.chkGreenPeppers.TabIndex = 12;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(158, 90);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(71, 23);
            this.chkOlives.TabIndex = 11;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labTotalPrice);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.labWhereToEat);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.labCrustType);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.labToppings);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.labSize);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(689, 72);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(375, 444);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.Location = new System.Drawing.Point(148, 372);
            this.labTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(18, 19);
            this.labTotalPrice.TabIndex = 21;
            this.labTotalPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total Price:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(148, 324);
            this.labWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(51, 19);
            this.labWhereToEat.TabIndex = 19;
            this.labWhereToEat.Text = "Eat In";
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(36, 295);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 19);
            this.button9.TabIndex = 18;
            this.button9.Text = "Where to Eat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 17;
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.Location = new System.Drawing.Point(137, 234);
            this.labCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(83, 19);
            this.labCrustType.TabIndex = 16;
            this.labCrustType.Text = "Thin Crust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Crust Type:";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(88, 128);
            this.labToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labToppings.MinimumSize = new System.Drawing.Size(220, 60);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(220, 60);
            this.labToppings.TabIndex = 14;
            this.labToppings.Text = "No Toppings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Toppings:";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(88, 38);
            this.labSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(65, 19);
            this.labSize.TabIndex = 12;
            this.labSize.Text = "Meduim";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 38);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 19);
            this.label20.TabIndex = 11;
            this.label20.Text = "Size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(321, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 48);
            this.label12.TabIndex = 11;
            this.label12.Text = "MAKE YOUR PIZZA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 528);
            this.Controls.Add(this.butOrderPizza);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gboToppings);
            this.Controls.Add(this.gboWhereToEat);
            this.Controls.Add(this.gboCrustType);
            this.Controls.Add(this.gboSize);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Order Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboSize.ResumeLayout(false);
            this.gboSize.PerformLayout();
            this.gboCrustType.ResumeLayout(false);
            this.gboCrustType.PerformLayout();
            this.gboWhereToEat.ResumeLayout(false);
            this.gboWhereToEat.PerformLayout();
            this.gboToppings.ResumeLayout(false);
            this.gboToppings.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radMeduim;
        private System.Windows.Forms.RadioButton radLarg;
        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.GroupBox gboCrustType;
        private System.Windows.Forms.RadioButton radThinCrust;
        private System.Windows.Forms.RadioButton radThikCrust;
        private System.Windows.Forms.GroupBox gboWhereToEat;
        private System.Windows.Forms.RadioButton radEatIn;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.Button butOrderPizza;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.GroupBox gboToppings;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label label12;
    }
}

