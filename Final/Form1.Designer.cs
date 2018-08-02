namespace Final
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label importTaskNameLabel;
            System.Windows.Forms.Label importTaskDescLabel;
            System.Windows.Forms.Label importTaskDueDateLabel;
            System.Windows.Forms.Label importTaskStatusLabel;
            System.Windows.Forms.Label importTaskPriorityLabel;
            System.Windows.Forms.Label importTaskWeatherLabel;
            this.importDBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.importDBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.importTaskNameTextBox = new System.Windows.Forms.TextBox();
            this.importTaskDescTextBox = new System.Windows.Forms.TextBox();
            this.importTaskDueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importTaskStatusTextBox = new System.Windows.Forms.TextBox();
            this.importTaskPriorityTextBox = new System.Windows.Forms.TextBox();
            this.importTaskWeatherTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sunRadioButton = new System.Windows.Forms.RadioButton();
            this.rainRadioButton = new System.Windows.Forms.RadioButton();
            this.snowRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.weatherImageList = new System.Windows.Forms.ImageList(this.components);
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.loadAgendaButton = new System.Windows.Forms.Button();
            this.importDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importDBDataSet = new Final.ImportDBDataSet();
            this.importDBTableAdapter = new Final.ImportDBDataSetTableAdapters.ImportDBTableAdapter();
            this.tableAdapterManager = new Final.ImportDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            importTaskNameLabel = new System.Windows.Forms.Label();
            importTaskDescLabel = new System.Windows.Forms.Label();
            importTaskDueDateLabel = new System.Windows.Forms.Label();
            importTaskStatusLabel = new System.Windows.Forms.Label();
            importTaskPriorityLabel = new System.Windows.Forms.Label();
            importTaskWeatherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importDBBindingNavigator)).BeginInit();
            this.importDBBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // importDBBindingNavigator
            // 
            this.importDBBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.importDBBindingNavigator.BindingSource = this.importDBBindingSource;
            this.importDBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.importDBBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.importDBBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.importDBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.importDBBindingNavigatorSaveItem});
            this.importDBBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.importDBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.importDBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.importDBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.importDBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.importDBBindingNavigator.Name = "importDBBindingNavigator";
            this.importDBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.importDBBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.importDBBindingNavigator.TabIndex = 0;
            this.importDBBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // importDBBindingNavigatorSaveItem
            // 
            this.importDBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importDBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("importDBBindingNavigatorSaveItem.Image")));
            this.importDBBindingNavigatorSaveItem.Name = "importDBBindingNavigatorSaveItem";
            this.importDBBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.importDBBindingNavigatorSaveItem.Text = "Save Data";
            this.importDBBindingNavigatorSaveItem.Click += new System.EventHandler(this.importDBBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(38, 127);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(194, 124);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // importTaskNameLabel
            // 
            importTaskNameLabel.AutoSize = true;
            importTaskNameLabel.Location = new System.Drawing.Point(38, 155);
            importTaskNameLabel.Name = "importTaskNameLabel";
            importTaskNameLabel.Size = new System.Drawing.Size(127, 17);
            importTaskNameLabel.TabIndex = 3;
            importTaskNameLabel.Text = "Import Task Name:";
            // 
            // importTaskNameTextBox
            // 
            this.importTaskNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "ImportTaskName", true));
            this.importTaskNameTextBox.Location = new System.Drawing.Point(194, 152);
            this.importTaskNameTextBox.Name = "importTaskNameTextBox";
            this.importTaskNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.importTaskNameTextBox.TabIndex = 4;
            // 
            // importTaskDescLabel
            // 
            importTaskDescLabel.AutoSize = true;
            importTaskDescLabel.Location = new System.Drawing.Point(38, 183);
            importTaskDescLabel.Name = "importTaskDescLabel";
            importTaskDescLabel.Size = new System.Drawing.Size(122, 17);
            importTaskDescLabel.TabIndex = 5;
            importTaskDescLabel.Text = "Import Task Desc:";
            // 
            // importTaskDescTextBox
            // 
            this.importTaskDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "ImportTaskDesc", true));
            this.importTaskDescTextBox.Location = new System.Drawing.Point(194, 180);
            this.importTaskDescTextBox.Name = "importTaskDescTextBox";
            this.importTaskDescTextBox.Size = new System.Drawing.Size(200, 22);
            this.importTaskDescTextBox.TabIndex = 6;
            // 
            // importTaskDueDateLabel
            // 
            importTaskDueDateLabel.AutoSize = true;
            importTaskDueDateLabel.Location = new System.Drawing.Point(38, 212);
            importTaskDueDateLabel.Name = "importTaskDueDateLabel";
            importTaskDueDateLabel.Size = new System.Drawing.Size(150, 17);
            importTaskDueDateLabel.TabIndex = 7;
            importTaskDueDateLabel.Text = "Import Task Due Date:";
            // 
            // importTaskDueDateDateTimePicker
            // 
            this.importTaskDueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.importDBBindingSource, "ImportTaskDueDate", true));
            this.importTaskDueDateDateTimePicker.Location = new System.Drawing.Point(194, 208);
            this.importTaskDueDateDateTimePicker.Name = "importTaskDueDateDateTimePicker";
            this.importTaskDueDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.importTaskDueDateDateTimePicker.TabIndex = 8;
            // 
            // importTaskStatusLabel
            // 
            importTaskStatusLabel.AutoSize = true;
            importTaskStatusLabel.Location = new System.Drawing.Point(38, 239);
            importTaskStatusLabel.Name = "importTaskStatusLabel";
            importTaskStatusLabel.Size = new System.Drawing.Size(130, 17);
            importTaskStatusLabel.TabIndex = 9;
            importTaskStatusLabel.Text = "Import Task Status:";
            // 
            // importTaskStatusTextBox
            // 
            this.importTaskStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "ImportTaskStatus", true));
            this.importTaskStatusTextBox.Location = new System.Drawing.Point(194, 236);
            this.importTaskStatusTextBox.Name = "importTaskStatusTextBox";
            this.importTaskStatusTextBox.Size = new System.Drawing.Size(200, 22);
            this.importTaskStatusTextBox.TabIndex = 10;
            // 
            // importTaskPriorityLabel
            // 
            importTaskPriorityLabel.AutoSize = true;
            importTaskPriorityLabel.Location = new System.Drawing.Point(38, 267);
            importTaskPriorityLabel.Name = "importTaskPriorityLabel";
            importTaskPriorityLabel.Size = new System.Drawing.Size(134, 17);
            importTaskPriorityLabel.TabIndex = 11;
            importTaskPriorityLabel.Text = "Import Task Priority:";
            // 
            // importTaskPriorityTextBox
            // 
            this.importTaskPriorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "ImportTaskPriority", true));
            this.importTaskPriorityTextBox.Location = new System.Drawing.Point(194, 264);
            this.importTaskPriorityTextBox.Name = "importTaskPriorityTextBox";
            this.importTaskPriorityTextBox.Size = new System.Drawing.Size(200, 22);
            this.importTaskPriorityTextBox.TabIndex = 12;
            // 
            // importTaskWeatherLabel
            // 
            importTaskWeatherLabel.AutoSize = true;
            importTaskWeatherLabel.Location = new System.Drawing.Point(38, 295);
            importTaskWeatherLabel.Name = "importTaskWeatherLabel";
            importTaskWeatherLabel.Size = new System.Drawing.Size(144, 17);
            importTaskWeatherLabel.TabIndex = 13;
            importTaskWeatherLabel.Text = "Import Task Weather:";
            // 
            // importTaskWeatherTextBox
            // 
            this.importTaskWeatherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importDBBindingSource, "ImportTaskWeather", true));
            this.importTaskWeatherTextBox.Location = new System.Drawing.Point(194, 292);
            this.importTaskWeatherTextBox.Name = "importTaskWeatherTextBox";
            this.importTaskWeatherTextBox.Size = new System.Drawing.Size(200, 22);
            this.importTaskWeatherTextBox.TabIndex = 14;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(193, 61);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 15;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(65, 62);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(102, 17);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Enter the date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.weatherPictureBox);
            this.panel1.Controls.Add(this.NoneRadioButton);
            this.panel1.Controls.Add(this.snowRadioButton);
            this.panel1.Controls.Add(this.rainRadioButton);
            this.panel1.Controls.Add(this.sunRadioButton);
            this.panel1.Location = new System.Drawing.Point(437, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 229);
            this.panel1.TabIndex = 17;
            // 
            // sunRadioButton
            // 
            this.sunRadioButton.AutoSize = true;
            this.sunRadioButton.Location = new System.Drawing.Point(22, 38);
            this.sunRadioButton.Name = "sunRadioButton";
            this.sunRadioButton.Size = new System.Drawing.Size(54, 21);
            this.sunRadioButton.TabIndex = 18;
            this.sunRadioButton.TabStop = true;
            this.sunRadioButton.Text = "Sun";
            this.sunRadioButton.UseVisualStyleBackColor = true;
            this.sunRadioButton.CheckedChanged += new System.EventHandler(this.sunRadioButton_CheckedChanged);
            // 
            // rainRadioButton
            // 
            this.rainRadioButton.AutoSize = true;
            this.rainRadioButton.Location = new System.Drawing.Point(22, 70);
            this.rainRadioButton.Name = "rainRadioButton";
            this.rainRadioButton.Size = new System.Drawing.Size(58, 21);
            this.rainRadioButton.TabIndex = 19;
            this.rainRadioButton.TabStop = true;
            this.rainRadioButton.Text = "Rain";
            this.rainRadioButton.UseVisualStyleBackColor = true;
            this.rainRadioButton.CheckedChanged += new System.EventHandler(this.rainRadioButton_CheckedChanged);
            // 
            // snowRadioButton
            // 
            this.snowRadioButton.AutoSize = true;
            this.snowRadioButton.Location = new System.Drawing.Point(22, 98);
            this.snowRadioButton.Name = "snowRadioButton";
            this.snowRadioButton.Size = new System.Drawing.Size(63, 21);
            this.snowRadioButton.TabIndex = 20;
            this.snowRadioButton.TabStop = true;
            this.snowRadioButton.Text = "Snow";
            this.snowRadioButton.UseVisualStyleBackColor = true;
            this.snowRadioButton.CheckedChanged += new System.EventHandler(this.snowRadioButton_CheckedChanged);
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(22, 127);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(63, 21);
            this.NoneRadioButton.TabIndex = 21;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // weatherImageList
            // 
            this.weatherImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("weatherImageList.ImageStream")));
            this.weatherImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.weatherImageList.Images.SetKeyName(0, "sun.jpg");
            this.weatherImageList.Images.SetKeyName(1, "rain.jpg");
            this.weatherImageList.Images.SetKeyName(2, "snow.jpg");
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.Location = new System.Drawing.Point(107, 42);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(100, 77);
            this.weatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherPictureBox.TabIndex = 22;
            this.weatherPictureBox.TabStop = false;
            this.weatherPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loadAgendaButton
            // 
            this.loadAgendaButton.Location = new System.Drawing.Point(68, 348);
            this.loadAgendaButton.Name = "loadAgendaButton";
            this.loadAgendaButton.Size = new System.Drawing.Size(75, 59);
            this.loadAgendaButton.TabIndex = 18;
            this.loadAgendaButton.Text = "Load Agenda";
            this.loadAgendaButton.UseVisualStyleBackColor = true;
            this.loadAgendaButton.Click += new System.EventHandler(this.loadAgendaButton_Click);
            // 
            // importDBBindingSource
            // 
            this.importDBBindingSource.DataMember = "ImportDB";
            this.importDBBindingSource.DataSource = this.importDBDataSet;
            // 
            // importDBDataSet
            // 
            this.importDBDataSet.DataSetName = "ImportDBDataSet";
            this.importDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importDBTableAdapter
            // 
            this.importDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImportDBTableAdapter = this.importDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final.ImportDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Load All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(309, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 59);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadAgendaButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(importTaskNameLabel);
            this.Controls.Add(this.importTaskNameTextBox);
            this.Controls.Add(importTaskDescLabel);
            this.Controls.Add(this.importTaskDescTextBox);
            this.Controls.Add(importTaskDueDateLabel);
            this.Controls.Add(this.importTaskDueDateDateTimePicker);
            this.Controls.Add(importTaskStatusLabel);
            this.Controls.Add(this.importTaskStatusTextBox);
            this.Controls.Add(importTaskPriorityLabel);
            this.Controls.Add(this.importTaskPriorityTextBox);
            this.Controls.Add(importTaskWeatherLabel);
            this.Controls.Add(this.importTaskWeatherTextBox);
            this.Controls.Add(this.importDBBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importDBBindingNavigator)).EndInit();
            this.importDBBindingNavigator.ResumeLayout(false);
            this.importDBBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImportDBDataSet importDBDataSet;
        private System.Windows.Forms.BindingSource importDBBindingSource;
        private ImportDBDataSetTableAdapters.ImportDBTableAdapter importDBTableAdapter;
        private ImportDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator importDBBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton importDBBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox importTaskNameTextBox;
        private System.Windows.Forms.TextBox importTaskDescTextBox;
        private System.Windows.Forms.DateTimePicker importTaskDueDateDateTimePicker;
        private System.Windows.Forms.TextBox importTaskStatusTextBox;
        private System.Windows.Forms.TextBox importTaskPriorityTextBox;
        private System.Windows.Forms.TextBox importTaskWeatherTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox weatherPictureBox;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.RadioButton snowRadioButton;
        private System.Windows.Forms.RadioButton rainRadioButton;
        private System.Windows.Forms.RadioButton sunRadioButton;
        private System.Windows.Forms.ImageList weatherImageList;
        private System.Windows.Forms.Button loadAgendaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
    }
}

