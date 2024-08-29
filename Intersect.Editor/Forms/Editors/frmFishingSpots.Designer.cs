using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmFishingSpots
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFishingSpots));
            btnCancel = new DarkButton();
            btnSave = new DarkButton();
            grpSpots = new DarkGroupBox();
            btnClearSearch = new DarkButton();
            txtSearch = new DarkTextBox();
            lstGameObjects = new Controls.GameObjectList();
            pnlContainer = new Panel();
            grpGeneral = new DarkGroupBox();
            nudFishingTimeMax = new DarkNumericUpDown();
            lblTimeMax = new DarkLabel();
            nudFishingTimeMin = new DarkNumericUpDown();
            lblTimeMin = new DarkLabel();
            btnAddFolder = new DarkButton();
            lblFolder = new Label();
            cmbFolder = new DarkComboBox();
            lblName = new Label();
            txtName = new DarkTextBox();
            grpFishes = new DarkGroupBox();
            btnRemoveFish = new DarkButton();
            btnFishDown = new DarkButton();
            btnFishUp = new DarkButton();
            btnAddFish = new DarkButton();
            cmbFishes = new DarkComboBox();
            lblAddFish = new Label();
            lstFishes = new ListBox();
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
            grpSpots.SuspendLayout();
            pnlContainer.SuspendLayout();
            grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFishingTimeMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFishingTimeMin).BeginInit();
            grpFishes.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(657, 456);
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
            btnSave.Location = new System.Drawing.Point(453, 456);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6);
            btnSave.Size = new Size(197, 31);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // grpSpots
            // 
            grpSpots.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpSpots.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpSpots.Controls.Add(btnClearSearch);
            grpSpots.Controls.Add(txtSearch);
            grpSpots.Controls.Add(lstGameObjects);
            grpSpots.ForeColor = System.Drawing.Color.Gainsboro;
            grpSpots.Location = new System.Drawing.Point(14, 42);
            grpSpots.Margin = new Padding(4, 3, 4, 3);
            grpSpots.Name = "grpSpots";
            grpSpots.Padding = new Padding(4, 3, 4, 3);
            grpSpots.Size = new Size(237, 399);
            grpSpots.TabIndex = 22;
            grpSpots.TabStop = false;
            grpSpots.Text = "Spots";
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new System.Drawing.Point(209, 18);
            btnClearSearch.Margin = new Padding(4, 3, 4, 3);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Padding = new Padding(6);
            btnClearSearch.Size = new Size(21, 23);
            btnClearSearch.TabIndex = 25;
            btnClearSearch.Text = "X";
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtSearch.Location = new System.Drawing.Point(7, 18);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 24;
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
            lstGameObjects.Location = new System.Drawing.Point(7, 48);
            lstGameObjects.Margin = new Padding(4, 3, 4, 3);
            lstGameObjects.Name = "lstGameObjects";
            lstGameObjects.SelectedImageIndex = 0;
            lstGameObjects.Size = new Size(223, 342);
            lstGameObjects.TabIndex = 23;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(grpGeneral);
            pnlContainer.Controls.Add(grpFishes);
            pnlContainer.Location = new System.Drawing.Point(258, 42);
            pnlContainer.Margin = new Padding(4, 3, 4, 3);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(609, 399);
            pnlContainer.TabIndex = 31;
            pnlContainer.Visible = false;
            // 
            // grpGeneral
            // 
            grpGeneral.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpGeneral.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpGeneral.Controls.Add(btnFishRequirements);
            grpGeneral.Controls.Add(nudFishingTimeMax);
            grpGeneral.Controls.Add(lblTimeMax);
            grpGeneral.Controls.Add(nudFishingTimeMin);
            grpGeneral.Controls.Add(lblTimeMin);
            grpGeneral.Controls.Add(btnAddFolder);
            grpGeneral.Controls.Add(lblFolder);
            grpGeneral.Controls.Add(cmbFolder);
            grpGeneral.Controls.Add(lblName);
            grpGeneral.Controls.Add(txtName);
            grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            grpGeneral.Location = new System.Drawing.Point(8, 3);
            grpGeneral.Margin = new Padding(4, 3, 4, 3);
            grpGeneral.Name = "grpGeneral";
            grpGeneral.Padding = new Padding(4, 3, 4, 3);
            grpGeneral.Size = new Size(292, 387);
            grpGeneral.TabIndex = 34;
            grpGeneral.TabStop = false;
            grpGeneral.Text = "General";
            // 
            // nudFishingTimeMax
            // 
            nudFishingTimeMax.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudFishingTimeMax.ForeColor = System.Drawing.Color.Gainsboro;
            nudFishingTimeMax.Location = new System.Drawing.Point(123, 117);
            nudFishingTimeMax.Margin = new Padding(4, 3, 4, 3);
            nudFishingTimeMax.Maximum = new decimal(new int[] { 200000000, 0, 0, 0 });
            nudFishingTimeMax.Name = "nudFishingTimeMax";
            nudFishingTimeMax.Size = new Size(162, 23);
            nudFishingTimeMax.TabIndex = 52;
            nudFishingTimeMax.Value = new decimal(new int[] { 30000, 0, 0, 0 });
            nudFishingTimeMax.ValueChanged += nud_ValueChanged;
            // 
            // lblTimeMax
            // 
            lblTimeMax.AutoSize = true;
            lblTimeMax.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lblTimeMax.Location = new System.Drawing.Point(5, 119);
            lblTimeMax.Margin = new Padding(4, 0, 4, 0);
            lblTimeMax.Name = "lblTimeMax";
            lblTimeMax.Size = new Size(100, 15);
            lblTimeMax.TabIndex = 51;
            lblTimeMax.Tag = "";
            lblTimeMax.Text = "Fishing Time Max";
            // 
            // nudFishingTimeMin
            // 
            nudFishingTimeMin.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudFishingTimeMin.ForeColor = System.Drawing.Color.Gainsboro;
            nudFishingTimeMin.Location = new System.Drawing.Point(123, 88);
            nudFishingTimeMin.Margin = new Padding(4, 3, 4, 3);
            nudFishingTimeMin.Maximum = new decimal(new int[] { 200000000, 0, 0, 0 });
            nudFishingTimeMin.Name = "nudFishingTimeMin";
            nudFishingTimeMin.Size = new Size(162, 23);
            nudFishingTimeMin.TabIndex = 50;
            nudFishingTimeMin.Value = new decimal(new int[] { 7000, 0, 0, 0 });
            nudFishingTimeMin.ValueChanged += nud_ValueChanged;
            // 
            // lblTimeMin
            // 
            lblTimeMin.AutoSize = true;
            lblTimeMin.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lblTimeMin.Location = new System.Drawing.Point(5, 90);
            lblTimeMin.Margin = new Padding(4, 0, 4, 0);
            lblTimeMin.Name = "lblTimeMin";
            lblTimeMin.Size = new Size(98, 15);
            lblTimeMin.TabIndex = 49;
            lblTimeMin.Tag = "";
            lblTimeMin.Text = "Fishing Time Min";
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new System.Drawing.Point(264, 51);
            btnAddFolder.Margin = new Padding(4, 3, 4, 3);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Padding = new Padding(6);
            btnAddFolder.Size = new Size(21, 24);
            btnAddFolder.TabIndex = 23;
            btnAddFolder.Text = "+";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new System.Drawing.Point(5, 55);
            lblFolder.Margin = new Padding(4, 0, 4, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 22;
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
            cmbFolder.Location = new System.Drawing.Point(66, 51);
            cmbFolder.Margin = new Padding(4, 3, 4, 3);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(185, 24);
            cmbFolder.TabIndex = 21;
            cmbFolder.Text = null;
            cmbFolder.TextPadding = new Padding(2);
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(5, 23);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 19;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txtName.Location = new System.Drawing.Point(66, 21);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 23);
            txtName.TabIndex = 18;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // grpFishes
            // 
            grpFishes.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpFishes.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpFishes.Controls.Add(btnRemoveFish);
            grpFishes.Controls.Add(btnFishDown);
            grpFishes.Controls.Add(btnFishUp);
            grpFishes.Controls.Add(btnAddFish);
            grpFishes.Controls.Add(cmbFishes);
            grpFishes.Controls.Add(lblAddFish);
            grpFishes.Controls.Add(lstFishes);
            grpFishes.ForeColor = System.Drawing.Color.Gainsboro;
            grpFishes.Location = new System.Drawing.Point(308, 3);
            grpFishes.Margin = new Padding(4, 3, 4, 3);
            grpFishes.Name = "grpFishes";
            grpFishes.Padding = new Padding(4, 3, 4, 3);
            grpFishes.Size = new Size(292, 387);
            grpFishes.TabIndex = 33;
            grpFishes.TabStop = false;
            grpFishes.Text = "Available Fishes";
            // 
            // btnRemoveFish
            // 
            btnRemoveFish.Location = new System.Drawing.Point(8, 347);
            btnRemoveFish.Margin = new Padding(4, 3, 4, 3);
            btnRemoveFish.Name = "btnRemoveFish";
            btnRemoveFish.Padding = new Padding(6);
            btnRemoveFish.Size = new Size(276, 27);
            btnRemoveFish.TabIndex = 53;
            btnRemoveFish.Text = "Remove Selected";
            btnRemoveFish.Click += btnRemoveFish_Click;
            // 
            // btnFishDown
            // 
            btnFishDown.Location = new System.Drawing.Point(259, 203);
            btnFishDown.Margin = new Padding(4, 3, 4, 3);
            btnFishDown.Name = "btnFishDown";
            btnFishDown.Padding = new Padding(6);
            btnFishDown.Size = new Size(26, 46);
            btnFishDown.TabIndex = 52;
            btnFishDown.Text = "?";
            btnFishDown.Click += btnFishDown_Click;
            // 
            // btnFishUp
            // 
            btnFishUp.Location = new System.Drawing.Point(259, 22);
            btnFishUp.Margin = new Padding(4, 3, 4, 3);
            btnFishUp.Name = "btnFishUp";
            btnFishUp.Padding = new Padding(6);
            btnFishUp.Size = new Size(26, 46);
            btnFishUp.TabIndex = 51;
            btnFishUp.Text = "?";
            btnFishUp.Click += btnFishUp_Click;
            // 
            // btnAddFish
            // 
            btnAddFish.Location = new System.Drawing.Point(8, 314);
            btnAddFish.Margin = new Padding(4, 3, 4, 3);
            btnAddFish.Name = "btnAddFish";
            btnAddFish.Padding = new Padding(6);
            btnAddFish.Size = new Size(276, 27);
            btnAddFish.TabIndex = 50;
            btnAddFish.Text = "Add Selected";
            btnAddFish.Click += btnAddFish_Click;
            // 
            // cmbFishes
            // 
            cmbFishes.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbFishes.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbFishes.BorderStyle = ButtonBorderStyle.Solid;
            cmbFishes.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbFishes.DrawDropdownHoverOutline = false;
            cmbFishes.DrawFocusRectangle = false;
            cmbFishes.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFishes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFishes.FlatStyle = FlatStyle.Flat;
            cmbFishes.ForeColor = System.Drawing.Color.Gainsboro;
            cmbFishes.FormattingEnabled = true;
            cmbFishes.Location = new System.Drawing.Point(8, 283);
            cmbFishes.Margin = new Padding(4, 3, 4, 3);
            cmbFishes.Name = "cmbFishes";
            cmbFishes.Size = new Size(276, 24);
            cmbFishes.TabIndex = 49;
            cmbFishes.Text = null;
            cmbFishes.TextPadding = new Padding(2);
            // 
            // lblAddFish
            // 
            lblAddFish.AutoSize = true;
            lblAddFish.Location = new System.Drawing.Point(7, 264);
            lblAddFish.Margin = new Padding(4, 0, 4, 0);
            lblAddFish.Name = "lblAddFish";
            lblAddFish.Size = new Size(128, 15);
            lblAddFish.TabIndex = 48;
            lblAddFish.Text = "Add Fish To Be Fishing:";
            // 
            // lstFishes
            // 
            lstFishes.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstFishes.BorderStyle = BorderStyle.FixedSingle;
            lstFishes.ForeColor = System.Drawing.Color.Gainsboro;
            lstFishes.FormattingEnabled = true;
            lstFishes.ItemHeight = 15;
            lstFishes.Location = new System.Drawing.Point(7, 22);
            lstFishes.Margin = new Padding(4, 3, 4, 3);
            lstFishes.Name = "lstFishes";
            lstFishes.Size = new Size(245, 227);
            lstFishes.TabIndex = 47;
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
            toolStrip.Size = new Size(878, 29);
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
            btnFishRequirements.Location = new System.Drawing.Point(8, 347);
            btnFishRequirements.Margin = new Padding(4, 3, 4, 3);
            btnFishRequirements.Name = "btnFishRequirements";
            btnFishRequirements.Padding = new Padding(6);
            btnFishRequirements.Size = new Size(277, 27);
            btnFishRequirements.TabIndex = 53;
            btnFishRequirements.Text = "Fishing Requirements";
            btnFishRequirements.Click += btnFishRequirements_Click;
            // 
            // FrmFishingSpots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(878, 498);
            ControlBox = false;
            Controls.Add(toolStrip);
            Controls.Add(pnlContainer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpSpots);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFishingSpots";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fishing Spots Editor";
            Load += frmFishing_Load;
            KeyDown += form_KeyDown;
            grpSpots.ResumeLayout(false);
            grpSpots.PerformLayout();
            pnlContainer.ResumeLayout(false);
            grpGeneral.ResumeLayout(false);
            grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFishingTimeMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFishingTimeMin).EndInit();
            grpFishes.ResumeLayout(false);
            grpFishes.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpSpots;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkGroupBox grpFishes;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Controls.GameObjectList lstGameObjects;
        private DarkButton btnFishDown;
        private DarkButton btnFishUp;
        private DarkButton btnAddFish;
        private DarkComboBox cmbFishes;
        private System.Windows.Forms.Label lblAddFish;
        private System.Windows.Forms.ListBox lstFishes;
        private DarkButton btnRemoveFish;
        private DarkNumericUpDown nudFishingTimeMin;
        private DarkLabel lblTimeMin;
        private DarkNumericUpDown nudFishingTimeMax;
        private DarkLabel lblTimeMax;
        private DarkButton btnFishRequirements;
    }
}
