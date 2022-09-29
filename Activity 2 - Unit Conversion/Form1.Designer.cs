namespace Activity_2___Unit_Conversion
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
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(270, 15);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 30);
            this.Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "temperature in Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "temperature in Farenheit";
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(270, 50);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(147, 30);
            this.Output.TabIndex = 3;
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.Location = new System.Drawing.Point(305, 93);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(112, 32);
            this.convert.TabIndex = 4;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 137);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Celcius to Farenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button convert;
    }
}

