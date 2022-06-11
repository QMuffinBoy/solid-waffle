
namespace Example_Forms
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.Background = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanelBG = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FunnyText = new DarkUI.Controls.DarkLabel();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomPanelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Background.Controls.Add(this.pictureBox1);
            this.Background.Controls.Add(this.BottomPanelBG);
            this.Background.Controls.Add(this.FunnyText);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.ForeColor = System.Drawing.Color.White;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(464, 176);
            this.Background.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BottomPanelBG
            // 
            this.BottomPanelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BottomPanelBG.Controls.Add(this.CloseButton);
            this.BottomPanelBG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanelBG.Location = new System.Drawing.Point(0, 136);
            this.BottomPanelBG.Name = "BottomPanelBG";
            this.BottomPanelBG.Size = new System.Drawing.Size(464, 40);
            this.BottomPanelBG.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(379, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "&OK";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FunnyText
            // 
            this.FunnyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunnyText.AutoUpdateHeight = true;
            this.FunnyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FunnyText.Location = new System.Drawing.Point(58, 13);
            this.FunnyText.Name = "FunnyText";
            this.FunnyText.Size = new System.Drawing.Size(364, 105);
            this.FunnyText.TabIndex = 1;
            this.FunnyText.Text = resources.GetString("FunnyText.Text");
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(464, 176);
            this.Controls.Add(this.Background);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "(FAKE) RegSvr32";
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomPanelBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private DarkUI.Controls.DarkLabel FunnyText;
        private System.Windows.Forms.Panel BottomPanelBG;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}