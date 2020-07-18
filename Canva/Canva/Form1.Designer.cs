namespace Canva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hexCode = new System.Windows.Forms.TextBox();
            this.colorPicker = new Nevron.Nov.WinFormControls.NHsbWheelColorPickerControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.colorTab = new System.Windows.Forms.TabPage();
            this.elementysTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.drawPanel = new System.Windows.Forms.PictureBox();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.hideTab = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.navigationBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.colorTab.SuspendLayout();
            this.elementysTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
            this.hidePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 64);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hexCode
            // 
            this.hexCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexCode.Location = new System.Drawing.Point(12, 248);
            this.hexCode.Name = "hexCode";
            this.hexCode.Size = new System.Drawing.Size(184, 31);
            this.hexCode.TabIndex = 1;
            this.hexCode.TextChanged += new System.EventHandler(this.hexCode_TextChanged);
            // 
            // colorPicker
            // 
            this.colorPicker.AutoSize = false;
            this.colorPicker.DesignTimeState = resources.GetString("colorPicker.DesignTimeState");
            this.colorPicker.Location = new System.Drawing.Point(6, 60);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(193, 171);
            this.colorPicker.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.colorTab);
            this.tabControl.Controls.Add(this.elementysTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 60);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(276, 599);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // colorTab
            // 
            this.colorTab.BackColor = System.Drawing.Color.Coral;
            this.colorTab.Controls.Add(this.hexCode);
            this.colorTab.Controls.Add(this.colorPicker);
            this.colorTab.Location = new System.Drawing.Point(64, 4);
            this.colorTab.Name = "colorTab";
            this.colorTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorTab.Size = new System.Drawing.Size(208, 591);
            this.colorTab.TabIndex = 0;
            this.colorTab.Text = "Color";
            // 
            // elementysTab
            // 
            this.elementysTab.Controls.Add(this.pictureBox1);
            this.elementysTab.Location = new System.Drawing.Point(64, 4);
            this.elementysTab.Name = "elementysTab";
            this.elementysTab.Padding = new System.Windows.Forms.Padding(3);
            this.elementysTab.Size = new System.Drawing.Size(208, 591);
            this.elementysTab.TabIndex = 1;
            this.elementysTab.Text = "Elements";
            this.elementysTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.drawPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(405, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 535);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(211, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 223);
            this.panel3.TabIndex = 1;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.drawPanel.Location = new System.Drawing.Point(41, 75);
            this.drawPanel.MinimumSize = new System.Drawing.Size(622, 354);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(622, 354);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.TabStop = false;
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hidePanel.Controls.Add(this.hideTab);
            this.hidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hidePanel.Location = new System.Drawing.Point(358, 0);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(47, 599);
            this.hidePanel.TabIndex = 1;
            // 
            // hideTab
            // 
            this.hideTab.Location = new System.Drawing.Point(2, 260);
            this.hideTab.Name = "hideTab";
            this.hideTab.Size = new System.Drawing.Size(41, 36);
            this.hideTab.TabIndex = 0;
            this.hideTab.Text = "Hide";
            this.hideTab.UseVisualStyleBackColor = true;
            this.hideTab.Click += new System.EventHandler(this.hideTab_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 599);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Elements";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navigationBar
            // 
            this.navigationBar.Controls.Add(this.tabControl);
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationBar.Location = new System.Drawing.Point(82, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(276, 599);
            this.navigationBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.colorTab.ResumeLayout(false);
            this.colorTab.PerformLayout();
            this.elementysTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
            this.hidePanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.navigationBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Nevron.Nov.WinFormControls.NHsbWheelColorPickerControl colorPicker;
        private System.Windows.Forms.TextBox hexCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage colorTab;
        private System.Windows.Forms.TabPage elementysTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Button hideTab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox drawPanel;
        private System.Windows.Forms.Panel panel3;
    }
}

