
namespace BazaDanych
{
    partial class Adding
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
            this.newName = new System.Windows.Forms.TextBox();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.newHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.newName.Location = new System.Drawing.Point(123, 21);
            this.newName.Name = "textBox1";
            this.newName.Size = new System.Drawing.Size(200, 22);
            this.newName.TabIndex = 0;
            this.newName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.newDate.Location = new System.Drawing.Point(123, 49);
            this.newDate.Name = "dateTimePicker1";
            this.newDate.Size = new System.Drawing.Size(200, 22);
            this.newDate.TabIndex = 3;
            this.newDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.newHeight.Location = new System.Drawing.Point(123, 77);
            this.newHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newHeight.Name = "numericUpDown1";
            this.newHeight.Size = new System.Drawing.Size(200, 22);
            this.newHeight.TabIndex = 4;
            this.newHeight.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wzrost (w cm)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(161, 105);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(107, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Zatwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 164);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newHeight);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.newName);
            this.Name = "Adding";
            this.Text = "Adding";
            ((System.ComponentModel.ISupportInitialize)(this.newHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.NumericUpDown newHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirm;
    }
}