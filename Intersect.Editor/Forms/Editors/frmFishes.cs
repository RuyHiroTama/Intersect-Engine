using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DarkUI.Forms;

using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Models;
using MathNet.Numerics.RootFinding;
using System.Drawing.Imaging;
using Intersect.Utilities;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Drawing.Drawing2D;
using WeifenLuo.WinFormsUI.Docking;
using Intersect.Editor.Core;
using Graphics = System.Drawing.Graphics;

namespace Intersect.Editor.Forms.Editors
{

    public partial class FrmFishes : EditorForm
    {

        private List<FishBase> mChanged = new List<FishBase>();

        private string mCopiedItem;

        private FishBase currentFishEdit;

        private List<string> mKnownFolders = new List<string>();

        private bool isLoaded = false;

        public FrmFishes()
        {
            ApplyHooks();
            InitializeComponent();
            Icon = Program.Icon;

            lstGameObjects.LostFocus += itemList_FocusChanged;
            lstGameObjects.GotFocus += itemList_FocusChanged;
            cmbFishItem.Items.Clear();
            cmbFishItem.Items.Add(Strings.General.None);
            cmbFishItem.Items.AddRange(ItemBase.Names);

            cmbEvent.Items.Clear();
            cmbEvent.Items.Add(Strings.General.None);
            cmbEvent.Items.AddRange(EventBase.Names);

            lstGameObjects.Init(UpdateToolStripItems, AssignEditorItem, toolStripItemNew_Click, toolStripItemCopy_Click, toolStripItemUndo_Click, toolStripItemPaste_Click, toolStripItemDelete_Click);

        }
        private void AssignEditorItem(Guid id)
        {
            currentFishEdit = FishBase.Get(id);

            UpdateEditor();
        }

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type == GameObjectType.Fishes)
            {
                InitEditor();
                if (currentFishEdit != null && !DatabaseObject<FishBase>.Lookup.Values.Contains(currentFishEdit))
                {
                    currentFishEdit = null;
                    UpdateEditor();
                }
            }
        }

        private void UpdateEditor()
        {

            if (currentFishEdit != null)
            {
                isLoaded = false;
                pnlContainer.Show();

                txtName.Text = currentFishEdit.Name;

                cmbFolder.Text = currentFishEdit.Folder;

                nudChance.Value = currentFishEdit.chance;
                nudCoeffUnpredictability.Value = currentFishEdit.coeffUnpredictability;
                nudPosition.Value = currentFishEdit.position;
                nudPushStrength.Value = currentFishEdit.pushStrength;
                nudRangeSize.Value = currentFishEdit.rangeSize;
                nudSpeedMove.Value = currentFishEdit.speedMove;
                nudSpeedResize.Value = currentFishEdit.speedChangeRangeSize;
                nudStrength.Value = currentFishEdit.strength;
                nudWeight.Value = currentFishEdit.weight;
                nudTimeChangeRangeSize.Value = currentFishEdit.timeChangeRangeSize;
                nudTimeChangeSpeed.Value = currentFishEdit.timeChangeSpeed;

                cmbFishItem.SelectedIndex = ItemBase.ListIndex(currentFishEdit.ItemId) + 1;

                picFish.BackgroundImage?.Dispose();
                picFish.BackgroundImage = null;
                if (cmbFishItem.SelectedIndex > 0)
                {
                    DrawItemIcon(ItemBase.Get(currentFishEdit.ItemId));
                }

                if (mChanged.IndexOf(currentFishEdit) == -1)
                {
                    mChanged.Add(currentFishEdit);
                    currentFishEdit.MakeBackup();
                }

                cmbEvent.SelectedIndex = EventBase.ListIndex(currentFishEdit.EventId) + 1;
                isLoaded = true;
            }
            else
            {
                pnlContainer.Hide();
            }

            UpdateToolStripItems();
        }

        #region Button Save&Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var item in mChanged)
            {
                item.RestoreBackup();
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Send Changed items
            foreach (var item in mChanged)
            {
                PacketSender.SendSaveObject(item);
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }
        #endregion

        #region Tools

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.Fishes);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (currentFishEdit != null && lstGameObjects.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.FishesEditor.deleteprompt, Strings.FishesEditor.deletetitle, DarkDialogButton.YesNo,
                        Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(currentFishEdit);
                }
            }
        }

        private void toolStripItemCopy_Click(object sender, EventArgs e)
        {
            if (currentFishEdit != null && lstGameObjects.Focused)
            {
                mCopiedItem = currentFishEdit.JsonData;
                toolStripItemPaste.Enabled = true;
            }
        }

        private void toolStripItemPaste_Click(object sender, EventArgs e)
        {
            if (currentFishEdit != null && mCopiedItem != null && lstGameObjects.Focused)
            {
                currentFishEdit.Load(mCopiedItem, true);
                UpdateEditor();
            }
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(currentFishEdit) && currentFishEdit != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.FishesEditor.undoprompt, Strings.FishesEditor.undotitle, DarkDialogButton.YesNo,
                        Icon
                    ) ==
                    DialogResult.Yes)
                {
                    currentFishEdit.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        #endregion

        #region Fields

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFishEdit.Event = EventBase.Get(EventBase.IdFromList(cmbEvent.SelectedIndex - 1));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            currentFishEdit.Name = txtName.Text;
            lstGameObjects.UpdateText(txtName.Text);
        }
        private void ChangeValues(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            currentFishEdit.chance = (int)nudChance.Value;
            currentFishEdit.coeffUnpredictability = (int)nudCoeffUnpredictability.Value;
            currentFishEdit.position = (int)nudPosition.Value;
            currentFishEdit.pushStrength = (int)nudPushStrength.Value;
            currentFishEdit.rangeSize = (int)nudRangeSize.Value;
            currentFishEdit.speedMove = (int)nudSpeedMove.Value;
            currentFishEdit.speedChangeRangeSize = (int)nudSpeedResize.Value;
            currentFishEdit.strength = (int)nudStrength.Value;
            currentFishEdit.weight = (int)nudWeight.Value;
            currentFishEdit.timeChangeRangeSize = (int)nudTimeChangeRangeSize.Value;
            currentFishEdit.timeChangeSpeed = (int)nudTimeChangeSpeed.Value;

        }
        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFishEdit.ItemId = ItemBase.IdFromList(cmbFishItem.SelectedIndex - 1);
            var itm = ItemBase.Get(currentFishEdit.ItemId);
            picFish.BackgroundImage?.Dispose();
            picFish.BackgroundImage = null;
            if (cmbFishItem.SelectedIndex > 0)
            {
                DrawItemIcon(ItemBase.Get(currentFishEdit.ItemId));
            }
        }
        private void DrawItemIcon(ItemBase item)
        {
            Bitmap picItemBmp = new Bitmap(picFish.Width, picFish.Height);
            Graphics gfx = Graphics.FromImage(picItemBmp);
            gfx.FillRectangle(Brushes.Black, new Rectangle(0, 0, picFish.Width, picFish.Height));
            if (item != null)
            {
                Image img = Image.FromFile("resources/items/" + TextUtils.NullToNone(item.Icon));
                if (img == null)
                {
                    picFish.BackgroundImage = null;
                    return;
                }
                ImageAttributes imgAttributes = new ImageAttributes();

                // Microsoft, what the heck is this crap?
                imgAttributes.SetColorMatrix(
                    new ColorMatrix(
                        new float[][]
                        {
                            new float[] { (float)item.Color.R / 255,  0,  0,  0, 0},  // Modify the red space
                            new float[] {0, (float)item.Color.G / 255,  0,  0, 0},    // Modify the green space
                            new float[] {0,  0, (float)item.Color.B / 255,  0, 0},    // Modify the blue space
                            new float[] {0,  0,  0, (float)item.Color.A / 255, 0},    // Modify the alpha space
                            new float[] {0, 0, 0, 0, 1}                                 // We're not adding any non-linear changes. Value of 1 at the end is a dummy value!
                        }
                    )
                );

                int[] size = new int[] { picFish.Size.Width, picFish.Size.Height };

                picItemBmp = new Bitmap(img, size[0], size[1]);
                picItemBmp = resizeImage(img, size[0], size[1], imgAttributes);

                img.Dispose();
                imgAttributes.Dispose();
            }


            picFish.BackgroundImage = picItemBmp;
        }

        Bitmap resizeImage(Image image, int width, int height, ImageAttributes imgAttributes)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = imgAttributes)
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height,
                                       GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destinationImage;
        }
        #endregion

        #region HotKeys

        private void itemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Z)
                {
                    toolStripItemUndo_Click(null, null);
                }
                else if (e.KeyCode == Keys.V)
                {
                    toolStripItemPaste_Click(null, null);
                }
                else if (e.KeyCode == Keys.C)
                {
                    toolStripItemCopy_Click(null, null);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Delete)
                {
                    toolStripItemDelete_Click(null, null);
                }
            }
        }

        private void UpdateToolStripItems()
        {
            toolStripItemCopy.Enabled = currentFishEdit != null && lstGameObjects.Focused;
            toolStripItemPaste.Enabled = currentFishEdit != null && mCopiedItem != null && lstGameObjects.Focused;
            toolStripItemDelete.Enabled = currentFishEdit != null && lstGameObjects.Focused;
            toolStripItemUndo.Enabled = currentFishEdit != null && lstGameObjects.Focused;
        }

        private void itemList_FocusChanged(object sender, EventArgs e)
        {
            UpdateToolStripItems();
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    toolStripItemNew_Click(null, null);
                }
            }
        }

        #endregion

        #region Localization

        private void frmFishes_Load(object sender, EventArgs e)
        {
            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.FishesEditor.title;
            toolStripItemNew.Text = Strings.FishesEditor.New;
            toolStripItemDelete.Text = Strings.FishesEditor.delete;
            toolStripItemCopy.Text = Strings.FishesEditor.copy;
            toolStripItemPaste.Text = Strings.FishesEditor.paste;
            toolStripItemUndo.Text = Strings.FishesEditor.undo;

            grpFishes.Text = Strings.FishesEditor.fishes;

            grpGeneral.Text = Strings.FishesEditor.general;
            lblName.Text = Strings.FishesEditor.name;
            lblFishItem.Text = Strings.FishesEditor.item;

            grpParameters.Text = Strings.FishesEditor.parameters;
            lblCommonEvent.Text = Strings.FishesEditor.commonevent;

            //Searching/Sorting
            btnAlphabetical.ToolTipText = Strings.FishesEditor.sortalphabetically;
            txtSearch.Text = Strings.FishesEditor.searchplaceholder;
            lblFolder.Text = Strings.FishesEditor.folderlabel;

            btnSave.Text = Strings.FishesEditor.save;
            btnCancel.Text = Strings.FishesEditor.cancel;
            lblChance.Text = Strings.FishesEditor.chance;
            lblCoeffUnpredictability.Text = Strings.FishesEditor.coeffUnpredictability;
            lblPosition.Text = Strings.FishesEditor.position;
            lblPushStrength.Text = Strings.FishesEditor.pushStrength;
            lblRangeSize.Text = Strings.FishesEditor.rangeSize;
            lblSpeedMove.Text = Strings.FishesEditor.speedMove;
            lblSpeedResize.Text = Strings.FishesEditor.speedResize;
            lblStrength.Text = Strings.FishesEditor.strength;
            lblTimeChangeRangeSize.Text = Strings.FishesEditor.timeChangeRangeSize;
            lblTimeChangeSpeed.Text = Strings.FishesEditor.nudTimeChangeSpeed;
            lblWeight.Text = Strings.FishesEditor.weight;
        }

        #endregion

        #region "Item List - Folders, Searching, Sorting, Etc"
        public void InitEditor()
        {
            //Collect folders
            var mFolders = new List<string>();
            foreach (var itm in FishBase.Lookup)
            {
                if (!string.IsNullOrEmpty(((FishBase)itm.Value).Folder) &&
                    !mFolders.Contains(((FishBase)itm.Value).Folder))
                {
                    mFolders.Add(((FishBase)itm.Value).Folder);
                    if (!mKnownFolders.Contains(((FishBase)itm.Value).Folder))
                    {
                        mKnownFolders.Add(((FishBase)itm.Value).Folder);
                    }
                }
            }

            mFolders.Sort();
            mKnownFolders.Sort();
            cmbFolder.Items.Clear();
            cmbFolder.Items.Add("");
            cmbFolder.Items.AddRange(mKnownFolders.ToArray());

            var items = FishBase.Lookup.OrderBy(p => p.Value?.Name).Select(pair => new KeyValuePair<Guid, KeyValuePair<string, string>>(pair.Key,
                new KeyValuePair<string, string>(((FishBase)pair.Value)?.Name ?? Models.DatabaseObject<FishBase>.Deleted, ((FishBase)pair.Value)?.Folder ?? ""))).ToArray();
            lstGameObjects.Repopulate(items, mFolders, btnAlphabetical.Checked, CustomSearch(), txtSearch.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderName = "";
            var result = DarkInputBox.ShowInformation(
                Strings.FishesEditor.folderprompt, Strings.FishesEditor.foldertitle, ref folderName,
                DarkDialogButton.OkCancel
            );

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderName))
            {
                if (!cmbFolder.Items.Contains(folderName))
                {
                    currentFishEdit.Folder = folderName;
                    lstGameObjects.ExpandFolder(folderName);
                    InitEditor();
                    cmbFolder.Text = folderName;
                }
            }
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFishEdit.Folder = cmbFolder.Text;
            InitEditor();
        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
            btnAlphabetical.Checked = !btnAlphabetical.Checked;
            InitEditor();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            InitEditor();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = Strings.FishesEditor.searchplaceholder;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = Strings.FishesEditor.searchplaceholder;
        }

        private bool CustomSearch()
        {
            return !string.IsNullOrWhiteSpace(txtSearch.Text) &&
                   txtSearch.Text != Strings.FishesEditor.searchplaceholder;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == Strings.FishesEditor.searchplaceholder)
            {
                txtSearch.SelectAll();
            }
        }

        #endregion

        private void btnFishRequirements_Click(object sender, EventArgs e)
        {
            var frm = new FrmDynamicRequirements(currentFishEdit.FishingRequirements, RequirementType.Fish);
            frm.ShowDialog();   
        }
    }

}
