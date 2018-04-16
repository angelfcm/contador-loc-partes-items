namespace CodeMetrics
{
    partial class AppCtrlForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openedFileNameLabel = new System.Windows.Forms.Label();
            this.locTextBox = new System.Windows.Forms.TextBox();
            this.locLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.partsContent = new System.Windows.Forms.FlowLayoutPanel();
            this.partHeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.partNumCaptionLabel = new System.Windows.Forms.Label();
            this.partLocCaptionLabel = new System.Windows.Forms.Label();
            this.itemsCountCaptionLabel = new System.Windows.Forms.Label();
            this.partNameCaptionLabel = new System.Windows.Forms.Label();
            this.partPanel = new System.Windows.Forms.Panel();
            this.partItemsPanel = new System.Windows.Forms.Panel();
            this.itemsContent = new System.Windows.Forms.FlowLayoutPanel();
            this.itemHeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.itemNumCaptionLabel = new System.Windows.Forms.Label();
            this.itemLocCaptionLabel = new System.Windows.Forms.Label();
            this.itemNameCaptionLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.itemNumLabel = new System.Windows.Forms.Label();
            this.itemLocLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.partItemsCaptionLabel = new System.Windows.Forms.Label();
            this.partInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.partNumLabel = new System.Windows.Forms.Label();
            this.partLocLabel = new System.Windows.Forms.Label();
            this.itemsCountLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.closeFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.metricsContent = new System.Windows.Forms.Panel();
            this.partsContent.SuspendLayout();
            this.partHeaderTable.SuspendLayout();
            this.partPanel.SuspendLayout();
            this.partItemsPanel.SuspendLayout();
            this.itemsContent.SuspendLayout();
            this.itemHeaderTable.SuspendLayout();
            this.itemPanel.SuspendLayout();
            this.partInfoTable.SuspendLayout();
            this.metricsContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openedFileNameLabel
            // 
            this.openedFileNameLabel.AutoSize = true;
            this.openedFileNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openedFileNameLabel.Location = new System.Drawing.Point(163, 89);
            this.openedFileNameLabel.MaximumSize = new System.Drawing.Size(128, 40);
            this.openedFileNameLabel.Name = "openedFileNameLabel";
            this.openedFileNameLabel.Size = new System.Drawing.Size(94, 13);
            this.openedFileNameLabel.TabIndex = 2;
            this.openedFileNameLabel.Text = "openend file name";
            // 
            // locTextBox
            // 
            this.locTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locTextBox.Location = new System.Drawing.Point(72, 425);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.ReadOnly = true;
            this.locTextBox.Size = new System.Drawing.Size(100, 29);
            this.locTextBox.TabIndex = 5;
            // 
            // locLabel
            // 
            this.locLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.Location = new System.Drawing.Point(25, 431);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(41, 20);
            this.locLabel.TabIndex = 8;
            this.locLabel.Text = "LOC";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.calculateButton.Location = new System.Drawing.Point(343, 425);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(135, 46);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calcular métricas";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // partsContent
            // 
            this.partsContent.AutoSize = true;
            this.partsContent.BackColor = System.Drawing.SystemColors.Info;
            this.partsContent.Controls.Add(this.partHeaderTable);
            this.partsContent.Controls.Add(this.partPanel);
            this.partsContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.partsContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.partsContent.Location = new System.Drawing.Point(3, 3);
            this.partsContent.Name = "partsContent";
            this.partsContent.Size = new System.Drawing.Size(446, 171);
            this.partsContent.TabIndex = 10;
            this.partsContent.WrapContents = false;
            // 
            // partHeaderTable
            // 
            this.partHeaderTable.ColumnCount = 4;
            this.partHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.partHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partHeaderTable.Controls.Add(this.partNumCaptionLabel, 0, 0);
            this.partHeaderTable.Controls.Add(this.partLocCaptionLabel, 1, 0);
            this.partHeaderTable.Controls.Add(this.itemsCountCaptionLabel, 1, 0);
            this.partHeaderTable.Controls.Add(this.partNameCaptionLabel, 1, 0);
            this.partHeaderTable.Location = new System.Drawing.Point(3, 3);
            this.partHeaderTable.Name = "partHeaderTable";
            this.partHeaderTable.RowCount = 1;
            this.partHeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.partHeaderTable.Size = new System.Drawing.Size(440, 26);
            this.partHeaderTable.TabIndex = 1;
            // 
            // partNumCaptionLabel
            // 
            this.partNumCaptionLabel.AutoSize = true;
            this.partNumCaptionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.partNumCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partNumCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partNumCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partNumCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.partNumCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partNumCaptionLabel.Name = "partNumCaptionLabel";
            this.partNumCaptionLabel.Size = new System.Drawing.Size(30, 26);
            this.partNumCaptionLabel.TabIndex = 4;
            this.partNumCaptionLabel.Text = "#";
            this.partNumCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partLocCaptionLabel
            // 
            this.partLocCaptionLabel.AutoSize = true;
            this.partLocCaptionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.partLocCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partLocCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partLocCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partLocCaptionLabel.Location = new System.Drawing.Point(302, 0);
            this.partLocCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partLocCaptionLabel.Name = "partLocCaptionLabel";
            this.partLocCaptionLabel.Size = new System.Drawing.Size(138, 26);
            this.partLocCaptionLabel.TabIndex = 3;
            this.partLocCaptionLabel.Text = "Part LOC";
            this.partLocCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsCountCaptionLabel
            // 
            this.itemsCountCaptionLabel.AutoSize = true;
            this.itemsCountCaptionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.itemsCountCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsCountCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsCountCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemsCountCaptionLabel.Location = new System.Drawing.Point(166, 0);
            this.itemsCountCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemsCountCaptionLabel.Name = "itemsCountCaptionLabel";
            this.itemsCountCaptionLabel.Size = new System.Drawing.Size(136, 26);
            this.itemsCountCaptionLabel.TabIndex = 2;
            this.itemsCountCaptionLabel.Text = "Items Count";
            this.itemsCountCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partNameCaptionLabel
            // 
            this.partNameCaptionLabel.AutoSize = true;
            this.partNameCaptionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.partNameCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partNameCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partNameCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partNameCaptionLabel.Location = new System.Drawing.Point(30, 0);
            this.partNameCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partNameCaptionLabel.Name = "partNameCaptionLabel";
            this.partNameCaptionLabel.Size = new System.Drawing.Size(136, 26);
            this.partNameCaptionLabel.TabIndex = 1;
            this.partNameCaptionLabel.Text = "Part Name";
            this.partNameCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partPanel
            // 
            this.partPanel.AutoSize = true;
            this.partPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partPanel.Controls.Add(this.partItemsPanel);
            this.partPanel.Controls.Add(this.partInfoTable);
            this.partPanel.Location = new System.Drawing.Point(0, 32);
            this.partPanel.Margin = new System.Windows.Forms.Padding(0);
            this.partPanel.Name = "partPanel";
            this.partPanel.Size = new System.Drawing.Size(446, 139);
            this.partPanel.TabIndex = 0;
            // 
            // partItemsPanel
            // 
            this.partItemsPanel.AutoSize = true;
            this.partItemsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partItemsPanel.Controls.Add(this.itemsContent);
            this.partItemsPanel.Controls.Add(this.partItemsCaptionLabel);
            this.partItemsPanel.Location = new System.Drawing.Point(0, 35);
            this.partItemsPanel.Name = "partItemsPanel";
            this.partItemsPanel.Size = new System.Drawing.Size(443, 101);
            this.partItemsPanel.TabIndex = 1;
            // 
            // itemsContent
            // 
            this.itemsContent.AutoSize = true;
            this.itemsContent.Controls.Add(this.itemHeaderTable);
            this.itemsContent.Controls.Add(this.itemPanel);
            this.itemsContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsContent.Location = new System.Drawing.Point(33, 26);
            this.itemsContent.Name = "itemsContent";
            this.itemsContent.Size = new System.Drawing.Size(308, 72);
            this.itemsContent.TabIndex = 2;
            // 
            // itemHeaderTable
            // 
            this.itemHeaderTable.ColumnCount = 3;
            this.itemHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.itemHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemHeaderTable.Controls.Add(this.itemNumCaptionLabel, 0, 0);
            this.itemHeaderTable.Controls.Add(this.itemLocCaptionLabel, 1, 0);
            this.itemHeaderTable.Controls.Add(this.itemNameCaptionLabel, 1, 0);
            this.itemHeaderTable.Location = new System.Drawing.Point(3, 3);
            this.itemHeaderTable.Name = "itemHeaderTable";
            this.itemHeaderTable.RowCount = 1;
            this.itemHeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemHeaderTable.Size = new System.Drawing.Size(302, 26);
            this.itemHeaderTable.TabIndex = 1;
            // 
            // itemNumCaptionLabel
            // 
            this.itemNumCaptionLabel.AutoSize = true;
            this.itemNumCaptionLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.itemNumCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNumCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNumCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemNumCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.itemNumCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemNumCaptionLabel.Name = "itemNumCaptionLabel";
            this.itemNumCaptionLabel.Size = new System.Drawing.Size(30, 26);
            this.itemNumCaptionLabel.TabIndex = 4;
            this.itemNumCaptionLabel.Text = "#";
            this.itemNumCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLocCaptionLabel
            // 
            this.itemLocCaptionLabel.AutoSize = true;
            this.itemLocCaptionLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.itemLocCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemLocCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLocCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemLocCaptionLabel.Location = new System.Drawing.Point(166, 0);
            this.itemLocCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLocCaptionLabel.Name = "itemLocCaptionLabel";
            this.itemLocCaptionLabel.Size = new System.Drawing.Size(136, 26);
            this.itemLocCaptionLabel.TabIndex = 3;
            this.itemLocCaptionLabel.Text = "Item LOC";
            this.itemLocCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameCaptionLabel
            // 
            this.itemNameCaptionLabel.AutoSize = true;
            this.itemNameCaptionLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.itemNameCaptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemNameCaptionLabel.Location = new System.Drawing.Point(30, 0);
            this.itemNameCaptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemNameCaptionLabel.Name = "itemNameCaptionLabel";
            this.itemNameCaptionLabel.Size = new System.Drawing.Size(136, 26);
            this.itemNameCaptionLabel.TabIndex = 1;
            this.itemNameCaptionLabel.Text = "Item Name";
            this.itemNameCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemPanel
            // 
            this.itemPanel.ColumnCount = 3;
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemPanel.Controls.Add(this.itemNumLabel, 0, 0);
            this.itemPanel.Controls.Add(this.itemLocLabel, 1, 0);
            this.itemPanel.Controls.Add(this.itemNameLabel, 1, 0);
            this.itemPanel.Location = new System.Drawing.Point(3, 35);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.RowCount = 1;
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemPanel.Size = new System.Drawing.Size(302, 26);
            this.itemPanel.TabIndex = 2;
            // 
            // itemNumLabel
            // 
            this.itemNumLabel.AutoSize = true;
            this.itemNumLabel.BackColor = System.Drawing.Color.Azure;
            this.itemNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemNumLabel.Location = new System.Drawing.Point(0, 0);
            this.itemNumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemNumLabel.Name = "itemNumLabel";
            this.itemNumLabel.Size = new System.Drawing.Size(30, 26);
            this.itemNumLabel.TabIndex = 5;
            this.itemNumLabel.Text = "1";
            this.itemNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLocLabel
            // 
            this.itemLocLabel.AutoSize = true;
            this.itemLocLabel.BackColor = System.Drawing.Color.Azure;
            this.itemLocLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLocLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemLocLabel.Location = new System.Drawing.Point(166, 0);
            this.itemLocLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLocLabel.Name = "itemLocLabel";
            this.itemLocLabel.Size = new System.Drawing.Size(136, 26);
            this.itemLocLabel.TabIndex = 3;
            this.itemLocLabel.Text = "999";
            this.itemLocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.Azure;
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemNameLabel.Location = new System.Drawing.Point(30, 0);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(136, 26);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item 1";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partItemsCaptionLabel
            // 
            this.partItemsCaptionLabel.AutoSize = true;
            this.partItemsCaptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partItemsCaptionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.partItemsCaptionLabel.Location = new System.Drawing.Point(30, 10);
            this.partItemsCaptionLabel.Name = "partItemsCaptionLabel";
            this.partItemsCaptionLabel.Size = new System.Drawing.Size(91, 13);
            this.partItemsCaptionLabel.TabIndex = 0;
            this.partItemsCaptionLabel.Text = "Items de la parte: ";
            // 
            // partInfoTable
            // 
            this.partInfoTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partInfoTable.ColumnCount = 4;
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.Controls.Add(this.partNumLabel, 0, 0);
            this.partInfoTable.Controls.Add(this.partLocLabel, 1, 0);
            this.partInfoTable.Controls.Add(this.itemsCountLabel, 1, 0);
            this.partInfoTable.Controls.Add(this.partNameLabel, 1, 0);
            this.partInfoTable.Location = new System.Drawing.Point(3, 3);
            this.partInfoTable.Name = "partInfoTable";
            this.partInfoTable.RowCount = 1;
            this.partInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.partInfoTable.Size = new System.Drawing.Size(440, 26);
            this.partInfoTable.TabIndex = 0;
            // 
            // partNumLabel
            // 
            this.partNumLabel.AutoSize = true;
            this.partNumLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partNumLabel.Location = new System.Drawing.Point(0, 0);
            this.partNumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partNumLabel.Name = "partNumLabel";
            this.partNumLabel.Size = new System.Drawing.Size(30, 26);
            this.partNumLabel.TabIndex = 4;
            this.partNumLabel.Text = "1";
            this.partNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partLocLabel
            // 
            this.partLocLabel.AutoSize = true;
            this.partLocLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partLocLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partLocLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partLocLabel.Location = new System.Drawing.Point(302, 0);
            this.partLocLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partLocLabel.Name = "partLocLabel";
            this.partLocLabel.Size = new System.Drawing.Size(138, 26);
            this.partLocLabel.TabIndex = 3;
            this.partLocLabel.Text = "999";
            this.partLocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsCountLabel
            // 
            this.itemsCountLabel.AutoSize = true;
            this.itemsCountLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemsCountLabel.Location = new System.Drawing.Point(166, 0);
            this.itemsCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemsCountLabel.Name = "itemsCountLabel";
            this.itemsCountLabel.Size = new System.Drawing.Size(136, 26);
            this.itemsCountLabel.TabIndex = 2;
            this.itemsCountLabel.Text = "999";
            this.itemsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partNameLabel.Location = new System.Drawing.Point(30, 0);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(136, 26);
            this.partNameLabel.TabIndex = 1;
            this.partNameLabel.Text = "Part 1";
            this.partNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeFileButton
            // 
            this.closeFileButton.BackColor = System.Drawing.Color.DarkOrange;
            this.closeFileButton.BackgroundImage = global::CodeMetrics.Properties.Resources.close;
            this.closeFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeFileButton.FlatAppearance.BorderSize = 0;
            this.closeFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.closeFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.closeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFileButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeFileButton.Location = new System.Drawing.Point(131, 37);
            this.closeFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(20, 20);
            this.closeFileButton.TabIndex = 11;
            this.closeFileButton.UseVisualStyleBackColor = false;
            this.closeFileButton.Click += new System.EventHandler(this.closeFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.DarkOrange;
            this.openFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.openFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Image = global::CodeMetrics.Properties.Resources.file_upload_48px;
            this.openFileButton.Location = new System.Drawing.Point(29, 31);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(128, 128);
            this.openFileButton.TabIndex = 12;
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            this.openFileButton.MouseEnter += new System.EventHandler(this.openFileButton_MouseEnter);
            this.openFileButton.MouseLeave += new System.EventHandler(this.openFileButton_MouseLeave);
            // 
            // metricsContent
            // 
            this.metricsContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metricsContent.AutoScroll = true;
            this.metricsContent.Controls.Add(this.partsContent);
            this.metricsContent.Location = new System.Drawing.Point(29, 176);
            this.metricsContent.Margin = new System.Windows.Forms.Padding(0);
            this.metricsContent.Name = "metricsContent";
            this.metricsContent.Size = new System.Drawing.Size(470, 228);
            this.metricsContent.TabIndex = 13;
            // 
            // AppCtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 497);
            this.Controls.Add(this.metricsContent);
            this.Controls.Add(this.closeFileButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.locLabel);
            this.Controls.Add(this.locTextBox);
            this.Controls.Add(this.openedFileNameLabel);
            this.Controls.Add(this.openFileButton);
            this.MinimumSize = new System.Drawing.Size(430, 430);
            this.Name = "AppCtrlForm";
            this.Text = "Métrica de código - Partes, Items, LOC";
            this.partsContent.ResumeLayout(false);
            this.partsContent.PerformLayout();
            this.partHeaderTable.ResumeLayout(false);
            this.partHeaderTable.PerformLayout();
            this.partPanel.ResumeLayout(false);
            this.partPanel.PerformLayout();
            this.partItemsPanel.ResumeLayout(false);
            this.partItemsPanel.PerformLayout();
            this.itemsContent.ResumeLayout(false);
            this.itemHeaderTable.ResumeLayout(false);
            this.itemHeaderTable.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            this.partInfoTable.ResumeLayout(false);
            this.partInfoTable.PerformLayout();
            this.metricsContent.ResumeLayout(false);
            this.metricsContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label openedFileNameLabel;
        private System.Windows.Forms.TextBox locTextBox;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.FlowLayoutPanel partsContent;
        private System.Windows.Forms.Button closeFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Panel partPanel;
        private System.Windows.Forms.TableLayoutPanel partInfoTable;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label itemsCountLabel;
        private System.Windows.Forms.Label partLocLabel;
        private System.Windows.Forms.Panel partItemsPanel;
        private System.Windows.Forms.Label partItemsCaptionLabel;
        private System.Windows.Forms.FlowLayoutPanel itemsContent;
        private System.Windows.Forms.TableLayoutPanel itemHeaderTable;
        private System.Windows.Forms.Label itemLocCaptionLabel;
        private System.Windows.Forms.Label itemNameCaptionLabel;
        private System.Windows.Forms.TableLayoutPanel itemPanel;
        private System.Windows.Forms.Label itemLocLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TableLayoutPanel partHeaderTable;
        private System.Windows.Forms.Label partLocCaptionLabel;
        private System.Windows.Forms.Label itemsCountCaptionLabel;
        private System.Windows.Forms.Label partNameCaptionLabel;
        private System.Windows.Forms.Label itemNumLabel;
        private System.Windows.Forms.Label partNumLabel;
        private System.Windows.Forms.Label partNumCaptionLabel;
        private System.Windows.Forms.Label itemNumCaptionLabel;
        private System.Windows.Forms.Panel metricsContent;
    }
}

