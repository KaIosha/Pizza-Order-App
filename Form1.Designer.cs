namespace Pizza_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.cbcheese = new System.Windows.Forms.CheckBox();
            this.chGreen_peppers = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chOliives = new System.Windows.Forms.CheckBox();
            this.chMushrooms = new System.Windows.Forms.CheckBox();
            this.gb_wheretoeat = new System.Windows.Forms.GroupBox();
            this.rbTakeout = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.gb__CrustType = new System.Windows.Forms.GroupBox();
            this.rbthick = new System.Windows.Forms.RadioButton();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbWheretoeat = new System.Windows.Forms.Label();
            this.lbWheretoEt = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCrust_type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gb_size.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_wheretoeat.SuspendLayout();
            this.gb__CrustType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(488, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_size
            // 
            this.gb_size.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_size.Controls.Add(this.rbLarge);
            this.gb_size.Controls.Add(this.rbmedium);
            this.gb_size.Controls.Add(this.rbsmall);
            this.gb_size.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_size.ForeColor = System.Drawing.Color.White;
            this.gb_size.Location = new System.Drawing.Point(19, 492);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(249, 388);
            this.gb_size.TabIndex = 1;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.ForeColor = System.Drawing.Color.White;
            this.rbLarge.Location = new System.Drawing.Point(9, 283);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(120, 39);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedium.ForeColor = System.Drawing.Color.White;
            this.rbmedium.Location = new System.Drawing.Point(9, 185);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(154, 39);
            this.rbmedium.TabIndex = 3;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "10";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsmall.ForeColor = System.Drawing.Color.White;
            this.rbsmall.Location = new System.Drawing.Point(9, 83);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(122, 39);
            this.rbsmall.TabIndex = 2;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "5";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_Toppings.Controls.Add(this.cbcheese);
            this.gb_Toppings.Controls.Add(this.chGreen_peppers);
            this.gb_Toppings.Controls.Add(this.chTomatoes);
            this.gb_Toppings.Controls.Add(this.chOnion);
            this.gb_Toppings.Controls.Add(this.chOliives);
            this.gb_Toppings.Controls.Add(this.chMushrooms);
            this.gb_Toppings.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Toppings.ForeColor = System.Drawing.Color.White;
            this.gb_Toppings.Location = new System.Drawing.Point(28, 88);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Size = new System.Drawing.Size(852, 388);
            this.gb_Toppings.TabIndex = 5;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // cbcheese
            // 
            this.cbcheese.ForeColor = System.Drawing.Color.Snow;
            this.cbcheese.Location = new System.Drawing.Point(40, 89);
            this.cbcheese.Name = "cbcheese";
            this.cbcheese.Size = new System.Drawing.Size(233, 40);
            this.cbcheese.TabIndex = 6;
            this.cbcheese.Tag = "5";
            this.cbcheese.Text = "Extra Cheese";
            this.cbcheese.UseVisualStyleBackColor = true;
            this.cbcheese.CheckedChanged += new System.EventHandler(this.cbcheese_CheckedChanged_1);
            // 
            // chGreen_peppers
            // 
            this.chGreen_peppers.AutoSize = true;
            this.chGreen_peppers.ForeColor = System.Drawing.Color.White;
            this.chGreen_peppers.Location = new System.Drawing.Point(449, 283);
            this.chGreen_peppers.Name = "chGreen_peppers";
            this.chGreen_peppers.Size = new System.Drawing.Size(258, 40);
            this.chGreen_peppers.TabIndex = 5;
            this.chGreen_peppers.Tag = "5";
            this.chGreen_peppers.Text = "Green Peppers";
            this.chGreen_peppers.UseVisualStyleBackColor = true;
            this.chGreen_peppers.CheckedChanged += new System.EventHandler(this.chGreen_peppers_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.ForeColor = System.Drawing.Color.White;
            this.chTomatoes.Location = new System.Drawing.Point(40, 283);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(185, 40);
            this.chTomatoes.TabIndex = 4;
            this.chTomatoes.Tag = "2";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.ForeColor = System.Drawing.Color.White;
            this.chOnion.Location = new System.Drawing.Point(449, 185);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(126, 40);
            this.chOnion.TabIndex = 3;
            this.chOnion.Tag = "1";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chOliives
            // 
            this.chOliives.AutoSize = true;
            this.chOliives.ForeColor = System.Drawing.Color.White;
            this.chOliives.Location = new System.Drawing.Point(449, 83);
            this.chOliives.Name = "chOliives";
            this.chOliives.Size = new System.Drawing.Size(128, 40);
            this.chOliives.TabIndex = 2;
            this.chOliives.Tag = "2";
            this.chOliives.Text = "Olives";
            this.chOliives.UseVisualStyleBackColor = true;
            this.chOliives.CheckedChanged += new System.EventHandler(this.chOliives_CheckedChanged);
            // 
            // chMushrooms
            // 
            this.chMushrooms.AutoSize = true;
            this.chMushrooms.ForeColor = System.Drawing.Color.White;
            this.chMushrooms.Location = new System.Drawing.Point(40, 185);
            this.chMushrooms.Name = "chMushrooms";
            this.chMushrooms.Size = new System.Drawing.Size(212, 40);
            this.chMushrooms.TabIndex = 1;
            this.chMushrooms.Tag = "5";
            this.chMushrooms.Text = "Mushrooms";
            this.chMushrooms.UseVisualStyleBackColor = true;
            this.chMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // gb_wheretoeat
            // 
            this.gb_wheretoeat.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_wheretoeat.Controls.Add(this.rbTakeout);
            this.gb_wheretoeat.Controls.Add(this.rbEatin);
            this.gb_wheretoeat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_wheretoeat.ForeColor = System.Drawing.Color.White;
            this.gb_wheretoeat.Location = new System.Drawing.Point(720, 541);
            this.gb_wheretoeat.Name = "gb_wheretoeat";
            this.gb_wheretoeat.Size = new System.Drawing.Size(236, 253);
            this.gb_wheretoeat.TabIndex = 6;
            this.gb_wheretoeat.TabStop = false;
            this.gb_wheretoeat.Text = "where To Eat";
            // 
            // rbTakeout
            // 
            this.rbTakeout.AutoSize = true;
            this.rbTakeout.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeout.ForeColor = System.Drawing.Color.White;
            this.rbTakeout.Location = new System.Drawing.Point(18, 172);
            this.rbTakeout.Name = "rbTakeout";
            this.rbTakeout.Size = new System.Drawing.Size(184, 42);
            this.rbTakeout.TabIndex = 3;
            this.rbTakeout.TabStop = true;
            this.rbTakeout.Tag = "0";
            this.rbTakeout.Text = "Take Out";
            this.rbTakeout.UseVisualStyleBackColor = true;
            this.rbTakeout.CheckedChanged += new System.EventHandler(this.rbTakeout_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatin.ForeColor = System.Drawing.Color.White;
            this.rbEatin.Location = new System.Drawing.Point(18, 80);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(132, 42);
            this.rbEatin.TabIndex = 2;
            this.rbEatin.TabStop = true;
            this.rbEatin.Tag = "3";
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // gb__CrustType
            // 
            this.gb__CrustType.BackColor = System.Drawing.Color.AliceBlue;
            this.gb__CrustType.Controls.Add(this.rbthick);
            this.gb__CrustType.Controls.Add(this.rbthin);
            this.gb__CrustType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb__CrustType.ForeColor = System.Drawing.Color.White;
            this.gb__CrustType.Location = new System.Drawing.Point(297, 526);
            this.gb__CrustType.Name = "gb__CrustType";
            this.gb__CrustType.Size = new System.Drawing.Size(370, 288);
            this.gb__CrustType.TabIndex = 7;
            this.gb__CrustType.TabStop = false;
            this.gb__CrustType.Text = "Crust Type";
            // 
            // rbthick
            // 
            this.rbthick.AutoSize = true;
            this.rbthick.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthick.ForeColor = System.Drawing.Color.White;
            this.rbthick.Location = new System.Drawing.Point(28, 185);
            this.rbthick.Name = "rbthick";
            this.rbthick.Size = new System.Drawing.Size(221, 42);
            this.rbthick.TabIndex = 3;
            this.rbthick.TabStop = true;
            this.rbthick.Tag = "5";
            this.rbthick.Text = "Thick Crust";
            this.rbthick.UseVisualStyleBackColor = true;
            this.rbthick.CheckedChanged += new System.EventHandler(this.rbthick_CheckedChanged);
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthin.ForeColor = System.Drawing.Color.White;
            this.rbthin.Location = new System.Drawing.Point(28, 99);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(205, 42);
            this.rbthin.TabIndex = 2;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "0";
            this.rbthin.Text = "Thin Crust";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.lbWheretoeat);
            this.groupBox1.Controls.Add(this.lbWheretoEt);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbCrust_type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbToppings);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(987, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 851);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // lbWheretoeat
            // 
            this.lbWheretoeat.AutoSize = true;
            this.lbWheretoeat.BackColor = System.Drawing.Color.Transparent;
            this.lbWheretoeat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWheretoeat.ForeColor = System.Drawing.Color.Red;
            this.lbWheretoeat.Location = new System.Drawing.Point(293, 631);
            this.lbWheretoeat.Name = "lbWheretoeat";
            this.lbWheretoeat.Size = new System.Drawing.Size(24, 36);
            this.lbWheretoeat.TabIndex = 9;
            this.lbWheretoeat.Text = " ";
            // 
            // lbWheretoEt
            // 
            this.lbWheretoEt.AutoSize = true;
            this.lbWheretoEt.BackColor = System.Drawing.Color.Transparent;
            this.lbWheretoEt.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWheretoEt.Location = new System.Drawing.Point(26, 629);
            this.lbWheretoEt.Name = "lbWheretoEt";
            this.lbWheretoEt.Size = new System.Drawing.Size(246, 36);
            this.lbWheretoEt.TabIndex = 8;
            this.lbWheretoEt.Text = "Where To Eat : ";
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbPrice.Location = new System.Drawing.Point(277, 744);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(114, 71);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = " 0 $";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 767);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price :";
            // 
            // lbCrust_type
            // 
            this.lbCrust_type.AutoSize = true;
            this.lbCrust_type.BackColor = System.Drawing.Color.Transparent;
            this.lbCrust_type.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust_type.ForeColor = System.Drawing.Color.Red;
            this.lbCrust_type.Location = new System.Drawing.Point(293, 511);
            this.lbCrust_type.Name = "lbCrust_type";
            this.lbCrust_type.Size = new System.Drawing.Size(24, 36);
            this.lbCrust_type.TabIndex = 5;
            this.lbCrust_type.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crust Type :";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.BackColor = System.Drawing.Color.Transparent;
            this.lbToppings.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.Red;
            this.lbToppings.Location = new System.Drawing.Point(179, 251);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(212, 36);
            this.lbToppings.TabIndex = 3;
            this.lbToppings.Text = " No Toppings";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings :";
            // 
            // lbSize
            // 
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Red;
            this.lbSize.Location = new System.Drawing.Point(183, 103);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(134, 36);
            this.lbSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size : ";
            // 
            // btn_Order
            // 
            this.btn_Order.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(372, 875);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(225, 84);
            this.btn_Order.TabIndex = 9;
            this.btn_Order.Text = "Order Pizza";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(645, 875);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(225, 84);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1492, 1113);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.gb_wheretoeat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb__CrustType);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_size);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_wheretoeat.ResumeLayout(false);
            this.gb_wheretoeat.PerformLayout();
            this.gb__CrustType.ResumeLayout(false);
            this.gb__CrustType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chOliives;
        private System.Windows.Forms.CheckBox chMushrooms;
        private System.Windows.Forms.CheckBox chGreen_peppers;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.GroupBox gb_wheretoeat;
        private System.Windows.Forms.RadioButton rbTakeout;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.GroupBox gb__CrustType;
        private System.Windows.Forms.RadioButton rbthick;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCrust_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbWheretoeat;
        private System.Windows.Forms.Label lbWheretoEt;
        private System.Windows.Forms.CheckBox cbcheese;
    }
}

