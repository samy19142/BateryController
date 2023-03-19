namespace BateryController
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkJuego = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAutomaticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPorcentaje.Location = new System.Drawing.Point(143, 179);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(95, 20);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.BackColor = System.Drawing.Color.Black;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMensajes.Location = new System.Drawing.Point(169, 8);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(69, 20);
            this.lblMensajes.TabIndex = 3;
            this.lblMensajes.Text = "Mensaje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkJuego
            // 
            this.checkJuego.AutoSize = true;
            this.checkJuego.BackColor = System.Drawing.Color.Black;
            this.checkJuego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkJuego.Location = new System.Drawing.Point(9, 12);
            this.checkJuego.Name = "checkJuego";
            this.checkJuego.Size = new System.Drawing.Size(85, 17);
            this.checkJuego.TabIndex = 5;
            this.checkJuego.Text = "Modo Juego";
            this.checkJuego.UseVisualStyleBackColor = false;
            this.checkJuego.CheckedChanged += new System.EventHandler(this.checkJuego_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sam_App";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoJuegoToolStripMenuItem,
            this.modoAutomaticoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            // 
            // modoJuegoToolStripMenuItem
            // 
            this.modoJuegoToolStripMenuItem.Name = "modoJuegoToolStripMenuItem";
            this.modoJuegoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modoJuegoToolStripMenuItem.Text = "Modo Juego";
            this.modoJuegoToolStripMenuItem.Click += new System.EventHandler(this.modoJuegoToolStripMenuItem_Click);
            // 
            // modoAutomaticoToolStripMenuItem
            // 
            this.modoAutomaticoToolStripMenuItem.Name = "modoAutomaticoToolStripMenuItem";
            this.modoAutomaticoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modoAutomaticoToolStripMenuItem.Text = "Modo Automatico";
            this.modoAutomaticoToolStripMenuItem.Click += new System.EventHandler(this.modoAutomaticoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 240);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 233);
            this.Controls.Add(this.checkJuego);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bateria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkJuego;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoAutomaticoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

