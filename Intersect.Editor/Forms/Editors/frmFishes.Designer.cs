using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmFishes
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFishes));
            btnCancel = new DarkButton();
            btnSave = new DarkButton();
            grpFishes = new DarkGroupBox();
            btnClearSearch = new DarkButton();
            txtSearch = new DarkTextBox();
            lstGameObjects = new Controls.GameObjectList();
            pnlContainer = new Panel();
            grpGeneral = new DarkGroupBox();
            lblName = new Label();
            txtName = new DarkTextBox();
            picFish = new PictureBox();
            cmbEvent = new DarkComboBox();
            btnAddFolder = new DarkButton();
            lblCommonEvent = new Label();
            lblFolder = new Label();
            cmbFolder = new DarkComboBox();
            nudChance = new DarkNumericUpDown();
            cmbFishItem = new DarkComboBox();
            lblFishItem = new Label();
            lblChance = new Label();
            grpParameters = new DarkGroupBox();
            nudTimeChangeRangeSize = new DarkNumericUpDown();
            lblTimeChangeRangeSize = new Label();
            nudTimeChangeSpeed = new DarkNumericUpDown();
            lblTimeChangeSpeed = new Label();
            nudCoeffUnpredictability = new DarkNumericUpDown();
            lblCoeffUnpredictability = new Label();
            nudSpeedResize = new DarkNumericUpDown();
            lblSpeedResize = new Label();
            nudSpeedMove = new DarkNumericUpDown();
            lblSpeedMove = new Label();
            nudRangeSize = new DarkNumericUpDown();
            lblRangeSize = new Label();
            nudPosition = new DarkNumericUpDown();
            lblPosition = new Label();
            nudStrength = new DarkNumericUpDown();
            lblStrength = new Label();
            nudPushStrength = new DarkNumericUpDown();
            lblPushStrength = new Label();
            nudWeight = new DarkNumericUpDown();
            lblWeight = new DarkLabel();
            toolStrip = new DarkToolStrip();
            toolStripItemNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripItemDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAlphabetical = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripItemCopy = new ToolStripButton();
            toolStripItemPaste = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripItemUndo = new ToolStripButton();
            btnFishRequirements = new DarkButton();
            grpFishes.SuspendLayout();
            pnlContainer.SuspendLayout();
            grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChance).BeginInit();
            grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTimeChangeRangeSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeChangeSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoeffUnpredictability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeedResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeedMove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRangeSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPushStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(719, 487);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6);
            btnCancel.Size = new Size(201, 31);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(514, 487);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6);
            btnSave.Size = new Size(197, 31);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // grpFishes
            // 
            grpFishes.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpFishes.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpFishes.Controls.Add(btnClearSearch);
            grpFishes.Controls.Add(txtSearch);
            grpFishes.Controls.Add(lstGameObjects);
            grpFishes.ForeColor = System.Drawing.Color.Gainsboro;
            grpFishes.Location = new System.Drawing.Point(14, 42);
            grpFishes.Margin = new Padding(4, 3, 4, 3);
            grpFishes.Name = "grpFishes";
            grpFishes.Padding = new Padding(4, 3, 4, 3);
            grpFishes.Size = new Size(237, 435);
            grpFishes.TabIndex = 22;
            grpFishes.TabStop = false;
            grpFishes.Text = "Fishes";
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new System.Drawing.Point(209, 15);
            btnClearSearch.Margin = new Padding(4, 3, 4, 3);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Padding = new Padding(6);
            btnClearSearch.Size = new Size(21, 23);
            btnClearSearch.TabIndex = 28;
            btnClearSearch.Text = "X";
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtSearch.Location = new System.Drawing.Point(7, 15);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "Search...";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // lstGameObjects
            // 
            lstGameObjects.AllowDrop = true;
            lstGameObjects.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstGameObjects.BorderStyle = BorderStyle.None;
            lstGameObjects.ForeColor = System.Drawing.Color.Gainsboro;
            lstGameObjects.HideSelection = false;
            lstGameObjects.ImageIndex = 0;
            lstGameObjects.LineColor = System.Drawing.Color.FromArgb(150, 150, 150);
            lstGameObjects.Location = new System.Drawing.Point(7, 45);
            lstGameObjects.Margin = new Padding(4, 3, 4, 3);
            lstGameObjects.Name = "lstGameObjects";
            lstGameObjects.SelectedImageIndex = 0;
            lstGameObjects.Size = new Size(223, 377);
            lstGameObjects.TabIndex = 26;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(grpGeneral);
            pnlContainer.Controls.Add(grpParameters);
            pnlContainer.Location = new System.Drawing.Point(258, 42);
            pnlContainer.Margin = new Padding(4, 3, 4, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(662, 435);
            pnlContainer.TabIndex = 31;
            pnlContainer.Visible = false;
            // 
            // grpGeneral
            // 
            grpGeneral.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpGeneral.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpGeneral.Controls.Add(btnFishRequirements);
            grpGeneral.Controls.Add(lblName);
            grpGeneral.Controls.Add(txtName);
            grpGeneral.Controls.Add(picFish);
            grpGeneral.Controls.Add(cmbEvent);
            grpGeneral.Controls.Add(btnAddFolder);
            grpGeneral.Controls.Add(lblCommonEvent);
            grpGeneral.Controls.Add(lblFolder);
            grpGeneral.Controls.Add(cmbFolder);
            grpGeneral.Controls.Add(nudChance);
            grpGeneral.Controls.Add(cmbFishItem);
            grpGeneral.Controls.Add(lblFishItem);
            grpGeneral.Controls.Add(lblChance);
            grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            grpGeneral.Location = new System.Drawing.Point(6, 5);
            grpGeneral.Margin = new Padding(4, 3, 4, 3);
            grpGeneral.Name = "grpGeneral";
            grpGeneral.Padding = new Padding(4, 3, 4, 3);
            grpGeneral.Size = new Size(318, 418);
            grpGeneral.TabIndex = 31;
            grpGeneral.TabStop = false;
            grpGeneral.Text = "General";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(8, 25);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 49;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtName.Location = new System.Drawing.Point(116, 25);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 23);
            txtName.TabIndex = 48;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // picFish
            // 
            picFish.BackColor = System.Drawing.Color.Black;
            picFish.Location = new System.Drawing.Point(200, 198);
            picFish.Margin = new Padding(4, 3, 4, 3);
            picFish.Name = "picFish";
            picFish.Size = new Size(107, 106);
            picFish.TabIndex = 47;
            picFish.TabStop = false;
            // 
            // cmbEvent
            // 
            cmbEvent.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbEvent.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbEvent.BorderStyle = ButtonBorderStyle.Solid;
            cmbEvent.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbEvent.DrawDropdownHoverOutline = false;
            cmbEvent.DrawFocusRectangle = false;
            cmbEvent.DrawMode = DrawMode.OwnerDrawFixed;
            cmbEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvent.FlatStyle = FlatStyle.Flat;
            cmbEvent.ForeColor = System.Drawing.Color.Gainsboro;
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Location = new System.Drawing.Point(145, 128);
            cmbEvent.Margin = new Padding(4, 3, 4, 3);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(162, 24);
            cmbEvent.TabIndex = 43;
            cmbEvent.Text = null;
            cmbEvent.TextPadding = new Padding(2);
            cmbEvent.SelectedIndexChanged += cmbEvent_SelectedIndexChanged;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new System.Drawing.Point(286, 58);
            btnAddFolder.Margin = new Padding(4, 3, 4, 3);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Padding = new Padding(6);
            btnAddFolder.Size = new Size(21, 24);
            btnAddFolder.TabIndex = 46;
            btnAddFolder.Text = "+";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // lblCommonEvent
            // 
            lblCommonEvent.AutoSize = true;
            lblCommonEvent.Location = new System.Drawing.Point(8, 130);
            lblCommonEvent.Margin = new Padding(4, 0, 4, 0);
            lblCommonEvent.Name = "lblCommonEvent";
            lblCommonEvent.Size = new Size(93, 15);
            lblCommonEvent.TabIndex = 42;
            lblCommonEvent.Text = "Common Event:";
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new System.Drawing.Point(8, 60);
            lblFolder.Margin = new Padding(4, 0, 4, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 45;
            lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            cmbFolder.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbFolder.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbFolder.BorderStyle = ButtonBorderStyle.Solid;
            cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbFolder.DrawDropdownHoverOutline = false;
            cmbFolder.DrawFocusRectangle = false;
            cmbFolder.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolder.FlatStyle = FlatStyle.Flat;
            cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            cmbFolder.FormattingEnabled = true;
            cmbFolder.Location = new System.Drawing.Point(116, 58);
            cmbFolder.Margin = new Padding(4, 3, 4, 3);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(162, 24);
            cmbFolder.TabIndex = 44;
            cmbFolder.Text = null;
            cmbFolder.TextPadding = new Padding(2);
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // nudChance
            // 
            nudChance.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudChance.ForeColor = System.Drawing.Color.Gainsboro;
            nudChance.Location = new System.Drawing.Point(116, 165);
            nudChance.Margin = new Padding(4, 3, 4, 3);
            nudChance.Name = "nudChance";
            nudChance.Size = new Size(191, 23);
            nudChance.TabIndex = 35;
            nudChance.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudChance.ValueChanged += ChangeValues;
            // 
            // cmbFishItem
            // 
            cmbFishItem.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbFishItem.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbFishItem.BorderStyle = ButtonBorderStyle.Solid;
            cmbFishItem.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbFishItem.DrawDropdownHoverOutline = false;
            cmbFishItem.DrawFocusRectangle = false;
            cmbFishItem.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFishItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFishItem.FlatStyle = FlatStyle.Flat;
            cmbFishItem.ForeColor = System.Drawing.Color.Gainsboro;
            cmbFishItem.FormattingEnabled = true;
            cmbFishItem.Location = new System.Drawing.Point(116, 93);
            cmbFishItem.Margin = new Padding(4, 3, 4, 3);
            cmbFishItem.Name = "cmbFishItem";
            cmbFishItem.Size = new Size(191, 24);
            cmbFishItem.TabIndex = 34;
            cmbFishItem.Text = null;
            cmbFishItem.TextPadding = new Padding(2);
            cmbFishItem.SelectedIndexChanged += cmbResult_SelectedIndexChanged;
            // 
            // lblFishItem
            // 
            lblFishItem.AutoSize = true;
            lblFishItem.Location = new System.Drawing.Point(8, 95);
            lblFishItem.Margin = new Padding(4, 0, 4, 0);
            lblFishItem.Name = "lblFishItem";
            lblFishItem.Size = new Size(34, 15);
            lblFishItem.TabIndex = 33;
            lblFishItem.Text = "Item:";
            // 
            // lblChance
            // 
            lblChance.AutoSize = true;
            lblChance.Location = new System.Drawing.Point(8, 165);
            lblChance.Margin = new Padding(4, 0, 4, 0);
            lblChance.Name = "lblChance";
            lblChance.Size = new Size(68, 15);
            lblChance.TabIndex = 3;
            lblChance.Text = "Chance (%)";
            // 
            // grpParameters
            // 
            grpParameters.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpParameters.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpParameters.Controls.Add(nudTimeChangeRangeSize);
            grpParameters.Controls.Add(lblTimeChangeRangeSize);
            grpParameters.Controls.Add(nudTimeChangeSpeed);
            grpParameters.Controls.Add(lblTimeChangeSpeed);
            grpParameters.Controls.Add(nudCoeffUnpredictability);
            grpParameters.Controls.Add(lblCoeffUnpredictability);
            grpParameters.Controls.Add(nudSpeedResize);
            grpParameters.Controls.Add(lblSpeedResize);
            grpParameters.Controls.Add(nudSpeedMove);
            grpParameters.Controls.Add(lblSpeedMove);
            grpParameters.Controls.Add(nudRangeSize);
            grpParameters.Controls.Add(lblRangeSize);
            grpParameters.Controls.Add(nudPosition);
            grpParameters.Controls.Add(lblPosition);
            grpParameters.Controls.Add(nudStrength);
            grpParameters.Controls.Add(lblStrength);
            grpParameters.Controls.Add(nudPushStrength);
            grpParameters.Controls.Add(lblPushStrength);
            grpParameters.Controls.Add(nudWeight);
            grpParameters.Controls.Add(lblWeight);
            grpParameters.ForeColor = System.Drawing.Color.Gainsboro;
            grpParameters.Location = new System.Drawing.Point(331, 3);
            grpParameters.Margin = new Padding(4, 3, 4, 3);
            grpParameters.Name = "grpParameters";
            grpParameters.Padding = new Padding(4, 3, 4, 3);
            grpParameters.Size = new Size(318, 419);
            grpParameters.TabIndex = 30;
            grpParameters.TabStop = false;
            grpParameters.Text = "Parameters";
            // 
            // nudTimeChangeRangeSize
            // 
            nudTimeChangeRangeSize.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudTimeChangeRangeSize.ForeColor = System.Drawing.Color.Gainsboro;
            nudTimeChangeRangeSize.Location = new System.Drawing.Point(190, 340);
            nudTimeChangeRangeSize.Margin = new Padding(4, 3, 4, 3);
            nudTimeChangeRangeSize.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudTimeChangeRangeSize.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudTimeChangeRangeSize.Name = "nudTimeChangeRangeSize";
            nudTimeChangeRangeSize.Size = new Size(120, 23);
            nudTimeChangeRangeSize.TabIndex = 66;
            nudTimeChangeRangeSize.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            nudTimeChangeRangeSize.ValueChanged += ChangeValues;
            // 
            // lblTimeChangeRangeSize
            // 
            lblTimeChangeRangeSize.AutoSize = true;
            lblTimeChangeRangeSize.Location = new System.Drawing.Point(16, 342);
            lblTimeChangeRangeSize.Margin = new Padding(4, 0, 4, 0);
            lblTimeChangeRangeSize.Name = "lblTimeChangeRangeSize";
            lblTimeChangeRangeSize.Size = new Size(144, 15);
            lblTimeChangeRangeSize.TabIndex = 65;
            lblTimeChangeRangeSize.Text = "Timer Change Resize (MS)";
            // 
            // nudTimeChangeSpeed
            // 
            nudTimeChangeSpeed.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudTimeChangeSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            nudTimeChangeSpeed.Location = new System.Drawing.Point(190, 305);
            nudTimeChangeSpeed.Margin = new Padding(4, 3, 4, 3);
            nudTimeChangeSpeed.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudTimeChangeSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudTimeChangeSpeed.Name = "nudTimeChangeSpeed";
            nudTimeChangeSpeed.Size = new Size(120, 23);
            nudTimeChangeSpeed.TabIndex = 64;
            nudTimeChangeSpeed.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nudTimeChangeSpeed.ValueChanged += ChangeValues;
            // 
            // lblTimeChangeSpeed
            // 
            lblTimeChangeSpeed.AutoSize = true;
            lblTimeChangeSpeed.Location = new System.Drawing.Point(16, 307);
            lblTimeChangeSpeed.Margin = new Padding(4, 0, 4, 0);
            lblTimeChangeSpeed.Name = "lblTimeChangeSpeed";
            lblTimeChangeSpeed.Size = new Size(144, 15);
            lblTimeChangeSpeed.TabIndex = 63;
            lblTimeChangeSpeed.Text = "Timer Change Speed (MS)";
            // 
            // nudCoeffUnpredictability
            // 
            nudCoeffUnpredictability.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudCoeffUnpredictability.ForeColor = System.Drawing.Color.Gainsboro;
            nudCoeffUnpredictability.Location = new System.Drawing.Point(190, 270);
            nudCoeffUnpredictability.Margin = new Padding(4, 3, 4, 3);
            nudCoeffUnpredictability.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudCoeffUnpredictability.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudCoeffUnpredictability.Name = "nudCoeffUnpredictability";
            nudCoeffUnpredictability.Size = new Size(120, 23);
            nudCoeffUnpredictability.TabIndex = 62;
            nudCoeffUnpredictability.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudCoeffUnpredictability.ValueChanged += ChangeValues;
            // 
            // lblCoeffUnpredictability
            // 
            lblCoeffUnpredictability.AutoSize = true;
            lblCoeffUnpredictability.Location = new System.Drawing.Point(16, 272);
            lblCoeffUnpredictability.Margin = new Padding(4, 0, 4, 0);
            lblCoeffUnpredictability.Name = "lblCoeffUnpredictability";
            lblCoeffUnpredictability.Size = new Size(144, 15);
            lblCoeffUnpredictability.TabIndex = 61;
            lblCoeffUnpredictability.Text = "Coeff Unpredictability (%)";
            // 
            // nudSpeedResize
            // 
            nudSpeedResize.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudSpeedResize.ForeColor = System.Drawing.Color.Gainsboro;
            nudSpeedResize.Location = new System.Drawing.Point(148, 235);
            nudSpeedResize.Margin = new Padding(4, 3, 4, 3);
            nudSpeedResize.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudSpeedResize.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudSpeedResize.Name = "nudSpeedResize";
            nudSpeedResize.Size = new Size(162, 23);
            nudSpeedResize.TabIndex = 60;
            nudSpeedResize.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudSpeedResize.ValueChanged += ChangeValues;
            // 
            // lblSpeedResize
            // 
            lblSpeedResize.AutoSize = true;
            lblSpeedResize.Location = new System.Drawing.Point(16, 237);
            lblSpeedResize.Margin = new Padding(4, 0, 4, 0);
            lblSpeedResize.Name = "lblSpeedResize";
            lblSpeedResize.Size = new Size(74, 15);
            lblSpeedResize.TabIndex = 59;
            lblSpeedResize.Text = "Speed Resize";
            // 
            // nudSpeedMove
            // 
            nudSpeedMove.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudSpeedMove.ForeColor = System.Drawing.Color.Gainsboro;
            nudSpeedMove.Location = new System.Drawing.Point(148, 200);
            nudSpeedMove.Margin = new Padding(4, 3, 4, 3);
            nudSpeedMove.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudSpeedMove.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudSpeedMove.Name = "nudSpeedMove";
            nudSpeedMove.Size = new Size(162, 23);
            nudSpeedMove.TabIndex = 58;
            nudSpeedMove.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudSpeedMove.ValueChanged += ChangeValues;
            // 
            // lblSpeedMove
            // 
            lblSpeedMove.AutoSize = true;
            lblSpeedMove.Location = new System.Drawing.Point(16, 202);
            lblSpeedMove.Margin = new Padding(4, 0, 4, 0);
            lblSpeedMove.Name = "lblSpeedMove";
            lblSpeedMove.Size = new Size(72, 15);
            lblSpeedMove.TabIndex = 57;
            lblSpeedMove.Text = "Speed Move";
            // 
            // nudRangeSize
            // 
            nudRangeSize.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudRangeSize.ForeColor = System.Drawing.Color.Gainsboro;
            nudRangeSize.Location = new System.Drawing.Point(148, 165);
            nudRangeSize.Margin = new Padding(4, 3, 4, 3);
            nudRangeSize.Name = "nudRangeSize";
            nudRangeSize.Size = new Size(162, 23);
            nudRangeSize.TabIndex = 56;
            nudRangeSize.Value = new decimal(new int[] { 30, 0, 0, 0 });
            nudRangeSize.ValueChanged += ChangeValues;
            // 
            // lblRangeSize
            // 
            lblRangeSize.AutoSize = true;
            lblRangeSize.Location = new System.Drawing.Point(16, 167);
            lblRangeSize.Margin = new Padding(4, 0, 4, 0);
            lblRangeSize.Name = "lblRangeSize";
            lblRangeSize.Size = new Size(63, 15);
            lblRangeSize.TabIndex = 55;
            lblRangeSize.Text = "Range Size";
            // 
            // nudPosition
            // 
            nudPosition.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudPosition.ForeColor = System.Drawing.Color.Gainsboro;
            nudPosition.Location = new System.Drawing.Point(148, 130);
            nudPosition.Margin = new Padding(4, 3, 4, 3);
            nudPosition.Name = "nudPosition";
            nudPosition.Size = new Size(162, 23);
            nudPosition.TabIndex = 54;
            nudPosition.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudPosition.ValueChanged += ChangeValues;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new System.Drawing.Point(16, 132);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 53;
            lblPosition.Text = "Position";
            // 
            // nudStrength
            // 
            nudStrength.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudStrength.ForeColor = System.Drawing.Color.Gainsboro;
            nudStrength.Location = new System.Drawing.Point(148, 95);
            nudStrength.Margin = new Padding(4, 3, 4, 3);
            nudStrength.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudStrength.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudStrength.Name = "nudStrength";
            nudStrength.Size = new Size(162, 23);
            nudStrength.TabIndex = 52;
            nudStrength.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudStrength.ValueChanged += ChangeValues;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new System.Drawing.Point(16, 97);
            lblStrength.Margin = new Padding(4, 0, 4, 0);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(52, 15);
            lblStrength.TabIndex = 51;
            lblStrength.Text = "Strength";
            // 
            // nudPushStrength
            // 
            nudPushStrength.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudPushStrength.ForeColor = System.Drawing.Color.Gainsboro;
            nudPushStrength.Location = new System.Drawing.Point(148, 60);
            nudPushStrength.Margin = new Padding(4, 3, 4, 3);
            nudPushStrength.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudPushStrength.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudPushStrength.Name = "nudPushStrength";
            nudPushStrength.Size = new Size(162, 23);
            nudPushStrength.TabIndex = 50;
            nudPushStrength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudPushStrength.ValueChanged += ChangeValues;
            // 
            // lblPushStrength
            // 
            lblPushStrength.AutoSize = true;
            lblPushStrength.Location = new System.Drawing.Point(16, 62);
            lblPushStrength.Margin = new Padding(4, 0, 4, 0);
            lblPushStrength.Name = "lblPushStrength";
            lblPushStrength.Size = new Size(81, 15);
            lblPushStrength.TabIndex = 49;
            lblPushStrength.Text = "Push Strength";
            // 
            // nudWeight
            // 
            nudWeight.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudWeight.ForeColor = System.Drawing.Color.Gainsboro;
            nudWeight.Location = new System.Drawing.Point(148, 25);
            nudWeight.Margin = new Padding(4, 3, 4, 3);
            nudWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(162, 23);
            nudWeight.TabIndex = 48;
            nudWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudWeight.ValueChanged += ChangeValues;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lblWeight.Location = new System.Drawing.Point(16, 27);
            lblWeight.Margin = new Padding(4, 0, 4, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 15);
            lblWeight.TabIndex = 47;
            lblWeight.Tag = "";
            lblWeight.Text = "Weight";
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            toolStrip.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripItemNew, toolStripSeparator1, toolStripItemDelete, toolStripSeparator2, btnAlphabetical, toolStripSeparator4, toolStripItemCopy, toolStripItemPaste, toolStripSeparator3, toolStripItemUndo });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(6, 0, 1, 0);
            toolStrip.Size = new Size(932, 29);
            toolStrip.TabIndex = 43;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            toolStripItemNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemNew.Image = (Image)resources.GetObject("toolStripItemNew.Image");
            toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemNew.Name = "toolStripItemNew";
            toolStripItemNew.Size = new Size(23, 26);
            toolStripItemNew.Text = "New";
            toolStripItemNew.Click += toolStripItemNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // toolStripItemDelete
            // 
            toolStripItemDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemDelete.Enabled = false;
            toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemDelete.Image = (Image)resources.GetObject("toolStripItemDelete.Image");
            toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemDelete.Name = "toolStripItemDelete";
            toolStripItemDelete.Size = new Size(23, 26);
            toolStripItemDelete.Text = "Delete";
            toolStripItemDelete.Click += toolStripItemDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 29);
            // 
            // btnAlphabetical
            // 
            btnAlphabetical.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAlphabetical.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnAlphabetical.Image = (Image)resources.GetObject("btnAlphabetical.Image");
            btnAlphabetical.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAlphabetical.Name = "btnAlphabetical";
            btnAlphabetical.Size = new Size(23, 26);
            btnAlphabetical.Text = "Order Chronologically";
            btnAlphabetical.Click += btnAlphabetical_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator4.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 29);
            // 
            // toolStripItemCopy
            // 
            toolStripItemCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemCopy.Enabled = false;
            toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemCopy.Image = (Image)resources.GetObject("toolStripItemCopy.Image");
            toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemCopy.Name = "toolStripItemCopy";
            toolStripItemCopy.Size = new Size(23, 26);
            toolStripItemCopy.Text = "Copy";
            toolStripItemCopy.Click += toolStripItemCopy_Click;
            // 
            // toolStripItemPaste
            // 
            toolStripItemPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemPaste.Enabled = false;
            toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemPaste.Image = (Image)resources.GetObject("toolStripItemPaste.Image");
            toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemPaste.Name = "toolStripItemPaste";
            toolStripItemPaste.Size = new Size(23, 26);
            toolStripItemPaste.Text = "Paste";
            toolStripItemPaste.Click += toolStripItemPaste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator3.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 29);
            // 
            // toolStripItemUndo
            // 
            toolStripItemUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripItemUndo.Enabled = false;
            toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripItemUndo.Image = (Image)resources.GetObject("toolStripItemUndo.Image");
            toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripItemUndo.Name = "toolStripItemUndo";
            toolStripItemUndo.Size = new Size(23, 26);
            toolStripItemUndo.Text = "Undo";
            toolStripItemUndo.Click += toolStripItemUndo_Click;
            // 
            // btnFishRequirements
            // 
            btnFishRequirements.Location = new System.Drawing.Point(11, 385);
            btnFishRequirements.Margin = new Padding(4, 3, 4, 3);
            btnFishRequirements.Name = "btnFishRequirements";
            btnFishRequirements.Padding = new Padding(6);
            btnFishRequirements.Size = new Size(296, 27);
            btnFishRequirements.TabIndex = 50;
            btnFishRequirements.Text = "Fishing Requirements";
            btnFishRequirements.Click += btnFishRequirements_Click;
            // 
            // FrmFishes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(932, 526);
            ControlBox = false;
            Controls.Add(toolStrip);
            Controls.Add(pnlContainer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpFishes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFishes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fishes Editor";
            Load += frmFishes_Load;
            KeyDown += form_KeyDown;
            grpFishes.ResumeLayout(false);
            grpFishes.PerformLayout();
            pnlContainer.ResumeLayout(false);
            grpGeneral.ResumeLayout(false);
            grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFish).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChance).EndInit();
            grpParameters.ResumeLayout(false);
            grpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTimeChangeRangeSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeChangeSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCoeffUnpredictability).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeedResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeedMove).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRangeSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPushStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        private string ConvexText(string text)
        {
            return text.Replace(@"\n", "\r\n");
        }

        #endregion

        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpFishes;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblFishItem;
        private System.Windows.Forms.Label lblChance;
        private DarkGroupBox grpParameters;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkComboBox cmbFishItem;
        private DarkNumericUpDown nudChance;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private Controls.GameObjectList lstGameObjects;
        private System.Windows.Forms.Label lblCommonEvent;
        private DarkComboBox cmbEvent;
        private DarkNumericUpDown nudWeight;
        private DarkLabel lblWeight;
        private DarkNumericUpDown nudPushStrength;
        private Label lblPushStrength;
        private DarkNumericUpDown nudPosition;
        private Label lblPosition;
        private DarkNumericUpDown nudStrength;
        private Label lblStrength;
        private DarkNumericUpDown nudCoeffUnpredictability;
        private Label lblCoeffUnpredictability;
        private DarkNumericUpDown nudSpeedResize;
        private Label lblSpeedResize;
        private DarkNumericUpDown nudSpeedMove;
        private Label lblSpeedMove;
        private DarkNumericUpDown nudRangeSize;
        private Label lblRangeSize;
        private DarkNumericUpDown nudTimeChangeRangeSize;
        private Label lblTimeChangeRangeSize;
        private DarkNumericUpDown nudTimeChangeSpeed;
        private Label lblTimeChangeSpeed;
        private PictureBox picFish;
        private Label lblName;
        private DarkTextBox txtName;
        private DarkButton btnFishRequirements;
    }
}
