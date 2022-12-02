namespace DisplayChanger
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pCScreenOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondDisplayOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondScreenOnly = new System.Windows.Forms.Button();
            this.Extend = new System.Windows.Forms.Button();
            this.Duplicate = new System.Windows.Forms.Button();
            this.PCScreenOnly = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem,
            this.toolStripSeparator2,
            this.pCScreenOnlyToolStripMenuItem,
            this.duplicateDisplayToolStripMenuItem,
            this.extendDisplayToolStripMenuItem,
            this.secondDisplayOnlyToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 190);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.topMostToolStripMenuItem.Text = "TopMost";
            this.topMostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topMostToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 10);
            // 
            // pCScreenOnlyToolStripMenuItem
            // 
            this.pCScreenOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pCScreenOnlyToolStripMenuItem.Name = "pCScreenOnlyToolStripMenuItem";
            this.pCScreenOnlyToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.pCScreenOnlyToolStripMenuItem.Text = "PC Display Only";
            this.pCScreenOnlyToolStripMenuItem.Click += new System.EventHandler(this.pCScreenOnlyToolStripMenuItem_Click);
            // 
            // duplicateDisplayToolStripMenuItem
            // 
            this.duplicateDisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.duplicateDisplayToolStripMenuItem.Name = "duplicateDisplayToolStripMenuItem";
            this.duplicateDisplayToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.duplicateDisplayToolStripMenuItem.Text = "Duplicate Display";
            this.duplicateDisplayToolStripMenuItem.Click += new System.EventHandler(this.duplicateDisplayToolStripMenuItem_Click);
            // 
            // extendDisplayToolStripMenuItem
            // 
            this.extendDisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.extendDisplayToolStripMenuItem.Name = "extendDisplayToolStripMenuItem";
            this.extendDisplayToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.extendDisplayToolStripMenuItem.Text = "Extend Display";
            this.extendDisplayToolStripMenuItem.Click += new System.EventHandler(this.extendDisplayToolStripMenuItem_Click);
            // 
            // secondDisplayOnlyToolStripMenuItem
            // 
            this.secondDisplayOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.secondDisplayOnlyToolStripMenuItem.Name = "secondDisplayOnlyToolStripMenuItem";
            this.secondDisplayOnlyToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.secondDisplayOnlyToolStripMenuItem.Text = "Second Display Only";
            this.secondDisplayOnlyToolStripMenuItem.Click += new System.EventHandler(this.secondDisplayOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 10);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SecondScreenOnly
            // 
            this.SecondScreenOnly.FlatAppearance.BorderSize = 0;
            this.SecondScreenOnly.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondScreenOnly.ForeColor = System.Drawing.Color.Black;
            this.SecondScreenOnly.Image = global::DisplayChanger.Properties.Resources.SecondScreenOnly;
            this.SecondScreenOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SecondScreenOnly.Location = new System.Drawing.Point(12, 186);
            this.SecondScreenOnly.Name = "SecondScreenOnly";
            this.SecondScreenOnly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondScreenOnly.Size = new System.Drawing.Size(402, 52);
            this.SecondScreenOnly.TabIndex = 7;
            this.SecondScreenOnly.Text = "Second Display Only";
            this.SecondScreenOnly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondScreenOnly.UseVisualStyleBackColor = true;
            this.SecondScreenOnly.Click += new System.EventHandler(this.SecondScreenOnly_Click);
            // 
            // Extend
            // 
            this.Extend.FlatAppearance.BorderSize = 0;
            this.Extend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extend.ForeColor = System.Drawing.Color.Black;
            this.Extend.Image = ((System.Drawing.Image)(resources.GetObject("Extend.Image")));
            this.Extend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Extend.Location = new System.Drawing.Point(12, 128);
            this.Extend.Name = "Extend";
            this.Extend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Extend.Size = new System.Drawing.Size(402, 52);
            this.Extend.TabIndex = 6;
            this.Extend.Text = "Extend Display";
            this.Extend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Extend.UseVisualStyleBackColor = true;
            this.Extend.Click += new System.EventHandler(this.Extend_Click);
            // 
            // Duplicate
            // 
            this.Duplicate.FlatAppearance.BorderSize = 0;
            this.Duplicate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duplicate.ForeColor = System.Drawing.Color.Black;
            this.Duplicate.Image = global::DisplayChanger.Properties.Resources.Duplicate;
            this.Duplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Duplicate.Location = new System.Drawing.Point(12, 70);
            this.Duplicate.Name = "Duplicate";
            this.Duplicate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Duplicate.Size = new System.Drawing.Size(402, 52);
            this.Duplicate.TabIndex = 5;
            this.Duplicate.Text = "Duplicate Display";
            this.Duplicate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Duplicate.UseVisualStyleBackColor = true;
            this.Duplicate.Click += new System.EventHandler(this.Duplicate_Click);
            // 
            // PCScreenOnly
            // 
            this.PCScreenOnly.FlatAppearance.BorderSize = 0;
            this.PCScreenOnly.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCScreenOnly.ForeColor = System.Drawing.Color.Black;
            this.PCScreenOnly.Image = ((System.Drawing.Image)(resources.GetObject("PCScreenOnly.Image")));
            this.PCScreenOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PCScreenOnly.Location = new System.Drawing.Point(12, 12);
            this.PCScreenOnly.Name = "PCScreenOnly";
            this.PCScreenOnly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PCScreenOnly.Size = new System.Drawing.Size(402, 52);
            this.PCScreenOnly.TabIndex = 4;
            this.PCScreenOnly.Text = "PC Display Only";
            this.PCScreenOnly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCScreenOnly.UseVisualStyleBackColor = true;
            this.PCScreenOnly.Click += new System.EventHandler(this.PCScreenOnly_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "DisplaySwitcher";
            this.notifyIcon1.BalloonTipTitle = "DisplaySwitcher";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DisplaySwitcher";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 251);
            this.Controls.Add(this.SecondScreenOnly);
            this.Controls.Add(this.Extend);
            this.Controls.Add(this.Duplicate);
            this.Controls.Add(this.PCScreenOnly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 290);
            this.MinimumSize = new System.Drawing.Size(442, 290);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplaySwitcher";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PCScreenOnly;
        private System.Windows.Forms.Button Duplicate;
        private System.Windows.Forms.Button Extend;
        private System.Windows.Forms.Button SecondScreenOnly;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pCScreenOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondDisplayOnlyToolStripMenuItem;
    }
}

