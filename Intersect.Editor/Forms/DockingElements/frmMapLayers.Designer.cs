using System.Windows.Forms;
using DarkUI.Controls;
using Intersect.Editor.Forms.Controls;

namespace Intersect.Editor.Forms.DockingElements
{
    partial class FrmMapLayers
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
            lblLayer = new Label();
            lblTileType = new Label();
            lblTileset = new Label();
            cmbAutotile = new DarkComboBox();
            cmbTilesets = new DarkComboBox();
            rbSlide = new DarkRadioButton();
            rbGrappleStone = new DarkRadioButton();
            rbAnimation = new DarkRadioButton();
            rbResource = new DarkRadioButton();
            rbSound = new DarkRadioButton();
            rbWarp = new DarkRadioButton();
            rbNPCAvoid = new DarkRadioButton();
            rbZDimension = new DarkRadioButton();
            rbItem = new DarkRadioButton();
            rbBlocked = new DarkRadioButton();
            grpResource = new DarkGroupBox();
            grpZResource = new DarkGroupBox();
            rbLevel2 = new DarkRadioButton();
            rbLevel1 = new DarkRadioButton();
            cmbResourceAttribute = new DarkComboBox();
            lblResource = new Label();
            grpItem = new DarkGroupBox();
            nudItemRespawnTime = new DarkNumericUpDown();
            lblItemRespawnTime = new Label();
            nudItemQuantity = new DarkNumericUpDown();
            cmbItemAttribute = new DarkComboBox();
            lblMaxItemAmount = new Label();
            lblMapItem = new Label();
            grpWarp = new DarkGroupBox();
            cmbWarpSound = new DarkComboBox();
            lblWarpSound = new Label();
            grpInstanceSettings = new DarkGroupBox();
            lblInstance = new Label();
            cmbInstanceType = new DarkComboBox();
            chkChangeInstance = new CheckBox();
            nudWarpY = new DarkNumericUpDown();
            nudWarpX = new DarkNumericUpDown();
            btnVisualMapSelector = new DarkButton();
            cmbWarpMap = new DarkComboBox();
            cmbDirection = new DarkComboBox();
            lblWarpDir = new Label();
            lblY = new Label();
            lblX = new Label();
            lblMap = new Label();
            grpZDimension = new DarkGroupBox();
            grpGateway = new DarkGroupBox();
            rbGateway2 = new DarkRadioButton();
            rbGateway1 = new DarkRadioButton();
            rbGatewayNone = new DarkRadioButton();
            grpDimBlock = new DarkGroupBox();
            rbBlock2 = new DarkRadioButton();
            rbBlock1 = new DarkRadioButton();
            rbBlockNone = new DarkRadioButton();
            grpSound = new DarkGroupBox();
            nudSoundLoopInterval = new DarkNumericUpDown();
            lblSoundInterval = new Label();
            nudSoundDistance = new DarkNumericUpDown();
            cmbMapAttributeSound = new DarkComboBox();
            lblSoundDistance = new Label();
            lblMapSound = new Label();
            grpSlide = new DarkGroupBox();
            cmbSlideDir = new DarkComboBox();
            lblSlideDir = new Label();
            grpAnimation = new DarkGroupBox();
            chkAnimationBlock = new DarkCheckBox();
            cmbAnimationAttribute = new DarkComboBox();
            lblAnimation = new Label();
            lblLightInstructions = new Label();
            lblEventInstructions = new Label();
            grpNpcList = new DarkGroupBox();
            btnRemoveMapNpc = new DarkButton();
            btnAddMapNpc = new DarkButton();
            cmbNpc = new DarkComboBox();
            grpSpawnLoc = new DarkGroupBox();
            rbRandom = new DarkRadioButton();
            rbDeclared = new DarkRadioButton();
            grpSpawnDirection = new DarkGroupBox();
            cmbDir = new DarkComboBox();
            lblNpcCount = new Label();
            lstMapNpcs = new ListBox();
            npcColorPulseDialog = new ColorDialog();
            btnNpcPulseColor = new DarkButton();
            btnTileHeader = new DarkButton();
            btnAttributeHeader = new DarkButton();
            btnLightsHeader = new DarkButton();
            btnEventsHeader = new DarkButton();
            btnNpcsHeader = new DarkButton();
            panel1 = new Panel();
            pnlAttributes = new Panel();
            grpFishingSpot = new DarkGroupBox();
            chkBlockedFishingSpot = new CheckBox();
            cmbSpotTypeSelect = new DarkComboBox();
            lblSpotTypeSelect = new Label();
            rbFishingSpot = new DarkRadioButton();
            grpCritter = new DarkGroupBox();
            cmbCritterDirection = new DarkComboBox();
            lblCritterDirection = new Label();
            chkCritterBlockPlayers = new DarkCheckBox();
            chkCritterIgnoreNpcAvoids = new DarkCheckBox();
            cmbCritterLayer = new DarkComboBox();
            lblCritterLayer = new Label();
            lblCritterMoveFrequency = new Label();
            lblCritterMoveSpeed = new Label();
            nudCritterMoveFrequency = new DarkNumericUpDown();
            nudCritterMoveSpeed = new DarkNumericUpDown();
            cmbCritterMovement = new DarkComboBox();
            lblCritterMovement = new Label();
            cmbCritterSprite = new DarkComboBox();
            lblCritterSprite = new Label();
            cmbCritterAnimation = new DarkComboBox();
            lblCritterAnimation = new Label();
            rbCritter = new DarkRadioButton();
            pnlNpcs = new Panel();
            pnlTiles = new Panel();
            cmbMapLayer = new DarkComboBox();
            picLayer5 = new PictureBox();
            picLayer4 = new PictureBox();
            picLayer3 = new PictureBox();
            picLayer2 = new PictureBox();
            picLayer1 = new PictureBox();
            pnlTilesetContainer = new AutoDragPanel();
            picTileset = new PictureBox();
            pnlEvents = new Panel();
            pnlLights = new Panel();
            lightEditor = new LightEditorCtrl();
            tooltips = new ToolTip(components);
            grpResource.SuspendLayout();
            grpZResource.SuspendLayout();
            grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudItemRespawnTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItemQuantity).BeginInit();
            grpWarp.SuspendLayout();
            grpInstanceSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarpY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWarpX).BeginInit();
            grpZDimension.SuspendLayout();
            grpGateway.SuspendLayout();
            grpDimBlock.SuspendLayout();
            grpSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoundLoopInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoundDistance).BeginInit();
            grpSlide.SuspendLayout();
            grpAnimation.SuspendLayout();
            grpNpcList.SuspendLayout();
            grpSpawnLoc.SuspendLayout();
            grpSpawnDirection.SuspendLayout();
            panel1.SuspendLayout();
            pnlAttributes.SuspendLayout();
            grpFishingSpot.SuspendLayout();
            grpCritter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCritterMoveFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCritterMoveSpeed).BeginInit();
            pnlNpcs.SuspendLayout();
            pnlTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLayer5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLayer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLayer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLayer1).BeginInit();
            pnlTilesetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTileset).BeginInit();
            pnlEvents.SuspendLayout();
            pnlLights.SuspendLayout();
            SuspendLayout();
            // 
            // lblLayer
            // 
            lblLayer.AutoSize = true;
            lblLayer.ForeColor = System.Drawing.Color.Gainsboro;
            lblLayer.Location = new System.Drawing.Point(9, 12);
            lblLayer.Name = "lblLayer";
            lblLayer.Size = new Size(36, 13);
            lblLayer.TabIndex = 23;
            lblLayer.Text = "Layer:";
            // 
            // lblTileType
            // 
            lblTileType.AutoSize = true;
            lblTileType.ForeColor = System.Drawing.Color.Gainsboro;
            lblTileType.Location = new System.Drawing.Point(9, 68);
            lblTileType.Name = "lblTileType";
            lblTileType.Size = new Size(54, 13);
            lblTileType.TabIndex = 21;
            lblTileType.Text = "Tile Type:";
            // 
            // lblTileset
            // 
            lblTileset.AutoSize = true;
            lblTileset.ForeColor = System.Drawing.Color.Gainsboro;
            lblTileset.Location = new System.Drawing.Point(9, 39);
            lblTileset.Name = "lblTileset";
            lblTileset.Size = new Size(41, 13);
            lblTileset.TabIndex = 20;
            lblTileset.Text = "Tileset:";
            // 
            // cmbAutotile
            // 
            cmbAutotile.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbAutotile.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbAutotile.BorderStyle = ButtonBorderStyle.Solid;
            cmbAutotile.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbAutotile.DrawDropdownHoverOutline = false;
            cmbAutotile.DrawFocusRectangle = false;
            cmbAutotile.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAutotile.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutotile.FlatStyle = FlatStyle.Flat;
            cmbAutotile.ForeColor = System.Drawing.Color.Gainsboro;
            cmbAutotile.FormattingEnabled = true;
            cmbAutotile.Items.AddRange(new object[] { "Normal", "Autotile    [VX Format]", "Fake          [VX Format]", "Animated [VX Format]", "Cliff           [VX Format]", "Waterfall   [VX Format]", "Autotile     [XP Format]", "Animated  [XP Format]" });
            cmbAutotile.Location = new System.Drawing.Point(84, 65);
            cmbAutotile.Name = "cmbAutotile";
            cmbAutotile.Size = new Size(178, 21);
            cmbAutotile.TabIndex = 18;
            cmbAutotile.Text = "Normal";
            cmbAutotile.TextPadding = new Padding(2);
            cmbAutotile.SelectedIndexChanged += cmbAutotile_SelectedIndexChanged;
            // 
            // cmbTilesets
            // 
            cmbTilesets.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbTilesets.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbTilesets.BorderStyle = ButtonBorderStyle.Solid;
            cmbTilesets.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbTilesets.DrawDropdownHoverOutline = false;
            cmbTilesets.DrawFocusRectangle = false;
            cmbTilesets.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTilesets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTilesets.FlatStyle = FlatStyle.Flat;
            cmbTilesets.ForeColor = System.Drawing.Color.Gainsboro;
            cmbTilesets.FormattingEnabled = true;
            cmbTilesets.Location = new System.Drawing.Point(84, 36);
            cmbTilesets.Name = "cmbTilesets";
            cmbTilesets.Size = new Size(178, 21);
            cmbTilesets.TabIndex = 17;
            cmbTilesets.Text = null;
            cmbTilesets.TextPadding = new Padding(2);
            cmbTilesets.SelectedIndexChanged += cmbTilesets_SelectedIndexChanged;
            cmbTilesets.MouseDown += cmbTilesets_MouseDown;
            // 
            // rbSlide
            // 
            rbSlide.AutoSize = true;
            rbSlide.ForeColor = System.Drawing.Color.Gainsboro;
            rbSlide.Location = new System.Drawing.Point(115, 30);
            rbSlide.Name = "rbSlide";
            rbSlide.Size = new Size(48, 17);
            rbSlide.TabIndex = 35;
            rbSlide.Text = "Slide";
            rbSlide.CheckedChanged += rbSlide_CheckedChanged;
            // 
            // rbGrappleStone
            // 
            rbGrappleStone.AutoSize = true;
            rbGrappleStone.ForeColor = System.Drawing.Color.Gainsboro;
            rbGrappleStone.Location = new System.Drawing.Point(115, 8);
            rbGrappleStone.Name = "rbGrappleStone";
            rbGrappleStone.Size = new Size(93, 17);
            rbGrappleStone.TabIndex = 34;
            rbGrappleStone.Text = "Grapple Stone";
            rbGrappleStone.CheckedChanged += rbGrappleStone_CheckedChanged;
            // 
            // rbAnimation
            // 
            rbAnimation.AutoSize = true;
            rbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            rbAnimation.Location = new System.Drawing.Point(6, 146);
            rbAnimation.Name = "rbAnimation";
            rbAnimation.Size = new Size(71, 17);
            rbAnimation.TabIndex = 32;
            rbAnimation.Text = "Animation";
            rbAnimation.CheckedChanged += rbAnimation_CheckedChanged;
            // 
            // rbResource
            // 
            rbResource.AutoSize = true;
            rbResource.ForeColor = System.Drawing.Color.Gainsboro;
            rbResource.Location = new System.Drawing.Point(6, 123);
            rbResource.Name = "rbResource";
            rbResource.Size = new Size(71, 17);
            rbResource.TabIndex = 30;
            rbResource.Text = "Resource";
            rbResource.CheckedChanged += rbResource_CheckedChanged;
            // 
            // rbSound
            // 
            rbSound.AutoSize = true;
            rbSound.ForeColor = System.Drawing.Color.Gainsboro;
            rbSound.Location = new System.Drawing.Point(6, 100);
            rbSound.Name = "rbSound";
            rbSound.Size = new Size(80, 17);
            rbSound.TabIndex = 28;
            rbSound.Text = "Map Sound";
            rbSound.CheckedChanged += rbSound_CheckedChanged;
            // 
            // rbWarp
            // 
            rbWarp.AutoSize = true;
            rbWarp.ForeColor = System.Drawing.Color.Gainsboro;
            rbWarp.Location = new System.Drawing.Point(6, 53);
            rbWarp.Name = "rbWarp";
            rbWarp.Size = new Size(51, 17);
            rbWarp.TabIndex = 25;
            rbWarp.Text = "Warp";
            rbWarp.CheckedChanged += rbWarp_CheckedChanged;
            // 
            // rbNPCAvoid
            // 
            rbNPCAvoid.AutoSize = true;
            rbNPCAvoid.ForeColor = System.Drawing.Color.Gainsboro;
            rbNPCAvoid.Location = new System.Drawing.Point(6, 30);
            rbNPCAvoid.Name = "rbNPCAvoid";
            rbNPCAvoid.Size = new Size(77, 17);
            rbNPCAvoid.TabIndex = 24;
            rbNPCAvoid.Text = "NPC Avoid";
            rbNPCAvoid.CheckedChanged += rbNPCAvoid_CheckedChanged;
            // 
            // rbZDimension
            // 
            rbZDimension.AutoSize = true;
            rbZDimension.ForeColor = System.Drawing.Color.Gainsboro;
            rbZDimension.Location = new System.Drawing.Point(115, 53);
            rbZDimension.Name = "rbZDimension";
            rbZDimension.Size = new Size(84, 17);
            rbZDimension.TabIndex = 23;
            rbZDimension.Text = "Z-Dimension";
            rbZDimension.CheckedChanged += rbZDimension_CheckedChanged;
            // 
            // rbItem
            // 
            rbItem.AutoSize = true;
            rbItem.ForeColor = System.Drawing.Color.Gainsboro;
            rbItem.Location = new System.Drawing.Point(6, 76);
            rbItem.Name = "rbItem";
            rbItem.Size = new Size(81, 17);
            rbItem.TabIndex = 21;
            rbItem.Text = "Item Spawn";
            rbItem.CheckedChanged += rbItem_CheckedChanged;
            // 
            // rbBlocked
            // 
            rbBlocked.AutoSize = true;
            rbBlocked.Checked = true;
            rbBlocked.ForeColor = System.Drawing.Color.Gainsboro;
            rbBlocked.Location = new System.Drawing.Point(6, 8);
            rbBlocked.Name = "rbBlocked";
            rbBlocked.Size = new Size(64, 17);
            rbBlocked.TabIndex = 20;
            rbBlocked.TabStop = true;
            rbBlocked.Text = "Blocked";
            rbBlocked.CheckedChanged += rbBlocked_CheckedChanged;
            // 
            // grpResource
            // 
            grpResource.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpResource.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpResource.Controls.Add(grpZResource);
            grpResource.Controls.Add(cmbResourceAttribute);
            grpResource.Controls.Add(lblResource);
            grpResource.ForeColor = System.Drawing.Color.Gainsboro;
            grpResource.Location = new System.Drawing.Point(6, 179);
            grpResource.Name = "grpResource";
            grpResource.Size = new Size(256, 116);
            grpResource.TabIndex = 31;
            grpResource.TabStop = false;
            grpResource.Text = "Resource";
            grpResource.Visible = false;
            // 
            // grpZResource
            // 
            grpZResource.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpZResource.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpZResource.Controls.Add(rbLevel2);
            grpZResource.Controls.Add(rbLevel1);
            grpZResource.ForeColor = System.Drawing.Color.Gainsboro;
            grpZResource.Location = new System.Drawing.Point(16, 65);
            grpZResource.Name = "grpZResource";
            grpZResource.Size = new Size(224, 45);
            grpZResource.TabIndex = 12;
            grpZResource.TabStop = false;
            grpZResource.Text = "Z-Dimension";
            // 
            // rbLevel2
            // 
            rbLevel2.AutoSize = true;
            rbLevel2.Location = new System.Drawing.Point(158, 20);
            rbLevel2.Name = "rbLevel2";
            rbLevel2.RightToLeft = RightToLeft.No;
            rbLevel2.Size = new Size(60, 17);
            rbLevel2.TabIndex = 15;
            rbLevel2.Text = "Level 2";
            // 
            // rbLevel1
            // 
            rbLevel1.AutoSize = true;
            rbLevel1.Checked = true;
            rbLevel1.Location = new System.Drawing.Point(6, 20);
            rbLevel1.Name = "rbLevel1";
            rbLevel1.RightToLeft = RightToLeft.Yes;
            rbLevel1.Size = new Size(60, 17);
            rbLevel1.TabIndex = 14;
            rbLevel1.TabStop = true;
            rbLevel1.Text = "Level 1";
            // 
            // cmbResourceAttribute
            // 
            cmbResourceAttribute.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbResourceAttribute.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbResourceAttribute.BorderStyle = ButtonBorderStyle.Solid;
            cmbResourceAttribute.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbResourceAttribute.DrawDropdownHoverOutline = false;
            cmbResourceAttribute.DrawFocusRectangle = false;
            cmbResourceAttribute.DrawMode = DrawMode.OwnerDrawFixed;
            cmbResourceAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResourceAttribute.FlatStyle = FlatStyle.Flat;
            cmbResourceAttribute.ForeColor = System.Drawing.Color.Gainsboro;
            cmbResourceAttribute.FormattingEnabled = true;
            cmbResourceAttribute.Location = new System.Drawing.Point(17, 36);
            cmbResourceAttribute.Name = "cmbResourceAttribute";
            cmbResourceAttribute.Size = new Size(222, 21);
            cmbResourceAttribute.TabIndex = 11;
            cmbResourceAttribute.Text = null;
            cmbResourceAttribute.TextPadding = new Padding(2);
            // 
            // lblResource
            // 
            lblResource.AutoSize = true;
            lblResource.Location = new System.Drawing.Point(14, 16);
            lblResource.Name = "lblResource";
            lblResource.Size = new Size(56, 13);
            lblResource.TabIndex = 10;
            lblResource.Text = "Resource:";
            // 
            // grpItem
            // 
            grpItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpItem.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpItem.Controls.Add(nudItemRespawnTime);
            grpItem.Controls.Add(lblItemRespawnTime);
            grpItem.Controls.Add(nudItemQuantity);
            grpItem.Controls.Add(cmbItemAttribute);
            grpItem.Controls.Add(lblMaxItemAmount);
            grpItem.Controls.Add(lblMapItem);
            grpItem.ForeColor = System.Drawing.Color.Gainsboro;
            grpItem.Location = new System.Drawing.Point(6, 179);
            grpItem.Name = "grpItem";
            grpItem.Size = new Size(246, 148);
            grpItem.TabIndex = 22;
            grpItem.TabStop = false;
            grpItem.Text = "Map Item";
            grpItem.Visible = false;
            // 
            // nudItemRespawnTime
            // 
            nudItemRespawnTime.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudItemRespawnTime.ForeColor = System.Drawing.Color.Gainsboro;
            nudItemRespawnTime.Location = new System.Drawing.Point(16, 116);
            nudItemRespawnTime.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudItemRespawnTime.Name = "nudItemRespawnTime";
            nudItemRespawnTime.Size = new Size(219, 20);
            nudItemRespawnTime.TabIndex = 12;
            nudItemRespawnTime.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudItemRespawnTime.ValueChanged += NudItemRespawnTime_ValueChanged;
            // 
            // lblItemRespawnTime
            // 
            lblItemRespawnTime.AutoSize = true;
            lblItemRespawnTime.Location = new System.Drawing.Point(13, 98);
            lblItemRespawnTime.Name = "lblItemRespawnTime";
            lblItemRespawnTime.Size = new Size(100, 13);
            lblItemRespawnTime.TabIndex = 11;
            lblItemRespawnTime.Text = "Respawn Time (ms)";
            // 
            // nudItemQuantity
            // 
            nudItemQuantity.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudItemQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            nudItemQuantity.Location = new System.Drawing.Point(16, 72);
            nudItemQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudItemQuantity.Name = "nudItemQuantity";
            nudItemQuantity.Size = new Size(219, 20);
            nudItemQuantity.TabIndex = 10;
            nudItemQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudItemQuantity.ValueChanged += NudItemQuantity_ValueChanged;
            // 
            // cmbItemAttribute
            // 
            cmbItemAttribute.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbItemAttribute.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbItemAttribute.BorderStyle = ButtonBorderStyle.Solid;
            cmbItemAttribute.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbItemAttribute.DrawDropdownHoverOutline = false;
            cmbItemAttribute.DrawFocusRectangle = false;
            cmbItemAttribute.DrawMode = DrawMode.OwnerDrawFixed;
            cmbItemAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemAttribute.FlatStyle = FlatStyle.Flat;
            cmbItemAttribute.ForeColor = System.Drawing.Color.Gainsboro;
            cmbItemAttribute.FormattingEnabled = true;
            cmbItemAttribute.Location = new System.Drawing.Point(16, 32);
            cmbItemAttribute.Name = "cmbItemAttribute";
            cmbItemAttribute.Size = new Size(219, 21);
            cmbItemAttribute.TabIndex = 9;
            cmbItemAttribute.Text = null;
            cmbItemAttribute.TextPadding = new Padding(2);
            // 
            // lblMaxItemAmount
            // 
            lblMaxItemAmount.AutoSize = true;
            lblMaxItemAmount.Location = new System.Drawing.Point(13, 54);
            lblMaxItemAmount.Name = "lblMaxItemAmount";
            lblMaxItemAmount.Size = new Size(49, 13);
            lblMaxItemAmount.TabIndex = 8;
            lblMaxItemAmount.Text = "Quantity:";
            // 
            // lblMapItem
            // 
            lblMapItem.AutoSize = true;
            lblMapItem.Location = new System.Drawing.Point(13, 16);
            lblMapItem.Name = "lblMapItem";
            lblMapItem.Size = new Size(30, 13);
            lblMapItem.TabIndex = 7;
            lblMapItem.Text = "Item:";
            // 
            // grpWarp
            // 
            grpWarp.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpWarp.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpWarp.Controls.Add(cmbWarpSound);
            grpWarp.Controls.Add(lblWarpSound);
            grpWarp.Controls.Add(grpInstanceSettings);
            grpWarp.Controls.Add(chkChangeInstance);
            grpWarp.Controls.Add(nudWarpY);
            grpWarp.Controls.Add(nudWarpX);
            grpWarp.Controls.Add(btnVisualMapSelector);
            grpWarp.Controls.Add(cmbWarpMap);
            grpWarp.Controls.Add(cmbDirection);
            grpWarp.Controls.Add(lblWarpDir);
            grpWarp.Controls.Add(lblY);
            grpWarp.Controls.Add(lblX);
            grpWarp.Controls.Add(lblMap);
            grpWarp.ForeColor = System.Drawing.Color.Gainsboro;
            grpWarp.Location = new System.Drawing.Point(6, 179);
            grpWarp.Name = "grpWarp";
            grpWarp.Size = new Size(255, 367);
            grpWarp.TabIndex = 26;
            grpWarp.TabStop = false;
            grpWarp.Text = "Warp";
            grpWarp.Visible = false;
            // 
            // cmbWarpSound
            // 
            cmbWarpSound.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbWarpSound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbWarpSound.BorderStyle = ButtonBorderStyle.Solid;
            cmbWarpSound.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbWarpSound.DrawDropdownHoverOutline = false;
            cmbWarpSound.DrawFocusRectangle = false;
            cmbWarpSound.DrawMode = DrawMode.OwnerDrawFixed;
            cmbWarpSound.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarpSound.FlatStyle = FlatStyle.Flat;
            cmbWarpSound.ForeColor = System.Drawing.Color.Gainsboro;
            cmbWarpSound.FormattingEnabled = true;
            cmbWarpSound.Location = new System.Drawing.Point(61, 177);
            cmbWarpSound.Name = "cmbWarpSound";
            cmbWarpSound.Size = new Size(179, 21);
            cmbWarpSound.TabIndex = 33;
            cmbWarpSound.Text = "Retain Direction";
            cmbWarpSound.TextPadding = new Padding(2);
            // 
            // lblWarpSound
            // 
            lblWarpSound.AutoSize = true;
            lblWarpSound.Location = new System.Drawing.Point(14, 180);
            lblWarpSound.Name = "lblWarpSound";
            lblWarpSound.Size = new Size(41, 13);
            lblWarpSound.TabIndex = 32;
            lblWarpSound.Text = "Sound:";
            // 
            // grpInstanceSettings
            // 
            grpInstanceSettings.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpInstanceSettings.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpInstanceSettings.Controls.Add(lblInstance);
            grpInstanceSettings.Controls.Add(cmbInstanceType);
            grpInstanceSettings.ForeColor = System.Drawing.Color.Gainsboro;
            grpInstanceSettings.Location = new System.Drawing.Point(7, 272);
            grpInstanceSettings.Name = "grpInstanceSettings";
            grpInstanceSettings.Size = new Size(242, 84);
            grpInstanceSettings.TabIndex = 32;
            grpInstanceSettings.TabStop = false;
            grpInstanceSettings.Text = "Instance Settings";
            grpInstanceSettings.Visible = false;
            // 
            // lblInstance
            // 
            lblInstance.AutoSize = true;
            lblInstance.Location = new System.Drawing.Point(11, 22);
            lblInstance.Name = "lblInstance";
            lblInstance.Size = new Size(78, 13);
            lblInstance.TabIndex = 30;
            lblInstance.Text = "Instance Type:";
            // 
            // cmbInstanceType
            // 
            cmbInstanceType.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbInstanceType.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbInstanceType.BorderStyle = ButtonBorderStyle.Solid;
            cmbInstanceType.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbInstanceType.DrawDropdownHoverOutline = false;
            cmbInstanceType.DrawFocusRectangle = false;
            cmbInstanceType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbInstanceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInstanceType.FlatStyle = FlatStyle.Flat;
            cmbInstanceType.ForeColor = System.Drawing.Color.Gainsboro;
            cmbInstanceType.FormattingEnabled = true;
            cmbInstanceType.Items.AddRange(new object[] { "Overworld", "Personal", "Guild", "Party" });
            cmbInstanceType.Location = new System.Drawing.Point(11, 39);
            cmbInstanceType.Name = "cmbInstanceType";
            cmbInstanceType.Size = new Size(225, 21);
            cmbInstanceType.TabIndex = 29;
            cmbInstanceType.Text = "Overworld";
            cmbInstanceType.TextPadding = new Padding(2);
            // 
            // chkChangeInstance
            // 
            chkChangeInstance.AutoSize = true;
            chkChangeInstance.Location = new System.Drawing.Point(6, 249);
            chkChangeInstance.Name = "chkChangeInstance";
            chkChangeInstance.Size = new Size(112, 17);
            chkChangeInstance.TabIndex = 29;
            chkChangeInstance.Text = "Change instance?";
            chkChangeInstance.UseVisualStyleBackColor = true;
            chkChangeInstance.CheckedChanged += chkChangeInstance_CheckedChanged;
            // 
            // nudWarpY
            // 
            nudWarpY.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudWarpY.ForeColor = System.Drawing.Color.Gainsboro;
            nudWarpY.Location = new System.Drawing.Point(61, 104);
            nudWarpY.Name = "nudWarpY";
            nudWarpY.Size = new Size(178, 20);
            nudWarpY.TabIndex = 26;
            nudWarpY.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nudWarpX
            // 
            nudWarpX.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudWarpX.ForeColor = System.Drawing.Color.Gainsboro;
            nudWarpX.Location = new System.Drawing.Point(61, 66);
            nudWarpX.Name = "nudWarpX";
            nudWarpX.Size = new Size(178, 20);
            nudWarpX.TabIndex = 25;
            nudWarpX.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnVisualMapSelector
            // 
            btnVisualMapSelector.Location = new System.Drawing.Point(16, 211);
            btnVisualMapSelector.Name = "btnVisualMapSelector";
            btnVisualMapSelector.Padding = new Padding(5);
            btnVisualMapSelector.Size = new Size(222, 23);
            btnVisualMapSelector.TabIndex = 24;
            btnVisualMapSelector.Text = "Open Visual Interface";
            btnVisualMapSelector.Click += btnVisualMapSelector_Click;
            // 
            // cmbWarpMap
            // 
            cmbWarpMap.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbWarpMap.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbWarpMap.BorderStyle = ButtonBorderStyle.Solid;
            cmbWarpMap.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbWarpMap.DrawDropdownHoverOutline = false;
            cmbWarpMap.DrawFocusRectangle = false;
            cmbWarpMap.DrawMode = DrawMode.OwnerDrawFixed;
            cmbWarpMap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarpMap.FlatStyle = FlatStyle.Flat;
            cmbWarpMap.ForeColor = System.Drawing.Color.Gainsboro;
            cmbWarpMap.FormattingEnabled = true;
            cmbWarpMap.Location = new System.Drawing.Point(17, 30);
            cmbWarpMap.Name = "cmbWarpMap";
            cmbWarpMap.Size = new Size(221, 21);
            cmbWarpMap.TabIndex = 12;
            cmbWarpMap.Text = null;
            cmbWarpMap.TextPadding = new Padding(2);
            // 
            // cmbDirection
            // 
            cmbDirection.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbDirection.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbDirection.BorderStyle = ButtonBorderStyle.Solid;
            cmbDirection.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbDirection.DrawDropdownHoverOutline = false;
            cmbDirection.DrawFocusRectangle = false;
            cmbDirection.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDirection.FlatStyle = FlatStyle.Flat;
            cmbDirection.ForeColor = System.Drawing.Color.Gainsboro;
            cmbDirection.FormattingEnabled = true;
            cmbDirection.Items.AddRange(new object[] { "Retain Direction", "Up", "Down", "Left", "Right" });
            cmbDirection.Location = new System.Drawing.Point(61, 144);
            cmbDirection.Name = "cmbDirection";
            cmbDirection.Size = new Size(177, 21);
            cmbDirection.TabIndex = 23;
            cmbDirection.Text = "Retain Direction";
            cmbDirection.TextPadding = new Padding(2);
            // 
            // lblWarpDir
            // 
            lblWarpDir.AutoSize = true;
            lblWarpDir.Location = new System.Drawing.Point(13, 146);
            lblWarpDir.Name = "lblWarpDir";
            lblWarpDir.Size = new Size(23, 13);
            lblWarpDir.TabIndex = 22;
            lblWarpDir.Text = "Dir:";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new System.Drawing.Point(13, 106);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 13);
            lblY.TabIndex = 11;
            lblY.Text = "Y:";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new System.Drawing.Point(13, 69);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 13);
            lblX.TabIndex = 10;
            lblX.Text = "X:";
            // 
            // lblMap
            // 
            lblMap.AutoSize = true;
            lblMap.Location = new System.Drawing.Point(13, 14);
            lblMap.Name = "lblMap";
            lblMap.Size = new Size(31, 13);
            lblMap.TabIndex = 9;
            lblMap.Text = "Map:";
            // 
            // grpZDimension
            // 
            grpZDimension.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpZDimension.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpZDimension.Controls.Add(grpGateway);
            grpZDimension.Controls.Add(grpDimBlock);
            grpZDimension.ForeColor = System.Drawing.Color.Gainsboro;
            grpZDimension.Location = new System.Drawing.Point(6, 179);
            grpZDimension.Name = "grpZDimension";
            grpZDimension.Size = new Size(257, 132);
            grpZDimension.TabIndex = 27;
            grpZDimension.TabStop = false;
            grpZDimension.Text = "Z-Dimension";
            grpZDimension.Visible = false;
            // 
            // grpGateway
            // 
            grpGateway.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpGateway.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpGateway.Controls.Add(rbGateway2);
            grpGateway.Controls.Add(rbGateway1);
            grpGateway.Controls.Add(rbGatewayNone);
            grpGateway.ForeColor = System.Drawing.Color.Gainsboro;
            grpGateway.Location = new System.Drawing.Point(10, 25);
            grpGateway.Name = "grpGateway";
            grpGateway.Size = new Size(107, 91);
            grpGateway.TabIndex = 9;
            grpGateway.TabStop = false;
            grpGateway.Text = "Gateway";
            // 
            // rbGateway2
            // 
            rbGateway2.AutoSize = true;
            rbGateway2.Location = new System.Drawing.Point(6, 64);
            rbGateway2.Name = "rbGateway2";
            rbGateway2.Size = new Size(60, 17);
            rbGateway2.TabIndex = 12;
            rbGateway2.Text = "Level 2";
            // 
            // rbGateway1
            // 
            rbGateway1.AutoSize = true;
            rbGateway1.Location = new System.Drawing.Point(6, 41);
            rbGateway1.Name = "rbGateway1";
            rbGateway1.Size = new Size(60, 17);
            rbGateway1.TabIndex = 11;
            rbGateway1.Text = "Level 1";
            // 
            // rbGatewayNone
            // 
            rbGatewayNone.AutoSize = true;
            rbGatewayNone.Checked = true;
            rbGatewayNone.Location = new System.Drawing.Point(6, 19);
            rbGatewayNone.Name = "rbGatewayNone";
            rbGatewayNone.Size = new Size(75, 17);
            rbGatewayNone.TabIndex = 10;
            rbGatewayNone.TabStop = true;
            rbGatewayNone.Text = "Not Found";
            // 
            // grpDimBlock
            // 
            grpDimBlock.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpDimBlock.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpDimBlock.Controls.Add(rbBlock2);
            grpDimBlock.Controls.Add(rbBlock1);
            grpDimBlock.Controls.Add(rbBlockNone);
            grpDimBlock.ForeColor = System.Drawing.Color.Gainsboro;
            grpDimBlock.Location = new System.Drawing.Point(123, 25);
            grpDimBlock.Name = "grpDimBlock";
            grpDimBlock.Size = new Size(111, 91);
            grpDimBlock.TabIndex = 8;
            grpDimBlock.TabStop = false;
            grpDimBlock.Text = "Block";
            // 
            // rbBlock2
            // 
            rbBlock2.AutoSize = true;
            rbBlock2.Location = new System.Drawing.Point(6, 64);
            rbBlock2.Name = "rbBlock2";
            rbBlock2.Size = new Size(60, 17);
            rbBlock2.TabIndex = 15;
            rbBlock2.Text = "Level 2";
            // 
            // rbBlock1
            // 
            rbBlock1.AutoSize = true;
            rbBlock1.Location = new System.Drawing.Point(6, 41);
            rbBlock1.Name = "rbBlock1";
            rbBlock1.Size = new Size(60, 17);
            rbBlock1.TabIndex = 14;
            rbBlock1.Text = "Level 1";
            // 
            // rbBlockNone
            // 
            rbBlockNone.AutoSize = true;
            rbBlockNone.Checked = true;
            rbBlockNone.Location = new System.Drawing.Point(6, 19);
            rbBlockNone.Name = "rbBlockNone";
            rbBlockNone.Size = new Size(51, 17);
            rbBlockNone.TabIndex = 13;
            rbBlockNone.TabStop = true;
            rbBlockNone.Text = "None";
            // 
            // grpSound
            // 
            grpSound.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpSound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpSound.Controls.Add(nudSoundLoopInterval);
            grpSound.Controls.Add(lblSoundInterval);
            grpSound.Controls.Add(nudSoundDistance);
            grpSound.Controls.Add(cmbMapAttributeSound);
            grpSound.Controls.Add(lblSoundDistance);
            grpSound.Controls.Add(lblMapSound);
            grpSound.ForeColor = System.Drawing.Color.Gainsboro;
            grpSound.Location = new System.Drawing.Point(6, 179);
            grpSound.Name = "grpSound";
            grpSound.Size = new Size(252, 150);
            grpSound.TabIndex = 29;
            grpSound.TabStop = false;
            grpSound.Text = "Map Sound";
            grpSound.Visible = false;
            // 
            // nudSoundLoopInterval
            // 
            nudSoundLoopInterval.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudSoundLoopInterval.ForeColor = System.Drawing.Color.Gainsboro;
            nudSoundLoopInterval.Location = new System.Drawing.Point(16, 118);
            nudSoundLoopInterval.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudSoundLoopInterval.Name = "nudSoundLoopInterval";
            nudSoundLoopInterval.Size = new Size(219, 20);
            nudSoundLoopInterval.TabIndex = 12;
            nudSoundLoopInterval.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblSoundInterval
            // 
            lblSoundInterval.AutoSize = true;
            lblSoundInterval.Location = new System.Drawing.Point(13, 100);
            lblSoundInterval.Name = "lblSoundInterval";
            lblSoundInterval.Size = new Size(107, 13);
            lblSoundInterval.TabIndex = 11;
            lblSoundInterval.Text = "Loop Interval (In Ms):";
            // 
            // nudSoundDistance
            // 
            nudSoundDistance.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudSoundDistance.ForeColor = System.Drawing.Color.Gainsboro;
            nudSoundDistance.Location = new System.Drawing.Point(16, 72);
            nudSoundDistance.Name = "nudSoundDistance";
            nudSoundDistance.Size = new Size(219, 20);
            nudSoundDistance.TabIndex = 10;
            nudSoundDistance.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // cmbMapAttributeSound
            // 
            cmbMapAttributeSound.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbMapAttributeSound.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbMapAttributeSound.BorderStyle = ButtonBorderStyle.Solid;
            cmbMapAttributeSound.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbMapAttributeSound.DrawDropdownHoverOutline = false;
            cmbMapAttributeSound.DrawFocusRectangle = false;
            cmbMapAttributeSound.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMapAttributeSound.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMapAttributeSound.FlatStyle = FlatStyle.Flat;
            cmbMapAttributeSound.ForeColor = System.Drawing.Color.Gainsboro;
            cmbMapAttributeSound.FormattingEnabled = true;
            cmbMapAttributeSound.Location = new System.Drawing.Point(16, 30);
            cmbMapAttributeSound.Name = "cmbMapAttributeSound";
            cmbMapAttributeSound.Size = new Size(219, 21);
            cmbMapAttributeSound.TabIndex = 9;
            cmbMapAttributeSound.Text = null;
            cmbMapAttributeSound.TextPadding = new Padding(2);
            // 
            // lblSoundDistance
            // 
            lblSoundDistance.AutoSize = true;
            lblSoundDistance.Location = new System.Drawing.Point(13, 54);
            lblSoundDistance.Name = "lblSoundDistance";
            lblSoundDistance.Size = new Size(95, 13);
            lblSoundDistance.TabIndex = 8;
            lblSoundDistance.Text = "Distance (In Tiles):";
            // 
            // lblMapSound
            // 
            lblMapSound.AutoSize = true;
            lblMapSound.Location = new System.Drawing.Point(13, 16);
            lblMapSound.Name = "lblMapSound";
            lblMapSound.Size = new Size(41, 13);
            lblMapSound.TabIndex = 7;
            lblMapSound.Text = "Sound:";
            // 
            // grpSlide
            // 
            grpSlide.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpSlide.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpSlide.Controls.Add(cmbSlideDir);
            grpSlide.Controls.Add(lblSlideDir);
            grpSlide.ForeColor = System.Drawing.Color.Gainsboro;
            grpSlide.Location = new System.Drawing.Point(5, 177);
            grpSlide.Name = "grpSlide";
            grpSlide.Size = new Size(259, 75);
            grpSlide.TabIndex = 36;
            grpSlide.TabStop = false;
            grpSlide.Text = "Slide";
            grpSlide.Visible = false;
            // 
            // cmbSlideDir
            // 
            cmbSlideDir.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSlideDir.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSlideDir.BorderStyle = ButtonBorderStyle.Solid;
            cmbSlideDir.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSlideDir.DrawDropdownHoverOutline = false;
            cmbSlideDir.DrawFocusRectangle = false;
            cmbSlideDir.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSlideDir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSlideDir.FlatStyle = FlatStyle.Flat;
            cmbSlideDir.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSlideDir.FormattingEnabled = true;
            cmbSlideDir.Items.AddRange(new object[] { "Retain Direction", "Up", "Down", "Left", "Right" });
            cmbSlideDir.Location = new System.Drawing.Point(50, 27);
            cmbSlideDir.Name = "cmbSlideDir";
            cmbSlideDir.Size = new Size(192, 21);
            cmbSlideDir.TabIndex = 25;
            cmbSlideDir.Text = "Retain Direction";
            cmbSlideDir.TextPadding = new Padding(2);
            // 
            // lblSlideDir
            // 
            lblSlideDir.AutoSize = true;
            lblSlideDir.ForeColor = System.Drawing.Color.Gainsboro;
            lblSlideDir.Location = new System.Drawing.Point(17, 30);
            lblSlideDir.Name = "lblSlideDir";
            lblSlideDir.Size = new Size(23, 13);
            lblSlideDir.TabIndex = 24;
            lblSlideDir.Text = "Dir:";
            // 
            // grpAnimation
            // 
            grpAnimation.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpAnimation.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpAnimation.Controls.Add(chkAnimationBlock);
            grpAnimation.Controls.Add(cmbAnimationAttribute);
            grpAnimation.Controls.Add(lblAnimation);
            grpAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            grpAnimation.Location = new System.Drawing.Point(6, 179);
            grpAnimation.Name = "grpAnimation";
            grpAnimation.Size = new Size(256, 96);
            grpAnimation.TabIndex = 33;
            grpAnimation.TabStop = false;
            grpAnimation.Text = "Animaton";
            grpAnimation.Visible = false;
            // 
            // chkAnimationBlock
            // 
            chkAnimationBlock.AutoSize = true;
            chkAnimationBlock.Location = new System.Drawing.Point(16, 66);
            chkAnimationBlock.Name = "chkAnimationBlock";
            chkAnimationBlock.Size = new Size(73, 17);
            chkAnimationBlock.TabIndex = 27;
            chkAnimationBlock.Text = "Block Tile";
            // 
            // cmbAnimationAttribute
            // 
            cmbAnimationAttribute.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbAnimationAttribute.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbAnimationAttribute.BorderStyle = ButtonBorderStyle.Solid;
            cmbAnimationAttribute.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbAnimationAttribute.DrawDropdownHoverOutline = false;
            cmbAnimationAttribute.DrawFocusRectangle = false;
            cmbAnimationAttribute.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAnimationAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnimationAttribute.FlatStyle = FlatStyle.Flat;
            cmbAnimationAttribute.ForeColor = System.Drawing.Color.Gainsboro;
            cmbAnimationAttribute.FormattingEnabled = true;
            cmbAnimationAttribute.Location = new System.Drawing.Point(17, 36);
            cmbAnimationAttribute.Name = "cmbAnimationAttribute";
            cmbAnimationAttribute.Size = new Size(222, 21);
            cmbAnimationAttribute.TabIndex = 11;
            cmbAnimationAttribute.Text = null;
            cmbAnimationAttribute.TextPadding = new Padding(2);
            // 
            // lblAnimation
            // 
            lblAnimation.AutoSize = true;
            lblAnimation.Location = new System.Drawing.Point(14, 16);
            lblAnimation.Name = "lblAnimation";
            lblAnimation.Size = new Size(56, 13);
            lblAnimation.TabIndex = 10;
            lblAnimation.Text = "Animation:";
            // 
            // lblLightInstructions
            // 
            lblLightInstructions.ForeColor = System.Drawing.Color.Gainsboro;
            lblLightInstructions.Location = new System.Drawing.Point(6, 9);
            lblLightInstructions.Name = "lblLightInstructions";
            lblLightInstructions.Size = new Size(259, 38);
            lblLightInstructions.TabIndex = 1;
            lblLightInstructions.Text = "Lower the maps brightness and double click on a tile to create a light!";
            // 
            // lblEventInstructions
            // 
            lblEventInstructions.AutoSize = true;
            lblEventInstructions.ForeColor = System.Drawing.Color.Gainsboro;
            lblEventInstructions.Location = new System.Drawing.Point(9, 9);
            lblEventInstructions.Name = "lblEventInstructions";
            lblEventInstructions.Size = new Size(240, 13);
            lblEventInstructions.TabIndex = 0;
            lblEventInstructions.Text = "Double click a tile on the map to create an event!";
            // 
            // grpNpcList
            // 
            grpNpcList.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpNpcList.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpNpcList.Controls.Add(btnRemoveMapNpc);
            grpNpcList.Controls.Add(btnAddMapNpc);
            grpNpcList.Controls.Add(cmbNpc);
            grpNpcList.ForeColor = System.Drawing.Color.Gainsboro;
            grpNpcList.Location = new System.Drawing.Point(7, 10);
            grpNpcList.Name = "grpNpcList";
            grpNpcList.Size = new Size(259, 80);
            grpNpcList.TabIndex = 12;
            grpNpcList.TabStop = false;
            grpNpcList.Text = "Add or Remove NPC Spawn:";
            // 
            // btnRemoveMapNpc
            // 
            btnRemoveMapNpc.Location = new System.Drawing.Point(142, 50);
            btnRemoveMapNpc.Name = "btnRemoveMapNpc";
            btnRemoveMapNpc.Padding = new Padding(5);
            btnRemoveMapNpc.Size = new Size(80, 20);
            btnRemoveMapNpc.TabIndex = 6;
            btnRemoveMapNpc.Text = "Remove";
            btnRemoveMapNpc.Click += btnRemoveMapNpc_Click;
            // 
            // btnAddMapNpc
            // 
            btnAddMapNpc.Location = new System.Drawing.Point(21, 50);
            btnAddMapNpc.Name = "btnAddMapNpc";
            btnAddMapNpc.Padding = new Padding(5);
            btnAddMapNpc.Size = new Size(80, 20);
            btnAddMapNpc.TabIndex = 5;
            btnAddMapNpc.Text = "Add";
            btnAddMapNpc.Click += btnAddMapNpc_Click;
            // 
            // cmbNpc
            // 
            cmbNpc.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbNpc.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbNpc.BorderStyle = ButtonBorderStyle.Solid;
            cmbNpc.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbNpc.DrawDropdownHoverOutline = false;
            cmbNpc.DrawFocusRectangle = false;
            cmbNpc.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNpc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc.FlatStyle = FlatStyle.Flat;
            cmbNpc.ForeColor = System.Drawing.Color.Gainsboro;
            cmbNpc.FormattingEnabled = true;
            cmbNpc.Location = new System.Drawing.Point(6, 20);
            cmbNpc.Name = "cmbNpc";
            cmbNpc.Size = new Size(247, 21);
            cmbNpc.TabIndex = 4;
            cmbNpc.Text = null;
            cmbNpc.TextPadding = new Padding(2);
            cmbNpc.SelectedIndexChanged += cmbNpc_SelectedIndexChanged;
            // 
            // grpSpawnLoc
            // 
            grpSpawnLoc.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpSpawnLoc.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpSpawnLoc.Controls.Add(rbRandom);
            grpSpawnLoc.Controls.Add(rbDeclared);
            grpSpawnLoc.ForeColor = System.Drawing.Color.Gainsboro;
            grpSpawnLoc.Location = new System.Drawing.Point(7, 390);
            grpSpawnLoc.Name = "grpSpawnLoc";
            grpSpawnLoc.Size = new Size(259, 46);
            grpSpawnLoc.TabIndex = 11;
            grpSpawnLoc.TabStop = false;
            grpSpawnLoc.Text = "Spawn Location: Random";
            // 
            // rbRandom
            // 
            rbRandom.AutoSize = true;
            rbRandom.Checked = true;
            rbRandom.Location = new System.Drawing.Point(137, 18);
            rbRandom.Name = "rbRandom";
            rbRandom.Size = new Size(65, 17);
            rbRandom.TabIndex = 1;
            rbRandom.TabStop = true;
            rbRandom.Text = "Random";
            rbRandom.Click += rbRandom_Click;
            // 
            // rbDeclared
            // 
            rbDeclared.AutoSize = true;
            rbDeclared.Location = new System.Drawing.Point(37, 18);
            rbDeclared.Name = "rbDeclared";
            rbDeclared.Size = new Size(68, 17);
            rbDeclared.TabIndex = 0;
            rbDeclared.Text = "Declared";
            // 
            // grpSpawnDirection
            // 
            grpSpawnDirection.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpSpawnDirection.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpSpawnDirection.Controls.Add(cmbDir);
            grpSpawnDirection.ForeColor = System.Drawing.Color.Gainsboro;
            grpSpawnDirection.Location = new System.Drawing.Point(7, 445);
            grpSpawnDirection.Name = "grpSpawnDirection";
            grpSpawnDirection.Size = new Size(259, 46);
            grpSpawnDirection.TabIndex = 11;
            grpSpawnDirection.TabStop = false;
            grpSpawnDirection.Text = "Spawn Direction:";
            // 
            // cmbDir
            // 
            cmbDir.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbDir.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbDir.BorderStyle = ButtonBorderStyle.Solid;
            cmbDir.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbDir.DrawDropdownHoverOutline = false;
            cmbDir.DrawFocusRectangle = false;
            cmbDir.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDir.FlatStyle = FlatStyle.Flat;
            cmbDir.ForeColor = System.Drawing.Color.Gainsboro;
            cmbDir.FormattingEnabled = true;
            cmbDir.Items.AddRange(new object[] { "Random", "Up", "Down", "Left", "Right" });
            cmbDir.Location = new System.Drawing.Point(7, 18);
            cmbDir.Name = "cmbDir";
            cmbDir.Size = new Size(246, 21);
            cmbDir.TabIndex = 3;
            cmbDir.Text = "Random";
            cmbDir.TextPadding = new Padding(2);
            cmbDir.SelectedIndexChanged += cmbDir_SelectedIndexChanged;
            // 
            // lblNpcCount
            // 
            lblNpcCount.AutoSize = true;
            lblNpcCount.BorderStyle = BorderStyle.FixedSingle;
            lblNpcCount.ForeColor = System.Drawing.Color.Gainsboro;
            lblNpcCount.Location = new System.Drawing.Point(7, 362);
            lblNpcCount.Name = "lblNpcCount";
            lblNpcCount.Size = new Size(2, 15);
            lblNpcCount.TabIndex = 13;
            // 
            // lstMapNpcs
            // 
            lstMapNpcs.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            lstMapNpcs.BorderStyle = BorderStyle.FixedSingle;
            lstMapNpcs.ForeColor = System.Drawing.Color.Gainsboro;
            lstMapNpcs.FormattingEnabled = true;
            lstMapNpcs.Location = new System.Drawing.Point(7, 100);
            lstMapNpcs.Name = "lstMapNpcs";
            lstMapNpcs.Size = new Size(259, 262);
            lstMapNpcs.TabIndex = 10;
            lstMapNpcs.Click += lstMapNpcs_Click;
            lstMapNpcs.SelectedIndexChanged += lstMapNpcs_SelectedIndexChanged;
            lstMapNpcs.MouseDown += lstMapNpcs_MouseDown;
            // 
            // btnNpcPulseColor
            // 
            btnNpcPulseColor.Location = new System.Drawing.Point(7, 505);
            btnNpcPulseColor.Margin = new Padding(4, 3, 4, 3);
            btnNpcPulseColor.Name = "btnNpcPulseColor";
            btnNpcPulseColor.Padding = new Padding(6);
            btnNpcPulseColor.Size = new Size(259, 24);
            btnNpcPulseColor.TabIndex = 4;
            btnNpcPulseColor.Text = "Selected NPC highlight color";
            btnNpcPulseColor.Click += btnNpcPulseColor_Click;
            // 
            // btnTileHeader
            // 
            btnTileHeader.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            btnTileHeader.Location = new System.Drawing.Point(8, 12);
            btnTileHeader.Name = "btnTileHeader";
            btnTileHeader.Padding = new Padding(5);
            btnTileHeader.Size = new Size(44, 23);
            btnTileHeader.TabIndex = 18;
            btnTileHeader.Text = "Tiles";
            btnTileHeader.Click += btnTileHeader_Click;
            // 
            // btnAttributeHeader
            // 
            btnAttributeHeader.Location = new System.Drawing.Point(52, 12);
            btnAttributeHeader.Name = "btnAttributeHeader";
            btnAttributeHeader.Padding = new Padding(5);
            btnAttributeHeader.Size = new Size(64, 23);
            btnAttributeHeader.TabIndex = 19;
            btnAttributeHeader.Text = "Attributes";
            btnAttributeHeader.Click += btnAttributeHeader_Click;
            // 
            // btnLightsHeader
            // 
            btnLightsHeader.Location = new System.Drawing.Point(115, 12);
            btnLightsHeader.Name = "btnLightsHeader";
            btnLightsHeader.Padding = new Padding(5);
            btnLightsHeader.Size = new Size(49, 23);
            btnLightsHeader.TabIndex = 20;
            btnLightsHeader.Text = "Lights";
            btnLightsHeader.Click += btnLightsHeader_Click;
            // 
            // btnEventsHeader
            // 
            btnEventsHeader.Location = new System.Drawing.Point(163, 12);
            btnEventsHeader.Name = "btnEventsHeader";
            btnEventsHeader.Padding = new Padding(5);
            btnEventsHeader.Size = new Size(51, 23);
            btnEventsHeader.TabIndex = 21;
            btnEventsHeader.Text = "Events";
            btnEventsHeader.Click += btnEventsHeader_Click;
            // 
            // btnNpcsHeader
            // 
            btnNpcsHeader.Location = new System.Drawing.Point(213, 12);
            btnNpcsHeader.Name = "btnNpcsHeader";
            btnNpcsHeader.Padding = new Padding(5);
            btnNpcsHeader.Size = new Size(46, 23);
            btnNpcsHeader.TabIndex = 22;
            btnNpcsHeader.Text = "Npcs";
            btnNpcsHeader.Click += btnNpcsHeader_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pnlAttributes);
            panel1.Controls.Add(pnlNpcs);
            panel1.Controls.Add(pnlTiles);
            panel1.Controls.Add(pnlEvents);
            panel1.Controls.Add(pnlLights);
            panel1.Location = new System.Drawing.Point(8, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 555);
            panel1.TabIndex = 23;
            // 
            // pnlAttributes
            // 
            pnlAttributes.Controls.Add(grpFishingSpot);
            pnlAttributes.Controls.Add(rbFishingSpot);
            pnlAttributes.Controls.Add(grpWarp);
            pnlAttributes.Controls.Add(grpCritter);
            pnlAttributes.Controls.Add(rbCritter);
            pnlAttributes.Controls.Add(rbSlide);
            pnlAttributes.Controls.Add(rbBlocked);
            pnlAttributes.Controls.Add(rbGrappleStone);
            pnlAttributes.Controls.Add(rbAnimation);
            pnlAttributes.Controls.Add(rbResource);
            pnlAttributes.Controls.Add(rbSound);
            pnlAttributes.Controls.Add(rbWarp);
            pnlAttributes.Controls.Add(rbNPCAvoid);
            pnlAttributes.Controls.Add(rbZDimension);
            pnlAttributes.Controls.Add(rbItem);
            pnlAttributes.Controls.Add(grpAnimation);
            pnlAttributes.Controls.Add(grpSlide);
            pnlAttributes.Controls.Add(grpSound);
            pnlAttributes.Controls.Add(grpZDimension);
            pnlAttributes.Controls.Add(grpItem);
            pnlAttributes.Controls.Add(grpResource);
            pnlAttributes.Dock = DockStyle.Fill;
            pnlAttributes.Location = new System.Drawing.Point(0, 0);
            pnlAttributes.Name = "pnlAttributes";
            pnlAttributes.Size = new Size(276, 553);
            pnlAttributes.TabIndex = 1;
            // 
            // grpFishingSpot
            // 
            grpFishingSpot.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpFishingSpot.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpFishingSpot.Controls.Add(chkBlockedFishingSpot);
            grpFishingSpot.Controls.Add(cmbSpotTypeSelect);
            grpFishingSpot.Controls.Add(lblSpotTypeSelect);
            grpFishingSpot.ForeColor = System.Drawing.Color.Gainsboro;
            grpFishingSpot.Location = new System.Drawing.Point(5, 173);
            grpFishingSpot.Name = "grpFishingSpot";
            grpFishingSpot.Size = new Size(255, 102);
            grpFishingSpot.TabIndex = 42;
            grpFishingSpot.TabStop = false;
            grpFishingSpot.Text = "Fishing Spot";
            grpFishingSpot.Visible = false;
            // 
            // chkBlockedFishingSpot
            // 
            chkBlockedFishingSpot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkBlockedFishingSpot.AutoSize = true;
            chkBlockedFishingSpot.Location = new System.Drawing.Point(167, 59);
            chkBlockedFishingSpot.Name = "chkBlockedFishingSpot";
            chkBlockedFishingSpot.Size = new Size(71, 17);
            chkBlockedFishingSpot.TabIndex = 29;
            chkBlockedFishingSpot.Text = "Blocked?";
            chkBlockedFishingSpot.UseVisualStyleBackColor = true;
            // 
            // cmbSpotTypeSelect
            // 
            cmbSpotTypeSelect.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbSpotTypeSelect.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbSpotTypeSelect.BorderStyle = ButtonBorderStyle.Solid;
            cmbSpotTypeSelect.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbSpotTypeSelect.DrawDropdownHoverOutline = false;
            cmbSpotTypeSelect.DrawFocusRectangle = false;
            cmbSpotTypeSelect.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSpotTypeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpotTypeSelect.FlatStyle = FlatStyle.Flat;
            cmbSpotTypeSelect.ForeColor = System.Drawing.Color.Gainsboro;
            cmbSpotTypeSelect.FormattingEnabled = true;
            cmbSpotTypeSelect.Location = new System.Drawing.Point(94, 30);
            cmbSpotTypeSelect.Name = "cmbSpotTypeSelect";
            cmbSpotTypeSelect.Size = new Size(144, 21);
            cmbSpotTypeSelect.TabIndex = 12;
            cmbSpotTypeSelect.Text = null;
            cmbSpotTypeSelect.TextPadding = new Padding(2);
            // 
            // lblSpotTypeSelect
            // 
            lblSpotTypeSelect.AutoSize = true;
            lblSpotTypeSelect.Location = new System.Drawing.Point(13, 33);
            lblSpotTypeSelect.Name = "lblSpotTypeSelect";
            lblSpotTypeSelect.Size = new Size(56, 13);
            lblSpotTypeSelect.TabIndex = 9;
            lblSpotTypeSelect.Text = "Spot Type";
            // 
            // rbFishingSpot
            // 
            rbFishingSpot.AutoSize = true;
            rbFishingSpot.ForeColor = System.Drawing.Color.Gainsboro;
            rbFishingSpot.Location = new System.Drawing.Point(112, 146);
            rbFishingSpot.Name = "rbFishingSpot";
            rbFishingSpot.Size = new Size(83, 17);
            rbFishingSpot.TabIndex = 41;
            rbFishingSpot.Text = "Fishing Spot";
            rbFishingSpot.CheckedChanged += rbFishingSpot_CheckedChanged;
            // 
            // grpCritter
            // 
            grpCritter.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            grpCritter.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            grpCritter.Controls.Add(cmbCritterDirection);
            grpCritter.Controls.Add(lblCritterDirection);
            grpCritter.Controls.Add(chkCritterBlockPlayers);
            grpCritter.Controls.Add(chkCritterIgnoreNpcAvoids);
            grpCritter.Controls.Add(cmbCritterLayer);
            grpCritter.Controls.Add(lblCritterLayer);
            grpCritter.Controls.Add(lblCritterMoveFrequency);
            grpCritter.Controls.Add(lblCritterMoveSpeed);
            grpCritter.Controls.Add(nudCritterMoveFrequency);
            grpCritter.Controls.Add(nudCritterMoveSpeed);
            grpCritter.Controls.Add(cmbCritterMovement);
            grpCritter.Controls.Add(lblCritterMovement);
            grpCritter.Controls.Add(cmbCritterSprite);
            grpCritter.Controls.Add(lblCritterSprite);
            grpCritter.Controls.Add(cmbCritterAnimation);
            grpCritter.Controls.Add(lblCritterAnimation);
            grpCritter.ForeColor = System.Drawing.Color.Gainsboro;
            grpCritter.Location = new System.Drawing.Point(6, 179);
            grpCritter.Name = "grpCritter";
            grpCritter.Size = new Size(256, 260);
            grpCritter.TabIndex = 38;
            grpCritter.TabStop = false;
            grpCritter.Text = "Critter";
            grpCritter.Visible = false;
            // 
            // cmbCritterDirection
            // 
            cmbCritterDirection.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbCritterDirection.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbCritterDirection.BorderStyle = ButtonBorderStyle.Solid;
            cmbCritterDirection.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbCritterDirection.DrawDropdownHoverOutline = false;
            cmbCritterDirection.DrawFocusRectangle = false;
            cmbCritterDirection.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCritterDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCritterDirection.FlatStyle = FlatStyle.Flat;
            cmbCritterDirection.ForeColor = System.Drawing.Color.Gainsboro;
            cmbCritterDirection.FormattingEnabled = true;
            cmbCritterDirection.Location = new System.Drawing.Point(82, 132);
            cmbCritterDirection.Name = "cmbCritterDirection";
            cmbCritterDirection.Size = new Size(161, 21);
            cmbCritterDirection.TabIndex = 25;
            cmbCritterDirection.Text = null;
            cmbCritterDirection.TextPadding = new Padding(2);
            // 
            // lblCritterDirection
            // 
            lblCritterDirection.AutoSize = true;
            lblCritterDirection.Location = new System.Drawing.Point(24, 135);
            lblCritterDirection.Name = "lblCritterDirection";
            lblCritterDirection.Size = new Size(52, 13);
            lblCritterDirection.TabIndex = 24;
            lblCritterDirection.Text = "Direction:";
            // 
            // chkCritterBlockPlayers
            // 
            chkCritterBlockPlayers.Location = new System.Drawing.Point(82, 233);
            chkCritterBlockPlayers.Name = "chkCritterBlockPlayers";
            chkCritterBlockPlayers.Size = new Size(162, 21);
            chkCritterBlockPlayers.TabIndex = 23;
            chkCritterBlockPlayers.Text = "Block Players";
            // 
            // chkCritterIgnoreNpcAvoids
            // 
            chkCritterIgnoreNpcAvoids.Location = new System.Drawing.Point(82, 212);
            chkCritterIgnoreNpcAvoids.Name = "chkCritterIgnoreNpcAvoids";
            chkCritterIgnoreNpcAvoids.Size = new Size(162, 21);
            chkCritterIgnoreNpcAvoids.TabIndex = 22;
            chkCritterIgnoreNpcAvoids.Text = "Ignore Npc Avoids";
            // 
            // cmbCritterLayer
            // 
            cmbCritterLayer.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbCritterLayer.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbCritterLayer.BorderStyle = ButtonBorderStyle.Solid;
            cmbCritterLayer.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbCritterLayer.DrawDropdownHoverOutline = false;
            cmbCritterLayer.DrawFocusRectangle = false;
            cmbCritterLayer.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCritterLayer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCritterLayer.FlatStyle = FlatStyle.Flat;
            cmbCritterLayer.ForeColor = System.Drawing.Color.Gainsboro;
            cmbCritterLayer.FormattingEnabled = true;
            cmbCritterLayer.Location = new System.Drawing.Point(82, 105);
            cmbCritterLayer.Name = "cmbCritterLayer";
            cmbCritterLayer.Size = new Size(161, 21);
            cmbCritterLayer.TabIndex = 21;
            cmbCritterLayer.Text = null;
            cmbCritterLayer.TextPadding = new Padding(2);
            // 
            // lblCritterLayer
            // 
            lblCritterLayer.AutoSize = true;
            lblCritterLayer.Location = new System.Drawing.Point(40, 111);
            lblCritterLayer.Name = "lblCritterLayer";
            lblCritterLayer.Size = new Size(36, 13);
            lblCritterLayer.TabIndex = 20;
            lblCritterLayer.Text = "Layer:";
            // 
            // lblCritterMoveFrequency
            // 
            lblCritterMoveFrequency.AutoSize = true;
            lblCritterMoveFrequency.Location = new System.Drawing.Point(13, 187);
            lblCritterMoveFrequency.Name = "lblCritterMoveFrequency";
            lblCritterMoveFrequency.Size = new Size(79, 13);
            lblCritterMoveFrequency.TabIndex = 19;
            lblCritterMoveFrequency.Text = "Frequency (ms)";
            // 
            // lblCritterMoveSpeed
            // 
            lblCritterMoveSpeed.AutoSize = true;
            lblCritterMoveSpeed.Location = new System.Drawing.Point(13, 161);
            lblCritterMoveSpeed.Name = "lblCritterMoveSpeed";
            lblCritterMoveSpeed.Size = new Size(63, 13);
            lblCritterMoveSpeed.TabIndex = 18;
            lblCritterMoveSpeed.Text = "Speed (ms):";
            // 
            // nudCritterMoveFrequency
            // 
            nudCritterMoveFrequency.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudCritterMoveFrequency.ForeColor = System.Drawing.Color.Gainsboro;
            nudCritterMoveFrequency.Location = new System.Drawing.Point(98, 185);
            nudCritterMoveFrequency.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCritterMoveFrequency.Name = "nudCritterMoveFrequency";
            nudCritterMoveFrequency.Size = new Size(145, 20);
            nudCritterMoveFrequency.TabIndex = 17;
            nudCritterMoveFrequency.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // nudCritterMoveSpeed
            // 
            nudCritterMoveSpeed.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            nudCritterMoveSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            nudCritterMoveSpeed.Location = new System.Drawing.Point(82, 159);
            nudCritterMoveSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCritterMoveSpeed.Name = "nudCritterMoveSpeed";
            nudCritterMoveSpeed.Size = new Size(161, 20);
            nudCritterMoveSpeed.TabIndex = 16;
            nudCritterMoveSpeed.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // cmbCritterMovement
            // 
            cmbCritterMovement.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbCritterMovement.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbCritterMovement.BorderStyle = ButtonBorderStyle.Solid;
            cmbCritterMovement.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbCritterMovement.DrawDropdownHoverOutline = false;
            cmbCritterMovement.DrawFocusRectangle = false;
            cmbCritterMovement.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCritterMovement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCritterMovement.FlatStyle = FlatStyle.Flat;
            cmbCritterMovement.ForeColor = System.Drawing.Color.Gainsboro;
            cmbCritterMovement.FormattingEnabled = true;
            cmbCritterMovement.Location = new System.Drawing.Point(82, 78);
            cmbCritterMovement.Name = "cmbCritterMovement";
            cmbCritterMovement.Size = new Size(161, 21);
            cmbCritterMovement.TabIndex = 15;
            cmbCritterMovement.Text = null;
            cmbCritterMovement.TextPadding = new Padding(2);
            // 
            // lblCritterMovement
            // 
            lblCritterMovement.AutoSize = true;
            lblCritterMovement.Location = new System.Drawing.Point(16, 81);
            lblCritterMovement.Name = "lblCritterMovement";
            lblCritterMovement.Size = new Size(60, 13);
            lblCritterMovement.TabIndex = 14;
            lblCritterMovement.Text = "Movement:";
            // 
            // cmbCritterSprite
            // 
            cmbCritterSprite.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbCritterSprite.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbCritterSprite.BorderStyle = ButtonBorderStyle.Solid;
            cmbCritterSprite.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbCritterSprite.DrawDropdownHoverOutline = false;
            cmbCritterSprite.DrawFocusRectangle = false;
            cmbCritterSprite.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCritterSprite.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCritterSprite.FlatStyle = FlatStyle.Flat;
            cmbCritterSprite.ForeColor = System.Drawing.Color.Gainsboro;
            cmbCritterSprite.FormattingEnabled = true;
            cmbCritterSprite.Location = new System.Drawing.Point(82, 24);
            cmbCritterSprite.Name = "cmbCritterSprite";
            cmbCritterSprite.Size = new Size(161, 21);
            cmbCritterSprite.TabIndex = 13;
            cmbCritterSprite.Text = null;
            cmbCritterSprite.TextPadding = new Padding(2);
            // 
            // lblCritterSprite
            // 
            lblCritterSprite.AutoSize = true;
            lblCritterSprite.Location = new System.Drawing.Point(42, 27);
            lblCritterSprite.Name = "lblCritterSprite";
            lblCritterSprite.Size = new Size(34, 13);
            lblCritterSprite.TabIndex = 12;
            lblCritterSprite.Text = "Sprite";
            // 
            // cmbCritterAnimation
            // 
            cmbCritterAnimation.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbCritterAnimation.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbCritterAnimation.BorderStyle = ButtonBorderStyle.Solid;
            cmbCritterAnimation.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbCritterAnimation.DrawDropdownHoverOutline = false;
            cmbCritterAnimation.DrawFocusRectangle = false;
            cmbCritterAnimation.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCritterAnimation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCritterAnimation.FlatStyle = FlatStyle.Flat;
            cmbCritterAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            cmbCritterAnimation.FormattingEnabled = true;
            cmbCritterAnimation.Location = new System.Drawing.Point(82, 51);
            cmbCritterAnimation.Name = "cmbCritterAnimation";
            cmbCritterAnimation.Size = new Size(161, 21);
            cmbCritterAnimation.TabIndex = 11;
            cmbCritterAnimation.Text = null;
            cmbCritterAnimation.TextPadding = new Padding(2);
            // 
            // lblCritterAnimation
            // 
            lblCritterAnimation.AutoSize = true;
            lblCritterAnimation.Location = new System.Drawing.Point(23, 54);
            lblCritterAnimation.Name = "lblCritterAnimation";
            lblCritterAnimation.Size = new Size(53, 13);
            lblCritterAnimation.TabIndex = 10;
            lblCritterAnimation.Text = "Animation";
            // 
            // rbCritter
            // 
            rbCritter.AutoSize = true;
            rbCritter.ForeColor = System.Drawing.Color.Gainsboro;
            rbCritter.Location = new System.Drawing.Point(115, 73);
            rbCritter.Name = "rbCritter";
            rbCritter.Size = new Size(52, 17);
            rbCritter.TabIndex = 37;
            rbCritter.Text = "Critter";
            rbCritter.CheckedChanged += rbCritter_CheckedChanged;
            // 
            // pnlNpcs
            // 
            pnlNpcs.Controls.Add(grpNpcList);
            pnlNpcs.Controls.Add(lblNpcCount);
            pnlNpcs.Controls.Add(lstMapNpcs);
            pnlNpcs.Controls.Add(grpSpawnLoc);
            pnlNpcs.Controls.Add(grpSpawnDirection);
            pnlNpcs.Controls.Add(btnNpcPulseColor);
            pnlNpcs.Dock = DockStyle.Fill;
            pnlNpcs.Location = new System.Drawing.Point(0, 0);
            pnlNpcs.Name = "pnlNpcs";
            pnlNpcs.Size = new Size(276, 553);
            pnlNpcs.TabIndex = 1;
            // 
            // pnlTiles
            // 
            pnlTiles.Controls.Add(cmbMapLayer);
            pnlTiles.Controls.Add(picLayer5);
            pnlTiles.Controls.Add(picLayer4);
            pnlTiles.Controls.Add(picLayer3);
            pnlTiles.Controls.Add(picLayer2);
            pnlTiles.Controls.Add(picLayer1);
            pnlTiles.Controls.Add(lblLayer);
            pnlTiles.Controls.Add(cmbTilesets);
            pnlTiles.Controls.Add(lblTileType);
            pnlTiles.Controls.Add(cmbAutotile);
            pnlTiles.Controls.Add(lblTileset);
            pnlTiles.Controls.Add(pnlTilesetContainer);
            pnlTiles.Dock = DockStyle.Fill;
            pnlTiles.Location = new System.Drawing.Point(0, 0);
            pnlTiles.Name = "pnlTiles";
            pnlTiles.Size = new Size(276, 553);
            pnlTiles.TabIndex = 0;
            // 
            // cmbMapLayer
            // 
            cmbMapLayer.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            cmbMapLayer.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            cmbMapLayer.BorderStyle = ButtonBorderStyle.Solid;
            cmbMapLayer.ButtonColor = System.Drawing.Color.FromArgb(43, 43, 43);
            cmbMapLayer.DrawDropdownHoverOutline = false;
            cmbMapLayer.DrawFocusRectangle = false;
            cmbMapLayer.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMapLayer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMapLayer.FlatStyle = FlatStyle.Flat;
            cmbMapLayer.ForeColor = System.Drawing.Color.Gainsboro;
            cmbMapLayer.FormattingEnabled = true;
            cmbMapLayer.Location = new System.Drawing.Point(84, 7);
            cmbMapLayer.Name = "cmbMapLayer";
            cmbMapLayer.Size = new Size(178, 21);
            cmbMapLayer.TabIndex = 29;
            cmbMapLayer.Text = null;
            cmbMapLayer.TextPadding = new Padding(2);
            cmbMapLayer.SelectedIndexChanged += cmbMapLayer_SelectedIndexChanged;
            // 
            // picLayer5
            // 
            picLayer5.Location = new System.Drawing.Point(232, 2);
            picLayer5.Name = "picLayer5";
            picLayer5.Size = new Size(30, 32);
            picLayer5.TabIndex = 28;
            picLayer5.TabStop = false;
            picLayer5.MouseClick += picMapLayer_MouseClick;
            picLayer5.MouseHover += picMapLayer_MouseHover;
            // 
            // picLayer4
            // 
            picLayer4.Location = new System.Drawing.Point(195, 2);
            picLayer4.Name = "picLayer4";
            picLayer4.Size = new Size(30, 32);
            picLayer4.TabIndex = 27;
            picLayer4.TabStop = false;
            picLayer4.MouseClick += picMapLayer_MouseClick;
            picLayer4.MouseHover += picMapLayer_MouseHover;
            // 
            // picLayer3
            // 
            picLayer3.Location = new System.Drawing.Point(158, 2);
            picLayer3.Name = "picLayer3";
            picLayer3.Size = new Size(30, 32);
            picLayer3.TabIndex = 26;
            picLayer3.TabStop = false;
            picLayer3.MouseClick += picMapLayer_MouseClick;
            picLayer3.MouseHover += picMapLayer_MouseHover;
            // 
            // picLayer2
            // 
            picLayer2.Location = new System.Drawing.Point(121, 2);
            picLayer2.Name = "picLayer2";
            picLayer2.Size = new Size(30, 32);
            picLayer2.TabIndex = 25;
            picLayer2.TabStop = false;
            picLayer2.MouseClick += picMapLayer_MouseClick;
            picLayer2.MouseHover += picMapLayer_MouseHover;
            // 
            // picLayer1
            // 
            picLayer1.Location = new System.Drawing.Point(84, 2);
            picLayer1.Name = "picLayer1";
            picLayer1.Size = new Size(30, 32);
            picLayer1.TabIndex = 24;
            picLayer1.TabStop = false;
            picLayer1.MouseClick += picMapLayer_MouseClick;
            picLayer1.MouseHover += picMapLayer_MouseHover;
            // 
            // pnlTilesetContainer
            // 
            pnlTilesetContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTilesetContainer.AutoScroll = true;
            pnlTilesetContainer.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            pnlTilesetContainer.Controls.Add(picTileset);
            pnlTilesetContainer.Location = new System.Drawing.Point(9, 96);
            pnlTilesetContainer.Name = "pnlTilesetContainer";
            pnlTilesetContainer.Size = new Size(264, 449);
            pnlTilesetContainer.TabIndex = 19;
            // 
            // picTileset
            // 
            picTileset.Location = new System.Drawing.Point(0, 0);
            picTileset.Name = "picTileset";
            picTileset.Size = new Size(167, 148);
            picTileset.TabIndex = 2;
            picTileset.TabStop = false;
            picTileset.MouseDown += picTileset_MouseDown;
            picTileset.MouseMove += picTileset_MouseMove;
            picTileset.MouseUp += picTileset_MouseUp;
            // 
            // pnlEvents
            // 
            pnlEvents.Controls.Add(lblEventInstructions);
            pnlEvents.Dock = DockStyle.Fill;
            pnlEvents.Location = new System.Drawing.Point(0, 0);
            pnlEvents.Name = "pnlEvents";
            pnlEvents.Size = new Size(276, 553);
            pnlEvents.TabIndex = 1;
            // 
            // pnlLights
            // 
            pnlLights.Controls.Add(lightEditor);
            pnlLights.Controls.Add(lblLightInstructions);
            pnlLights.Dock = DockStyle.Fill;
            pnlLights.Location = new System.Drawing.Point(0, 0);
            pnlLights.Name = "pnlLights";
            pnlLights.Size = new Size(276, 553);
            pnlLights.TabIndex = 1;
            // 
            // lightEditor
            // 
            lightEditor.ForeColor = System.Drawing.Color.Gainsboro;
            lightEditor.Location = new System.Drawing.Point(6, 6);
            lightEditor.Margin = new Padding(4, 3, 4, 3);
            lightEditor.Name = "lightEditor";
            lightEditor.Size = new Size(256, 358);
            lightEditor.TabIndex = 2;
            lightEditor.Visible = false;
            lightEditor.Load += lightEditor_Load;
            // 
            // FrmMapLayers
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(312, 592);
            CloseButton = false;
            CloseButtonVisible = false;
            ControlBox = false;
            Controls.Add(btnAttributeHeader);
            Controls.Add(panel1);
            Controls.Add(btnNpcsHeader);
            Controls.Add(btnEventsHeader);
            Controls.Add(btnLightsHeader);
            Controls.Add(btnTileHeader);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HideOnClose = true;
            MinimumSize = new Size(314, 250);
            Name = "FrmMapLayers";
            Text = "Map Layers";
            DockStateChanged += frmMapLayers_DockStateChanged;
            Load += frmMapLayers_Load;
            grpResource.ResumeLayout(false);
            grpResource.PerformLayout();
            grpZResource.ResumeLayout(false);
            grpZResource.PerformLayout();
            grpItem.ResumeLayout(false);
            grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudItemRespawnTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItemQuantity).EndInit();
            grpWarp.ResumeLayout(false);
            grpWarp.PerformLayout();
            grpInstanceSettings.ResumeLayout(false);
            grpInstanceSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarpY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWarpX).EndInit();
            grpZDimension.ResumeLayout(false);
            grpGateway.ResumeLayout(false);
            grpGateway.PerformLayout();
            grpDimBlock.ResumeLayout(false);
            grpDimBlock.PerformLayout();
            grpSound.ResumeLayout(false);
            grpSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoundLoopInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoundDistance).EndInit();
            grpSlide.ResumeLayout(false);
            grpSlide.PerformLayout();
            grpAnimation.ResumeLayout(false);
            grpAnimation.PerformLayout();
            grpNpcList.ResumeLayout(false);
            grpSpawnLoc.ResumeLayout(false);
            grpSpawnLoc.PerformLayout();
            grpSpawnDirection.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlAttributes.ResumeLayout(false);
            pnlAttributes.PerformLayout();
            grpFishingSpot.ResumeLayout(false);
            grpFishingSpot.PerformLayout();
            grpCritter.ResumeLayout(false);
            grpCritter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCritterMoveFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCritterMoveSpeed).EndInit();
            pnlNpcs.ResumeLayout(false);
            pnlNpcs.PerformLayout();
            pnlTiles.ResumeLayout(false);
            pnlTiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLayer5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLayer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLayer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLayer1).EndInit();
            pnlTilesetContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTileset).EndInit();
            pnlEvents.ResumeLayout(false);
            pnlEvents.PerformLayout();
            pnlLights.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Label lblTileset;
        private AutoDragPanel pnlTilesetContainer;
        public System.Windows.Forms.PictureBox picTileset;
        private DarkComboBox cmbAutotile;
        public DarkComboBox cmbTilesets;
        private DarkRadioButton rbResource;
        private DarkRadioButton rbSound;
        private DarkRadioButton rbWarp;
        private DarkRadioButton rbNPCAvoid;
        private DarkRadioButton rbZDimension;
        private DarkRadioButton rbItem;
        private DarkRadioButton rbBlocked;
        private DarkGroupBox grpResource;
        private DarkGroupBox grpSound;
        public DarkComboBox cmbMapAttributeSound;
        private System.Windows.Forms.Label lblSoundDistance;
        private System.Windows.Forms.Label lblMapSound;
        private DarkGroupBox grpItem;
        private System.Windows.Forms.Label lblMaxItemAmount;
        private System.Windows.Forms.Label lblMapItem;
        private DarkGroupBox grpWarp;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMap;
        private DarkGroupBox grpZDimension;
        private DarkGroupBox grpGateway;
        private DarkRadioButton rbGateway2;
        private DarkRadioButton rbGateway1;
        private DarkRadioButton rbGatewayNone;
        private DarkGroupBox grpDimBlock;
        private DarkRadioButton rbBlock2;
        private DarkRadioButton rbBlock1;
        private DarkRadioButton rbBlockNone;
        private System.Windows.Forms.Label lblLayer;
        private DarkGroupBox grpNpcList;
        private DarkButton btnRemoveMapNpc;
        private DarkButton btnAddMapNpc;
        private DarkComboBox cmbNpc;
        private DarkGroupBox grpSpawnLoc;
        private DarkGroupBox grpSpawnDirection;
        private DarkComboBox cmbDir;
        public DarkRadioButton rbRandom;
        public DarkRadioButton rbDeclared;
        private Label lblNpcCount;
        public System.Windows.Forms.ListBox lstMapNpcs;
        private ColorDialog npcColorPulseDialog;
        private System.Windows.Forms.Label lblLightInstructions;
        private System.Windows.Forms.Label lblEventInstructions;
        public Controls.LightEditorCtrl lightEditor;
        private DarkComboBox cmbResourceAttribute;
        private System.Windows.Forms.Label lblResource;
        private DarkComboBox cmbItemAttribute;
        private DarkComboBox cmbWarpMap;
        private DarkButton btnVisualMapSelector;
        private DarkComboBox cmbDirection;
        private System.Windows.Forms.Label lblWarpDir;
        private DarkGroupBox grpAnimation;
        private DarkComboBox cmbAnimationAttribute;
        private System.Windows.Forms.Label lblAnimation;
        private DarkRadioButton rbAnimation;
        private DarkRadioButton rbSlide;
        private DarkRadioButton rbGrappleStone;
        private DarkGroupBox grpSlide;
        private DarkComboBox cmbSlideDir;
        private System.Windows.Forms.Label lblSlideDir;
        private DarkGroupBox grpZResource;
        private DarkRadioButton rbLevel2;
        private DarkRadioButton rbLevel1;
        private DarkUI.Controls.DarkButton btnTileHeader;
        private DarkUI.Controls.DarkButton btnAttributeHeader;
        private DarkUI.Controls.DarkButton btnLightsHeader;
        private DarkUI.Controls.DarkButton btnEventsHeader;
        private DarkUI.Controls.DarkButton btnNpcsHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Panel pnlLights;
        private System.Windows.Forms.Panel pnlNpcs;
        private System.Windows.Forms.Panel pnlAttributes;
        private System.Windows.Forms.Panel pnlTiles;
        private PictureBox picLayer5;
        private PictureBox picLayer4;
        private PictureBox picLayer3;
        private PictureBox picLayer2;
        private PictureBox picLayer1;
        private DarkNumericUpDown nudWarpY;
        private DarkNumericUpDown nudWarpX;
        private DarkNumericUpDown nudItemQuantity;
        private DarkNumericUpDown nudSoundDistance;
        private DarkCheckBox chkAnimationBlock;
        public DarkComboBox cmbMapLayer;
        private DarkNumericUpDown nudSoundLoopInterval;
        private Label lblSoundInterval;
        private DarkRadioButton rbCritter;
        private DarkGroupBox grpCritter;
        private DarkComboBox cmbCritterSprite;
        private Label lblCritterSprite;
        private DarkComboBox cmbCritterAnimation;
        private Label lblCritterAnimation;
        private DarkComboBox cmbCritterMovement;
        private Label lblCritterMovement;
        private Label lblCritterMoveFrequency;
        private Label lblCritterMoveSpeed;
        private DarkNumericUpDown nudCritterMoveFrequency;
        private DarkNumericUpDown nudCritterMoveSpeed;
        private DarkComboBox cmbCritterLayer;
        private Label lblCritterLayer;
        private DarkCheckBox chkCritterBlockPlayers;
        private DarkCheckBox chkCritterIgnoreNpcAvoids;
        private DarkComboBox cmbCritterDirection;
        private Label lblCritterDirection;
        private DarkGroupBox grpInstanceSettings;
        private Label lblInstance;
        private DarkComboBox cmbInstanceType;
        private CheckBox chkChangeInstance;
        private DarkComboBox cmbWarpSound;
        private Label lblWarpSound;
        private DarkNumericUpDown nudItemRespawnTime;
        private Label lblItemRespawnTime;
        private ToolTip tooltips;
        private DarkGroupBox grpFishingSpot;
        private CheckBox chkBlockedFishingSpot;
        private DarkComboBox cmbSpotTypeSelect;
        private Label lblSpotTypeSelect;
        private DarkRadioButton rbFishingSpot;
        private DarkButton btnNpcPulseColor;
    }
}
