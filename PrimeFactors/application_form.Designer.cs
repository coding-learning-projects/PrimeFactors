namespace PrimeFactors
{
    partial class application_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number_textbox
            // 
            this.number_textbox.Location = new System.Drawing.Point(341, 34);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(100, 23);
            this.number_textbox.TabIndex = 1;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(447, 34);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 2;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(39, 112);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 15);
            this.result_label.TabIndex = 3;
            // 
            // application_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.label1);
            this.Name = "application_form";
            this.Text = "Prime Factors Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox number_textbox;
        private Button calculate_button;
        private Label result_label;
    }
}