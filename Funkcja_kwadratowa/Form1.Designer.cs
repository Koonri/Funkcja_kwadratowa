namespace Funkcja_kwadratowa
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.LA = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.TextBox();
            this.LC = new System.Windows.Forms.TextBox();
            this.delta = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Podaj A,B,C i Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LA
            // 
            this.LA.Location = new System.Drawing.Point(178, 355);
            this.LA.Name = "LA";
            this.LA.Size = new System.Drawing.Size(100, 23);
            this.LA.TabIndex = 1;
            this.LA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB
            // 
            this.LB.Location = new System.Drawing.Point(346, 355);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(100, 23);
            this.LB.TabIndex = 2;
            // 
            // LC
            // 
            this.LC.Location = new System.Drawing.Point(516, 355);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(100, 23);
            this.LC.TabIndex = 3;
            // 
            // delta
            // 
            this.delta.AutoSize = true;
            this.delta.Location = new System.Drawing.Point(178, 219);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(34, 15);
            this.delta.TabIndex = 4;
            this.delta.Text = "Delta";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(346, 219);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(19, 15);
            this.x1.TabIndex = 5;
            this.x1.Text = "x1";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(516, 219);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(19, 15);
            this.x2.TabIndex = 6;
            this.x2.Text = "x2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.LA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox LA;
        private TextBox LB;
        private TextBox LC;
        private Label delta;
        private Label x1;
        private Label x2;
    }
}