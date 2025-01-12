namespace ProdTools
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openquery = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(214, 18);
            label1.Name = "label1";
            label1.Size = new Size(388, 47);
            label1.TabIndex = 0;
            label1.Text = "כלי להכנה עלייה לייצור";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // openquery
            // 
            openquery.BackColor = Color.Transparent;
            openquery.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            openquery.Location = new Point(398, 103);
            openquery.Name = "openquery";
            openquery.Size = new Size(281, 75);
            openquery.TabIndex = 1;
            openquery.Text = "צפה בטבלה";
            openquery.UseVisualStyleBackColor = false;
            openquery.Click += openquery_Click;
            // 
            // Inicio
            // 
            AccessibleName = "Inicio";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(804, 461);
            Controls.Add(openquery);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inicio";
            Text = "Fausto Deploy Tools";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button openquery;
    }
}
