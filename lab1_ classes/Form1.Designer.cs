namespace lab1__classes
{
    partial class Figures
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddPlugin = new System.Windows.Forms.Button();
            this.dlgPlugin = new System.Windows.Forms.OpenFileDialog();
            this.lsbPictures = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.opnDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAddFunctionPlugin = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(316, 368);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(348, 100);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(85, 23);
            this.btnLine.TabIndex = 1;
            this.btnLine.Tag = "1";
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(348, 129);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(85, 23);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Tag = "2";
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(348, 158);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(85, 23);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Tag = "3";
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(348, 187);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(85, 23);
            this.btnEllipse.TabIndex = 6;
            this.btnEllipse.Tag = "4";
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCircle.Location = new System.Drawing.Point(348, 216);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(85, 23);
            this.btnCircle.TabIndex = 7;
            this.btnCircle.Tag = "5";
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.Location = new System.Drawing.Point(348, 71);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(85, 23);
            this.btnBrush.TabIndex = 8;
            this.btnBrush.Tag = "0";
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColor.Location = new System.Drawing.Point(348, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(40, 20);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbWidth.Location = new System.Drawing.Point(394, 38);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(41, 21);
            this.cmbWidth.TabIndex = 3;
            this.cmbWidth.Text = "3";
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(356, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "width";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnAddPlugin
            // 
            this.btnAddPlugin.Location = new System.Drawing.Point(12, 391);
            this.btnAddPlugin.Name = "btnAddPlugin";
            this.btnAddPlugin.Size = new System.Drawing.Size(156, 23);
            this.btnAddPlugin.TabIndex = 12;
            this.btnAddPlugin.Text = "Add Figure Plugin";
            this.btnAddPlugin.UseVisualStyleBackColor = true;
            this.btnAddPlugin.Click += new System.EventHandler(this.btnAddPlugin_Click);
            // 
            // dlgPlugin
            // 
            this.dlgPlugin.FileName = "openFileDialog1";
            // 
            // lsbPictures
            // 
            this.lsbPictures.FormattingEnabled = true;
            this.lsbPictures.Location = new System.Drawing.Point(460, 12);
            this.lsbPictures.Name = "lsbPictures";
            this.lsbPictures.Size = new System.Drawing.Size(132, 108);
            this.lsbPictures.TabIndex = 13;
            this.lsbPictures.DoubleClick += new System.EventHandler(this.lsbPictures_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(598, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(598, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(59, 23);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // opnDialog
            // 
            this.opnDialog.FileName = "openFileDialog1";
            // 
            // btnAddFunctionPlugin
            // 
            this.btnAddFunctionPlugin.Location = new System.Drawing.Point(174, 391);
            this.btnAddFunctionPlugin.Name = "btnAddFunctionPlugin";
            this.btnAddFunctionPlugin.Size = new System.Drawing.Size(154, 23);
            this.btnAddFunctionPlugin.TabIndex = 17;
            this.btnAddFunctionPlugin.Text = "Add Function Plugin";
            this.btnAddFunctionPlugin.UseVisualStyleBackColor = true;
            this.btnAddFunctionPlugin.Click += new System.EventHandler(this.btnAddFunctionPlugin_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(598, 100);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(59, 23);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(598, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAddFunctionPlugin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbPictures);
            this.Controls.Add(this.btnAddPlugin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnBrush);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(685, 464);
            this.Name = "Figures";
            this.Text = "Figures";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddPlugin;
        private System.Windows.Forms.OpenFileDialog dlgPlugin;
        private System.Windows.Forms.ListBox lsbPictures;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog opnDialog;
        private System.Windows.Forms.Button btnAddFunctionPlugin;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

