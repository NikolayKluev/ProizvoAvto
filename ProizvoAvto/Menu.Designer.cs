namespace ProizvoAvto
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.станкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производственныеЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.станкиToolStripMenuItem,
            this.производственныеЛинииToolStripMenuItem,
            this.датчикиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // станкиToolStripMenuItem
            // 
            this.станкиToolStripMenuItem.Name = "станкиToolStripMenuItem";
            this.станкиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.станкиToolStripMenuItem.Text = "Станки";
            this.станкиToolStripMenuItem.Click += new System.EventHandler(this.станкиToolStripMenuItem_Click);
            // 
            // производственныеЛинииToolStripMenuItem
            // 
            this.производственныеЛинииToolStripMenuItem.Name = "производственныеЛинииToolStripMenuItem";
            this.производственныеЛинииToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.производственныеЛинииToolStripMenuItem.Text = "Производственные линии";
            this.производственныеЛинииToolStripMenuItem.Click += new System.EventHandler(this.производственныеЛинииToolStripMenuItem_Click);
            // 
            // датчикиToolStripMenuItem
            // 
            this.датчикиToolStripMenuItem.Name = "датчикиToolStripMenuItem";
            this.датчикиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.датчикиToolStripMenuItem.Text = "Датчики";
            this.датчикиToolStripMenuItem.Click += new System.EventHandler(this.датчикиToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem станкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производственныеЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датчикиToolStripMenuItem;
    }
}