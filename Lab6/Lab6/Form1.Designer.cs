namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_colour = new System.Windows.Forms.Button();
            this.rdb_1 = new System.Windows.Forms.RadioButton();
            this.rdb_2 = new System.Windows.Forms.RadioButton();
            this.rdb_3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_end = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 434);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bt_colour
            // 
            this.bt_colour.Location = new System.Drawing.Point(580, 42);
            this.bt_colour.Name = "bt_colour";
            this.bt_colour.Size = new System.Drawing.Size(112, 34);
            this.bt_colour.TabIndex = 1;
            this.bt_colour.Text = "Colour";
            this.bt_colour.UseVisualStyleBackColor = true;
            this.bt_colour.Click += new System.EventHandler(this.bt_colour_Click);
            // 
            // rdb_1
            // 
            this.rdb_1.AutoSize = true;
            this.rdb_1.Location = new System.Drawing.Point(610, 111);
            this.rdb_1.Name = "rdb_1";
            this.rdb_1.Size = new System.Drawing.Size(47, 29);
            this.rdb_1.TabIndex = 2;
            this.rdb_1.TabStop = true;
            this.rdb_1.Text = "1";
            this.rdb_1.UseVisualStyleBackColor = true;
            // 
            // rdb_2
            // 
            this.rdb_2.AutoSize = true;
            this.rdb_2.Location = new System.Drawing.Point(12, 41);
            this.rdb_2.Name = "rdb_2";
            this.rdb_2.Size = new System.Drawing.Size(47, 29);
            this.rdb_2.TabIndex = 2;
            this.rdb_2.TabStop = true;
            this.rdb_2.Text = "2";
            this.rdb_2.UseVisualStyleBackColor = true;
            // 
            // rdb_3
            // 
            this.rdb_3.AutoSize = true;
            this.rdb_3.Location = new System.Drawing.Point(12, 76);
            this.rdb_3.Name = "rdb_3";
            this.rdb_3.Size = new System.Drawing.Size(47, 29);
            this.rdb_3.TabIndex = 2;
            this.rdb_3.TabStop = true;
            this.rdb_3.Text = "3";
            this.rdb_3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_2);
            this.panel2.Controls.Add(this.rdb_3);
            this.panel2.Location = new System.Drawing.Point(598, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 117);
            this.panel2.TabIndex = 3;
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(580, 346);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(120, 52);
            this.bt_end.TabIndex = 5;
            this.bt_end.Text = "End";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 492);
            this.Controls.Add(this.bt_end);
            this.Controls.Add(this.rdb_1);
            this.Controls.Add(this.bt_colour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button bt_colour;
        private RadioButton rdb_1;
        private RadioButton rdb_2;
        private RadioButton rdb_3;
        private Panel panel2;
        private Button bt_end;
    }
}