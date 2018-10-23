namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_Token_bold = new System.Windows.Forms.Label();
            this.lb_Token = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERANDO TOKEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Token_bold
            // 
            this.label_Token_bold.AutoSize = true;
            this.label_Token_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Token_bold.Location = new System.Drawing.Point(12, 173);
            this.label_Token_bold.Name = "label_Token_bold";
            this.label_Token_bold.Size = new System.Drawing.Size(86, 25);
            this.label_Token_bold.TabIndex = 1;
            this.label_Token_bold.Text = "Token: ";
            this.label_Token_bold.Visible = false;
            // 
            // lb_Token
            // 
            this.lb_Token.AutoSize = true;
            this.lb_Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Token.Location = new System.Drawing.Point(91, 178);
            this.lb_Token.Name = "lb_Token";
            this.lb_Token.Size = new System.Drawing.Size(0, 18);
            this.lb_Token.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gerando Token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Token);
            this.Controls.Add(this.label_Token_bold);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Teste Gerador Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Token_bold;
        private System.Windows.Forms.Label lb_Token;
        private System.Windows.Forms.Label label2;
    }
}

