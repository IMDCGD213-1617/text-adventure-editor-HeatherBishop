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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.UseBtn = new System.Windows.Forms.Button();
            this.PickupBtn = new System.Windows.Forms.Button();
            this.North = new System.Windows.Forms.Button();
            this.South = new System.Windows.Forms.Button();
            this.East = new System.Windows.Forms.Button();
            this.West = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(12, 12);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(379, 292);
            this.OutputBox.TabIndex = 0;
            // 
            // UseBtn
            // 
            this.UseBtn.Location = new System.Drawing.Point(13, 355);
            this.UseBtn.Name = "UseBtn";
            this.UseBtn.Size = new System.Drawing.Size(75, 23);
            this.UseBtn.TabIndex = 1;
            this.UseBtn.Text = "Use";
            this.UseBtn.UseVisualStyleBackColor = true;
            this.UseBtn.Click += new System.EventHandler(this.UseBtn_Click);
            // 
            // PickupBtn
            // 
            this.PickupBtn.Location = new System.Drawing.Point(13, 384);
            this.PickupBtn.Name = "PickupBtn";
            this.PickupBtn.Size = new System.Drawing.Size(75, 23);
            this.PickupBtn.TabIndex = 2;
            this.PickupBtn.Text = "Pickup";
            this.PickupBtn.UseVisualStyleBackColor = true;
            this.PickupBtn.Click += new System.EventHandler(this.PickupBtn_Click);
            // 
            // North
            // 
            this.North.Location = new System.Drawing.Point(180, 342);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(75, 23);
            this.North.TabIndex = 3;
            this.North.Text = "North";
            this.North.UseVisualStyleBackColor = true;
            this.North.Click += new System.EventHandler(this.North_Click);
            // 
            // South
            // 
            this.South.Location = new System.Drawing.Point(180, 419);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(75, 23);
            this.South.TabIndex = 4;
            this.South.Text = "South";
            this.South.UseVisualStyleBackColor = true;
            this.South.Click += new System.EventHandler(this.South_Click);
            // 
            // East
            // 
            this.East.Location = new System.Drawing.Point(262, 381);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(75, 23);
            this.East.TabIndex = 5;
            this.East.Text = "East";
            this.East.UseVisualStyleBackColor = true;
            this.East.Click += new System.EventHandler(this.East_Click);
            // 
            // West
            // 
            this.West.Location = new System.Drawing.Point(101, 381);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(75, 23);
            this.West.TabIndex = 6;
            this.West.Text = "West";
            this.West.UseVisualStyleBackColor = true;
            this.West.Click += new System.EventHandler(this.West_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 310);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(379, 20);
            this.InputBox.TabIndex = 7;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 526);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.West);
            this.Controls.Add(this.East);
            this.Controls.Add(this.South);
            this.Controls.Add(this.North);
            this.Controls.Add(this.PickupBtn);
            this.Controls.Add(this.UseBtn);
            this.Controls.Add(this.OutputBox);
            this.Name = "BaseForm";
            this.Text = "Text Adventure";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button UseBtn;
        private System.Windows.Forms.Button PickupBtn;
        private System.Windows.Forms.Button North;
        private System.Windows.Forms.Button South;
        private System.Windows.Forms.Button East;
        private System.Windows.Forms.Button West;
        private System.Windows.Forms.TextBox InputBox;
    }
}

