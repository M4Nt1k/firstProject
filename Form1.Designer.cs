namespace Че_то
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attackEnemy = new System.Windows.Forms.Button();
            this.resistFromEnemy = new System.Windows.Forms.Button();
            this.playerHpProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyHpProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyHpPercent = new System.Windows.Forms.Label();
            this.playerHpPercent = new System.Windows.Forms.Label();
            this.playerStats = new System.Windows.Forms.Label();
            this.playerHps = new System.Windows.Forms.Label();
            this.playerResistance = new System.Windows.Forms.Label();
            this.playerDamage = new System.Windows.Forms.Label();
            this.enemyStats = new System.Windows.Forms.Label();
            this.enemyHps = new System.Windows.Forms.Label();
            this.enemyResistance = new System.Windows.Forms.Label();
            this.enemyDamage = new System.Windows.Forms.Label();
            this.winBanner = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.enemyEvent = new System.Windows.Forms.Label();
            this.killCounter = new System.Windows.Forms.Label();
            this.progressChargeAttack = new System.Windows.Forms.ProgressBar();
            this.igni = new System.Windows.Forms.PictureBox();
            this.fire = new System.Windows.Forms.PictureBox();
            this.progressChargedShield = new System.Windows.Forms.ProgressBar();
            this.quen = new System.Windows.Forms.PictureBox();
            this.shield = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            this.SuspendLayout();
            // 
            // attackEnemy
            // 
            this.attackEnemy.Location = new System.Drawing.Point(348, 374);
            this.attackEnemy.Name = "attackEnemy";
            this.attackEnemy.Size = new System.Drawing.Size(84, 23);
            this.attackEnemy.TabIndex = 2;
            this.attackEnemy.Text = "Атаковать";
            this.attackEnemy.UseVisualStyleBackColor = true;
            this.attackEnemy.Click += new System.EventHandler(this.attackEnemy_Click);
            // 
            // resistFromEnemy
            // 
            this.resistFromEnemy.Location = new System.Drawing.Point(158, 374);
            this.resistFromEnemy.Name = "resistFromEnemy";
            this.resistFromEnemy.Size = new System.Drawing.Size(83, 23);
            this.resistFromEnemy.TabIndex = 3;
            this.resistFromEnemy.Text = "Защититься";
            this.resistFromEnemy.UseVisualStyleBackColor = true;
            this.resistFromEnemy.Click += new System.EventHandler(this.resistFromEnemy_Click);
            // 
            // playerHpProgressBar
            // 
            this.playerHpProgressBar.Location = new System.Drawing.Point(155, 345);
            this.playerHpProgressBar.Name = "playerHpProgressBar";
            this.playerHpProgressBar.Size = new System.Drawing.Size(90, 23);
            this.playerHpProgressBar.TabIndex = 4;
            this.playerHpProgressBar.Value = 100;
            // 
            // enemyHpProgressBar
            // 
            this.enemyHpProgressBar.Location = new System.Drawing.Point(345, 345);
            this.enemyHpProgressBar.Name = "enemyHpProgressBar";
            this.enemyHpProgressBar.Size = new System.Drawing.Size(90, 23);
            this.enemyHpProgressBar.TabIndex = 5;
            this.enemyHpProgressBar.Value = 100;
            // 
            // enemyHpPercent
            // 
            this.enemyHpPercent.AutoSize = true;
            this.enemyHpPercent.BackColor = System.Drawing.Color.Transparent;
            this.enemyHpPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemyHpPercent.Location = new System.Drawing.Point(437, 350);
            this.enemyHpPercent.Name = "enemyHpPercent";
            this.enemyHpPercent.Size = new System.Drawing.Size(51, 13);
            this.enemyHpPercent.TabIndex = 6;
            this.enemyHpPercent.Text = "100% HP";
            // 
            // playerHpPercent
            // 
            this.playerHpPercent.AutoSize = true;
            this.playerHpPercent.BackColor = System.Drawing.Color.Transparent;
            this.playerHpPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerHpPercent.Location = new System.Drawing.Point(247, 350);
            this.playerHpPercent.Name = "playerHpPercent";
            this.playerHpPercent.Size = new System.Drawing.Size(51, 13);
            this.playerHpPercent.TabIndex = 6;
            this.playerHpPercent.Text = "100% HP";
            // 
            // playerStats
            // 
            this.playerStats.AutoSize = true;
            this.playerStats.BackColor = System.Drawing.Color.Transparent;
            this.playerStats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerStats.Location = new System.Drawing.Point(12, 193);
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(121, 13);
            this.playerStats.TabIndex = 7;
            this.playerStats.Text = "Ваши характеристики:";
            // 
            // playerHps
            // 
            this.playerHps.AutoSize = true;
            this.playerHps.BackColor = System.Drawing.Color.Transparent;
            this.playerHps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerHps.Location = new System.Drawing.Point(12, 207);
            this.playerHps.Name = "playerHps";
            this.playerHps.Size = new System.Drawing.Size(80, 13);
            this.playerHps.TabIndex = 7;
            this.playerHps.Text = "Здоровье: 123";
            // 
            // playerResistance
            // 
            this.playerResistance.AutoSize = true;
            this.playerResistance.BackColor = System.Drawing.Color.Transparent;
            this.playerResistance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerResistance.Location = new System.Drawing.Point(12, 222);
            this.playerResistance.Name = "playerResistance";
            this.playerResistance.Size = new System.Drawing.Size(56, 13);
            this.playerResistance.TabIndex = 7;
            this.playerResistance.Text = "Броня: 31";
            // 
            // playerDamage
            // 
            this.playerDamage.AutoSize = true;
            this.playerDamage.BackColor = System.Drawing.Color.Transparent;
            this.playerDamage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerDamage.Location = new System.Drawing.Point(12, 237);
            this.playerDamage.Name = "playerDamage";
            this.playerDamage.Size = new System.Drawing.Size(51, 13);
            this.playerDamage.TabIndex = 7;
            this.playerDamage.Text = "Урон: 32";
            // 
            // enemyStats
            // 
            this.enemyStats.AutoSize = true;
            this.enemyStats.BackColor = System.Drawing.Color.Transparent;
            this.enemyStats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemyStats.Location = new System.Drawing.Point(452, 193);
            this.enemyStats.Name = "enemyStats";
            this.enemyStats.Size = new System.Drawing.Size(155, 13);
            this.enemyStats.TabIndex = 7;
            this.enemyStats.Text = "Характеристики противника:";
            // 
            // enemyHps
            // 
            this.enemyHps.AutoSize = true;
            this.enemyHps.BackColor = System.Drawing.Color.Transparent;
            this.enemyHps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemyHps.Location = new System.Drawing.Point(452, 207);
            this.enemyHps.Name = "enemyHps";
            this.enemyHps.Size = new System.Drawing.Size(80, 13);
            this.enemyHps.TabIndex = 7;
            this.enemyHps.Text = "Здоровье: 123";
            // 
            // enemyResistance
            // 
            this.enemyResistance.AutoSize = true;
            this.enemyResistance.BackColor = System.Drawing.Color.Transparent;
            this.enemyResistance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemyResistance.Location = new System.Drawing.Point(452, 222);
            this.enemyResistance.Name = "enemyResistance";
            this.enemyResistance.Size = new System.Drawing.Size(56, 13);
            this.enemyResistance.TabIndex = 7;
            this.enemyResistance.Text = "Броня: 31";
            // 
            // enemyDamage
            // 
            this.enemyDamage.AutoSize = true;
            this.enemyDamage.BackColor = System.Drawing.Color.Transparent;
            this.enemyDamage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemyDamage.Location = new System.Drawing.Point(452, 237);
            this.enemyDamage.Name = "enemyDamage";
            this.enemyDamage.Size = new System.Drawing.Size(51, 13);
            this.enemyDamage.TabIndex = 7;
            this.enemyDamage.Text = "Урон: 32";
            // 
            // winBanner
            // 
            this.winBanner.AutoSize = true;
            this.winBanner.BackColor = System.Drawing.Color.Transparent;
            this.winBanner.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winBanner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winBanner.Location = new System.Drawing.Point(212, 37);
            this.winBanner.Name = "winBanner";
            this.winBanner.Size = new System.Drawing.Size(179, 32);
            this.winBanner.TabIndex = 8;
            this.winBanner.Text = "Вы победили!";
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(8, 415);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 11;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(345, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // enemyEvent
            // 
            this.enemyEvent.AutoSize = true;
            this.enemyEvent.BackColor = System.Drawing.Color.Transparent;
            this.enemyEvent.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.enemyEvent.Location = new System.Drawing.Point(246, 403);
            this.enemyEvent.Name = "enemyEvent";
            this.enemyEvent.Size = new System.Drawing.Size(52, 21);
            this.enemyEvent.TabIndex = 14;
            this.enemyEvent.Text = "event";
            // 
            // killCounter
            // 
            this.killCounter.AutoSize = true;
            this.killCounter.BackColor = System.Drawing.Color.Transparent;
            this.killCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.killCounter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.killCounter.Location = new System.Drawing.Point(490, 9);
            this.killCounter.Name = "killCounter";
            this.killCounter.Size = new System.Drawing.Size(141, 18);
            this.killCounter.TabIndex = 15;
            this.killCounter.Text = "Счетчик убийств: 0";
            // 
            // progressChargeAttack
            // 
            this.progressChargeAttack.Location = new System.Drawing.Point(155, 307);
            this.progressChargeAttack.Name = "progressChargeAttack";
            this.progressChargeAttack.Size = new System.Drawing.Size(90, 23);
            this.progressChargeAttack.Step = 0;
            this.progressChargeAttack.TabIndex = 16;
            // 
            // igni
            // 
            this.igni.Location = new System.Drawing.Point(127, 307);
            this.igni.Name = "igni";
            this.igni.Size = new System.Drawing.Size(23, 23);
            this.igni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.igni.TabIndex = 17;
            this.igni.TabStop = false;
            this.igni.Click += new System.EventHandler(this.igni_Click);
            // 
            // fire
            // 
            this.fire.Location = new System.Drawing.Point(440, 112);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(26, 26);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire.TabIndex = 18;
            this.fire.TabStop = false;
            // 
            // progressChargedShield
            // 
            this.progressChargedShield.Location = new System.Drawing.Point(155, 278);
            this.progressChargedShield.Name = "progressChargedShield";
            this.progressChargedShield.Size = new System.Drawing.Size(90, 23);
            this.progressChargedShield.Step = 0;
            this.progressChargedShield.TabIndex = 19;
            // 
            // quen
            // 
            this.quen.Location = new System.Drawing.Point(127, 278);
            this.quen.Name = "quen";
            this.quen.Size = new System.Drawing.Size(23, 23);
            this.quen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quen.TabIndex = 20;
            this.quen.TabStop = false;
            this.quen.Click += new System.EventHandler(this.quen_Click);
            // 
            // shield
            // 
            this.shield.Location = new System.Drawing.Point(124, 112);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(26, 26);
            this.shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shield.TabIndex = 21;
            this.shield.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Че_то.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.quen);
            this.Controls.Add(this.progressChargedShield);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.igni);
            this.Controls.Add(this.progressChargeAttack);
            this.Controls.Add(this.killCounter);
            this.Controls.Add(this.enemyEvent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.winBanner);
            this.Controls.Add(this.enemyDamage);
            this.Controls.Add(this.playerDamage);
            this.Controls.Add(this.enemyResistance);
            this.Controls.Add(this.playerResistance);
            this.Controls.Add(this.enemyHps);
            this.Controls.Add(this.playerHps);
            this.Controls.Add(this.enemyStats);
            this.Controls.Add(this.playerStats);
            this.Controls.Add(this.playerHpPercent);
            this.Controls.Add(this.enemyHpPercent);
            this.Controls.Add(this.enemyHpProgressBar);
            this.Controls.Add(this.playerHpProgressBar);
            this.Controls.Add(this.resistFromEnemy);
            this.Controls.Add(this.attackEnemy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(660, 490);
            this.MinimumSize = new System.Drawing.Size(660, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "unrealGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackEnemy;
        private System.Windows.Forms.Button resistFromEnemy;
        private System.Windows.Forms.ProgressBar playerHpProgressBar;
        private System.Windows.Forms.ProgressBar enemyHpProgressBar;
        private System.Windows.Forms.Label enemyHpPercent;
        private System.Windows.Forms.Label playerHpPercent;
        private System.Windows.Forms.Label playerStats;
        private System.Windows.Forms.Label playerHps;
        private System.Windows.Forms.Label playerResistance;
        private System.Windows.Forms.Label playerDamage;
        private System.Windows.Forms.Label enemyStats;
        private System.Windows.Forms.Label enemyHps;
        private System.Windows.Forms.Label enemyResistance;
        private System.Windows.Forms.Label enemyDamage;
        private System.Windows.Forms.Label winBanner;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label enemyEvent;
        private System.Windows.Forms.Label killCounter;
        private System.Windows.Forms.ProgressBar progressChargeAttack;
        private System.Windows.Forms.PictureBox igni;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.ProgressBar progressChargedShield;
        private System.Windows.Forms.PictureBox quen;
        private System.Windows.Forms.PictureBox shield;
    }
}

