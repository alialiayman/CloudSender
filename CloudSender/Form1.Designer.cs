namespace CloudSender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPages = new System.Windows.Forms.ListBox();
            this.dfsSendString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dfsPageName = new System.Windows.Forms.TextBox();
            this.lblScriptName = new System.Windows.Forms.Label();
            this.btnTab = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLastRandom = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.sbMain = new System.Windows.Forms.StatusStrip();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnPin = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAddCollection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn10Digits = new System.Windows.Forms.Button();
            this.dfcCollections = new System.Windows.Forms.ComboBox();
            this.dffTakeScreenshots = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstPages
            // 
            this.lstPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPages.FormattingEnabled = true;
            this.lstPages.Location = new System.Drawing.Point(16, 263);
            this.lstPages.Name = "lstPages";
            this.lstPages.Size = new System.Drawing.Size(434, 381);
            this.lstPages.Sorted = true;
            this.lstPages.TabIndex = 0;
            this.lstPages.SelectedIndexChanged += new System.EventHandler(this.lstPages_SelectedIndexChanged);
            this.lstPages.DoubleClick += new System.EventHandler(this.lstPages_DoubleClick);
            // 
            // dfsSendString
            // 
            this.dfsSendString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsSendString.BackColor = System.Drawing.Color.Yellow;
            this.dfsSendString.Location = new System.Drawing.Point(15, 25);
            this.dfsSendString.Multiline = true;
            this.dfsSendString.Name = "dfsSendString";
            this.dfsSendString.Size = new System.Drawing.Size(349, 90);
            this.dfsSendString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field Values";
            // 
            // dfsPageName
            // 
            this.dfsPageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsPageName.Location = new System.Drawing.Point(92, 121);
            this.dfsPageName.Name = "dfsPageName";
            this.dfsPageName.Size = new System.Drawing.Size(350, 20);
            this.dfsPageName.TabIndex = 3;
            this.dfsPageName.TextChanged += new System.EventHandler(this.dfsPageName_TextChanged);
            this.dfsPageName.DoubleClick += new System.EventHandler(this.dfsPageName_DoubleClick);
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Location = new System.Drawing.Point(13, 124);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(65, 13);
            this.lblScriptName.TabIndex = 4;
            this.lblScriptName.Text = "Script Name";
            this.lblScriptName.Click += new System.EventHandler(this.lblScriptName_Click);
            this.lblScriptName.DoubleClick += new System.EventHandler(this.lblScriptName_DoubleClick);
            // 
            // btnTab
            // 
            this.btnTab.AutoSize = true;
            this.btnTab.BackColor = System.Drawing.Color.Yellow;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.Location = new System.Drawing.Point(347, 3);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(39, 19);
            this.btnTab.TabIndex = 6;
            this.btnTab.Text = "TAB";
            this.btnTab.UseVisualStyleBackColor = false;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.BackColor = System.Drawing.Color.Yellow;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(140, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(39, 19);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLastRandom
            // 
            this.btnLastRandom.AutoSize = true;
            this.btnLastRandom.BackColor = System.Drawing.Color.Yellow;
            this.btnLastRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastRandom.Location = new System.Drawing.Point(236, 3);
            this.btnLastRandom.Name = "btnLastRandom";
            this.btnLastRandom.Size = new System.Drawing.Size(60, 19);
            this.btnLastRandom.TabIndex = 8;
            this.btnLastRandom.Text = "Last Random";
            this.btnLastRandom.UseVisualStyleBackColor = false;
            this.btnLastRandom.Click += new System.EventHandler(this.btnLastRandom_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.BackColor = System.Drawing.Color.Yellow;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(302, 3);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(44, 19);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // sbMain
            // 
            this.sbMain.Location = new System.Drawing.Point(0, 647);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(454, 22);
            this.sbMain.TabIndex = 10;
            this.sbMain.Text = "statusStrip1";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "pinned.png");
            this.imgList.Images.SetKeyName(1, "unpinned.png");
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.AutoSize = true;
            this.btnPin.BackgroundImage = global::CloudSender.Properties.Resources.pinned;
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPin.Location = new System.Drawing.Point(426, -1);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(24, 23);
            this.btnPin.TabIndex = 11;
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackgroundImage = global::CloudSender.Properties.Resources.plane;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(365, 25);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 90);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAddCollection
            // 
            this.btnAddCollection.AutoSize = true;
            this.btnAddCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCollection.Location = new System.Drawing.Point(403, 232);
            this.btnAddCollection.Name = "btnAddCollection";
            this.btnAddCollection.Size = new System.Drawing.Size(39, 21);
            this.btnAddCollection.TabIndex = 13;
            this.btnAddCollection.Text = "+";
            this.btnAddCollection.UseVisualStyleBackColor = false;
            this.btnAddCollection.Click += new System.EventHandler(this.btnAddCollection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Collections";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn10Digits
            // 
            this.btn10Digits.AutoSize = true;
            this.btn10Digits.BackColor = System.Drawing.Color.Yellow;
            this.btn10Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Digits.Location = new System.Drawing.Point(185, 3);
            this.btn10Digits.Name = "btn10Digits";
            this.btn10Digits.Size = new System.Drawing.Size(45, 19);
            this.btn10Digits.TabIndex = 15;
            this.btn10Digits.Text = "10 Digits";
            this.btn10Digits.UseVisualStyleBackColor = false;
            this.btn10Digits.Click += new System.EventHandler(this.btn10Digits_Click);
            // 
            // dfcCollections
            // 
            this.dfcCollections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dfcCollections.FormattingEnabled = true;
            this.dfcCollections.Location = new System.Drawing.Point(92, 232);
            this.dfcCollections.Name = "dfcCollections";
            this.dfcCollections.Size = new System.Drawing.Size(303, 21);
            this.dfcCollections.TabIndex = 12;
            this.dfcCollections.SelectedIndexChanged += new System.EventHandler(this.dfcCollections_SelectedIndexChanged);
            // 
            // dffTakeScreenshots
            // 
            this.dffTakeScreenshots.AutoSize = true;
            this.dffTakeScreenshots.Checked = global::CloudSender.Properties.Settings.Default.isTakeScreenShots;
            this.dffTakeScreenshots.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CloudSender.Properties.Settings.Default, "isTakeScreenShots", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dffTakeScreenshots.Location = new System.Drawing.Point(92, 147);
            this.dffTakeScreenshots.Name = "dffTakeScreenshots";
            this.dffTakeScreenshots.Size = new System.Drawing.Size(114, 17);
            this.dffTakeScreenshots.TabIndex = 16;
            this.dffTakeScreenshots.Text = "Take screen shots";
            this.dffTakeScreenshots.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 669);
            this.Controls.Add(this.dffTakeScreenshots);
            this.Controls.Add(this.btn10Digits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCollection);
            this.Controls.Add(this.dfcCollections);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.sbMain);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLastRandom);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblScriptName);
            this.Controls.Add(this.dfsPageName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfsSendString);
            this.Controls.Add(this.lstPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cloud Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPages;
        private System.Windows.Forms.TextBox dfsSendString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dfsPageName;
        private System.Windows.Forms.Label lblScriptName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLastRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.StatusStrip sbMain;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ComboBox dfcCollections;
        private System.Windows.Forms.Button btnAddCollection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn10Digits;
        private System.Windows.Forms.CheckBox dffTakeScreenshots;
    }
}

