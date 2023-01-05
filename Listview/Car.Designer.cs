namespace Cars
{
    partial class Car
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.CheckBox();
            this.modelBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.gear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customize = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.CheckBox();
            this.gearbox = new System.Windows.Forms.CheckBox();
            this.colorBox = new System.Windows.Forms.CheckBox();
            this.maxBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.automatic = new System.Windows.Forms.RadioButton();
            this.manual = new System.Windows.Forms.RadioButton();
            this.fastest = new System.Windows.Forms.Button();
            this.numberof = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mygrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customize the Columns:";
            // 
            // idBox
            // 
            this.idBox.AutoSize = true;
            this.idBox.Checked = true;
            this.idBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idBox.Location = new System.Drawing.Point(134, 21);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(37, 17);
            this.idBox.TabIndex = 4;
            this.idBox.Text = "ID";
            this.idBox.UseVisualStyleBackColor = true;
            // 
            // modelBox
            // 
            this.modelBox.AutoSize = true;
            this.modelBox.Location = new System.Drawing.Point(177, 21);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(55, 17);
            this.modelBox.TabIndex = 4;
            this.modelBox.Text = "Model";
            this.modelBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.gear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected or a New Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID: ";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(6, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(70, 20);
            this.id.TabIndex = 2;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(83, 32);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(117, 20);
            this.model.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(206, 32);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(66, 20);
            this.year.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(480, 32);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(95, 20);
            this.speed.TabIndex = 2;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(379, 33);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(95, 20);
            this.color.TabIndex = 2;
            // 
            // gear
            // 
            this.gear.Location = new System.Drawing.Point(278, 33);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(95, 20);
            this.gear.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max_Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GearBox";
            // 
            // customize
            // 
            this.customize.Location = new System.Drawing.Point(503, 18);
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(113, 21);
            this.customize.TabIndex = 1;
            this.customize.Text = "Customize";
            this.customize.UseVisualStyleBackColor = true;
            this.customize.Click += new System.EventHandler(this.customize_Click);
            // 
            // yearBox
            // 
            this.yearBox.AutoSize = true;
            this.yearBox.Location = new System.Drawing.Point(240, 21);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(48, 17);
            this.yearBox.TabIndex = 4;
            this.yearBox.Text = "Year";
            this.yearBox.UseVisualStyleBackColor = true;
            // 
            // gearbox
            // 
            this.gearbox.AutoSize = true;
            this.gearbox.Location = new System.Drawing.Point(293, 21);
            this.gearbox.Name = "gearbox";
            this.gearbox.Size = new System.Drawing.Size(67, 17);
            this.gearbox.TabIndex = 4;
            this.gearbox.Text = "GearBox";
            this.gearbox.UseVisualStyleBackColor = true;
            // 
            // colorBox
            // 
            this.colorBox.AutoSize = true;
            this.colorBox.Location = new System.Drawing.Point(358, 21);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(50, 17);
            this.colorBox.TabIndex = 4;
            this.colorBox.Text = "Color";
            this.colorBox.UseVisualStyleBackColor = true;
            // 
            // maxBox
            // 
            this.maxBox.AutoSize = true;
            this.maxBox.Location = new System.Drawing.Point(414, 21);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(83, 17);
            this.maxBox.TabIndex = 4;
            this.maxBox.Text = "Max_Speed";
            this.maxBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.automatic);
            this.groupBox2.Controls.Add(this.manual);
            this.groupBox2.Controls.Add(this.fastest);
            this.groupBox2.Controls.Add(this.numberof);
            this.groupBox2.Controls.Add(this.remove);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(622, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 291);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit the Website";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BMW",
            "Mercedes Benz",
            "Buggati",
            "Lamborghini",
            "Ferrari"});
            this.comboBox1.Location = new System.Drawing.Point(91, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "and";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Choose a Brand:";
            // 
            // automatic
            // 
            this.automatic.AutoSize = true;
            this.automatic.Location = new System.Drawing.Point(116, 119);
            this.automatic.Name = "automatic";
            this.automatic.Size = new System.Drawing.Size(96, 17);
            this.automatic.TabIndex = 4;
            this.automatic.TabStop = true;
            this.automatic.Text = "Automatic Cars";
            this.automatic.UseVisualStyleBackColor = true;
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Location = new System.Drawing.Point(116, 96);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(84, 17);
            this.manual.TabIndex = 3;
            this.manual.TabStop = true;
            this.manual.Text = "Manual Cars";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // fastest
            // 
            this.fastest.Location = new System.Drawing.Point(6, 156);
            this.fastest.Name = "fastest";
            this.fastest.Size = new System.Drawing.Size(202, 29);
            this.fastest.TabIndex = 5;
            this.fastest.Text = "Find the fastest car / cars";
            this.fastest.UseVisualStyleBackColor = true;
            // 
            // numberof
            // 
            this.numberof.Location = new System.Drawing.Point(6, 96);
            this.numberof.Name = "numberof";
            this.numberof.Size = new System.Drawing.Size(104, 40);
            this.numberof.TabIndex = 2;
            this.numberof.Text = "Find the number of";
            this.numberof.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(6, 52);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(202, 23);
            this.remove.TabIndex = 1;
            this.remove.Text = "Remove the Selected Car";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 23);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(202, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add a new Car";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mygrid
            // 
            this.mygrid.AllowUserToOrderColumns = true;
            this.mygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mygrid.Location = new System.Drawing.Point(15, 43);
            this.mygrid.Name = "mygrid";
            this.mygrid.Size = new System.Drawing.Size(600, 196);
            this.mygrid.TabIndex = 7;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 324);
            this.Controls.Add(this.mygrid);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.gearbox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Car";
            this.Text = "Cars Data";
            this.Load += new System.EventHandler(this.Car_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox idBox;
        private System.Windows.Forms.CheckBox modelBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox gear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button customize;
        private System.Windows.Forms.CheckBox yearBox;
        private System.Windows.Forms.CheckBox gearbox;
        private System.Windows.Forms.CheckBox colorBox;
        private System.Windows.Forms.CheckBox maxBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton automatic;
        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.Button fastest;
        private System.Windows.Forms.Button numberof;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView mygrid;
    }
}

