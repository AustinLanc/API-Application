namespace APIApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            searchSubmit = new Button();
            qcRouteOption = new RadioButton();
            searchBatchInput = new TextBox();
            routeInput = new GroupBox();
            retainsRouteOption = new RadioButton();
            testingRouteOption = new RadioButton();
            searchBatchLabel = new Label();
            searchResultsLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            searchOutput = new RichTextBox();
            qcTabs = new TabControl();
            searchTab = new TabPage();
            remindersTab = new TabPage();
            remindersResultsLabel = new Label();
            reminderOutput = new RichTextBox();
            remindersSubmit = new Button();
            remindersBatchLabel = new Label();
            reminderBatchInput = new TextBox();
            testsTab = new TabPage();
            testsResultsLabel = new Label();
            testsOutput = new RichTextBox();
            testsSubmit = new Button();
            testsBatchLabel = new Label();
            testsBatchInput = new TextBox();
            routeInput.SuspendLayout();
            qcTabs.SuspendLayout();
            searchTab.SuspendLayout();
            remindersTab.SuspendLayout();
            testsTab.SuspendLayout();
            SuspendLayout();
            // 
            // searchSubmit
            // 
            searchSubmit.BackColor = SystemColors.ButtonFace;
            searchSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchSubmit.Location = new Point(7, 272);
            searchSubmit.Margin = new Padding(4);
            searchSubmit.Name = "searchSubmit";
            searchSubmit.Size = new Size(125, 39);
            searchSubmit.TabIndex = 0;
            searchSubmit.Text = "Search";
            searchSubmit.UseVisualStyleBackColor = false;
            searchSubmit.Click += searchSubmit_Click;
            // 
            // qcRouteOption
            // 
            qcRouteOption.AutoSize = true;
            qcRouteOption.Checked = true;
            qcRouteOption.Location = new Point(8, 31);
            qcRouteOption.Margin = new Padding(4);
            qcRouteOption.Name = "qcRouteOption";
            qcRouteOption.Size = new Size(50, 25);
            qcRouteOption.TabIndex = 2;
            qcRouteOption.TabStop = true;
            qcRouteOption.Text = "QC";
            qcRouteOption.UseVisualStyleBackColor = true;
            // 
            // searchBatchInput
            // 
            searchBatchInput.BorderStyle = BorderStyle.FixedSingle;
            searchBatchInput.Location = new Point(6, 39);
            searchBatchInput.Margin = new Padding(4);
            searchBatchInput.MaxLength = 7;
            searchBatchInput.Name = "searchBatchInput";
            searchBatchInput.Size = new Size(125, 29);
            searchBatchInput.TabIndex = 3;
            // 
            // routeInput
            // 
            routeInput.Controls.Add(retainsRouteOption);
            routeInput.Controls.Add(testingRouteOption);
            routeInput.Controls.Add(qcRouteOption);
            routeInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            routeInput.Location = new Point(6, 77);
            routeInput.Margin = new Padding(4);
            routeInput.Name = "routeInput";
            routeInput.Padding = new Padding(4);
            routeInput.Size = new Size(125, 170);
            routeInput.TabIndex = 4;
            routeInput.TabStop = false;
            routeInput.Text = "Type";
            // 
            // retainsRouteOption
            // 
            retainsRouteOption.AutoSize = true;
            retainsRouteOption.Location = new Point(8, 101);
            retainsRouteOption.Margin = new Padding(4);
            retainsRouteOption.Name = "retainsRouteOption";
            retainsRouteOption.Size = new Size(84, 25);
            retainsRouteOption.TabIndex = 4;
            retainsRouteOption.TabStop = true;
            retainsRouteOption.Text = "Retains";
            retainsRouteOption.UseVisualStyleBackColor = true;
            // 
            // testingRouteOption
            // 
            testingRouteOption.AutoSize = true;
            testingRouteOption.Location = new Point(8, 66);
            testingRouteOption.Margin = new Padding(4);
            testingRouteOption.Name = "testingRouteOption";
            testingRouteOption.Size = new Size(83, 25);
            testingRouteOption.TabIndex = 3;
            testingRouteOption.TabStop = true;
            testingRouteOption.Text = "Testing";
            testingRouteOption.UseVisualStyleBackColor = true;
            // 
            // searchBatchLabel
            // 
            searchBatchLabel.AutoSize = true;
            searchBatchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchBatchLabel.Location = new Point(6, 15);
            searchBatchLabel.Margin = new Padding(4, 0, 4, 0);
            searchBatchLabel.Name = "searchBatchLabel";
            searchBatchLabel.Size = new Size(125, 21);
            searchBatchLabel.TabIndex = 5;
            searchBatchLabel.Text = "Batch Number:";
            // 
            // searchResultsLabel
            // 
            searchResultsLabel.AutoSize = true;
            searchResultsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchResultsLabel.Location = new Point(156, 15);
            searchResultsLabel.Margin = new Padding(4, 0, 4, 0);
            searchResultsLabel.Name = "searchResultsLabel";
            searchResultsLabel.Size = new Size(68, 21);
            searchResultsLabel.TabIndex = 6;
            searchResultsLabel.Text = "Results:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // searchOutput
            // 
            searchOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchOutput.BackColor = SystemColors.ControlLightLight;
            searchOutput.BorderStyle = BorderStyle.FixedSingle;
            searchOutput.Location = new Point(156, 40);
            searchOutput.Margin = new Padding(4);
            searchOutput.Name = "searchOutput";
            searchOutput.ReadOnly = true;
            searchOutput.Size = new Size(531, 280);
            searchOutput.TabIndex = 7;
            searchOutput.Text = "";
            // 
            // qcTabs
            // 
            qcTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            qcTabs.Controls.Add(searchTab);
            qcTabs.Controls.Add(remindersTab);
            qcTabs.Controls.Add(testsTab);
            qcTabs.Location = new Point(0, 0);
            qcTabs.Name = "qcTabs";
            qcTabs.SelectedIndex = 0;
            qcTabs.Size = new Size(703, 363);
            qcTabs.TabIndex = 8;
            // 
            // searchTab
            // 
            searchTab.Controls.Add(routeInput);
            searchTab.Controls.Add(searchOutput);
            searchTab.Controls.Add(searchBatchInput);
            searchTab.Controls.Add(searchSubmit);
            searchTab.Controls.Add(searchResultsLabel);
            searchTab.Controls.Add(searchBatchLabel);
            searchTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchTab.Location = new Point(4, 30);
            searchTab.Name = "searchTab";
            searchTab.Padding = new Padding(3);
            searchTab.Size = new Size(695, 329);
            searchTab.TabIndex = 0;
            searchTab.Text = "Search";
            searchTab.UseVisualStyleBackColor = true;
            // 
            // remindersTab
            // 
            remindersTab.Controls.Add(remindersResultsLabel);
            remindersTab.Controls.Add(reminderOutput);
            remindersTab.Controls.Add(remindersSubmit);
            remindersTab.Controls.Add(remindersBatchLabel);
            remindersTab.Controls.Add(reminderBatchInput);
            remindersTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            remindersTab.Location = new Point(4, 24);
            remindersTab.Name = "remindersTab";
            remindersTab.Padding = new Padding(3);
            remindersTab.Size = new Size(695, 335);
            remindersTab.TabIndex = 1;
            remindersTab.Text = "Reminders";
            remindersTab.UseVisualStyleBackColor = true;
            // 
            // remindersResultsLabel
            // 
            remindersResultsLabel.AutoSize = true;
            remindersResultsLabel.Location = new Point(156, 15);
            remindersResultsLabel.Name = "remindersResultsLabel";
            remindersResultsLabel.Size = new Size(68, 21);
            remindersResultsLabel.TabIndex = 4;
            remindersResultsLabel.Text = "Results:";
            // 
            // reminderOutput
            // 
            reminderOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reminderOutput.BackColor = SystemColors.ControlLightLight;
            reminderOutput.BorderStyle = BorderStyle.FixedSingle;
            reminderOutput.Location = new Point(156, 40);
            reminderOutput.Name = "reminderOutput";
            reminderOutput.ReadOnly = true;
            reminderOutput.Size = new Size(531, 275);
            reminderOutput.TabIndex = 3;
            reminderOutput.Text = "";
            // 
            // remindersSubmit
            // 
            remindersSubmit.BackColor = SystemColors.ButtonFace;
            remindersSubmit.Location = new Point(6, 74);
            remindersSubmit.Name = "remindersSubmit";
            remindersSubmit.Size = new Size(125, 38);
            remindersSubmit.TabIndex = 2;
            remindersSubmit.Text = "Search";
            remindersSubmit.UseVisualStyleBackColor = false;
            remindersSubmit.Click += remindersSubmit_Click;
            // 
            // remindersBatchLabel
            // 
            remindersBatchLabel.AutoSize = true;
            remindersBatchLabel.Location = new Point(6, 15);
            remindersBatchLabel.Name = "remindersBatchLabel";
            remindersBatchLabel.Size = new Size(125, 21);
            remindersBatchLabel.TabIndex = 1;
            remindersBatchLabel.Text = "Batch Number:";
            // 
            // reminderBatchInput
            // 
            reminderBatchInput.BorderStyle = BorderStyle.FixedSingle;
            reminderBatchInput.Location = new Point(6, 39);
            reminderBatchInput.Name = "reminderBatchInput";
            reminderBatchInput.Size = new Size(125, 29);
            reminderBatchInput.TabIndex = 0;
            // 
            // testsTab
            // 
            testsTab.Controls.Add(testsResultsLabel);
            testsTab.Controls.Add(testsOutput);
            testsTab.Controls.Add(testsSubmit);
            testsTab.Controls.Add(testsBatchLabel);
            testsTab.Controls.Add(testsBatchInput);
            testsTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            testsTab.Location = new Point(4, 24);
            testsTab.Name = "testsTab";
            testsTab.Padding = new Padding(3);
            testsTab.Size = new Size(695, 335);
            testsTab.TabIndex = 2;
            testsTab.Text = "Active Tests";
            testsTab.UseVisualStyleBackColor = true;
            // 
            // testsResultsLabel
            // 
            testsResultsLabel.AutoSize = true;
            testsResultsLabel.Location = new Point(156, 15);
            testsResultsLabel.Name = "testsResultsLabel";
            testsResultsLabel.Size = new Size(68, 21);
            testsResultsLabel.TabIndex = 4;
            testsResultsLabel.Text = "Results:";
            // 
            // testsOutput
            // 
            testsOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            testsOutput.BackColor = SystemColors.ControlLightLight;
            testsOutput.BorderStyle = BorderStyle.FixedSingle;
            testsOutput.Location = new Point(156, 40);
            testsOutput.Name = "testsOutput";
            testsOutput.ReadOnly = true;
            testsOutput.Size = new Size(531, 263);
            testsOutput.TabIndex = 3;
            testsOutput.Text = "";
            // 
            // testsSubmit
            // 
            testsSubmit.BackColor = SystemColors.ButtonFace;
            testsSubmit.Location = new Point(6, 74);
            testsSubmit.Name = "testsSubmit";
            testsSubmit.Size = new Size(125, 38);
            testsSubmit.TabIndex = 2;
            testsSubmit.Text = "Search";
            testsSubmit.UseVisualStyleBackColor = false;
            testsSubmit.Click += testsSubmit_Click;
            // 
            // testsBatchLabel
            // 
            testsBatchLabel.AutoSize = true;
            testsBatchLabel.Location = new Point(6, 15);
            testsBatchLabel.Name = "testsBatchLabel";
            testsBatchLabel.Size = new Size(125, 21);
            testsBatchLabel.TabIndex = 1;
            testsBatchLabel.Text = "Batch Number:";
            // 
            // testsBatchInput
            // 
            testsBatchInput.BorderStyle = BorderStyle.FixedSingle;
            testsBatchInput.Location = new Point(6, 39);
            testsBatchInput.Name = "testsBatchInput";
            testsBatchInput.Size = new Size(125, 29);
            testsBatchInput.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(703, 363);
            Controls.Add(qcTabs);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            routeInput.ResumeLayout(false);
            routeInput.PerformLayout();
            qcTabs.ResumeLayout(false);
            searchTab.ResumeLayout(false);
            searchTab.PerformLayout();
            remindersTab.ResumeLayout(false);
            remindersTab.PerformLayout();
            testsTab.ResumeLayout(false);
            testsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button searchSubmit;
        private RadioButton qcRouteOption;
        private TextBox searchBatchInput;
        private GroupBox routeInput;
        private RadioButton testingRouteOption;
        private Label searchBatchLabel;
        private Label searchResultsLabel;
        private ContextMenuStrip contextMenuStrip1;
        private RadioButton retainsRouteOption;
        private RichTextBox searchOutput;
        private TabControl qcTabs;
        private TabPage searchTab;
        private TabPage remindersTab;
        private Label remindersBatchLabel;
        private TextBox reminderBatchInput;
        private Button remindersSubmit;
        private RichTextBox reminderOutput;
        private Label remindersResultsLabel;
        private TabPage testsTab;
        private Label testsResultsLabel;
        private RichTextBox testsOutput;
        private Button testsSubmit;
        private Label testsBatchLabel;
        private TextBox testsBatchInput;
    }
}
