﻿using System;
using System.Windows.Forms;

namespace Dashboard.Preferences
{
    public partial class ScreenControl : UserControl
    {
        public ScreenControl()
        {
            InitializeComponent();
        }

        private void MoveAllSelectedUrlsDown_Click(object sender, EventArgs e)
        {
            // TODO: make button grey out when none selected OR when all selected ones are in a bunch at the bottom.
            bool gapFound = false;

            // scan from the bottom up, but don't start moving selected items down until
            // we find an unselected gap to move items(s) down in to.
            for (int i = lvUrls.Items.Count - 1; i >= 0; i--)
            {
                if (lvUrls.Items[i].Selected)
                {
                    if (gapFound)
                    {
                        Swap(lvUrls.Items, i, i + 1);
                    }
                }
                else
                {
                    gapFound = true;
                }
            }

            // 'select'ing the list makes sure the selections of items within it are being displayed.
            // Otherwise the button becomes the 'selected' control and the selections within the list
            // are invisible or hard to see.
            lvUrls.Select();
        }

        private void MoveAllSelectedUrlsUp_Click(object sender, EventArgs e)
        {
            // TODO: make button grey out when none selected OR when all selected ones are in a bunch at the top.
            bool gapFound = false;

            // scan through for all selected, but don't start moving selected items up until
            // we find an unselected gap to move items(s) up in to.
            for (int i = 0; i < lvUrls.Items.Count; i++)
            {
                if (lvUrls.Items[i].Selected)
                {
                    if (gapFound)
                    {
                        Swap(lvUrls.Items, i, i - 1);
                    }
                }
                else
                {
                    gapFound = true;
                }
            }

            // 'select'ing the list makes sure the selections of items within it are being displayed.
            // Otherwise the button becomes the 'selected' control and the selections within the list
            // are invisible or hard to see.
            lvUrls.Select();
        }

        private void DeleteAllSelectedUrls_Click(object sender, EventArgs e)
        {
            // TODO: undo capability?
            // TODO: make button grey out when no selection.
            // work from the bottom up, deleting any we find
            for (int i = lvUrls.Items.Count - 1; i >= 0; i--)
            {
                if (lvUrls.Items[i].Selected)
                {
                    lvUrls.Items[i].Remove();
                }
            }
        }

        private void addUrlButton_Click(object sender, EventArgs e)
        {
            if (txtNewItem.Text.Trim() != string.Empty) {
                lvUrls.Items.Add(txtNewItem.Text);
            }
            txtNewItem.Text = "";
        }

        /// <summary>
        /// Swap the positions of 2 items in a ListViewItemCollection, maintaining Selected status.
        /// Any indexes given outside the bounds of the list are treated as if they point to
        /// the nearest end of the list.
        /// </summary>
        private static void Swap(ListView.ListViewItemCollection itemsList, int indexA, int indexB)
        {
            var a = Math.Min(itemsList.Count - 1, Math.Max(0, indexA));
            var b = Math.Min(itemsList.Count - 1, Math.Max(0, indexB));
            if (a != b)
            {
                var itemA = (ListViewItem)itemsList[a].Clone();
                bool itemASelected = itemsList[a].Selected;
                var itemB = (ListViewItem)itemsList[b].Clone();
                bool itemBSelected = itemsList[b].Selected;
                itemsList[a] = itemB;
                itemsList[a].Selected = itemBSelected;
                itemsList[b] = itemA;
                itemsList[b].Selected = itemASelected;
            }
        }

        private void LvUrls_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateActionsState(lvUrls.SelectedItems.Count != 0);

        }
        private void UpdateActionsState(bool state) {
            var buttonStatus = state;
            btnDelete.Enabled = buttonStatus;
            btnUp.Enabled = buttonStatus;
            btnDown.Enabled = buttonStatus;
        }

        private void TxtNewItem_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtNewItem.Text.Trim().Length != 0;

        }
    }
}
