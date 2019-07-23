namespace Dashboard.Preferences
{
    partial class ScreenControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudRotationInterval = new System.Windows.Forms.NumericUpDown();
            this.lblSecondsToDisplay = new System.Windows.Forms.Label();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            this.lvUrls = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.urlButtonsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRotationInterval.Location = new System.Drawing.Point(2, 288);
            this.nudRotationInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudRotationInterval.Name = "nudRotationInterval";
            this.nudRotationInterval.Size = new System.Drawing.Size(40, 20);
            this.nudRotationInterval.TabIndex = 6;
            this.nudRotationInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblSecondsToDisplay
            // 
            this.lblSecondsToDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSecondsToDisplay.AutoSize = true;
            this.lblSecondsToDisplay.Location = new System.Drawing.Point(44, 290);
            this.lblSecondsToDisplay.Name = "lblSecondsToDisplay";
            this.lblSecondsToDisplay.Size = new System.Drawing.Size(142, 13);
            this.lblSecondsToDisplay.TabIndex = 7;
            this.lblSecondsToDisplay.Text = "Seconds to display each site";
            // 
            // cbRandomize
            // 
            this.cbRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Location = new System.Drawing.Point(3, 264);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(121, 17);
            this.cbRandomize.TabIndex = 5;
            this.cbRandomize.Text = "Shuffle display order";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // lvUrls
            // 
            this.lvUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUrls.GridLines = true;
            this.lvUrls.HideSelection = false;
            this.lvUrls.LabelEdit = true;
            this.lvUrls.Location = new System.Drawing.Point(2, 2);
            this.lvUrls.Margin = new System.Windows.Forms.Padding(2);
            this.lvUrls.MinimumSize = new System.Drawing.Size(205, 4);
            this.lvUrls.Name = "lvUrls";
            this.lvUrls.Size = new System.Drawing.Size(400, 222);
            this.lvUrls.TabIndex = 0;
            this.lvUrls.UseCompatibleStateImageBehavior = false;
            this.lvUrls.View = System.Windows.Forms.View.List;
            this.lvUrls.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvUrls_ItemSelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(352, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 22);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Enabled = false;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(407, 80);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(18, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "▲";
            this.urlButtonsTooltip.SetToolTip(this.btnUp, "Move selected URLs up");
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.MoveAllSelectedUrlsUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Enabled = false;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(407, 120);
            this.btnDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(18, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "▼";
            this.urlButtonsTooltip.SetToolTip(this.btnDown, "Move selected URLs down");
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.MoveAllSelectedUrlsDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(407, 160);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(18, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "X";
            this.urlButtonsTooltip.SetToolTip(this.btnDelete, "DELETE selected URLs");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteAllSelectedUrls_Click);
            // 
            // txtNewItem
            // 
            this.txtNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewItem.Location = new System.Drawing.Point(3, 234);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(343, 20);
            this.txtNewItem.TabIndex = 14;
            this.txtNewItem.TextChanged += new System.EventHandler(this.TxtNewItem_TextChanged);
            // 
            // PrefsByScreenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.nudRotationInterval);
            this.Controls.Add(this.lblSecondsToDisplay);
            this.Controls.Add(this.cbRandomize);
            this.Controls.Add(this.lvUrls);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(430, 320);
            this.Name = "PrefsByScreenUserControl";
            this.Size = new System.Drawing.Size(430, 320);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown nudRotationInterval;
        private System.Windows.Forms.Label lblSecondsToDisplay;
        public System.Windows.Forms.CheckBox cbRandomize;
        public System.Windows.Forms.ListView lvUrls;
        private System.Windows.Forms.ToolTip urlButtonsTooltip;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNewItem;
    }
}
