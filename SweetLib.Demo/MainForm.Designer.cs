namespace SweetLib.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgTaskbar = new System.Windows.Forms.TabPage();
            this.gbxProgress = new System.Windows.Forms.GroupBox();
            this.rdbNoProgress = new System.Windows.Forms.RadioButton();
            this.rdbIndeterminate = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbError = new System.Windows.Forms.RadioButton();
            this.rdbPaused = new System.Windows.Forms.RadioButton();
            this.tbrTaskBarProgress = new System.Windows.Forms.TrackBar();
            this.tabMain.SuspendLayout();
            this.tpgTaskbar.SuspendLayout();
            this.gbxProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTaskBarProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgTaskbar);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(546, 333);
            this.tabMain.TabIndex = 0;
            // 
            // tpgTaskbar
            // 
            this.tpgTaskbar.Controls.Add(this.gbxProgress);
            this.tpgTaskbar.Location = new System.Drawing.Point(4, 22);
            this.tpgTaskbar.Name = "tpgTaskbar";
            this.tpgTaskbar.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTaskbar.Size = new System.Drawing.Size(538, 307);
            this.tpgTaskbar.TabIndex = 0;
            this.tpgTaskbar.Text = "TaskBar";
            this.tpgTaskbar.UseVisualStyleBackColor = true;
            // 
            // gbxProgress
            // 
            this.gbxProgress.Controls.Add(this.tbrTaskBarProgress);
            this.gbxProgress.Controls.Add(this.rdbPaused);
            this.gbxProgress.Controls.Add(this.rdbError);
            this.gbxProgress.Controls.Add(this.rdbNormal);
            this.gbxProgress.Controls.Add(this.rdbIndeterminate);
            this.gbxProgress.Controls.Add(this.rdbNoProgress);
            this.gbxProgress.Location = new System.Drawing.Point(8, 6);
            this.gbxProgress.Name = "gbxProgress";
            this.gbxProgress.Size = new System.Drawing.Size(268, 143);
            this.gbxProgress.TabIndex = 0;
            this.gbxProgress.TabStop = false;
            this.gbxProgress.Text = "Progress";
            // 
            // rdbNoProgress
            // 
            this.rdbNoProgress.AutoSize = true;
            this.rdbNoProgress.Checked = true;
            this.rdbNoProgress.Location = new System.Drawing.Point(6, 28);
            this.rdbNoProgress.Name = "rdbNoProgress";
            this.rdbNoProgress.Size = new System.Drawing.Size(80, 17);
            this.rdbNoProgress.TabIndex = 1;
            this.rdbNoProgress.TabStop = true;
            this.rdbNoProgress.Tag = "0";
            this.rdbNoProgress.Text = "NoProgress";
            this.rdbNoProgress.UseVisualStyleBackColor = true;
            this.rdbNoProgress.CheckedChanged += new System.EventHandler(this.radioProgressCheckedChanged);
            // 
            // rdbIndeterminate
            // 
            this.rdbIndeterminate.AutoSize = true;
            this.rdbIndeterminate.Location = new System.Drawing.Point(6, 51);
            this.rdbIndeterminate.Name = "rdbIndeterminate";
            this.rdbIndeterminate.Size = new System.Drawing.Size(89, 17);
            this.rdbIndeterminate.TabIndex = 2;
            this.rdbIndeterminate.Tag = "1";
            this.rdbIndeterminate.Text = "Indeterminate";
            this.rdbIndeterminate.UseVisualStyleBackColor = true;
            this.rdbIndeterminate.CheckedChanged += new System.EventHandler(this.radioProgressCheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(6, 74);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 3;
            this.rdbNormal.Tag = "2";
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.radioProgressCheckedChanged);
            // 
            // rdbError
            // 
            this.rdbError.AutoSize = true;
            this.rdbError.Location = new System.Drawing.Point(6, 97);
            this.rdbError.Name = "rdbError";
            this.rdbError.Size = new System.Drawing.Size(47, 17);
            this.rdbError.TabIndex = 4;
            this.rdbError.Tag = "3";
            this.rdbError.Text = "Error";
            this.rdbError.UseVisualStyleBackColor = true;
            this.rdbError.CheckedChanged += new System.EventHandler(this.radioProgressCheckedChanged);
            // 
            // rdbPaused
            // 
            this.rdbPaused.AutoSize = true;
            this.rdbPaused.Location = new System.Drawing.Point(6, 120);
            this.rdbPaused.Name = "rdbPaused";
            this.rdbPaused.Size = new System.Drawing.Size(61, 17);
            this.rdbPaused.TabIndex = 5;
            this.rdbPaused.Tag = "4";
            this.rdbPaused.Text = "Paused";
            this.rdbPaused.UseVisualStyleBackColor = true;
            this.rdbPaused.CheckedChanged += new System.EventHandler(this.radioProgressCheckedChanged);
            // 
            // tbrTaskBarProgress
            // 
            this.tbrTaskBarProgress.Location = new System.Drawing.Point(128, 28);
            this.tbrTaskBarProgress.Maximum = 100;
            this.tbrTaskBarProgress.Name = "tbrTaskBarProgress";
            this.tbrTaskBarProgress.Size = new System.Drawing.Size(134, 45);
            this.tbrTaskBarProgress.TabIndex = 6;
            this.tbrTaskBarProgress.ValueChanged += new System.EventHandler(this.tbrTaskBarProgress_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 333);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = "SweetLib Demo";
            this.tabMain.ResumeLayout(false);
            this.tpgTaskbar.ResumeLayout(false);
            this.gbxProgress.ResumeLayout(false);
            this.gbxProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTaskBarProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgTaskbar;
        private System.Windows.Forms.GroupBox gbxProgress;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbIndeterminate;
        private System.Windows.Forms.RadioButton rdbNoProgress;
        private System.Windows.Forms.RadioButton rdbPaused;
        private System.Windows.Forms.RadioButton rdbError;
        private System.Windows.Forms.TrackBar tbrTaskBarProgress;
    }
}

