using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace CodeMetrics
{
    // BeginPart: CodePart
    class CodePart : Panel
    {
        string _partName = "";
        int _partLoc = 0;
        List<CodeItem> _items = new List<CodeItem>();
        static int partNumCounter = 1;

        public int partNum
        {
            get; private set;
        }
        public string partName
        {
            get { return _partName; }
            set
            {
                _partName = value;
                partNameLabel.Text = _partName;
            }
        }
        public int partLoc
        {
            get { return _partLoc; }
            set
            {
                _partLoc = value;
                partLocLabel.Text = _partLoc.ToString();
            }
        }
        public int itemsCount { get { return _items.Count; } }

        // BeginItem: AddItem
        public void AddItem(CodeItem item)
        {
            _items.Add(item);
            itemsContent.Controls.Add(item);
            itemsCountLabel.Text = _items.Count.ToString();
        }
        // EndItem: AddItem

        // BeginItem: Destroy
        public void Destroy()
        {
            DestroyHandle();
        }
        // EndItem: Destroy

        // BeginItem: CodePart
        public CodePart(string partName)
        {
            #region UI
            this.partItemsPanel = new System.Windows.Forms.Panel();
            this.itemsContent = new System.Windows.Forms.FlowLayoutPanel();
            this.itemHeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.itemNumCaptionLabel = new System.Windows.Forms.Label();
            this.itemLocCaptionLabel = new System.Windows.Forms.Label();
            this.itemNameCaptionLabel = new System.Windows.Forms.Label();
            this.partItemsCaptionLabel = new System.Windows.Forms.Label();
            this.partInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.partNumLabel = new System.Windows.Forms.Label();
            this.partLocLabel = new System.Windows.Forms.Label();
            this.itemsCountLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.partItemsPanel.SuspendLayout();
            this.itemsContent.SuspendLayout();
            this.itemHeaderTable.SuspendLayout();
            this.partInfoTable.SuspendLayout();
            // 
            // partPanel
            // 
            this.AutoSize = true;
            this.Controls.Add(this.partItemsPanel);
            this.Controls.Add(this.partInfoTable);
            this.Location = new System.Drawing.Point(0, 32);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "partPanel";
            this.Size = new System.Drawing.Size(446, 139);
            this.TabIndex = 0;
            // 
            // partItemsPanel
            // 
            this.partItemsPanel.AutoSize = true;
            this.partItemsPanel.Controls.Add(this.itemsContent);
            this.partItemsPanel.Controls.Add(this.partItemsCaptionLabel);
            this.partItemsPanel.Location = new System.Drawing.Point(0, 26);
            this.partItemsPanel.Name = "partItemsPanel";
            this.partItemsPanel.Size = new System.Drawing.Size(443, 101);
            this.partItemsPanel.TabIndex = 1;
            this.partItemsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partItemsPanel.Margin = new System.Windows.Forms.Padding(0);
            // 
            // partInfoTable
            // 
            this.partInfoTable.BackColor = System.Drawing.SystemColors.Info;
            this.partInfoTable.ColumnCount = 4;
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.partInfoTable.Controls.Add(this.partNumLabel, 0, 0);
            this.partInfoTable.Controls.Add(this.partLocLabel, 1, 0);
            this.partInfoTable.Controls.Add(this.itemsCountLabel, 1, 0);
            this.partInfoTable.Controls.Add(this.partNameLabel, 1, 0);
            this.partInfoTable.Location = new System.Drawing.Point(1, 1);
            this.partInfoTable.Name = "partInfoTable";
            this.partInfoTable.RowCount = 1;
            this.partInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.partInfoTable.Size = new System.Drawing.Size(443, 26);
            this.partInfoTable.TabIndex = 0;
            this.partInfoTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partInfoTable.Margin = new System.Windows.Forms.Padding(0);
            // 
            // itemsContent
            // 
            this.itemsContent.AutoSize = true;
            this.itemsContent.Controls.Add(this.itemHeaderTable);
            this.itemsContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsContent.Location = new System.Drawing.Point(33, 26);
            this.itemsContent.Name = "itemsContent";
            this.itemsContent.Size = new System.Drawing.Size(308, 72);
            this.itemsContent.TabIndex = 2;
            this.itemsContent.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // partItemsCaptionLabel
            // 
            this.partItemsCaptionLabel.AutoSize = true;
            this.partItemsCaptionLabel.BackColor = System.Drawing.SystemColors.Info;
            this.partItemsCaptionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.partItemsCaptionLabel.Location = new System.Drawing.Point(30, 10);
            this.partItemsCaptionLabel.Name = "partItemsCaptionLabel";
            this.partItemsCaptionLabel.Size = new System.Drawing.Size(91, 13);
            this.partItemsCaptionLabel.TabIndex = 0;
            this.partItemsCaptionLabel.Text = "Items de la parte: ";
            this.partItemsCaptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.partNumLabel.Text = "0";
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
            this.partLocLabel.Text = "0";
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
            this.itemsCountLabel.Text = "0";
            this.itemsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.partNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partNameLabel.Location = new System.Drawing.Point(30, 0);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(136, 26);
            this.partNameLabel.TabIndex = 1;
            this.partNameLabel.Text = "";
            this.partNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameLabel.Cursor = Cursors.Hand;
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

            this.ResumeLayout(false);
            this.PerformLayout();
            this.partItemsPanel.ResumeLayout(false);
            this.partItemsPanel.PerformLayout();
            this.itemsContent.ResumeLayout(false);
            this.itemHeaderTable.ResumeLayout(false);
            this.itemHeaderTable.PerformLayout();
            this.partInfoTable.ResumeLayout(false);
            this.partInfoTable.PerformLayout();
            #endregion

            this.partName = partName;
            partNumLabel.Text = partNumCounter.ToString();
            partNum = partNumCounter;
            partNumCounter++;

            partItemsPanel.Visible = false;
            partNameLabel.Click += (x, y) => { partItemsPanel.Visible = !partItemsPanel.Visible; };
        }
        // EndItem: CodePart

        #region declaración UI
        private System.Windows.Forms.Panel partItemsPanel;
        private System.Windows.Forms.TableLayoutPanel partInfoTable;
        private System.Windows.Forms.FlowLayoutPanel itemsContent;
        private System.Windows.Forms.Label partItemsCaptionLabel;
        private System.Windows.Forms.Label partNumLabel;
        private System.Windows.Forms.Label partLocLabel;
        private System.Windows.Forms.Label itemsCountLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TableLayoutPanel itemHeaderTable;
        private System.Windows.Forms.Label itemNumCaptionLabel;
        private System.Windows.Forms.Label itemLocCaptionLabel;
        private System.Windows.Forms.Label itemNameCaptionLabel;
        #endregion
    }
    // EndPart: CodePart

    // BeginPart: CodeItem
    class CodeItem : TableLayoutPanel
    {
        string _itemName = "";
        int _itemLoc = 0;
        
        static int itemNumCounter = 1;

        public int itemNum { get; private set; }
        public string itemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                itemNameLabel.Text = value;
            }
        }
        public int itemLoc
        {
            get { return _itemLoc; }
            set
            {
                _itemLoc = value;
                itemLocLabel.Text = _itemLoc.ToString();
            }
        }

        // BeginItem: CodeItem
        public CodeItem(string itemName)
        {
            #region UI
            this.itemNumLabel = new System.Windows.Forms.Label();
            this.itemLocLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.ColumnCount = 3;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Controls.Add(this.itemNumLabel, 0, 0);
            this.Controls.Add(this.itemLocLabel, 1, 0);
            this.Controls.Add(this.itemNameLabel, 1, 0);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "itemPanel";
            this.RowCount = 1;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Size = new System.Drawing.Size(302, 26);
            this.TabIndex = 2;
            this.itemLocLabel.Margin = new System.Windows.Forms.Padding(0);
            // 
            // itemLocLabel
            // 
            this.itemLocLabel.AutoSize = true;
            this.itemLocLabel.BackColor = System.Drawing.Color.Azure;
            this.itemLocLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLocLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemLocLabel.Location = new System.Drawing.Point(166, 0);
            this.itemLocLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLocLabel.Name = "label1";
            this.itemLocLabel.Size = new System.Drawing.Size(136, 26);
            this.itemLocLabel.TabIndex = 3;
            this.itemLocLabel.Text = "0";
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
            this.itemNameLabel.Name = "label2";
            this.itemNameLabel.Size = new System.Drawing.Size(136, 26);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.itemNumLabel.Text = "0";
            this.itemNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.ResumeLayout(false);
            this.PerformLayout();

            #endregion

            this.itemName = itemName;
            itemNumLabel.Text = itemNumCounter.ToString();
            itemNum = itemNumCounter;
            itemNumCounter++;
        }
        // EndItem: CodeItem

        #region declaración UI
        private System.Windows.Forms.Label itemNumLabel;
        private System.Windows.Forms.Label itemLocLabel;
        private System.Windows.Forms.Label itemNameLabel;
        #endregion
    }
    // EndPart: CodeItem

    // BeginPart: CodeMetrics
    class CodeMetrics
    {
        static readonly Regex matchBeginPart = new Regex(@"^ *// *BeginPart:(.*?)$");
        static readonly Regex matchBeginItem = new Regex(@"^ *// *BeginItem:(.*?)$");
        static readonly Regex matchEndPart = new Regex(@"^ *// *EndPart:(.*?)$");
        static readonly Regex matchEndItem = new Regex(@"^ *// *EndItem:(.*?)$");
        static readonly Regex matchSingleComment = new Regex(@"^ *//.*?$");
        static readonly Regex matchBeginLargeComment = new Regex(@"^ */\*.*$");
        static readonly Regex matchEndLargeComment = new Regex(@"^.*?\*/ *$");

        public List<CodePart> parts = new List<CodePart>();
        public int totalLoc { get; private set; }
        string filePath = "";

        // BeginItem: CodeMetrics
        /// <summary>
        /// Crea la instancia guardardando la ruta del archivo que será usado para calcular la métrica.
        /// </summary>
        /// <param name="filePath">Ruta local del archivo fuente .cs</param>
        public CodeMetrics(string filePath)
        {
            totalLoc = 0;
            this.filePath = filePath;
        }
        // EndItem: CodeMetric

        // BeginItem: CalculateMetrics
        /// <summary>
        /// Calcula el número de partes, items y loc del archivo fuente indicado en el constructor.
        /// </summary>
        public void CalculateMetrics()
        {
            using (StreamReader fileStream = File.OpenText(filePath))
            {
                string line = "";
                CodePart currentPart = null;
                CodeItem currentItem = null;
                bool startedComment = false;

                while ((line = fileStream.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                        continue;

                    if (!startedComment && matchBeginLargeComment.IsMatch(line))
                        startedComment = true;
                    if (startedComment && matchEndLargeComment.IsMatch(line))
                        startedComment = false;

                    if (startedComment)
                        continue;

                    if (currentPart == null && matchBeginPart.IsMatch(line))
                    {
                        currentPart = new CodePart(matchBeginPart.Split(line)[1].Trim());
                    }
                    else if (currentPart != null)
                    {
                        if (matchEndPart.IsMatch(line))
                        {
                            parts.Add(currentPart);
                            currentPart = null;
                        }
                        else if (matchBeginItem.IsMatch(line))
                        {
                            currentItem = new CodeItem(matchBeginItem.Split(line)[1].Trim());
                        }
                        else if (currentItem != null)
                        {
                            if (matchEndItem.IsMatch(line))
                            {
                                currentPart.AddItem(currentItem);
                                currentItem = null;
                            }
                            else
                                currentItem.itemLoc++;
                        }

                        if (currentPart != null)
                            currentPart.partLoc++;
                    }

                    if (!matchSingleComment.IsMatch(line))
                        totalLoc++;
                }
            }
        }
        // EndItem: CalculateMetrics
    }
    // EndPart: CodeMetrics
}
