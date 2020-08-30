namespace SearchForm
{
    partial class bookingconfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingconfirmation));
            this.outbound = new System.Windows.Forms.GroupBox();
            this.txtflightnumberout = new System.Windows.Forms.Label();
            this.txtdateout = new System.Windows.Forms.Label();
            this.txtcabintypeout = new System.Windows.Forms.Label();
            this.txttoout = new System.Windows.Forms.Label();
            this.txtfromout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnflight = new System.Windows.Forms.GroupBox();
            this.txtdatere = new System.Windows.Forms.Label();
            this.txtcabintypere = new System.Windows.Forms.Label();
            this.txtflightre = new System.Windows.Forms.Label();
            this.txttore = new System.Windows.Forms.Label();
            this.txtfromre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtpassportcountry = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtpassportnb = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.grvpassenger = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportcountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.outbound1 = new System.Windows.Forms.GroupBox();
            this.txtflightnumberout1 = new System.Windows.Forms.Label();
            this.txtdateout1 = new System.Windows.Forms.Label();
            this.txtcabintypeout1 = new System.Windows.Forms.Label();
            this.txttoout1 = new System.Windows.Forms.Label();
            this.txtfromout1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.returnflight1 = new System.Windows.Forms.GroupBox();
            this.txtdatere1 = new System.Windows.Forms.Label();
            this.txtcabintypere1 = new System.Windows.Forms.Label();
            this.txtflightre1 = new System.Windows.Forms.Label();
            this.txttore1 = new System.Windows.Forms.Label();
            this.txtfromre1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.outbound.SuspendLayout();
            this.returnflight.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvpassenger)).BeginInit();
            this.outbound1.SuspendLayout();
            this.returnflight1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outbound
            // 
            this.outbound.BackColor = System.Drawing.Color.White;
            this.outbound.Controls.Add(this.txtflightnumberout);
            this.outbound.Controls.Add(this.txtdateout);
            this.outbound.Controls.Add(this.txtcabintypeout);
            this.outbound.Controls.Add(this.txttoout);
            this.outbound.Controls.Add(this.txtfromout);
            this.outbound.Controls.Add(this.label5);
            this.outbound.Controls.Add(this.label4);
            this.outbound.Controls.Add(this.label3);
            this.outbound.Controls.Add(this.ds);
            this.outbound.Controls.Add(this.label1);
            this.outbound.Location = new System.Drawing.Point(61, 12);
            this.outbound.Name = "outbound";
            this.outbound.Size = new System.Drawing.Size(945, 69);
            this.outbound.TabIndex = 0;
            this.outbound.TabStop = false;
            this.outbound.Text = "Outbound flight detailts";
            this.outbound.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtflightnumberout
            // 
            this.txtflightnumberout.AutoSize = true;
            this.txtflightnumberout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightnumberout.Location = new System.Drawing.Point(819, 29);
            this.txtflightnumberout.Name = "txtflightnumberout";
            this.txtflightnumberout.Size = new System.Drawing.Size(44, 17);
            this.txtflightnumberout.TabIndex = 9;
            this.txtflightnumberout.Text = "1998";
            // 
            // txtdateout
            // 
            this.txtdateout.AutoSize = true;
            this.txtdateout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateout.Location = new System.Drawing.Point(584, 29);
            this.txtdateout.Name = "txtdateout";
            this.txtdateout.Size = new System.Drawing.Size(72, 17);
            this.txtdateout.TabIndex = 8;
            this.txtdateout.Text = "1/1/2020";
            // 
            // txtcabintypeout
            // 
            this.txtcabintypeout.AutoSize = true;
            this.txtcabintypeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcabintypeout.Location = new System.Drawing.Point(420, 29);
            this.txtcabintypeout.Name = "txtcabintypeout";
            this.txtcabintypeout.Size = new System.Drawing.Size(73, 17);
            this.txtcabintypeout.TabIndex = 7;
            this.txtcabintypeout.Text = "Economy";
            // 
            // txttoout
            // 
            this.txttoout.AutoSize = true;
            this.txttoout.BackColor = System.Drawing.Color.White;
            this.txttoout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoout.Location = new System.Drawing.Point(228, 29);
            this.txttoout.Name = "txttoout";
            this.txttoout.Size = new System.Drawing.Size(40, 17);
            this.txttoout.TabIndex = 6;
            this.txttoout.Text = "AUH";
            // 
            // txtfromout
            // 
            this.txtfromout.AutoSize = true;
            this.txtfromout.BackColor = System.Drawing.Color.White;
            this.txtfromout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromout.Location = new System.Drawing.Point(92, 29);
            this.txtfromout.Name = "txtfromout";
            this.txtfromout.Size = new System.Drawing.Size(32, 17);
            this.txtfromout.TabIndex = 5;
            this.txtfromout.Text = "CAI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight  number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cabin type :";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Location = new System.Drawing.Point(189, 29);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(33, 17);
            this.ds.TabIndex = 1;
            this.ds.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // returnflight
            // 
            this.returnflight.BackColor = System.Drawing.Color.White;
            this.returnflight.Controls.Add(this.txtdatere);
            this.returnflight.Controls.Add(this.txtcabintypere);
            this.returnflight.Controls.Add(this.txtflightre);
            this.returnflight.Controls.Add(this.txttore);
            this.returnflight.Controls.Add(this.txtfromre);
            this.returnflight.Controls.Add(this.label8);
            this.returnflight.Controls.Add(this.label9);
            this.returnflight.Controls.Add(this.label10);
            this.returnflight.Controls.Add(this.label11);
            this.returnflight.Controls.Add(this.label12);
            this.returnflight.Location = new System.Drawing.Point(61, 185);
            this.returnflight.Name = "returnflight";
            this.returnflight.Size = new System.Drawing.Size(945, 64);
            this.returnflight.TabIndex = 1;
            this.returnflight.TabStop = false;
            this.returnflight.Text = "Return flight detailts";
            this.returnflight.Visible = false;
            // 
            // txtdatere
            // 
            this.txtdatere.AutoSize = true;
            this.txtdatere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatere.Location = new System.Drawing.Point(584, 27);
            this.txtdatere.Name = "txtdatere";
            this.txtdatere.Size = new System.Drawing.Size(72, 17);
            this.txtdatere.TabIndex = 13;
            this.txtdatere.Text = "1/1/2020";
            // 
            // txtcabintypere
            // 
            this.txtcabintypere.AutoSize = true;
            this.txtcabintypere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcabintypere.Location = new System.Drawing.Point(420, 27);
            this.txtcabintypere.Name = "txtcabintypere";
            this.txtcabintypere.Size = new System.Drawing.Size(73, 17);
            this.txtcabintypere.TabIndex = 12;
            this.txtcabintypere.Text = "Economy";
            // 
            // txtflightre
            // 
            this.txtflightre.AutoSize = true;
            this.txtflightre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightre.Location = new System.Drawing.Point(819, 27);
            this.txtflightre.Name = "txtflightre";
            this.txtflightre.Size = new System.Drawing.Size(44, 17);
            this.txtflightre.TabIndex = 11;
            this.txtflightre.Text = "1999";
            // 
            // txttore
            // 
            this.txttore.AutoSize = true;
            this.txttore.BackColor = System.Drawing.Color.White;
            this.txttore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttore.Location = new System.Drawing.Point(228, 27);
            this.txttore.Name = "txttore";
            this.txttore.Size = new System.Drawing.Size(32, 17);
            this.txttore.TabIndex = 8;
            this.txttore.Text = "CAI";
            // 
            // txtfromre
            // 
            this.txtfromre.AutoSize = true;
            this.txtfromre.BackColor = System.Drawing.Color.White;
            this.txtfromre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromre.Location = new System.Drawing.Point(92, 27);
            this.txtfromre.Name = "txtfromre";
            this.txtfromre.Size = new System.Drawing.Size(40, 17);
            this.txtfromre.TabIndex = 7;
            this.txtfromre.Text = "AUH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(711, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Flight  number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cabin type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "To :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "From :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtbirthdate);
            this.groupBox3.Controls.Add(this.txtpassportcountry);
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Controls.Add(this.txtphone);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtpassportnb);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtlastname);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtfirstname);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(61, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger details";
            // 
            // txtbirthdate
            // 
            this.txtbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtbirthdate.Location = new System.Drawing.Point(697, 48);
            this.txtbirthdate.Name = "txtbirthdate";
            this.txtbirthdate.Size = new System.Drawing.Size(142, 22);
            this.txtbirthdate.TabIndex = 20;
            // 
            // txtpassportcountry
            // 
            this.txtpassportcountry.FormattingEnabled = true;
            this.txtpassportcountry.Location = new System.Drawing.Point(453, 99);
            this.txtpassportcountry.Name = "txtpassportcountry";
            this.txtpassportcountry.Size = new System.Drawing.Size(141, 24);
            this.txtpassportcountry.TabIndex = 19;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(715, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 28);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add passenger";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(681, 103);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(158, 22);
            this.txtphone.TabIndex = 17;
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(626, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 17);
            this.label26.TabIndex = 16;
            this.label26.Text = "Phone";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(332, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 17);
            this.label25.TabIndex = 14;
            this.label25.Text = "Passport country";
            // 
            // txtpassportnb
            // 
            this.txtpassportnb.Location = new System.Drawing.Point(161, 102);
            this.txtpassportnb.Name = "txtpassportnb";
            this.txtpassportnb.Size = new System.Drawing.Size(125, 22);
            this.txtpassportnb.TabIndex = 13;
            this.txtpassportnb.TextChanged += new System.EventHandler(this.txtfirstname_Leave);
            this.txtpassportnb.Leave += new System.EventHandler(this.txtpassportnb_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(39, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "Passport number";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(626, 53);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "Birthdate";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(423, 50);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(171, 22);
            this.txtlastname.TabIndex = 9;
            this.txtlastname.Leave += new System.EventHandler(this.txtlastname_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(332, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 17);
            this.label22.TabIndex = 8;
            this.label22.Text = "Last name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(129, 50);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(157, 22);
            this.txtfirstname.TabIndex = 7;
            this.txtfirstname.Leave += new System.EventHandler(this.txtfirstname_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(39, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "First name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(58, 547);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 17);
            this.label27.TabIndex = 13;
            this.label27.Text = "Passenger list";
            // 
            // grvpassenger
            // 
            this.grvpassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvpassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.birthdate,
            this.passportnumber,
            this.passportcountry,
            this.phone});
            this.grvpassenger.Location = new System.Drawing.Point(61, 577);
            this.grvpassenger.Name = "grvpassenger";
            this.grvpassenger.RowHeadersWidth = 51;
            this.grvpassenger.RowTemplate.Height = 24;
            this.grvpassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvpassenger.Size = new System.Drawing.Size(942, 154);
            this.grvpassenger.TabIndex = 14;
            this.grvpassenger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvpassenger_CellClick);
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First name";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.Width = 125;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Lastname";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.Width = 125;
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.Width = 125;
            // 
            // passportnumber
            // 
            this.passportnumber.HeaderText = "Passport number";
            this.passportnumber.MinimumWidth = 6;
            this.passportnumber.Name = "passportnumber";
            this.passportnumber.Width = 125;
            // 
            // passportcountry
            // 
            this.passportcountry.HeaderText = "Passport country";
            this.passportcountry.MinimumWidth = 6;
            this.passportcountry.Name = "passportcountry";
            this.passportcountry.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // btnremove
            // 
            this.btnremove.Enabled = false;
            this.btnremove.Location = new System.Drawing.Point(844, 737);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(159, 28);
            this.btnremove.TabIndex = 19;
            this.btnremove.Text = "Remove passenger";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnback
            // 
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(255, 752);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(220, 35);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back to search for flights";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnconfirm.Image")));
            this.btnconfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfirm.Location = new System.Drawing.Point(530, 752);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(163, 35);
            this.btnconfirm.TabIndex = 21;
            this.btnconfirm.Text = "Confirm booking";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // outbound1
            // 
            this.outbound1.BackColor = System.Drawing.Color.White;
            this.outbound1.Controls.Add(this.txtflightnumberout1);
            this.outbound1.Controls.Add(this.txtdateout1);
            this.outbound1.Controls.Add(this.txtcabintypeout1);
            this.outbound1.Controls.Add(this.txttoout1);
            this.outbound1.Controls.Add(this.txtfromout1);
            this.outbound1.Controls.Add(this.label17);
            this.outbound1.Controls.Add(this.label18);
            this.outbound1.Controls.Add(this.label19);
            this.outbound1.Controls.Add(this.label20);
            this.outbound1.Controls.Add(this.label21);
            this.outbound1.Location = new System.Drawing.Point(60, 98);
            this.outbound1.Name = "outbound1";
            this.outbound1.Size = new System.Drawing.Size(945, 63);
            this.outbound1.TabIndex = 22;
            this.outbound1.TabStop = false;
            this.outbound1.Text = "Outbound flight detailts";
            this.outbound1.Visible = false;
            // 
            // txtflightnumberout1
            // 
            this.txtflightnumberout1.AutoSize = true;
            this.txtflightnumberout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightnumberout1.Location = new System.Drawing.Point(820, 31);
            this.txtflightnumberout1.Name = "txtflightnumberout1";
            this.txtflightnumberout1.Size = new System.Drawing.Size(44, 17);
            this.txtflightnumberout1.TabIndex = 19;
            this.txtflightnumberout1.Text = "1998";
            // 
            // txtdateout1
            // 
            this.txtdateout1.AutoSize = true;
            this.txtdateout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateout1.Location = new System.Drawing.Point(585, 31);
            this.txtdateout1.Name = "txtdateout1";
            this.txtdateout1.Size = new System.Drawing.Size(72, 17);
            this.txtdateout1.TabIndex = 18;
            this.txtdateout1.Text = "1/1/2020";
            // 
            // txtcabintypeout1
            // 
            this.txtcabintypeout1.AutoSize = true;
            this.txtcabintypeout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcabintypeout1.Location = new System.Drawing.Point(421, 31);
            this.txtcabintypeout1.Name = "txtcabintypeout1";
            this.txtcabintypeout1.Size = new System.Drawing.Size(73, 17);
            this.txtcabintypeout1.TabIndex = 17;
            this.txtcabintypeout1.Text = "Economy";
            // 
            // txttoout1
            // 
            this.txttoout1.AutoSize = true;
            this.txttoout1.BackColor = System.Drawing.Color.White;
            this.txttoout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoout1.Location = new System.Drawing.Point(229, 31);
            this.txttoout1.Name = "txttoout1";
            this.txttoout1.Size = new System.Drawing.Size(40, 17);
            this.txttoout1.TabIndex = 16;
            this.txttoout1.Text = "AUH";
            // 
            // txtfromout1
            // 
            this.txtfromout1.AutoSize = true;
            this.txtfromout1.BackColor = System.Drawing.Color.White;
            this.txtfromout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromout1.Location = new System.Drawing.Point(93, 31);
            this.txtfromout1.Name = "txtfromout1";
            this.txtfromout1.Size = new System.Drawing.Size(32, 17);
            this.txtfromout1.TabIndex = 15;
            this.txtfromout1.Text = "CAI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(712, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Flight  number:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(533, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Date :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(332, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Cabin type :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "To :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "From :";
            // 
            // returnflight1
            // 
            this.returnflight1.BackColor = System.Drawing.Color.White;
            this.returnflight1.Controls.Add(this.txtdatere1);
            this.returnflight1.Controls.Add(this.txtcabintypere1);
            this.returnflight1.Controls.Add(this.txtflightre1);
            this.returnflight1.Controls.Add(this.txttore1);
            this.returnflight1.Controls.Add(this.txtfromre1);
            this.returnflight1.Controls.Add(this.label33);
            this.returnflight1.Controls.Add(this.label34);
            this.returnflight1.Controls.Add(this.label35);
            this.returnflight1.Controls.Add(this.label36);
            this.returnflight1.Controls.Add(this.label37);
            this.returnflight1.Location = new System.Drawing.Point(61, 270);
            this.returnflight1.Name = "returnflight1";
            this.returnflight1.Size = new System.Drawing.Size(945, 64);
            this.returnflight1.TabIndex = 23;
            this.returnflight1.TabStop = false;
            this.returnflight1.Text = "Return flight detailts";
            this.returnflight1.Visible = false;
            // 
            // txtdatere1
            // 
            this.txtdatere1.AutoSize = true;
            this.txtdatere1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatere1.Location = new System.Drawing.Point(584, 27);
            this.txtdatere1.Name = "txtdatere1";
            this.txtdatere1.Size = new System.Drawing.Size(72, 17);
            this.txtdatere1.TabIndex = 13;
            this.txtdatere1.Text = "1/1/2020";
            // 
            // txtcabintypere1
            // 
            this.txtcabintypere1.AutoSize = true;
            this.txtcabintypere1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcabintypere1.Location = new System.Drawing.Point(420, 27);
            this.txtcabintypere1.Name = "txtcabintypere1";
            this.txtcabintypere1.Size = new System.Drawing.Size(73, 17);
            this.txtcabintypere1.TabIndex = 12;
            this.txtcabintypere1.Text = "Economy";
            // 
            // txtflightre1
            // 
            this.txtflightre1.AutoSize = true;
            this.txtflightre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightre1.Location = new System.Drawing.Point(819, 27);
            this.txtflightre1.Name = "txtflightre1";
            this.txtflightre1.Size = new System.Drawing.Size(44, 17);
            this.txtflightre1.TabIndex = 11;
            this.txtflightre1.Text = "1999";
            // 
            // txttore1
            // 
            this.txttore1.AutoSize = true;
            this.txttore1.BackColor = System.Drawing.Color.White;
            this.txttore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttore1.Location = new System.Drawing.Point(228, 27);
            this.txttore1.Name = "txttore1";
            this.txttore1.Size = new System.Drawing.Size(32, 17);
            this.txttore1.TabIndex = 8;
            this.txttore1.Text = "CAI";
            // 
            // txtfromre1
            // 
            this.txtfromre1.AutoSize = true;
            this.txtfromre1.BackColor = System.Drawing.Color.White;
            this.txtfromre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromre1.Location = new System.Drawing.Point(92, 27);
            this.txtfromre1.Name = "txtfromre1";
            this.txtfromre1.Size = new System.Drawing.Size(40, 17);
            this.txtfromre1.TabIndex = 7;
            this.txtfromre1.Text = "AUH";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(711, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(102, 17);
            this.label33.TabIndex = 4;
            this.label33.Text = "Flight  number:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(532, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "Date :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(331, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 17);
            this.label35.TabIndex = 2;
            this.label35.Text = "Cabin type :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(189, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "To :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(38, 27);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 17);
            this.label37.TabIndex = 0;
            this.label37.Text = "From :";
            // 
            // bookingconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 813);
            this.Controls.Add(this.returnflight1);
            this.Controls.Add(this.outbound1);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.grvpassenger);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.returnflight);
            this.Controls.Add(this.outbound);
            this.Name = "bookingconfirmation";
            this.Text = "bookingconfirmation";
            this.Load += new System.EventHandler(this.bookingconfirmation_Load);
            this.outbound.ResumeLayout(false);
            this.outbound.PerformLayout();
            this.returnflight.ResumeLayout(false);
            this.returnflight.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvpassenger)).EndInit();
            this.outbound1.ResumeLayout(false);
            this.outbound1.PerformLayout();
            this.returnflight1.ResumeLayout(false);
            this.returnflight1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outbound;
        private System.Windows.Forms.Label txtflightnumberout;
        private System.Windows.Forms.Label txtdateout;
        private System.Windows.Forms.Label txtcabintypeout;
        private System.Windows.Forms.Label txttoout;
        private System.Windows.Forms.Label txtfromout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox returnflight;
        private System.Windows.Forms.Label txtflightre;
        private System.Windows.Forms.Label txttore;
        private System.Windows.Forms.Label txtfromre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtpassportnb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView grvpassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportcountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label txtdatere;
        private System.Windows.Forms.Label txtcabintypere;
        private System.Windows.Forms.ComboBox txtpassportcountry;
        private System.Windows.Forms.DateTimePicker txtbirthdate;
        private System.Windows.Forms.GroupBox outbound1;
        private System.Windows.Forms.Label txtflightnumberout1;
        private System.Windows.Forms.Label txtdateout1;
        private System.Windows.Forms.Label txtcabintypeout1;
        private System.Windows.Forms.Label txttoout1;
        private System.Windows.Forms.Label txtfromout1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox returnflight1;
        private System.Windows.Forms.Label txtdatere1;
        private System.Windows.Forms.Label txtcabintypere1;
        private System.Windows.Forms.Label txtflightre1;
        private System.Windows.Forms.Label txttore1;
        private System.Windows.Forms.Label txtfromre1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
    }
}