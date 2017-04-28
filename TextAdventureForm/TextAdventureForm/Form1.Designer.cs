namespace TextAdventureForm {
    partial class BaseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.roomDescrip = new System.Windows.Forms.TextBox();
            this.UseBtn = new System.Windows.Forms.Button();
            this.PickupBtn = new System.Windows.Forms.Button();
            this.roomTitle = new System.Windows.Forms.TextBox();
            this.CreateItemBtn = new System.Windows.Forms.Button();
            this.loadItemBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemTitle = new System.Windows.Forms.TextBox();
            this.itemDescrip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDescrip
            // 
            this.roomDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomDescrip.Location = new System.Drawing.Point(12, 38);
            this.roomDescrip.Multiline = true;
            this.roomDescrip.Name = "roomDescrip";
            this.roomDescrip.Size = new System.Drawing.Size(156, 140);
            this.roomDescrip.TabIndex = 0;
            // 
            // UseBtn
            // 
            this.UseBtn.Location = new System.Drawing.Point(13, 355);
            this.UseBtn.Name = "UseBtn";
            this.UseBtn.Size = new System.Drawing.Size(94, 23);
            this.UseBtn.TabIndex = 1;
            this.UseBtn.Text = "Create Room";
            this.UseBtn.UseVisualStyleBackColor = true;
            this.UseBtn.Click += new System.EventHandler(this.UseBtn_Click);
            // 
            // PickupBtn
            // 
            this.PickupBtn.Location = new System.Drawing.Point(13, 384);
            this.PickupBtn.Name = "PickupBtn";
            this.PickupBtn.Size = new System.Drawing.Size(94, 23);
            this.PickupBtn.TabIndex = 2;
            this.PickupBtn.Text = "Load Room";
            this.PickupBtn.UseVisualStyleBackColor = true;
            this.PickupBtn.Click += new System.EventHandler(this.PickupBtn_Click);
            // 
            // roomTitle
            // 
            this.roomTitle.Location = new System.Drawing.Point(12, 12);
            this.roomTitle.Name = "roomTitle";
            this.roomTitle.Size = new System.Drawing.Size(156, 20);
            this.roomTitle.TabIndex = 7;
            // 
            // CreateItemBtn
            // 
            this.CreateItemBtn.Location = new System.Drawing.Point(297, 355);
            this.CreateItemBtn.Name = "CreateItemBtn";
            this.CreateItemBtn.Size = new System.Drawing.Size(94, 23);
            this.CreateItemBtn.TabIndex = 8;
            this.CreateItemBtn.Text = "Create Item";
            this.CreateItemBtn.UseVisualStyleBackColor = true;
            this.CreateItemBtn.Click += new System.EventHandler(this.CreateItemBtn_Click);
            // 
            // loadItemBtn
            // 
            this.loadItemBtn.Location = new System.Drawing.Point(297, 384);
            this.loadItemBtn.Name = "loadItemBtn";
            this.loadItemBtn.Size = new System.Drawing.Size(94, 23);
            this.loadItemBtn.TabIndex = 9;
            this.loadItemBtn.Text = "Load Item";
            this.loadItemBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "North",
            "East",
            "South",
            "West"});
            this.comboBox1.Location = new System.Drawing.Point(13, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 242);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(179, 241);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "exit direction";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "save data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemTitle
            // 
            this.itemTitle.Location = new System.Drawing.Point(244, 12);
            this.itemTitle.Name = "itemTitle";
            this.itemTitle.Size = new System.Drawing.Size(147, 20);
            this.itemTitle.TabIndex = 18;
            // 
            // itemDescrip
            // 
            this.itemDescrip.Location = new System.Drawing.Point(244, 38);
            this.itemDescrip.Multiline = true;
            this.itemDescrip.Name = "itemDescrip";
            this.itemDescrip.Size = new System.Drawing.Size(147, 140);
            this.itemDescrip.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "load data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.itemDescrip);
            this.Controls.Add(this.itemTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loadItemBtn);
            this.Controls.Add(this.CreateItemBtn);
            this.Controls.Add(this.roomTitle);
            this.Controls.Add(this.PickupBtn);
            this.Controls.Add(this.UseBtn);
            this.Controls.Add(this.roomDescrip);
            this.Name = "BaseForm";
            this.Text = "Text Adventure";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomDescrip;
        private System.Windows.Forms.Button UseBtn;
        private System.Windows.Forms.Button PickupBtn;
        private System.Windows.Forms.TextBox roomTitle;
        private System.Windows.Forms.Button CreateItemBtn;
        private System.Windows.Forms.Button loadItemBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox itemTitle;
        private System.Windows.Forms.TextBox itemDescrip;
        private System.Windows.Forms.Button button2;
    }
}

