namespace mableware
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbCPS = new System.Windows.Forms.Label();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.Bind = new System.Windows.Forms.Timer(this.components);
            this.cbShiftD = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.cbToggle = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.sldCPS = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.btBind = new System.Windows.Forms.Button();
            this.InfoButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.ForeColor = System.Drawing.Color.White;
            this.lbCPS.Location = new System.Drawing.Point(18, 57);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(54, 16);
            this.lbCPS.TabIndex = 2;
            this.lbCPS.Text = "CPS: 10";
            this.lbCPS.Click += new System.EventHandler(this.lbCPS_Click);
            // 
            // LeftClicker
            // 
            this.LeftClicker.Enabled = true;
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Bind
            // 
            this.Bind.Enabled = true;
            this.Bind.Interval = 150;
            this.Bind.Tick += new System.EventHandler(this.Bind_Tick);
            // 
            // cbShiftD
            // 
            this.cbShiftD.AutoSize = true;
            this.cbShiftD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShiftD.CheckedState.BorderRadius = 2;
            this.cbShiftD.CheckedState.BorderThickness = 0;
            this.cbShiftD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShiftD.CheckMarkColor = System.Drawing.Color.Red;
            this.cbShiftD.ForeColor = System.Drawing.Color.White;
            this.cbShiftD.Location = new System.Drawing.Point(21, 112);
            this.cbShiftD.Name = "cbShiftD";
            this.cbShiftD.Size = new System.Drawing.Size(104, 20);
            this.cbShiftD.TabIndex = 5;
            this.cbShiftD.Text = "Shift Disable";
            this.cbShiftD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShiftD.UncheckedState.BorderRadius = 2;
            this.cbShiftD.UncheckedState.BorderThickness = 0;
            this.cbShiftD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShiftD.UseVisualStyleBackColor = true;
            // 
            // cbToggle
            // 
            this.cbToggle.AutoSize = true;
            this.cbToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToggle.CheckedState.BorderRadius = 2;
            this.cbToggle.CheckedState.BorderThickness = 0;
            this.cbToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbToggle.CheckMarkColor = System.Drawing.Color.Red;
            this.cbToggle.ForeColor = System.Drawing.Color.White;
            this.cbToggle.Location = new System.Drawing.Point(21, 20);
            this.cbToggle.Name = "cbToggle";
            this.cbToggle.Size = new System.Drawing.Size(72, 20);
            this.cbToggle.TabIndex = 6;
            this.cbToggle.Text = "Enable";
            this.cbToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbToggle.UncheckedState.BorderRadius = 2;
            this.cbToggle.UncheckedState.BorderThickness = 0;
            this.cbToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbToggle.UseVisualStyleBackColor = true;
            // 
            // sldCPS
            // 
            this.sldCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.sldCPS.HoveredState.Parent = this.sldCPS;
            this.sldCPS.Location = new System.Drawing.Point(21, 76);
            this.sldCPS.Maximum = 20;
            this.sldCPS.Minimum = 5;
            this.sldCPS.Name = "sldCPS";
            this.sldCPS.Size = new System.Drawing.Size(300, 23);
            this.sldCPS.TabIndex = 7;
            this.sldCPS.ThumbColor = System.Drawing.Color.Red;
            this.sldCPS.Value = 10;
            this.sldCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldCPS_Scroll);
            // 
            // btBind
            // 
            this.btBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btBind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBind.ForeColor = System.Drawing.Color.White;
            this.btBind.Location = new System.Drawing.Point(108, 18);
            this.btBind.Name = "btBind";
            this.btBind.Size = new System.Drawing.Size(75, 23);
            this.btBind.TabIndex = 4;
            this.btBind.Text = "none";
            this.btBind.UseVisualStyleBackColor = false;
            this.btBind.Click += new System.EventHandler(this.btBind_Click);
            this.btBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btBind_KeyUp);
            // 
            // InfoButton
            // 
            this.InfoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InfoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InfoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InfoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InfoButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InfoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InfoButton.ForeColor = System.Drawing.Color.White;
            this.InfoButton.Location = new System.Drawing.Point(209, 371);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(153, 36);
            this.InfoButton.TabIndex = 8;
            this.InfoButton.Text = "Info";
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(374, 419);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.sldCPS);
            this.Controls.Add(this.cbToggle);
            this.Controls.Add(this.cbShiftD);
            this.Controls.Add(this.btBind);
            this.Controls.Add(this.lbCPS);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Timer Bind;
        private Siticone.UI.WinForms.SiticoneCheckBox cbShiftD;
        private Siticone.UI.WinForms.SiticoneCheckBox cbToggle;
        private Siticone.UI.WinForms.SiticoneTrackBar sldCPS;
        private System.Windows.Forms.Button btBind;
        private Siticone.Desktop.UI.WinForms.SiticoneButton InfoButton;
    }
}

