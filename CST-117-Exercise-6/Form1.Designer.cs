namespace CST_117_Exercise_6
{
    partial class snakeEyesForm
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
            this.rollButton = new System.Windows.Forms.Button();
            this.diceOnePanel = new System.Windows.Forms.Panel();
            this.diceTwoPanel = new System.Windows.Forms.Panel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(17, 16);
            this.rollButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(133, 123);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diceOnePanel
            // 
            this.diceOnePanel.Location = new System.Drawing.Point(175, 15);
            this.diceOnePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diceOnePanel.Name = "diceOnePanel";
            this.diceOnePanel.Size = new System.Drawing.Size(133, 123);
            this.diceOnePanel.TabIndex = 1;
            this.diceOnePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.diceOnePanel_Paint);
            // 
            // diceTwoPanel
            // 
            this.diceTwoPanel.Location = new System.Drawing.Point(341, 16);
            this.diceTwoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diceTwoPanel.Name = "diceTwoPanel";
            this.diceTwoPanel.Size = new System.Drawing.Size(133, 123);
            this.diceTwoPanel.TabIndex = 2;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(16, 198);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(370, 17);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Roll dice to see how many rolls it takes to get snake eyes!";
            // 
            // snakeEyesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 411);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.diceTwoPanel);
            this.Controls.Add(this.diceOnePanel);
            this.Controls.Add(this.rollButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "snakeEyesForm";
            this.Text = "Snake Eyes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Panel diceOnePanel;
        private System.Windows.Forms.Panel diceTwoPanel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

