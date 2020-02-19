namespace blackjack
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.playButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.card = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.hitButton = new System.Windows.Forms.PictureBox();
            this.standButton = new System.Windows.Forms.PictureBox();
            this.standLabel = new System.Windows.Forms.Label();
            this.hitLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standButton)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Location = new System.Drawing.Point(0, 363);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(949, 94);
            this.playButton.TabIndex = 0;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(949, 314);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card.BackgroundImage")));
            this.card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.card.Location = new System.Drawing.Point(375, 349);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(103, 157);
            this.card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card.TabIndex = 2;
            this.card.TabStop = false;
            this.card.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animation
            // 
            this.animation.Interval = 20;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Transparent;
            this.hitButton.BackgroundImage = global::blackjack.Properties.Resources.hit;
            this.hitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hitButton.Location = new System.Drawing.Point(306, 349);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(59, 56);
            this.hitButton.TabIndex = 4;
            this.hitButton.TabStop = false;
            this.hitButton.Visible = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.Transparent;
            this.standButton.BackgroundImage = global::blackjack.Properties.Resources.stand;
            this.standButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.standButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standButton.Location = new System.Drawing.Point(306, 428);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(59, 56);
            this.standButton.TabIndex = 5;
            this.standButton.TabStop = false;
            this.standButton.Visible = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // standLabel
            // 
            this.standLabel.AutoSize = true;
            this.standLabel.BackColor = System.Drawing.Color.Transparent;
            this.standLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.standLabel.ForeColor = System.Drawing.Color.White;
            this.standLabel.Location = new System.Drawing.Point(309, 485);
            this.standLabel.Name = "standLabel";
            this.standLabel.Size = new System.Drawing.Size(50, 17);
            this.standLabel.TabIndex = 6;
            this.standLabel.Text = "Stand";
            this.standLabel.Visible = false;
            // 
            // hitLabel
            // 
            this.hitLabel.AutoSize = true;
            this.hitLabel.BackColor = System.Drawing.Color.Transparent;
            this.hitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hitLabel.ForeColor = System.Drawing.Color.White;
            this.hitLabel.Location = new System.Drawing.Point(322, 407);
            this.hitLabel.Name = "hitLabel";
            this.hitLabel.Size = new System.Drawing.Size(28, 17);
            this.hitLabel.TabIndex = 7;
            this.hitLabel.Text = "Hit";
            this.hitLabel.Visible = false;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerLabel.ForeColor = System.Drawing.Color.White;
            this.playerLabel.Location = new System.Drawing.Point(459, 317);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(23, 25);
            this.playerLabel.TabIndex = 8;
            this.playerLabel.Text = "0";
            this.playerLabel.Visible = false;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 509);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.hitLabel);
            this.Controls.Add(this.standLabel);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.card);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.playButton);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox card;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.PictureBox hitButton;
        private System.Windows.Forms.PictureBox standButton;
        private System.Windows.Forms.Label standLabel;
        private System.Windows.Forms.Label hitLabel;
        private System.Windows.Forms.Label playerLabel;
    }
}

