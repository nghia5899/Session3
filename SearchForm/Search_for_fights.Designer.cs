namespace SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnapply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rboneway = new System.Windows.Forms.RadioButton();
            this.rbreturn = new System.Windows.Forms.RadioButton();
            this.cbcabintype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbthreeday1 = new System.Windows.Forms.CheckBox();
            this.gridviewreturn = new System.Windows.Forms.DataGridView();
            this.txtreturnflight = new System.Windows.Forms.Label();
            this.cbthreeday2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gridviewoutbound = new System.Windows.Forms.DataGridView();
            this.txtoutbound = new System.Windows.Forms.DateTimePicker();
            this.txtreturn = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewreturn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewoutbound)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtreturn);
            this.groupBox1.Controls.Add(this.txtoutbound);
            this.groupBox1.Controls.Add(this.btnapply);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rboneway);
            this.groupBox1.Controls.Add(this.rbreturn);
            this.groupBox1.Controls.Add(this.cbcabintype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbfrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(69, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(909, 177);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search parameter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnapply
            // 
            this.btnapply.Image = ((System.Drawing.Image)(resources.GetObject("btnapply.Image")));
            this.btnapply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnapply.Location = new System.Drawing.Point(783, 102);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(120, 38);
            this.btnapply.TabIndex = 15;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(517, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "     Return";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(247, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "     Outbound";
            // 
            // rboneway
            // 
            this.rboneway.AutoSize = true;
            this.rboneway.Checked = true;
            this.rboneway.Location = new System.Drawing.Point(120, 111);
            this.rboneway.Name = "rboneway";
            this.rboneway.Size = new System.Drawing.Size(84, 21);
            this.rboneway.TabIndex = 8;
            this.rboneway.TabStop = true;
            this.rboneway.Text = "One way";
            this.rboneway.UseVisualStyleBackColor = true;
            this.rboneway.CheckedChanged += new System.EventHandler(this.rboneway_CheckedChanged);
            // 
            // rbreturn
            // 
            this.rbreturn.AutoSize = true;
            this.rbreturn.Location = new System.Drawing.Point(17, 111);
            this.rbreturn.Name = "rbreturn";
            this.rbreturn.Size = new System.Drawing.Size(72, 21);
            this.rbreturn.TabIndex = 7;
            this.rbreturn.TabStop = true;
            this.rbreturn.Text = "Return";
            this.rbreturn.UseVisualStyleBackColor = true;
            this.rbreturn.CheckedChanged += new System.EventHandler(this.rbreturn_CheckedChanged);
            // 
            // cbcabintype
            // 
            this.cbcabintype.BackColor = System.Drawing.SystemColors.Window;
            this.cbcabintype.FormattingEnabled = true;
            this.cbcabintype.Location = new System.Drawing.Point(692, 35);
            this.cbcabintype.Name = "cbcabintype";
            this.cbcabintype.Size = new System.Drawing.Size(154, 24);
            this.cbcabintype.TabIndex = 6;
            this.cbcabintype.SelectedIndexChanged += new System.EventHandler(this.cbcabintype_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cabin Type";
            // 
            // cbto
            // 
            this.cbto.FormattingEnabled = true;
            this.cbto.Location = new System.Drawing.Point(372, 35);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(142, 24);
            this.cbto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // cbfrom
            // 
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Location = new System.Drawing.Point(85, 35);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(132, 24);
            this.cbfrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(66, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Outbound flights details :";
            // 
            // cbthreeday1
            // 
            this.cbthreeday1.AutoSize = true;
            this.cbthreeday1.Location = new System.Drawing.Point(725, 247);
            this.cbthreeday1.Name = "cbthreeday1";
            this.cbthreeday1.Size = new System.Drawing.Size(253, 21);
            this.cbthreeday1.TabIndex = 21;
            this.cbthreeday1.Text = "Display three days before and after";
            this.cbthreeday1.UseVisualStyleBackColor = true;
            this.cbthreeday1.CheckedChanged += new System.EventHandler(this.cbthreeday1_CheckedChanged);
            // 
            // gridviewreturn
            // 
            this.gridviewreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewreturn.Enabled = false;
            this.gridviewreturn.Location = new System.Drawing.Point(69, 526);
            this.gridviewreturn.Name = "gridviewreturn";
            this.gridviewreturn.RowHeadersWidth = 51;
            this.gridviewreturn.RowTemplate.Height = 24;
            this.gridviewreturn.Size = new System.Drawing.Size(909, 177);
            this.gridviewreturn.TabIndex = 23;
            // 
            // txtreturnflight
            // 
            this.txtreturnflight.AutoSize = true;
            this.txtreturnflight.Enabled = false;
            this.txtreturnflight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtreturnflight.Location = new System.Drawing.Point(66, 491);
            this.txtreturnflight.Name = "txtreturnflight";
            this.txtreturnflight.Size = new System.Drawing.Size(138, 17);
            this.txtreturnflight.TabIndex = 22;
            this.txtreturnflight.Text = "Return flight details :";
            // 
            // cbthreeday2
            // 
            this.cbthreeday2.AutoSize = true;
            this.cbthreeday2.Enabled = false;
            this.cbthreeday2.Location = new System.Drawing.Point(725, 490);
            this.cbthreeday2.Name = "cbthreeday2";
            this.cbthreeday2.Size = new System.Drawing.Size(253, 21);
            this.cbthreeday2.TabIndex = 24;
            this.cbthreeday2.Text = "Display three days before and after";
            this.cbthreeday2.UseVisualStyleBackColor = true;
            this.cbthreeday2.CheckedChanged += new System.EventHandler(this.cbthreeday2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(253, 726);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 82);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(316, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "  Book flight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(156, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Passengers";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 22);
            this.textBox3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(788, 747);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 39);
            this.button3.TabIndex = 26;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gridviewoutbound
            // 
            this.gridviewoutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewoutbound.Location = new System.Drawing.Point(69, 274);
            this.gridviewoutbound.Name = "gridviewoutbound";
            this.gridviewoutbound.RowHeadersWidth = 51;
            this.gridviewoutbound.RowTemplate.Height = 24;
            this.gridviewoutbound.Size = new System.Drawing.Size(903, 181);
            this.gridviewoutbound.TabIndex = 27;
            // 
            // txtoutbound
            // 
            this.txtoutbound.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtoutbound.Location = new System.Drawing.Point(344, 108);
            this.txtoutbound.MinDate = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            this.txtoutbound.Name = "txtoutbound";
            this.txtoutbound.Size = new System.Drawing.Size(134, 22);
            this.txtoutbound.TabIndex = 16;
            this.txtoutbound.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            this.txtoutbound.ValueChanged += new System.EventHandler(this.txtoutbound_ValueChanged);
            // 
            // txtreturn
            // 
            this.txtreturn.Enabled = false;
            this.txtreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtreturn.Location = new System.Drawing.Point(594, 109);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.Size = new System.Drawing.Size(134, 22);
            this.txtreturn.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 850);
            this.Controls.Add(this.gridviewoutbound);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbthreeday2);
            this.Controls.Add(this.gridviewreturn);
            this.Controls.Add(this.txtreturnflight);
            this.Controls.Add(this.cbthreeday1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewreturn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewoutbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboneway;
        private System.Windows.Forms.RadioButton rbreturn;
        private System.Windows.Forms.ComboBox cbcabintype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbthreeday1;
        private System.Windows.Forms.DataGridView gridviewreturn;
        private System.Windows.Forms.Label txtreturnflight;
        private System.Windows.Forms.CheckBox cbthreeday2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gridviewoutbound;
        private System.Windows.Forms.DateTimePicker txtreturn;
        private System.Windows.Forms.DateTimePicker txtoutbound;
    }
}

