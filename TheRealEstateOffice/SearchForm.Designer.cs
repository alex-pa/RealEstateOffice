namespace TheRealEstateOffice
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxArea = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxClass = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxCondition = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Room1 = new System.Windows.Forms.NumericUpDown();
            this.Room2 = new System.Windows.Forms.NumericUpDown();
            this.Floor1 = new System.Windows.Forms.NumericUpDown();
            this.Floor2 = new System.Windows.Forms.NumericUpDown();
            this.SquareMeters1 = new System.Windows.Forms.NumericUpDown();
            this.SquareMeters2 = new System.Windows.Forms.NumericUpDown();
            this.Value1 = new System.Windows.Forms.NumericUpDown();
            this.Value2 = new System.Windows.Forms.NumericUpDown();
            this.Reset = new System.Windows.Forms.Button();
            this.AllRooms = new System.Windows.Forms.Button();
            this.AllFloors = new System.Windows.Forms.Button();
            this.AllSquareMeters = new System.Windows.Forms.Button();
            this.AllValues = new System.Windows.Forms.Button();
            this.AllAreas = new System.Windows.Forms.Button();
            this.AllTypes = new System.Windows.Forms.Button();
            this.AllClases = new System.Windows.Forms.Button();
            this.AllConditions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Room1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMeters1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMeters2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value2)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(141, 536);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(199, 62);
            this.search.TabIndex = 0;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(406, 536);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(199, 62);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Район";
            // 
            // checkedListBoxArea
            // 
            this.checkedListBoxArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListBoxArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxArea.CheckOnClick = true;
            this.checkedListBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxArea.FormattingEnabled = true;
            this.checkedListBoxArea.Items.AddRange(new object[] {
            "Новобаварский",
            "Холодногорский",
            "Шевченковский",
            "Основянский",
            "Московский",
            "Киевский",
            "Слободской",
            "Индустриальный",
            "Немышлянский",
            "Харьковская область"});
            this.checkedListBoxArea.Location = new System.Drawing.Point(32, 59);
            this.checkedListBoxArea.Name = "checkedListBoxArea";
            this.checkedListBoxArea.Size = new System.Drawing.Size(254, 275);
            this.checkedListBoxArea.TabIndex = 4;
            this.checkedListBoxArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxArea_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(351, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(587, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Класс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(353, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Состояние";
            // 
            // checkedListBoxType
            // 
            this.checkedListBoxType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxType.CheckOnClick = true;
            this.checkedListBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Items.AddRange(new object[] {
            "Дом",
            "Квартира",
            "Офис"});
            this.checkedListBoxType.Location = new System.Drawing.Point(354, 59);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(133, 100);
            this.checkedListBoxType.TabIndex = 8;
            this.checkedListBoxType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxType_MouseClick);
            // 
            // checkedListBoxClass
            // 
            this.checkedListBoxClass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxClass.CheckOnClick = true;
            this.checkedListBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxClass.FormattingEnabled = true;
            this.checkedListBoxClass.Items.AddRange(new object[] {
            "Економ",
            "Средний",
            "Бизнес",
            "Люкс"});
            this.checkedListBoxClass.Location = new System.Drawing.Point(591, 59);
            this.checkedListBoxClass.Name = "checkedListBoxClass";
            this.checkedListBoxClass.Size = new System.Drawing.Size(143, 125);
            this.checkedListBoxClass.TabIndex = 9;
            this.checkedListBoxClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxClass_MouseClick);
            // 
            // checkedListBoxCondition
            // 
            this.checkedListBoxCondition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxCondition.CheckOnClick = true;
            this.checkedListBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxCondition.FormattingEnabled = true;
            this.checkedListBoxCondition.Items.AddRange(new object[] {
            "Отличное",
            "Удовлетворительное",
            "Среднее",
            "Требуется ремонт"});
            this.checkedListBoxCondition.Location = new System.Drawing.Point(357, 211);
            this.checkedListBoxCondition.Name = "checkedListBoxCondition";
            this.checkedListBoxCondition.Size = new System.Drawing.Size(262, 125);
            this.checkedListBoxCondition.TabIndex = 10;
            this.checkedListBoxCondition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxCondition_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(31, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Комнаты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(70, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Этаж";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(73, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Кв.м.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(17, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Стоимость";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(154, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "От";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(322, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "До";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(166, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "С";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(324, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "По";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(154, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "От";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(324, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "До";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(154, 491);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "От";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(322, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 23);
            this.label16.TabIndex = 22;
            this.label16.Text = "До";
            // 
            // Room1
            // 
            this.Room1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Room1.Location = new System.Drawing.Point(196, 345);
            this.Room1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Room1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room1.Name = "Room1";
            this.Room1.Size = new System.Drawing.Size(120, 30);
            this.Room1.TabIndex = 23;
            this.Room1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room1.ValueChanged += new System.EventHandler(this.Room1_ValueChanged);
            // 
            // Room2
            // 
            this.Room2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Room2.Location = new System.Drawing.Point(365, 345);
            this.Room2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Room2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room2.Name = "Room2";
            this.Room2.Size = new System.Drawing.Size(122, 30);
            this.Room2.TabIndex = 24;
            this.Room2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Room2.ValueChanged += new System.EventHandler(this.Room2_ValueChanged);
            // 
            // Floor1
            // 
            this.Floor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Floor1.Location = new System.Drawing.Point(196, 394);
            this.Floor1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Floor1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Floor1.Name = "Floor1";
            this.Floor1.Size = new System.Drawing.Size(120, 30);
            this.Floor1.TabIndex = 25;
            this.Floor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Floor1.ValueChanged += new System.EventHandler(this.Floor1_ValueChanged);
            // 
            // Floor2
            // 
            this.Floor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Floor2.Location = new System.Drawing.Point(367, 394);
            this.Floor2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Floor2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Floor2.Name = "Floor2";
            this.Floor2.Size = new System.Drawing.Size(120, 30);
            this.Floor2.TabIndex = 26;
            this.Floor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Floor2.ValueChanged += new System.EventHandler(this.Floor2_ValueChanged);
            // 
            // SquareMeters1
            // 
            this.SquareMeters1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareMeters1.Location = new System.Drawing.Point(196, 441);
            this.SquareMeters1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SquareMeters1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SquareMeters1.Name = "SquareMeters1";
            this.SquareMeters1.Size = new System.Drawing.Size(120, 30);
            this.SquareMeters1.TabIndex = 27;
            this.SquareMeters1.ThousandsSeparator = true;
            this.SquareMeters1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SquareMeters1.ValueChanged += new System.EventHandler(this.SquareMeters1_ValueChanged);
            // 
            // SquareMeters2
            // 
            this.SquareMeters2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareMeters2.Location = new System.Drawing.Point(367, 441);
            this.SquareMeters2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SquareMeters2.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SquareMeters2.Name = "SquareMeters2";
            this.SquareMeters2.Size = new System.Drawing.Size(120, 30);
            this.SquareMeters2.TabIndex = 28;
            this.SquareMeters2.ThousandsSeparator = true;
            this.SquareMeters2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SquareMeters2.ValueChanged += new System.EventHandler(this.SquareMeters2_ValueChanged);
            // 
            // Value1
            // 
            this.Value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Value1.Location = new System.Drawing.Point(196, 488);
            this.Value1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Value1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(120, 30);
            this.Value1.TabIndex = 29;
            this.Value1.ThousandsSeparator = true;
            this.Value1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Value1.ValueChanged += new System.EventHandler(this.Value1_ValueChanged);
            // 
            // Value2
            // 
            this.Value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Value2.Location = new System.Drawing.Point(365, 487);
            this.Value2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Value2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(122, 30);
            this.Value2.TabIndex = 30;
            this.Value2.ThousandsSeparator = true;
            this.Value2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Value2.ValueChanged += new System.EventHandler(this.Value2_ValueChanged);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(616, 394);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(158, 73);
            this.Reset.TabIndex = 31;
            this.Reset.Text = "Сбросить";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // AllRooms
            // 
            this.AllRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllRooms.Location = new System.Drawing.Point(505, 345);
            this.AllRooms.Name = "AllRooms";
            this.AllRooms.Size = new System.Drawing.Size(74, 30);
            this.AllRooms.TabIndex = 32;
            this.AllRooms.Text = "Все";
            this.AllRooms.UseVisualStyleBackColor = true;
            this.AllRooms.Click += new System.EventHandler(this.AllRooms_Click);
            // 
            // AllFloors
            // 
            this.AllFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllFloors.Location = new System.Drawing.Point(505, 394);
            this.AllFloors.Name = "AllFloors";
            this.AllFloors.Size = new System.Drawing.Size(74, 30);
            this.AllFloors.TabIndex = 33;
            this.AllFloors.Text = "Все";
            this.AllFloors.UseVisualStyleBackColor = true;
            this.AllFloors.Click += new System.EventHandler(this.AllFloors_Click);
            // 
            // AllSquareMeters
            // 
            this.AllSquareMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSquareMeters.Location = new System.Drawing.Point(504, 441);
            this.AllSquareMeters.Name = "AllSquareMeters";
            this.AllSquareMeters.Size = new System.Drawing.Size(75, 30);
            this.AllSquareMeters.TabIndex = 34;
            this.AllSquareMeters.Text = "Все";
            this.AllSquareMeters.UseVisualStyleBackColor = true;
            this.AllSquareMeters.Click += new System.EventHandler(this.AllSquareMeters_Click);
            // 
            // AllValues
            // 
            this.AllValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllValues.Location = new System.Drawing.Point(505, 487);
            this.AllValues.Name = "AllValues";
            this.AllValues.Size = new System.Drawing.Size(74, 31);
            this.AllValues.TabIndex = 35;
            this.AllValues.Text = "Все";
            this.AllValues.UseVisualStyleBackColor = true;
            this.AllValues.Click += new System.EventHandler(this.AllValues_Click);
            // 
            // AllAreas
            // 
            this.AllAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAreas.Location = new System.Drawing.Point(107, 23);
            this.AllAreas.Name = "AllAreas";
            this.AllAreas.Size = new System.Drawing.Size(74, 30);
            this.AllAreas.TabIndex = 36;
            this.AllAreas.Text = "Все";
            this.AllAreas.UseVisualStyleBackColor = true;
            this.AllAreas.Click += new System.EventHandler(this.AllAreas_Click);
            // 
            // AllTypes
            // 
            this.AllTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllTypes.Location = new System.Drawing.Point(406, 22);
            this.AllTypes.Name = "AllTypes";
            this.AllTypes.Size = new System.Drawing.Size(74, 30);
            this.AllTypes.TabIndex = 37;
            this.AllTypes.Text = "Все";
            this.AllTypes.UseVisualStyleBackColor = true;
            this.AllTypes.Click += new System.EventHandler(this.AllTypes_Click);
            // 
            // AllClases
            // 
            this.AllClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllClases.Location = new System.Drawing.Point(659, 23);
            this.AllClases.Name = "AllClases";
            this.AllClases.Size = new System.Drawing.Size(74, 30);
            this.AllClases.TabIndex = 38;
            this.AllClases.Text = "Все";
            this.AllClases.UseVisualStyleBackColor = true;
            this.AllClases.Click += new System.EventHandler(this.AllClases_Click);
            // 
            // AllConditions
            // 
            this.AllConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllConditions.Location = new System.Drawing.Point(475, 176);
            this.AllConditions.Name = "AllConditions";
            this.AllConditions.Size = new System.Drawing.Size(74, 30);
            this.AllConditions.TabIndex = 39;
            this.AllConditions.Text = "Все";
            this.AllConditions.UseVisualStyleBackColor = true;
            this.AllConditions.Click += new System.EventHandler(this.AllConditions_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.AllConditions);
            this.Controls.Add(this.AllClases);
            this.Controls.Add(this.AllTypes);
            this.Controls.Add(this.AllAreas);
            this.Controls.Add(this.AllValues);
            this.Controls.Add(this.AllSquareMeters);
            this.Controls.Add(this.AllFloors);
            this.Controls.Add(this.AllRooms);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.SquareMeters2);
            this.Controls.Add(this.SquareMeters1);
            this.Controls.Add(this.Floor2);
            this.Controls.Add(this.Floor1);
            this.Controls.Add(this.Room2);
            this.Controls.Add(this.Room1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBoxCondition);
            this.Controls.Add(this.checkedListBoxClass);
            this.Controls.Add(this.checkedListBoxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 657);
            this.MinimumSize = new System.Drawing.Size(818, 657);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск объектов";
            ((System.ComponentModel.ISupportInitialize)(this.Room1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMeters1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareMeters2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button AllRooms;
        private System.Windows.Forms.Button AllFloors;
        private System.Windows.Forms.Button AllSquareMeters;
        private System.Windows.Forms.Button AllValues;
        private System.Windows.Forms.Button AllAreas;
        private System.Windows.Forms.Button AllTypes;
        private System.Windows.Forms.Button AllClases;
        private System.Windows.Forms.Button AllConditions;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxArea;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxType;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxClass;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxCondition;
        protected internal System.Windows.Forms.NumericUpDown Room1;
        protected internal System.Windows.Forms.NumericUpDown Room2;
        protected internal System.Windows.Forms.NumericUpDown Floor1;
        protected internal System.Windows.Forms.NumericUpDown Floor2;
        protected internal System.Windows.Forms.NumericUpDown SquareMeters1;
        protected internal System.Windows.Forms.NumericUpDown SquareMeters2;
        protected internal System.Windows.Forms.NumericUpDown Value1;
        protected internal System.Windows.Forms.NumericUpDown Value2;
    }
}