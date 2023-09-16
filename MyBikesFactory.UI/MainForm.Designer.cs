namespace MyBikesFactory.UI
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturingyear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbTireType = new System.Windows.Forms.ComboBox();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbMountain = new System.Windows.Forms.RadioButton();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.lstBikes = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOriginalId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturing Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tire Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(730, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Suspension Type:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(398, 68);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(125, 27);
            this.txtSerialNumber.TabIndex = 8;
            // 
            // txtManufacturingyear
            // 
            this.txtManufacturingyear.Location = new System.Drawing.Point(1024, 61);
            this.txtManufacturingyear.Name = "txtManufacturingyear";
            this.txtManufacturingyear.Size = new System.Drawing.Size(125, 27);
            this.txtManufacturingyear.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(674, 64);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(125, 27);
            this.txtModel.TabIndex = 10;
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Road",
            "Mountain"});
            this.cbBikeType.Location = new System.Drawing.Point(119, 71);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(151, 28);
            this.cbBikeType.TabIndex = 11;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Green",
            "Blue",
            "Red"});
            this.cbColor.Location = new System.Drawing.Point(211, 199);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(151, 28);
            this.cbColor.TabIndex = 12;
            // 
            // cbTireType
            // 
            this.cbTireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTireType.FormattingEnabled = true;
            this.cbTireType.Items.AddRange(new object[] {
            "Gravel",
            "Commuter",
            "Regular"});
            this.cbTireType.Location = new System.Drawing.Point(529, 199);
            this.cbTireType.Name = "cbTireType";
            this.cbTireType.Size = new System.Drawing.Size(151, 28);
            this.cbTireType.TabIndex = 13;
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Neutral"});
            this.cbSuspensionType.Location = new System.Drawing.Point(857, 196);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(151, 28);
            this.cbSuspensionType.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(415, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(604, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Display All, Road or Mountain Bikes";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(398, 375);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 18;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged_1);
            // 
            // rbMountain
            // 
            this.rbMountain.AutoSize = true;
            this.rbMountain.Location = new System.Drawing.Point(600, 378);
            this.rbMountain.Name = "rbMountain";
            this.rbMountain.Size = new System.Drawing.Size(93, 24);
            this.rbMountain.TabIndex = 19;
            this.rbMountain.Text = "Mountain";
            this.rbMountain.UseVisualStyleBackColor = true;
            this.rbMountain.CheckedChanged += new System.EventHandler(this.rbMountain_CheckedChanged_1);
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(817, 374);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(65, 24);
            this.rbRoad.TabIndex = 20;
            this.rbRoad.Text = "Road";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged_1);
            // 
            // lstBikes
            // 
            this.lstBikes.FormattingEnabled = true;
            this.lstBikes.ItemHeight = 20;
            this.lstBikes.Location = new System.Drawing.Point(46, 429);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.Size = new System.Drawing.Size(1087, 104);
            this.lstBikes.TabIndex = 21;
            this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(236, 558);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(429, 558);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(626, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(826, 558);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Original Id:";
            // 
            // txtOriginalId
            // 
            this.txtOriginalId.Location = new System.Drawing.Point(984, 114);
            this.txtOriginalId.Name = "txtOriginalId";
            this.txtOriginalId.Size = new System.Drawing.Size(125, 27);
            this.txtOriginalId.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 685);
            this.Controls.Add(this.txtOriginalId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstBikes);
            this.Controls.Add(this.rbRoad);
            this.Controls.Add(this.rbMountain);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.cbTireType);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturingyear);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSerialNumber;
        private TextBox txtManufacturingyear;
        private TextBox txtModel;
        private ComboBox cbBikeType;
        private ComboBox cbColor;
        private ComboBox cbTireType;
        private ComboBox cbSuspensionType;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox textBox1;
        private RadioButton rbAll;
        private RadioButton rbMountain;
        private RadioButton rbRoad;
        private ListBox lstBikes;
        private Button btnRemove;
        private Button btnSearch;
        private Button btnSave;
        private Button btnExit;
        private Label label5;
        private TextBox txtOriginalId;
    }
}