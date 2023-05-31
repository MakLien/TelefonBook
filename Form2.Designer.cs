
namespace dbProj
{
    partial class Form2
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
            this.AddButton = new System.Windows.Forms.Button();
            this.Idbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(525, 115);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 160);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Go back";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Idbox
            // 
            this.Idbox.Location = new System.Drawing.Point(104, 165);
            this.Idbox.Multiline = true;
            this.Idbox.Name = "Idbox";
            this.Idbox.Size = new System.Drawing.Size(330, 110);
            this.Idbox.TabIndex = 17;
            this.Idbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Idbox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(88, 115);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(401, 31);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Write down the ID you would like to remove";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Idbox);
            this.Controls.Add(this.AddButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Idbox;
        private System.Windows.Forms.Label NameLabel;
    }
}