namespace Audiences
{
    partial class MainWindow
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
            this.audiencesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.audienceList = new System.Windows.Forms.ListBox();
            this.audienceDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.audienceDetailsLabel = new System.Windows.Forms.Label();
            this.rulesView = new System.Windows.Forms.ListView();
            this.left = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.op = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.right = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveRulesButton = new System.Windows.Forms.Button();
            this.removeRulesButton = new System.Windows.Forms.Button();
            this.URLFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.audiencesSplitContainer.Panel1.SuspendLayout();
            this.audiencesSplitContainer.Panel2.SuspendLayout();
            this.audiencesSplitContainer.SuspendLayout();
            this.audienceDetailsTable.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.URLFlowLayoutPanel.SuspendLayout();
            this.rootTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // audiencesSplitContainer
            // 
            this.audiencesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audiencesSplitContainer.Location = new System.Drawing.Point(3, 38);
            this.audiencesSplitContainer.Name = "audiencesSplitContainer";
            // 
            // audiencesSplitContainer.Panel1
            // 
            this.audiencesSplitContainer.Panel1.Controls.Add(this.audienceList);
            // 
            // audiencesSplitContainer.Panel2
            // 
            this.audiencesSplitContainer.Panel2.Controls.Add(this.audienceDetailsTable);
            this.audiencesSplitContainer.Size = new System.Drawing.Size(753, 388);
            this.audiencesSplitContainer.SplitterDistance = 251;
            this.audiencesSplitContainer.TabIndex = 0;
            // 
            // audienceList
            // 
            this.audienceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audienceList.FormattingEnabled = true;
            this.audienceList.Location = new System.Drawing.Point(0, 0);
            this.audienceList.Name = "audienceList";
            this.audienceList.Size = new System.Drawing.Size(251, 388);
            this.audienceList.TabIndex = 0;
            this.audienceList.SelectedIndexChanged += new System.EventHandler(this.audienceList_SelectedIndexChanged);
            // 
            // audienceDetailsTable
            // 
            this.audienceDetailsTable.ColumnCount = 1;
            this.audienceDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.audienceDetailsTable.Controls.Add(this.audienceDetailsLabel, 0, 0);
            this.audienceDetailsTable.Controls.Add(this.rulesView, 0, 2);
            this.audienceDetailsTable.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.audienceDetailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audienceDetailsTable.Location = new System.Drawing.Point(0, 0);
            this.audienceDetailsTable.Name = "audienceDetailsTable";
            this.audienceDetailsTable.RowCount = 3;
            this.audienceDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.audienceDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.audienceDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.audienceDetailsTable.Size = new System.Drawing.Size(498, 388);
            this.audienceDetailsTable.TabIndex = 0;
            // 
            // audienceDetailsLabel
            // 
            this.audienceDetailsLabel.AutoSize = true;
            this.audienceDetailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audienceDetailsLabel.Location = new System.Drawing.Point(3, 0);
            this.audienceDetailsLabel.Name = "audienceDetailsLabel";
            this.audienceDetailsLabel.Size = new System.Drawing.Size(492, 100);
            this.audienceDetailsLabel.TabIndex = 0;
            // 
            // rulesView
            // 
            this.rulesView.CheckBoxes = true;
            this.rulesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.left,
            this.op,
            this.right});
            this.rulesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesView.FullRowSelect = true;
            this.rulesView.GridLines = true;
            this.rulesView.Location = new System.Drawing.Point(3, 133);
            this.rulesView.Name = "rulesView";
            this.rulesView.ShowGroups = false;
            this.rulesView.Size = new System.Drawing.Size(492, 252);
            this.rulesView.TabIndex = 1;
            this.rulesView.UseCompatibleStateImageBehavior = false;
            this.rulesView.View = System.Windows.Forms.View.Details;
            this.rulesView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.rulesView_ItemChecked);
            // 
            // left
            // 
            this.left.Text = "Left content";
            this.left.Width = 107;
            // 
            // op
            // 
            this.op.Text = "Operator";
            this.op.Width = 114;
            // 
            // right
            // 
            this.right.Text = "Right content";
            this.right.Width = 243;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saveRulesButton);
            this.flowLayoutPanel1.Controls.Add(this.removeRulesButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(498, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // saveRulesButton
            // 
            this.saveRulesButton.Enabled = false;
            this.saveRulesButton.Location = new System.Drawing.Point(3, 3);
            this.saveRulesButton.Name = "saveRulesButton";
            this.saveRulesButton.Size = new System.Drawing.Size(75, 23);
            this.saveRulesButton.TabIndex = 1;
            this.saveRulesButton.Text = "Save rules";
            this.saveRulesButton.UseVisualStyleBackColor = true;
            this.saveRulesButton.Click += new System.EventHandler(this.saveRulesButton_Click);
            // 
            // removeRulesButton
            // 
            this.removeRulesButton.Enabled = false;
            this.removeRulesButton.Location = new System.Drawing.Point(84, 3);
            this.removeRulesButton.Name = "removeRulesButton";
            this.removeRulesButton.Size = new System.Drawing.Size(90, 23);
            this.removeRulesButton.TabIndex = 0;
            this.removeRulesButton.Text = "Remove rule(s)";
            this.removeRulesButton.UseVisualStyleBackColor = true;
            this.removeRulesButton.Click += new System.EventHandler(this.removeRulesButton_Click);
            // 
            // URLFlowLayoutPanel
            // 
            this.URLFlowLayoutPanel.Controls.Add(this.label1);
            this.URLFlowLayoutPanel.Controls.Add(this.URLBox);
            this.URLFlowLayoutPanel.Controls.Add(this.loadButton);
            this.URLFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URLFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.URLFlowLayoutPanel.Name = "URLFlowLayoutPanel";
            this.URLFlowLayoutPanel.Size = new System.Drawing.Size(753, 29);
            this.URLFlowLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // URLBox
            // 
            this.URLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLBox.Location = new System.Drawing.Point(44, 3);
            this.URLBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(575, 23);
            this.URLBox.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(625, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(122, 25);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Audiences";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 1;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootTable.Controls.Add(this.audiencesSplitContainer, 0, 1);
            this.rootTable.Controls.Add(this.URLFlowLayoutPanel, 0, 0);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 2;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Size = new System.Drawing.Size(759, 429);
            this.rootTable.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 429);
            this.Controls.Add(this.rootTable);
            this.Name = "MainWindow";
            this.Text = "Audience editor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.audiencesSplitContainer.Panel1.ResumeLayout(false);
            this.audiencesSplitContainer.Panel2.ResumeLayout(false);
            this.audiencesSplitContainer.ResumeLayout(false);
            this.audienceDetailsTable.ResumeLayout(false);
            this.audienceDetailsTable.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.URLFlowLayoutPanel.ResumeLayout(false);
            this.URLFlowLayoutPanel.PerformLayout();
            this.rootTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer audiencesSplitContainer;
        private System.Windows.Forms.ListBox audienceList;
        private System.Windows.Forms.FlowLayoutPanel URLFlowLayoutPanel;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.TableLayoutPanel audienceDetailsTable;
        private System.Windows.Forms.Label audienceDetailsLabel;
        private System.Windows.Forms.ListView rulesView;
        private System.Windows.Forms.ColumnHeader left;
        private System.Windows.Forms.ColumnHeader op;
        private System.Windows.Forms.ColumnHeader right;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button removeRulesButton;
        private System.Windows.Forms.Button saveRulesButton;
        private System.Windows.Forms.Label label1;
    }
}