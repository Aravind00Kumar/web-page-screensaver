﻿namespace Dashboard.Preferences
{
    partial class PreferencesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cbCloseOnActivity = new System.Windows.Forms.CheckBox();
            this.tcScreens = new System.Windows.Forms.TabControl();
            this.screenTabPage1 = new System.Windows.Forms.TabPage();
            this.ucScreenPreferences = new Dashboard.Preferences.ScreenControl();
            this.spanScreensButton = new System.Windows.Forms.RadioButton();
            this.separateScreensButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mirrorScreensButton = new System.Windows.Forms.RadioButton();
            this.multiScreenGroup = new System.Windows.Forms.GroupBox();
            this.screenModeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tcScreens.SuspendLayout();
            this.screenTabPage1.SuspendLayout();
            this.multiScreenGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(357, 475);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(438, 475);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // cbCloseOnActivity
            // 
            this.cbCloseOnActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCloseOnActivity.AutoSize = true;
            this.cbCloseOnActivity.Location = new System.Drawing.Point(15, 448);
            this.cbCloseOnActivity.Name = "cbCloseOnActivity";
            this.cbCloseOnActivity.Size = new System.Drawing.Size(153, 17);
            this.cbCloseOnActivity.TabIndex = 6;
            this.cbCloseOnActivity.Text = "Close on mouse movement";
            this.cbCloseOnActivity.UseVisualStyleBackColor = true;
            // 
            // tcScreens
            // 
            this.tcScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcScreens.Controls.Add(this.screenTabPage1);
            this.tcScreens.Location = new System.Drawing.Point(15, 68);
            this.tcScreens.Margin = new System.Windows.Forms.Padding(2);
            this.tcScreens.Name = "tcScreens";
            this.tcScreens.SelectedIndex = 0;
            this.tcScreens.Size = new System.Drawing.Size(501, 363);
            this.tcScreens.TabIndex = 13;
            // 
            // screenTabPage1
            // 
            this.screenTabPage1.Controls.Add(this.ucScreenPreferences);
            this.screenTabPage1.Location = new System.Drawing.Point(4, 22);
            this.screenTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.screenTabPage1.Name = "screenTabPage1";
            this.screenTabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.screenTabPage1.Size = new System.Drawing.Size(493, 337);
            this.screenTabPage1.TabIndex = 0;
            this.screenTabPage1.Text = "Screen 1";
            this.screenTabPage1.UseVisualStyleBackColor = true;
            // 
            // ucScreenPreferences
            // 
            this.ucScreenPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucScreenPreferences.BackColor = System.Drawing.Color.White;
            this.ucScreenPreferences.Location = new System.Drawing.Point(6, 4);
            this.ucScreenPreferences.Margin = new System.Windows.Forms.Padding(2);
            this.ucScreenPreferences.MinimumSize = new System.Drawing.Size(330, 320);
            this.ucScreenPreferences.Name = "ucScreenPreferences";
            this.ucScreenPreferences.Size = new System.Drawing.Size(483, 329);
            this.ucScreenPreferences.TabIndex = 21;
            // 
            // spanScreensButton
            // 
            this.spanScreensButton.AutoSize = true;
            this.spanScreensButton.Checked = true;
            this.spanScreensButton.Location = new System.Drawing.Point(75, 8);
            this.spanScreensButton.Margin = new System.Windows.Forms.Padding(2);
            this.spanScreensButton.Name = "spanScreensButton";
            this.spanScreensButton.Size = new System.Drawing.Size(50, 17);
            this.spanScreensButton.TabIndex = 14;
            this.spanScreensButton.TabStop = true;
            this.spanScreensButton.Tag = "MultiScreenMode";
            this.spanScreensButton.Text = "Span";
            this.screenModeTooltip.SetToolTip(this.spanScreensButton, "All for One!");
            this.spanScreensButton.UseVisualStyleBackColor = true;
            this.spanScreensButton.Click += new System.EventHandler(this.AnyMultiScreenModeButton_Click);
            // 
            // separateScreensButton
            // 
            this.separateScreensButton.AutoSize = true;
            this.separateScreensButton.Location = new System.Drawing.Point(178, 8);
            this.separateScreensButton.Margin = new System.Windows.Forms.Padding(2);
            this.separateScreensButton.Name = "separateScreensButton";
            this.separateScreensButton.Size = new System.Drawing.Size(68, 17);
            this.separateScreensButton.TabIndex = 15;
            this.separateScreensButton.TabStop = true;
            this.separateScreensButton.Tag = "MultiScreenMode";
            this.separateScreensButton.Text = "Separate";
            this.screenModeTooltip.SetToolTip(this.separateScreensButton, "Each to their own.");
            this.separateScreensButton.UseVisualStyleBackColor = true;
            this.separateScreensButton.Click += new System.EventHandler(this.AnyMultiScreenModeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Multiscreen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website URLs";
            // 
            // mirrorScreensButton
            // 
            this.mirrorScreensButton.AutoSize = true;
            this.mirrorScreensButton.Location = new System.Drawing.Point(126, 8);
            this.mirrorScreensButton.Margin = new System.Windows.Forms.Padding(2);
            this.mirrorScreensButton.Name = "mirrorScreensButton";
            this.mirrorScreensButton.Size = new System.Drawing.Size(51, 17);
            this.mirrorScreensButton.TabIndex = 17;
            this.mirrorScreensButton.TabStop = true;
            this.mirrorScreensButton.Tag = "MultiScreenMode";
            this.mirrorScreensButton.Text = "Mirror";
            this.screenModeTooltip.SetToolTip(this.mirrorScreensButton, "One for All!");
            this.mirrorScreensButton.UseVisualStyleBackColor = true;
            this.mirrorScreensButton.Click += new System.EventHandler(this.AnyMultiScreenModeButton_Click);
            // 
            // multiScreenGroup
            // 
            this.multiScreenGroup.Controls.Add(this.label4);
            this.multiScreenGroup.Controls.Add(this.mirrorScreensButton);
            this.multiScreenGroup.Controls.Add(this.spanScreensButton);
            this.multiScreenGroup.Controls.Add(this.separateScreensButton);
            this.multiScreenGroup.Location = new System.Drawing.Point(11, 12);
            this.multiScreenGroup.Margin = new System.Windows.Forms.Padding(2);
            this.multiScreenGroup.Name = "multiScreenGroup";
            this.multiScreenGroup.Padding = new System.Windows.Forms.Padding(2);
            this.multiScreenGroup.Size = new System.Drawing.Size(244, 28);
            this.multiScreenGroup.TabIndex = 18;
            this.multiScreenGroup.TabStop = false;
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(534, 531);
            this.Controls.Add(this.multiScreenGroup);
            this.Controls.Add(this.tcScreens);
            this.Controls.Add(this.cbCloseOnActivity);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 570);
            this.Name = "PreferencesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard Settings";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this.tcScreens.ResumeLayout(false);
            this.screenTabPage1.ResumeLayout(false);
            this.multiScreenGroup.ResumeLayout(false);
            this.multiScreenGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox cbCloseOnActivity;
        private System.Windows.Forms.TabControl tcScreens;
        private System.Windows.Forms.TabPage screenTabPage1;
        private System.Windows.Forms.RadioButton spanScreensButton;
        private System.Windows.Forms.RadioButton separateScreensButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton mirrorScreensButton;
        private System.Windows.Forms.GroupBox multiScreenGroup;
        private ScreenControl ucScreenPreferences;
        private System.Windows.Forms.ToolTip screenModeTooltip;
    }
}