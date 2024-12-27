namespace Tyuiu.SchcapovMA.Sprint7.Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout_SMA = new Label();
            pictureBoxAbout_SMA = new PictureBox();
            buttonAboutOk_SMA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_SMA).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_SMA
            // 
            labelAbout_SMA.AutoSize = true;
            labelAbout_SMA.BackColor = Color.Transparent;
            labelAbout_SMA.ForeColor = Color.Honeydew;
            labelAbout_SMA.Location = new Point(339, 96);
            labelAbout_SMA.Name = "labelAbout_SMA";
            labelAbout_SMA.Size = new Size(369, 240);
            labelAbout_SMA.TabIndex = 0;
            labelAbout_SMA.Text = resources.GetString("labelAbout_SMA.Text");
            // 
            // pictureBoxAbout_SMA
            // 
            pictureBoxAbout_SMA.Image = (Image)resources.GetObject("pictureBoxAbout_SMA.Image");
            pictureBoxAbout_SMA.Location = new Point(-7, -2);
            pictureBoxAbout_SMA.Name = "pictureBoxAbout_SMA";
            pictureBoxAbout_SMA.Size = new Size(322, 417);
            pictureBoxAbout_SMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAbout_SMA.TabIndex = 1;
            pictureBoxAbout_SMA.TabStop = false;
            // 
            // buttonAboutOk_SMA
            // 
            buttonAboutOk_SMA.BackColor = Color.Transparent;
            buttonAboutOk_SMA.Cursor = Cursors.Hand;
            buttonAboutOk_SMA.FlatStyle = FlatStyle.Flat;
            buttonAboutOk_SMA.ForeColor = Color.DimGray;
            buttonAboutOk_SMA.Image = (Image)resources.GetObject("buttonAboutOk_SMA.Image");
            buttonAboutOk_SMA.Location = new Point(615, 361);
            buttonAboutOk_SMA.Name = "buttonAboutOk_SMA";
            buttonAboutOk_SMA.Size = new Size(71, 43);
            buttonAboutOk_SMA.TabIndex = 2;
            buttonAboutOk_SMA.UseVisualStyleBackColor = false;
            buttonAboutOk_SMA.Click += buttonAboutOk_SMA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 416);
            Controls.Add(buttonAboutOk_SMA);
            Controls.Add(pictureBoxAbout_SMA);
            Controls.Add(labelAbout_SMA);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_SMA;
        private PictureBox pictureBoxAbout_SMA;
        private Button buttonAboutOk_SMA;
    }
}