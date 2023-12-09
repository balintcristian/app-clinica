namespace Proiect
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
            this.dbButton = new System.Windows.Forms.Button();
            this.btnReceptie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status: neconectat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dbButton
            // 
            this.dbButton.Location = new System.Drawing.Point(28, 415);
            this.dbButton.Name = "dbButton";
            this.dbButton.Size = new System.Drawing.Size(75, 23);
            this.dbButton.TabIndex = 6;
            this.dbButton.Text = "button1";
            this.dbButton.UseVisualStyleBackColor = true;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // btnReceptie
            // 
            this.btnReceptie.Location = new System.Drawing.Point(133, 105);
            this.btnReceptie.Name = "btnReceptie";
            this.btnReceptie.Size = new System.Drawing.Size(195, 23);
            this.btnReceptie.TabIndex = 7;
            this.btnReceptie.Text = "Receptie";
            this.btnReceptie.UseVisualStyleBackColor = true;
            this.btnReceptie.Click += new System.EventHandler(this.btnReceptie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Laborator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cabinet psihiatrie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cabinet terapie psihologica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReceptie);
            this.Controls.Add(this.dbButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dbButton;
        private System.Windows.Forms.Button btnReceptie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

