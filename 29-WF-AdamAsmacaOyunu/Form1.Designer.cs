namespace _29_WF_AdamAsmacaOyunu
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
            pctrbxAdamAs = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pctrbxAdamAs).BeginInit();
            SuspendLayout();
            // 
            // pctrbxAdamAs
            // 
            pctrbxAdamAs.Location = new Point(609, 37);
            pctrbxAdamAs.Name = "pctrbxAdamAs";
            pctrbxAdamAs.Size = new Size(249, 370);
            pctrbxAdamAs.SizeMode = PictureBoxSizeMode.Zoom;
            pctrbxAdamAs.TabIndex = 0;
            pctrbxAdamAs.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(pctrbxAdamAs);
            Name = "Form1";
            Text = "Adam Asmaca Oyunu";
            ((System.ComponentModel.ISupportInitialize)pctrbxAdamAs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctrbxAdamAs;
        private Button button1;
    }
}
