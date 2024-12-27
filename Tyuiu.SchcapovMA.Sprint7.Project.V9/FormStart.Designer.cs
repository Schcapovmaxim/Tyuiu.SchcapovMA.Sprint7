namespace Tyuiu.SchcapovMA.Sprint7.Project.V9
{
    partial class FormStart
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            buttonRun_SMA = new Button();
            toolTipRun_SMA = new ToolTip(components);
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonRun_SMA
            // 
            buttonRun_SMA.BackColor = Color.Transparent;
            buttonRun_SMA.Cursor = Cursors.Hand;
            buttonRun_SMA.FlatStyle = FlatStyle.Flat;
            buttonRun_SMA.Location = new Point(506, 308);
            buttonRun_SMA.Name = "buttonRun_SMA";
            buttonRun_SMA.Size = new Size(114, 63);
            buttonRun_SMA.TabIndex = 0;
            buttonRun_SMA.Text = "Начать";
            toolTipRun_SMA.SetToolTip(buttonRun_SMA, "Нажмите,чтобы приступить к работе");
            buttonRun_SMA.UseVisualStyleBackColor = false;
            buttonRun_SMA.Click += button1_Click;
            // 
            // toolTipRun_SMA
            // 
            toolTipRun_SMA.ToolTipIcon = ToolTipIcon.Info;
            toolTipRun_SMA.ToolTipTitle = "Подсказка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(274, 125);
            label1.Name = "label1";
            label1.Size = new Size(260, 67);
            label1.TabIndex = 1;
            label1.Text = "SortedInfo";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(218, 308);
            button1.Name = "button1";
            button1.Size = new Size(114, 63);
            button1.TabIndex = 2;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonRun_SMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SortedInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun_SMA;
        private ToolTip toolTipRun_SMA;
        private Label label1;
        private Button button1;
    }
}
