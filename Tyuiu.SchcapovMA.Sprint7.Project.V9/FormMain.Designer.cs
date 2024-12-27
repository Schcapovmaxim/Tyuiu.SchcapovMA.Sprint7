namespace Tyuiu.SchcapovMA.Sprint7.Project.V9
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_SMA = new Panel();
            buttonBook = new Button();
            buttonHelp_SMA = new Button();
            buttonSaveFile_SMA = new Button();
            buttonOpenFile_SMA = new Button();
            buttonGraf_SMA = new Button();
            panelButtonFun_SMA = new Panel();
            button1 = new Button();
            checkBoxSer_SMA = new CheckBox();
            checkBoxPop_SMA = new CheckBox();
            checkBoxBall_SMA = new CheckBox();
            checkBoxTime_SMA = new CheckBox();
            panelBase_SMA = new Panel();
            groupBoxTabl_SMA = new GroupBox();
            dataGridViewTabl_SMA = new DataGridView();
            toolTip_SMA = new ToolTip(components);
            openFileDialog_SMA = new OpenFileDialog();
            saveFileDialog_SMA = new SaveFileDialog();
            panelButton_SMA.SuspendLayout();
            panelButtonFun_SMA.SuspendLayout();
            panelBase_SMA.SuspendLayout();
            groupBoxTabl_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabl_SMA).BeginInit();
            SuspendLayout();
            // 
            // panelButton_SMA
            // 
            panelButton_SMA.BackColor = SystemColors.ActiveCaption;
            panelButton_SMA.Controls.Add(buttonBook);
            panelButton_SMA.Controls.Add(buttonHelp_SMA);
            panelButton_SMA.Controls.Add(buttonSaveFile_SMA);
            panelButton_SMA.Controls.Add(buttonOpenFile_SMA);
            panelButton_SMA.Dock = DockStyle.Top;
            panelButton_SMA.Location = new Point(0, 0);
            panelButton_SMA.Name = "panelButton_SMA";
            panelButton_SMA.Size = new Size(800, 89);
            panelButton_SMA.TabIndex = 0;
            // 
            // buttonBook
            // 
            buttonBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBook.Cursor = Cursors.Hand;
            buttonBook.FlatStyle = FlatStyle.Flat;
            buttonBook.Image = (Image)resources.GetObject("buttonBook.Image");
            buttonBook.Location = new Point(612, 13);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(75, 63);
            buttonBook.TabIndex = 8;
            toolTip_SMA.SetToolTip(buttonBook, "Главное меню");
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // buttonHelp_SMA
            // 
            buttonHelp_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SMA.Cursor = Cursors.Help;
            buttonHelp_SMA.FlatStyle = FlatStyle.Flat;
            buttonHelp_SMA.Image = (Image)resources.GetObject("buttonHelp_SMA.Image");
            buttonHelp_SMA.Location = new Point(707, 13);
            buttonHelp_SMA.Name = "buttonHelp_SMA";
            buttonHelp_SMA.Size = new Size(75, 63);
            buttonHelp_SMA.TabIndex = 2;
            toolTip_SMA.SetToolTip(buttonHelp_SMA, "О разработчике");
            buttonHelp_SMA.UseVisualStyleBackColor = true;
            buttonHelp_SMA.Click += buttonHelp_SMA_Click;
            // 
            // buttonSaveFile_SMA
            // 
            buttonSaveFile_SMA.Cursor = Cursors.Hand;
            buttonSaveFile_SMA.Enabled = false;
            buttonSaveFile_SMA.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_SMA.Image = (Image)resources.GetObject("buttonSaveFile_SMA.Image");
            buttonSaveFile_SMA.Location = new Point(113, 12);
            buttonSaveFile_SMA.Name = "buttonSaveFile_SMA";
            buttonSaveFile_SMA.Size = new Size(75, 63);
            buttonSaveFile_SMA.TabIndex = 1;
            toolTip_SMA.SetToolTip(buttonSaveFile_SMA, "Сохранить файл");
            buttonSaveFile_SMA.UseVisualStyleBackColor = true;
            buttonSaveFile_SMA.Click += buttonSaveFile_SMA_Click;
            // 
            // buttonOpenFile_SMA
            // 
            buttonOpenFile_SMA.Cursor = Cursors.Hand;
            buttonOpenFile_SMA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_SMA.Image = (Image)resources.GetObject("buttonOpenFile_SMA.Image");
            buttonOpenFile_SMA.Location = new Point(12, 12);
            buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            buttonOpenFile_SMA.Size = new Size(75, 63);
            buttonOpenFile_SMA.TabIndex = 0;
            toolTip_SMA.SetToolTip(buttonOpenFile_SMA, "Выбрать файл в формате csv");
            buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            buttonOpenFile_SMA.Click += buttonOpenFile_SMA_Click;
            // 
            // buttonGraf_SMA
            // 
            buttonGraf_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGraf_SMA.Cursor = Cursors.Hand;
            buttonGraf_SMA.FlatStyle = FlatStyle.Flat;
            buttonGraf_SMA.Image = (Image)resources.GetObject("buttonGraf_SMA.Image");
            buttonGraf_SMA.Location = new Point(713, 11);
            buttonGraf_SMA.Name = "buttonGraf_SMA";
            buttonGraf_SMA.Size = new Size(75, 63);
            buttonGraf_SMA.TabIndex = 3;
            toolTip_SMA.SetToolTip(buttonGraf_SMA, "Построить график на основе критерия");
            buttonGraf_SMA.UseVisualStyleBackColor = true;
            buttonGraf_SMA.Click += buttonGraf_SMA_Click;
            // 
            // panelButtonFun_SMA
            // 
            panelButtonFun_SMA.BackColor = SystemColors.ActiveCaption;
            panelButtonFun_SMA.Controls.Add(button1);
            panelButtonFun_SMA.Controls.Add(checkBoxSer_SMA);
            panelButtonFun_SMA.Controls.Add(checkBoxPop_SMA);
            panelButtonFun_SMA.Controls.Add(checkBoxBall_SMA);
            panelButtonFun_SMA.Controls.Add(buttonGraf_SMA);
            panelButtonFun_SMA.Controls.Add(checkBoxTime_SMA);
            panelButtonFun_SMA.Dock = DockStyle.Bottom;
            panelButtonFun_SMA.Location = new Point(0, 364);
            panelButtonFun_SMA.Name = "panelButtonFun_SMA";
            panelButtonFun_SMA.Size = new Size(800, 86);
            panelButtonFun_SMA.TabIndex = 4;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 63);
            button1.TabIndex = 7;
            toolTip_SMA.SetToolTip(button1, "Применить фильтры");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBoxSer_SMA
            // 
            checkBoxSer_SMA.AutoSize = true;
            checkBoxSer_SMA.Location = new Point(535, 31);
            checkBoxSer_SMA.Name = "checkBoxSer_SMA";
            checkBoxSer_SMA.Size = new Size(119, 24);
            checkBoxSer_SMA.TabIndex = 6;
            checkBoxSer_SMA.Text = "Серьёзность";
            checkBoxSer_SMA.UseVisualStyleBackColor = true;
            // 
            // checkBoxPop_SMA
            // 
            checkBoxPop_SMA.AutoSize = true;
            checkBoxPop_SMA.Location = new Point(398, 31);
            checkBoxPop_SMA.Name = "checkBoxPop_SMA";
            checkBoxPop_SMA.Size = new Size(131, 24);
            checkBoxPop_SMA.TabIndex = 5;
            checkBoxPop_SMA.Text = "Популярность";
            checkBoxPop_SMA.UseVisualStyleBackColor = true;
            // 
            // checkBoxBall_SMA
            // 
            checkBoxBall_SMA.AutoSize = true;
            checkBoxBall_SMA.Location = new Point(291, 31);
            checkBoxBall_SMA.Name = "checkBoxBall_SMA";
            checkBoxBall_SMA.Size = new Size(83, 24);
            checkBoxBall_SMA.TabIndex = 4;
            checkBoxBall_SMA.Text = "Оценка";
            checkBoxBall_SMA.UseVisualStyleBackColor = true;
            // 
            // checkBoxTime_SMA
            // 
            checkBoxTime_SMA.AutoSize = true;
            checkBoxTime_SMA.Location = new Point(147, 31);
            checkBoxTime_SMA.Name = "checkBoxTime_SMA";
            checkBoxTime_SMA.Size = new Size(127, 24);
            checkBoxTime_SMA.TabIndex = 0;
            checkBoxTime_SMA.Text = "Длительность";
            checkBoxTime_SMA.UseVisualStyleBackColor = true;
            // 
            // panelBase_SMA
            // 
            panelBase_SMA.Controls.Add(groupBoxTabl_SMA);
            panelBase_SMA.Dock = DockStyle.Fill;
            panelBase_SMA.Location = new Point(0, 89);
            panelBase_SMA.Name = "panelBase_SMA";
            panelBase_SMA.Size = new Size(800, 275);
            panelBase_SMA.TabIndex = 4;
            // 
            // groupBoxTabl_SMA
            // 
            groupBoxTabl_SMA.BackColor = SystemColors.ActiveCaption;
            groupBoxTabl_SMA.Controls.Add(dataGridViewTabl_SMA);
            groupBoxTabl_SMA.Dock = DockStyle.Fill;
            groupBoxTabl_SMA.Location = new Point(0, 0);
            groupBoxTabl_SMA.Name = "groupBoxTabl_SMA";
            groupBoxTabl_SMA.Size = new Size(800, 275);
            groupBoxTabl_SMA.TabIndex = 5;
            groupBoxTabl_SMA.TabStop = false;
            groupBoxTabl_SMA.Text = "Фильмы";
            // 
            // dataGridViewTabl_SMA
            // 
            dataGridViewTabl_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTabl_SMA.Dock = DockStyle.Fill;
            dataGridViewTabl_SMA.Location = new Point(3, 23);
            dataGridViewTabl_SMA.Name = "dataGridViewTabl_SMA";
            dataGridViewTabl_SMA.RowHeadersVisible = false;
            dataGridViewTabl_SMA.RowHeadersWidth = 51;
            dataGridViewTabl_SMA.Size = new Size(794, 249);
            dataGridViewTabl_SMA.TabIndex = 4;
            dataGridViewTabl_SMA.CellContentClick += dataGridViewTabl_SMA_CellContentClick;
            // 
            // toolTip_SMA
            // 
            toolTip_SMA.Tag = "Подсказка";
            toolTip_SMA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SMA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_SMA
            // 
            openFileDialog_SMA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBase_SMA);
            Controls.Add(panelButtonFun_SMA);
            Controls.Add(panelButton_SMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(818, 497);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SortedInfo";
            WindowState = FormWindowState.Maximized;
            panelButton_SMA.ResumeLayout(false);
            panelButtonFun_SMA.ResumeLayout(false);
            panelButtonFun_SMA.PerformLayout();
            panelBase_SMA.ResumeLayout(false);
            groupBoxTabl_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabl_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_SMA;
        private Button buttonGraf_SMA;
        private Button buttonHelp_SMA;
        private Button buttonSaveFile_SMA;
        private Button buttonOpenFile_SMA;
        private Panel panelButtonFun_SMA;
        private Panel panelBase_SMA;
        private DataGridView dataGridViewTabl_SMA;
        private GroupBox groupBoxTabl_SMA;
        private CheckBox checkBoxTime_SMA;
        private Button button1;
        private CheckBox checkBoxSer_SMA;
        private CheckBox checkBoxPop_SMA;
        private CheckBox checkBoxBall_SMA;
        private Button buttonBook;
        private ToolTip toolTip_SMA;
        private OpenFileDialog openFileDialog_SMA;
        private SaveFileDialog saveFileDialog_SMA;
    }
}