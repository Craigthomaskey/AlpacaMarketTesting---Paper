namespace AlpacaMarketTesting___Paper
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
            this.GetTimeBttn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.AccntBttn = new System.Windows.Forms.Button();
            this.AccntLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetTimeBttn
            // 
            this.GetTimeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetTimeBttn.Location = new System.Drawing.Point(12, 59);
            this.GetTimeBttn.Name = "GetTimeBttn";
            this.GetTimeBttn.Size = new System.Drawing.Size(75, 23);
            this.GetTimeBttn.TabIndex = 0;
            this.GetTimeBttn.Text = "Get Time";
            this.GetTimeBttn.UseVisualStyleBackColor = true;
            this.GetTimeBttn.Click += new System.EventHandler(this.GetTimeBttn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(535, 47);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccntBttn
            // 
            this.AccntBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccntBttn.Location = new System.Drawing.Point(457, 59);
            this.AccntBttn.Name = "AccntBttn";
            this.AccntBttn.Size = new System.Drawing.Size(90, 23);
            this.AccntBttn.TabIndex = 0;
            this.AccntBttn.Text = "Account Info";
            this.AccntBttn.UseVisualStyleBackColor = true;
            this.AccntBttn.Click += new System.EventHandler(this.AccntBttn_Click);
            // 
            // AccntLabel
            // 
            this.AccntLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccntLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccntLabel.Location = new System.Drawing.Point(12, 85);
            this.AccntLabel.Name = "AccntLabel";
            this.AccntLabel.Size = new System.Drawing.Size(535, 47);
            this.AccntLabel.TabIndex = 1;
            this.AccntLabel.Text = "Info";
            this.AccntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 147);
            this.Controls.Add(this.AccntLabel);
            this.Controls.Add(this.AccntBttn);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.GetTimeBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetTimeBttn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button AccntBttn;
        private System.Windows.Forms.Label AccntLabel;
    }
}

