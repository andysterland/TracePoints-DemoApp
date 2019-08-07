namespace TracePoint_DemoApp
{
    partial class frmTest
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
            this.btnGetRandom = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetRandom
            // 
            this.btnGetRandom.Location = new System.Drawing.Point(238, 159);
            this.btnGetRandom.Name = "btnGetRandom";
            this.btnGetRandom.Size = new System.Drawing.Size(253, 83);
            this.btnGetRandom.TabIndex = 0;
            this.btnGetRandom.Text = "Pick Winner";
            this.btnGetRandom.UseVisualStyleBackColor = true;
            this.btnGetRandom.Click += new System.EventHandler(this.BtnGetRandom_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.Location = new System.Drawing.Point(123, 357);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(484, 73);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "The Winner Is...";
            this.lblRandom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(154, 463);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(396, 73);
            this.lblWinner.TabIndex = 2;
            this.lblWinner.Text = "No one yet...";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 627);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.btnGetRandom);
            this.Name = "frmTest";
            this.Text = "TracePoint Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRandom;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblWinner;
    }
}

