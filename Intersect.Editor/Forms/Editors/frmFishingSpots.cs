using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DarkUI.Forms;
using Intersect.Editor.Core;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects;
using Intersect.Models;

namespace Intersect.Editor.Forms.Editors
{

    public partial class FrmFishingSpots : EditorForm
    {

        private List<FishingSpotBase> mChanged = new List<FishingSpotBase>();

        private string mCopiedItem;

        private FishingSpotBase currentSpotEdit;

        private List<string> mKnownFolders = new List<string>();

        private bool isLoaded = false;
        public FrmFishingSpots()
        {
            ApplyHooks();
            InitializeComponent();
            Icon = Program.Icon;

            lstGameObjects.Init(UpdateToolStripItems, AssignEditorItem, toolStripItemNew_Click, toolStripItemCopy_Click, toolStripItemUndo_Click, toolStripItemPaste_Click, toolStripItemDelete_Click);
        }
        private void AssignEditorItem(Guid id)
        {
            currentSpotEdit = FishingSpotBase.Get(id);
            UpdateEditor();
        }

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type == GameObjectType.FishingSpot)
            {
                InitEditor();
                if (currentSpotEdit != null && !DatabaseObject<FishingSpotBase>.Lookup.Values.Contains(currentSpotEdit))
                {
                    currentSpotEdit = null;
                    UpdateEditor();
                }
            }
        }

        private void UpdateEditor()
        {
            if (currentSpotEdit != null)
            {
                isLoaded = false;
                pnlContainer.Show();

                txtName.Text = currentSpotEdit.Name;
                nudFishingTimeMax.Value = currentSpotEdit.FishingTimeMax;
                nudFishingTimeMin.Value = currentSpotEdit.FishingTimeMin;
                cmbFolder.Text = currentSpotEdit.Folder;

                UpdateList();

                if (mChanged.IndexOf(currentSpotEdit) == -1)
                {
                    mChanged.Add(currentSpotEdit);
                    currentSpotEdit.MakeBackup();
                }
                isLoaded = true;
            }
            else
            {
                pnlContainer.Hide();
            }

            UpdateToolStripItems();
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            currentSpotEdit.FishingTimeMin = (int)nudFishingTimeMin.Value;
            currentSpotEdit.FishingTimeMax = (int)nudFishingTimeMax.Value;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            currentSpotEdit.Name = txtName.Text;
            lstGameObjects.UpdateText(txtName.Text);
        }

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

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.FishingSpot);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (currentSpotEdit != null && lstGameObjects.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.FishingSpotEditor.deleteprompt, Strings.FishingSpotEditor.delete,
                        DarkDialogButton.YesNo, Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(currentSpotEdit);
                }
            }
        }

        private void toolStripItemCopy_Click(object sender, EventArgs e)
        {
            if (currentSpotEdit != null && lstGameObjects.Focused)
            {
                mCopiedItem = currentSpotEdit.JsonData;
                toolStripItemPaste.Enabled = true;
            }
        }

        private void toolStripItemPaste_Click(object sender, EventArgs e)
        {
            if (currentSpotEdit != null && mCopiedItem != null && lstGameObjects.Focused)
            {
                currentSpotEdit.Load(mCopiedItem, true);
                UpdateEditor();
            }
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(currentSpotEdit) && currentSpotEdit != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.FishingSpotEditor.undoprompt, Strings.FishingSpotEditor.undotitle,
                        DarkDialogButton.YesNo, Icon
                    ) ==
                    DialogResult.Yes)
                {
                    currentSpotEdit.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        private void UpdateToolStripItems()
        {
            toolStripItemCopy.Enabled = currentSpotEdit != null && lstGameObjects.Focused;
            toolStripItemPaste.Enabled = currentSpotEdit != null && mCopiedItem != null && lstGameObjects.Focused;
            toolStripItemDelete.Enabled = currentSpotEdit != null && lstGameObjects.Focused;
            toolStripItemUndo.Enabled = currentSpotEdit != null && lstGameObjects.Focused;
        }

        private void lstGameObjects_FocusChanged(object sender, EventArgs e)
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

        private void frmFishing_Load(object sender, EventArgs e)
        {
            cmbFishes.Items.Clear();
            cmbFishes.Items.AddRange(FishBase.Names);

            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.FishingSpotEditor.title;
            toolStripItemNew.Text = Strings.FishingSpotEditor.New;
            toolStripItemDelete.Text = Strings.FishingSpotEditor.delete;
            toolStripItemCopy.Text = Strings.FishingSpotEditor.copy;
            toolStripItemPaste.Text = Strings.FishingSpotEditor.paste;
            toolStripItemUndo.Text = Strings.FishingSpotEditor.undo;

            grpSpots.Text = Strings.FishingSpotEditor.tables;
            grpFishes.Text = Strings.FishingSpotEditor.fishes;

            lblAddFish.Text = Strings.FishingSpotEditor.addfishlabel;
            btnAddFish.Text = Strings.FishingSpotEditor.add;
            btnRemoveFish.Text = Strings.FishingSpotEditor.remove;

            grpGeneral.Text = Strings.FishingSpotEditor.general;
            lblName.Text = Strings.FishingSpotEditor.name;

            //Searching/Sorting
            btnAlphabetical.ToolTipText = Strings.FishingSpotEditor.sortalphabetically;
            txtSearch.Text = Strings.FishingSpotEditor.searchplaceholder;
            lblFolder.Text = Strings.FishingSpotEditor.folderlabel;

            btnSave.Text = Strings.FishingSpotEditor.save;
            btnCancel.Text = Strings.FishingSpotEditor.cancel;

            lblTimeMin.Text = Strings.FishingSpotEditor.fishingtimemin;
            lblTimeMax.Text = Strings.FishingSpotEditor.fishingtimemax;
        }

        public void UpdateList()
        {
            lstFishes.Items.Clear();
            foreach (var id in currentSpotEdit.Fishes)
            {
                lstFishes.Items.Add(FishBase.GetName(id));
            }
        }

        private void btnAddFish_Click(object sender, EventArgs e)
        {
            var id = FishBase.IdFromList(cmbFishes.SelectedIndex);
            var fish = FishBase.Get(id);
            if (fish != null && !currentSpotEdit.Fishes.Contains(id))
            {
                currentSpotEdit.Fishes.Add(id);
                UpdateList();
            }
        }

        private void btnRemoveFish_Click(object sender, EventArgs e)
        {
            if (lstFishes.SelectedIndex > -1)
            {
                currentSpotEdit.Fishes.RemoveAt(lstFishes.SelectedIndex);
                UpdateList();
            }
        }

        private void btnFishUp_Click(object sender, EventArgs e)
        {
            if (lstFishes.SelectedIndex > 0 && lstFishes.Items.Count > 1)
            {
                var index = lstFishes.SelectedIndex;
                var swapWith = currentSpotEdit.Fishes[index - 1];
                currentSpotEdit.Fishes[index - 1] = currentSpotEdit.Fishes[index];
                currentSpotEdit.Fishes[index] = swapWith;
                UpdateList();
                lstFishes.SelectedIndex = index - 1;
            }
        }

        private void btnFishDown_Click(object sender, EventArgs e)
        {
            if (lstFishes.SelectedIndex > -1 && lstFishes.SelectedIndex + 1 != lstFishes.Items.Count)
            {
                var index = lstFishes.SelectedIndex;
                var swapWith = currentSpotEdit.Fishes[index + 1];
                currentSpotEdit.Fishes[index + 1] = currentSpotEdit.Fishes[index];
                currentSpotEdit.Fishes[index] = swapWith;
                UpdateList();
                lstFishes.SelectedIndex = index + 1;
            }
        }

        #region "Item List - Folders, Searching, Sorting, Etc"

        public void InitEditor()
        {
            //Collect folders
            var mFolders = new List<string>();
            foreach (var itm in FishingSpotBase.Lookup)
            {
                if (!string.IsNullOrEmpty(((FishingSpotBase)itm.Value).Folder) &&
                    !mFolders.Contains(((FishingSpotBase)itm.Value).Folder))
                {
                    mFolders.Add(((FishingSpotBase)itm.Value).Folder);
                    if (!mKnownFolders.Contains(((FishingSpotBase)itm.Value).Folder))
                    {
                        mKnownFolders.Add(((FishingSpotBase)itm.Value).Folder);
                    }
                }
            }

            mFolders.Sort();
            mKnownFolders.Sort();
            cmbFolder.Items.Clear();
            cmbFolder.Items.Add("");
            cmbFolder.Items.AddRange(mKnownFolders.ToArray());

            var items = FishingSpotBase.Lookup.OrderBy(p => p.Value?.Name).Select(pair => new KeyValuePair<Guid, KeyValuePair<string, string>>(pair.Key,
                new KeyValuePair<string, string>(((FishingSpotBase)pair.Value)?.Name ?? Models.DatabaseObject<FishingSpotBase>.Deleted, ((FishingSpotBase)pair.Value)?.Folder ?? ""))).ToArray();
            lstGameObjects.Repopulate(items, mFolders, btnAlphabetical.Checked, CustomSearch(), txtSearch.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderName = "";
            var result = DarkInputBox.ShowInformation(
                Strings.FishingSpotEditor.folderprompt, Strings.FishingSpotEditor.foldertitle, ref folderName,
                DarkDialogButton.OkCancel
            );

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderName))
            {
                if (!cmbFolder.Items.Contains(folderName))
                {
                    currentSpotEdit.Folder = folderName;
                    lstGameObjects.ExpandFolder(folderName);
                    InitEditor();
                    cmbFolder.Text = folderName;
                }
            }
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSpotEdit.Folder = cmbFolder.Text;
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
                txtSearch.Text = Strings.FishingSpotEditor.searchplaceholder;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = Strings.FishingSpotEditor.searchplaceholder;
        }

        private bool CustomSearch()
        {
            return !string.IsNullOrWhiteSpace(txtSearch.Text) &&
                   txtSearch.Text != Strings.FishingSpotEditor.searchplaceholder;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == Strings.FishingSpotEditor.searchplaceholder)
            {
                txtSearch.SelectAll();
            }
        }

        #endregion

        private void btnFishRequirements_Click(object sender, EventArgs e)
        {
            var frm = new FrmDynamicRequirements(currentSpotEdit.FishingRequirements, RequirementType.FishingSpot);
            frm.ShowDialog();
        }
    }

}
