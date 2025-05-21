namespace BinaryConverterLibrary
{
    partial class BinaryConverterControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Оголошення елементів керування
        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBoxBinary;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси слід видалити; інакше, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Метод, необхідний для підтримки конструктора — не змінюйте
        /// вміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Location = new System.Drawing.Point(10, 10);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(120, 20);
            // Встановлення Anchor: верх, ліво, право
            this.textBoxDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecimal.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(10, 40);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 25);
            // Встановлення Anchor: верх, ліво, право
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Перетворити";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Location = new System.Drawing.Point(10, 80);
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.ReadOnly = true;
            this.textBoxBinary.Size = new System.Drawing.Size(120, 20);
            // Встановлення Anchor: верх, ліво, право
            this.textBoxBinary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBinary.TabIndex = 2;
            // 
            // BinaryConverterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBoxDecimal);
            this.Name = "BinaryConverterControl";
            this.Size = new System.Drawing.Size(150, 120);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
