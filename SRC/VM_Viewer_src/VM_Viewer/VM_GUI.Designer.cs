﻿namespace VM_Viewer {
    partial class VM_GUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VM_GUI));
            this.mnViewer = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vmxSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnLauch = new MetroFramework.Controls.MetroButton();
            this.cbFullScreen = new MetroFramework.Controls.MetroCheckBox();
            this.cbOpen = new MetroFramework.Controls.MetroCheckBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.gbFullScreen = new MetroFramework.Controls.MetroPanel();
            this.btConfig = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.cbPath = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbControl = new System.Windows.Forms.Panel();
            this.tbFolder = new System.Windows.Forms.Panel();
            this.Barreoblique = new System.Windows.Forms.Label();
            this.mnViewer.SuspendLayout();
            this.gbFullScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnViewer
            // 
            this.mnViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mnViewer.Dock = System.Windows.Forms.DockStyle.None;
            this.mnViewer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnViewer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.mnViewer.Location = new System.Drawing.Point(0, 0);
            this.mnViewer.Name = "mnViewer";
            this.mnViewer.Size = new System.Drawing.Size(147, 25);
            this.mnViewer.TabIndex = 16;
            this.mnViewer.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vmxSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // vmxSettingsToolStripMenuItem
            // 
            this.vmxSettingsToolStripMenuItem.Name = "vmxSettingsToolStripMenuItem";
            this.vmxSettingsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.vmxSettingsToolStripMenuItem.Text = "Open Library";
            this.vmxSettingsToolStripMenuItem.Click += new System.EventHandler(this.vmxSettingsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToovaToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToovaToolStripMenuItem
            // 
            this.exportToovaToolStripMenuItem.Name = "exportToovaToolStripMenuItem";
            this.exportToovaToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.exportToovaToolStripMenuItem.Text = "Export to .ova";
            this.exportToovaToolStripMenuItem.Click += new System.EventHandler(this.exportToovaToolStripMenuItem_Click);
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Checked = true;
            this.ckbAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdmin.Location = new System.Drawing.Point(94, 47);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(145, 17);
            this.ckbAdmin.TabIndex = 19;
            this.ckbAdmin.Text = "Run as administrator";
            this.ckbAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ckbAdmin.UseCustomBackColor = true;
            this.ckbAdmin.UseSelectable = true;
            this.ckbAdmin.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::VM_Viewer.Properties.Resources.openfolderpng;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(785, 76);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(54, 25);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "...";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnLauch
            // 
            this.btnLauch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLauch.Highlight = true;
            this.btnLauch.Location = new System.Drawing.Point(94, 198);
            this.btnLauch.Name = "btnLauch";
            this.btnLauch.Size = new System.Drawing.Size(662, 53);
            this.btnLauch.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLauch.TabIndex = 22;
            this.btnLauch.Text = "Launch";
            this.btnLauch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLauch.UseSelectable = true;
            this.btnLauch.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.Location = new System.Drawing.Point(260, 47);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(123, 17);
            this.cbFullScreen.TabIndex = 23;
            this.cbFullScreen.Text = "Full screen mode";
            this.cbFullScreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbFullScreen.UseCustomBackColor = true;
            this.cbFullScreen.UseSelectable = true;
            this.cbFullScreen.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Checked = true;
            this.cbOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpen.Location = new System.Drawing.Point(94, 166);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(116, 17);
            this.cbOpen.TabIndex = 26;
            this.cbOpen.Text = "Open on mount";
            this.cbOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOpen.UseCustomBackColor = true;
            this.cbOpen.UseSelectable = true;
            this.cbOpen.CheckedChanged += new System.EventHandler(this.cbOpen_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(785, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit Drive";
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReset.Location = new System.Drawing.Point(4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 94);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "RESET";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.metroButton2_Click_2);
            // 
            // gbFullScreen
            // 
            this.gbFullScreen.Controls.Add(this.btConfig);
            this.gbFullScreen.Controls.Add(this.btnStop);
            this.gbFullScreen.Controls.Add(this.btnPause);
            this.gbFullScreen.Controls.Add(this.btnReset);
            this.gbFullScreen.HorizontalScrollbarBarColor = true;
            this.gbFullScreen.HorizontalScrollbarHighlightOnWheel = false;
            this.gbFullScreen.HorizontalScrollbarSize = 10;
            this.gbFullScreen.Location = new System.Drawing.Point(9, 257);
            this.gbFullScreen.Name = "gbFullScreen";
            this.gbFullScreen.Size = new System.Drawing.Size(734, 100);
            this.gbFullScreen.TabIndex = 32;
            this.gbFullScreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbFullScreen.VerticalScrollbarBarColor = true;
            this.gbFullScreen.VerticalScrollbarHighlightOnWheel = false;
            this.gbFullScreen.VerticalScrollbarSize = 10;
            // 
            // btConfig
            // 
            this.btConfig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btConfig.Location = new System.Drawing.Point(550, 3);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(176, 94);
            this.btConfig.TabIndex = 31;
            this.btConfig.Text = "CONFIG";
            this.btConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btConfig.UseSelectable = true;
            this.btConfig.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // btnStop
            // 
            this.btnStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStop.Location = new System.Drawing.Point(368, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 94);
            this.btnStop.TabIndex = 30;
            this.btnStop.Text = "STOP";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnPause
            // 
            this.btnPause.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPause.Location = new System.Drawing.Point(186, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(176, 94);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "PAUSE";
            this.btnPause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPause.UseSelectable = true;
            this.btnPause.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // cbDrive
            // 
            this.cbDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDrive.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrive.ForeColor = System.Drawing.SystemColors.Control;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Location = new System.Drawing.Point(94, 123);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(662, 25);
            this.cbDrive.TabIndex = 34;
            // 
            // cbPath
            // 
            this.cbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPath.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPath.ForeColor = System.Drawing.SystemColors.Control;
            this.cbPath.FormattingEnabled = true;
            this.cbPath.Location = new System.Drawing.Point(94, 76);
            this.cbPath.Name = "cbPath";
            this.cbPath.Size = new System.Drawing.Size(662, 25);
            this.cbPath.TabIndex = 35;
            this.cbPath.TextChanged += new System.EventHandler(this.cbPath_TextChanged_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "VM File :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 20);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Drive :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // tbControl
            // 
            this.tbControl.Location = new System.Drawing.Point(803, 307);
            this.tbControl.Name = "tbControl";
            this.tbControl.Size = new System.Drawing.Size(73, 50);
            this.tbControl.TabIndex = 39;
            this.tbControl.Visible = false;
            // 
            // tbFolder
            // 
            this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolder.Location = new System.Drawing.Point(9, 383);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(887, 156);
            this.tbFolder.TabIndex = 38;
            // 
            // Barreoblique
            // 
            this.Barreoblique.AutoSize = true;
            this.Barreoblique.Location = new System.Drawing.Point(793, 25);
            this.Barreoblique.Name = "Barreoblique";
            this.Barreoblique.Size = new System.Drawing.Size(12, 17);
            this.Barreoblique.TabIndex = 40;
            this.Barreoblique.Text = "\\";
            this.Barreoblique.Visible = false;
            // 
            // VM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(903, 550);
            this.Controls.Add(this.Barreoblique);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbPath);
            this.Controls.Add(this.cbDrive);
            this.Controls.Add(this.gbFullScreen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.cbFullScreen);
            this.Controls.Add(this.btnLauch);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ckbAdmin);
            this.Controls.Add(this.mnViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnViewer;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VM_GUI";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VM·Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VM_GUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VM_GUI_FormClosed);
            this.Load += new System.EventHandler(this.VM_GUI_Load);
            this.ResizeEnd += new System.EventHandler(this.VM_GUI_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.VM_GUI_SizeChanged);
            this.Move += new System.EventHandler(this.VM_GUI_Move);
            this.Resize += new System.EventHandler(this.VM_GUI_Resize);
            this.mnViewer.ResumeLayout(false);
            this.mnViewer.PerformLayout();
            this.gbFullScreen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnViewer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vmxSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToovaToolStripMenuItem;
        private MetroFramework.Controls.MetroCheckBox ckbAdmin;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnLauch;
        private MetroFramework.Controls.MetroCheckBox cbFullScreen;
        private MetroFramework.Controls.MetroCheckBox cbOpen;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroPanel gbFullScreen;
        private MetroFramework.Controls.MetroButton btConfig;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnPause;

        private System.Windows.Forms.ComboBox cbDrive;
        private System.Windows.Forms.ComboBox cbPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel tbControl;
        private System.Windows.Forms.Panel tbFolder;
        private System.Windows.Forms.Label Barreoblique;
    }
}
