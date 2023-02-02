namespace IParcial
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.HornearAzincronoButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(67, 29);
            this.HornearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(237, 82);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // HornearAzincronoButton
            // 
            this.HornearAzincronoButton.Location = new System.Drawing.Point(401, 29);
            this.HornearAzincronoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HornearAzincronoButton.Name = "HornearAzincronoButton";
            this.HornearAzincronoButton.Size = new System.Drawing.Size(237, 82);
            this.HornearAzincronoButton.TabIndex = 1;
            this.HornearAzincronoButton.Text = "Hornear Pizza Asincrono";
            this.HornearAzincronoButton.UseVisualStyleBackColor = true;
            this.HornearAzincronoButton.Click += new System.EventHandler(this.HornearAzincronoButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(369, 187);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(147, 64);
            this.CalcularButton.TabIndex = 2;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(188, 187);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(160, 26);
            this.Numero1TextBox.TabIndex = 5;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(188, 225);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(160, 26);
            this.Numero2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 458);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.HornearAzincronoButton);
            this.Controls.Add(this.HornearButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button HornearAzincronoButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
    }
}