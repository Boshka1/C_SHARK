namespace para7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            выборToolStripMenuItem = new ToolStripMenuItem();
            товарыToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            наклданыеToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выборToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выборToolStripMenuItem
            // 
            выборToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { товарыToolStripMenuItem, клиентыToolStripMenuItem, наклданыеToolStripMenuItem, отчетыToolStripMenuItem });
            выборToolStripMenuItem.Name = "выборToolStripMenuItem";
            выборToolStripMenuItem.Size = new Size(56, 20);
            выборToolStripMenuItem.Text = "Выбор";
            // 
            // товарыToolStripMenuItem
            // 
            товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            товарыToolStripMenuItem.Size = new Size(180, 22);
            товарыToolStripMenuItem.Text = "Товары";
            товарыToolStripMenuItem.Click += товарыToolStripMenuItem_Click;
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(180, 22);
            клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // наклданыеToolStripMenuItem
            // 
            наклданыеToolStripMenuItem.Name = "наклданыеToolStripMenuItem";
            наклданыеToolStripMenuItem.Size = new Size(180, 22);
            наклданыеToolStripMenuItem.Text = "Наклданые";
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(180, 22);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem выборToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem наклданыеToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}
