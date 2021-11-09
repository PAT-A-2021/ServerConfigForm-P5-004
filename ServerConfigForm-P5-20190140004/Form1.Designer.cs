
namespace ServerConfigForm_P5_20190140004
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(288, 115);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 13);
            this.labelKet.TabIndex = 1;
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(288, 154);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(0, 13);
            this.labelOnOff.TabIndex = 2;
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(228, 240);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 23);
            this.buttonOn.TabIndex = 3;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(341, 240);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOff.TabIndex = 4;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
    }
}

