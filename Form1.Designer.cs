namespace blackops_mod_tool
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noclip = new System.Windows.Forms.Button();
            this.godmode = new System.Windows.Forms.Button();
            this.thirdperson = new System.Windows.Forms.Button();
            this.resetTimeScale = new System.Windows.Forms.Button();
            this.maxTimeScale = new System.Windows.Forms.Button();
            this.minTimeScale = new System.Windows.Forms.Button();
            this.fov100 = new System.Windows.Forms.Button();
            this.giveAmmo = new System.Windows.Forms.Button();
            this.farKnife = new System.Windows.Forms.Button();
            this.dropWeapon = new System.Windows.Forms.Button();
            this.maxSpeed = new System.Windows.Forms.Button();
            this.normSpeed = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(13, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(79, 30);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.normSpeed);
            this.tabPage2.Controls.Add(this.maxSpeed);
            this.tabPage2.Controls.Add(this.dropWeapon);
            this.tabPage2.Controls.Add(this.farKnife);
            this.tabPage2.Controls.Add(this.giveAmmo);
            this.tabPage2.Controls.Add(this.fov100);
            this.tabPage2.Controls.Add(this.minTimeScale);
            this.tabPage2.Controls.Add(this.maxTimeScale);
            this.tabPage2.Controls.Add(this.resetTimeScale);
            this.tabPage2.Controls.Add(this.thirdperson);
            this.tabPage2.Controls.Add(this.godmode);
            this.tabPage2.Controls.Add(this.noclip);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zombies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noclip
            // 
            this.noclip.Location = new System.Drawing.Point(7, 7);
            this.noclip.Name = "noclip";
            this.noclip.Size = new System.Drawing.Size(90, 33);
            this.noclip.TabIndex = 0;
            this.noclip.Text = "No Clip";
            this.noclip.UseVisualStyleBackColor = true;
            this.noclip.Click += new System.EventHandler(this.noclip_Click);
            // 
            // godmode
            // 
            this.godmode.Location = new System.Drawing.Point(6, 50);
            this.godmode.Name = "godmode";
            this.godmode.Size = new System.Drawing.Size(90, 43);
            this.godmode.TabIndex = 1;
            this.godmode.Text = "God Mode";
            this.godmode.UseVisualStyleBackColor = true;
            this.godmode.Click += new System.EventHandler(this.godmode_Click);
            // 
            // thirdperson
            // 
            this.thirdperson.Location = new System.Drawing.Point(7, 99);
            this.thirdperson.Name = "thirdperson";
            this.thirdperson.Size = new System.Drawing.Size(94, 29);
            this.thirdperson.TabIndex = 2;
            this.thirdperson.Text = "Third Person";
            this.thirdperson.UseVisualStyleBackColor = true;
            this.thirdperson.Click += new System.EventHandler(this.thirdperson_Click);
            // 
            // resetTimeScale
            // 
            this.resetTimeScale.Location = new System.Drawing.Point(207, 134);
            this.resetTimeScale.Name = "resetTimeScale";
            this.resetTimeScale.Size = new System.Drawing.Size(94, 40);
            this.resetTimeScale.TabIndex = 3;
            this.resetTimeScale.Text = "Reset Time Scale";
            this.resetTimeScale.UseVisualStyleBackColor = true;
            this.resetTimeScale.Click += new System.EventHandler(this.resetTimeScale_Click);
            // 
            // maxTimeScale
            // 
            this.maxTimeScale.Location = new System.Drawing.Point(107, 134);
            this.maxTimeScale.Name = "maxTimeScale";
            this.maxTimeScale.Size = new System.Drawing.Size(94, 40);
            this.maxTimeScale.TabIndex = 4;
            this.maxTimeScale.Text = "Max Time Scale";
            this.maxTimeScale.UseVisualStyleBackColor = true;
            this.maxTimeScale.Click += new System.EventHandler(this.maxTimeScale_Click);
            // 
            // minTimeScale
            // 
            this.minTimeScale.Location = new System.Drawing.Point(7, 134);
            this.minTimeScale.Name = "minTimeScale";
            this.minTimeScale.Size = new System.Drawing.Size(94, 40);
            this.minTimeScale.TabIndex = 5;
            this.minTimeScale.Text = "Min Time Scale";
            this.minTimeScale.UseVisualStyleBackColor = true;
            this.minTimeScale.Click += new System.EventHandler(this.minTimeScale_Click);
            // 
            // fov100
            // 
            this.fov100.Location = new System.Drawing.Point(7, 180);
            this.fov100.Name = "fov100";
            this.fov100.Size = new System.Drawing.Size(94, 40);
            this.fov100.TabIndex = 6;
            this.fov100.Text = "Fov 100";
            this.fov100.UseVisualStyleBackColor = true;
            this.fov100.Click += new System.EventHandler(this.fov100_Click);
            // 
            // giveAmmo
            // 
            this.giveAmmo.Location = new System.Drawing.Point(107, 180);
            this.giveAmmo.Name = "giveAmmo";
            this.giveAmmo.Size = new System.Drawing.Size(94, 40);
            this.giveAmmo.TabIndex = 7;
            this.giveAmmo.Text = "Give Ammo";
            this.giveAmmo.UseVisualStyleBackColor = true;
            this.giveAmmo.Click += new System.EventHandler(this.giveAmmo_Click);
            // 
            // farKnife
            // 
            this.farKnife.Location = new System.Drawing.Point(102, 6);
            this.farKnife.Name = "farKnife";
            this.farKnife.Size = new System.Drawing.Size(94, 34);
            this.farKnife.TabIndex = 8;
            this.farKnife.Text = "Far Knife";
            this.farKnife.UseVisualStyleBackColor = true;
            this.farKnife.Click += new System.EventHandler(this.farKnife_Click);
            // 
            // dropWeapon
            // 
            this.dropWeapon.Location = new System.Drawing.Point(102, 50);
            this.dropWeapon.Name = "dropWeapon";
            this.dropWeapon.Size = new System.Drawing.Size(94, 43);
            this.dropWeapon.TabIndex = 9;
            this.dropWeapon.Text = "Drop Weapon";
            this.dropWeapon.UseVisualStyleBackColor = true;
            this.dropWeapon.Click += new System.EventHandler(this.dropWeapon_Click);
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(107, 99);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(94, 29);
            this.maxSpeed.TabIndex = 10;
            this.maxSpeed.Text = "Max Speed";
            this.maxSpeed.UseVisualStyleBackColor = true;
            this.maxSpeed.Click += new System.EventHandler(this.maxSpeed_Click);
            // 
            // normSpeed
            // 
            this.normSpeed.Location = new System.Drawing.Point(207, 99);
            this.normSpeed.Name = "normSpeed";
            this.normSpeed.Size = new System.Drawing.Size(94, 29);
            this.normSpeed.TabIndex = 11;
            this.normSpeed.Text = "Norm Speed";
            this.normSpeed.UseVisualStyleBackColor = true;
            this.normSpeed.Click += new System.EventHandler(this.normSpeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 321);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button noclip;
        private System.Windows.Forms.Button godmode;
        private System.Windows.Forms.Button thirdperson;
        private System.Windows.Forms.Button minTimeScale;
        private System.Windows.Forms.Button maxTimeScale;
        private System.Windows.Forms.Button resetTimeScale;
        private System.Windows.Forms.Button fov100;
        private System.Windows.Forms.Button giveAmmo;
        private System.Windows.Forms.Button farKnife;
        private System.Windows.Forms.Button dropWeapon;
        private System.Windows.Forms.Button maxSpeed;
        private System.Windows.Forms.Button normSpeed;
    }
}

