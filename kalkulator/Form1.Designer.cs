namespace kalkulator
{
    partial class FormKalkulator
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
            this.radioButtondodawanie = new System.Windows.Forms.RadioButton();
            this.buttonLiczenie = new System.Windows.Forms.Button();
            this.textBoxliczba1 = new System.Windows.Forms.TextBox();
            this.textBoxliczba2 = new System.Windows.Forms.TextBox();
            this.labelrownasie = new System.Windows.Forms.Label();
            this.radioButtonodejmowanie = new System.Windows.Forms.RadioButton();
            this.radioButtonMnozenie = new System.Windows.Forms.RadioButton();
            this.radioButtondzielenie = new System.Windows.Forms.RadioButton();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.groupBoxDzialania = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.zerujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbyToolStripMenuItemLiczby = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rzeczywisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItemPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDzialania.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtondodawanie
            // 
            this.radioButtondodawanie.AutoSize = true;
            this.radioButtondodawanie.Location = new System.Drawing.Point(33, 53);
            this.radioButtondodawanie.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtondodawanie.Name = "radioButtondodawanie";
            this.radioButtondodawanie.Size = new System.Drawing.Size(39, 28);
            this.radioButtondodawanie.TabIndex = 0;
            this.radioButtondodawanie.TabStop = true;
            this.radioButtondodawanie.Text = "+";
            this.radioButtondodawanie.UseVisualStyleBackColor = true;
            this.radioButtondodawanie.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonLiczenie
            // 
            this.buttonLiczenie.Location = new System.Drawing.Point(277, 367);
            this.buttonLiczenie.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLiczenie.Name = "buttonLiczenie";
            this.buttonLiczenie.Size = new System.Drawing.Size(138, 42);
            this.buttonLiczenie.TabIndex = 1;
            this.buttonLiczenie.Text = "Oblicz";
            this.buttonLiczenie.UseVisualStyleBackColor = true;
            this.buttonLiczenie.Click += new System.EventHandler(this.buttonLiczenie_Click);
            // 
            // textBoxliczba1
            // 
            this.textBoxliczba1.Location = new System.Drawing.Point(110, 255);
            this.textBoxliczba1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxliczba1.Name = "textBoxliczba1";
            this.textBoxliczba1.Size = new System.Drawing.Size(65, 29);
            this.textBoxliczba1.TabIndex = 2;
            this.textBoxliczba1.TextChanged += new System.EventHandler(this.textBoxliczba1_TextChanged);
            // 
            // textBoxliczba2
            // 
            this.textBoxliczba2.Location = new System.Drawing.Point(295, 255);
            this.textBoxliczba2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxliczba2.Name = "textBoxliczba2";
            this.textBoxliczba2.Size = new System.Drawing.Size(67, 29);
            this.textBoxliczba2.TabIndex = 3;
            this.textBoxliczba2.TextChanged += new System.EventHandler(this.textBoxliczba2_TextChanged);
            // 
            // labelrownasie
            // 
            this.labelrownasie.AutoSize = true;
            this.labelrownasie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelrownasie.Location = new System.Drawing.Point(391, 259);
            this.labelrownasie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelrownasie.Name = "labelrownasie";
            this.labelrownasie.Size = new System.Drawing.Size(24, 25);
            this.labelrownasie.TabIndex = 4;
            this.labelrownasie.Text = "=";
            this.labelrownasie.Click += new System.EventHandler(this.labelrownasie_Click);
            // 
            // radioButtonodejmowanie
            // 
            this.radioButtonodejmowanie.AutoSize = true;
            this.radioButtonodejmowanie.Location = new System.Drawing.Point(33, 77);
            this.radioButtonodejmowanie.Name = "radioButtonodejmowanie";
            this.radioButtonodejmowanie.Size = new System.Drawing.Size(34, 28);
            this.radioButtonodejmowanie.TabIndex = 5;
            this.radioButtonodejmowanie.TabStop = true;
            this.radioButtonodejmowanie.Text = "-";
            this.radioButtonodejmowanie.UseVisualStyleBackColor = true;
            this.radioButtonodejmowanie.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMnozenie
            // 
            this.radioButtonMnozenie.AutoSize = true;
            this.radioButtonMnozenie.Location = new System.Drawing.Point(32, 102);
            this.radioButtonMnozenie.Name = "radioButtonMnozenie";
            this.radioButtonMnozenie.Size = new System.Drawing.Size(35, 28);
            this.radioButtonMnozenie.TabIndex = 6;
            this.radioButtonMnozenie.TabStop = true;
            this.radioButtonMnozenie.Text = "*";
            this.radioButtonMnozenie.UseVisualStyleBackColor = true;
            this.radioButtonMnozenie.CheckedChanged += new System.EventHandler(this.radioButtonmnozenie_CheckedChanged);
            // 
            // radioButtondzielenie
            // 
            this.radioButtondzielenie.AutoSize = true;
            this.radioButtondzielenie.Location = new System.Drawing.Point(32, 126);
            this.radioButtondzielenie.Name = "radioButtondzielenie";
            this.radioButtondzielenie.Size = new System.Drawing.Size(33, 28);
            this.radioButtondzielenie.TabIndex = 7;
            this.radioButtondzielenie.TabStop = true;
            this.radioButtondzielenie.Text = "/";
            this.radioButtondzielenie.UseVisualStyleBackColor = true;
            this.radioButtondzielenie.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(442, 255);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.ReadOnly = true;
            this.textBoxWynik.Size = new System.Drawing.Size(100, 29);
            this.textBoxWynik.TabIndex = 8;
            this.textBoxWynik.TextChanged += new System.EventHandler(this.textBoxWynik_TextChanged);
            // 
            // groupBoxDzialania
            // 
            this.groupBoxDzialania.Controls.Add(this.label1);
            this.groupBoxDzialania.Controls.Add(this.radioButtondodawanie);
            this.groupBoxDzialania.Controls.Add(this.radioButtonodejmowanie);
            this.groupBoxDzialania.Controls.Add(this.radioButtondzielenie);
            this.groupBoxDzialania.Controls.Add(this.radioButtonMnozenie);
            this.groupBoxDzialania.Location = new System.Drawing.Point(184, 195);
            this.groupBoxDzialania.Name = "groupBoxDzialania";
            this.groupBoxDzialania.Size = new System.Drawing.Size(95, 173);
            this.groupBoxDzialania.TabIndex = 9;
            this.groupBoxDzialania.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Działania:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlik,
            this.liczbyToolStripMenuItemLiczby,
            this.pomocToolStripMenuItemPomoc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemPlik
            // 
            this.toolStripMenuItemPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zerujToolStripMenuItem,
            this.zamknijAltF4ToolStripMenuItem});
            this.toolStripMenuItemPlik.Name = "toolStripMenuItemPlik";
            this.toolStripMenuItemPlik.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItemPlik.Text = "Plik";
            // 
            // zerujToolStripMenuItem
            // 
            this.zerujToolStripMenuItem.Name = "zerujToolStripMenuItem";
            this.zerujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zerujToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.zerujToolStripMenuItem.Text = "Zeruj     Ctrl+0";
            this.zerujToolStripMenuItem.Click += new System.EventHandler(this.zerujToolStripMenuItem_Click);
            // 
            // zamknijAltF4ToolStripMenuItem
            // 
            this.zamknijAltF4ToolStripMenuItem.Name = "zamknijAltF4ToolStripMenuItem";
            this.zamknijAltF4ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.zamknijAltF4ToolStripMenuItem.Text = "Zamknij  Alt+F4";
            this.zamknijAltF4ToolStripMenuItem.Click += new System.EventHandler(this.zamknijAltF4ToolStripMenuItem_Click);
            // 
            // liczbyToolStripMenuItemLiczby
            // 
            this.liczbyToolStripMenuItemLiczby.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naturalneToolStripMenuItem,
            this.rzeczywisteToolStripMenuItem});
            this.liczbyToolStripMenuItemLiczby.Name = "liczbyToolStripMenuItemLiczby";
            this.liczbyToolStripMenuItemLiczby.Size = new System.Drawing.Size(52, 20);
            this.liczbyToolStripMenuItemLiczby.Text = "Liczby";
            // 
            // naturalneToolStripMenuItem
            // 
            this.naturalneToolStripMenuItem.Name = "naturalneToolStripMenuItem";
            this.naturalneToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.naturalneToolStripMenuItem.Text = "Naturalne";
            // 
            // rzeczywisteToolStripMenuItem
            // 
            this.rzeczywisteToolStripMenuItem.Name = "rzeczywisteToolStripMenuItem";
            this.rzeczywisteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.rzeczywisteToolStripMenuItem.Text = "Rzeczywiste";
            // 
            // pomocToolStripMenuItemPomoc
            // 
            this.pomocToolStripMenuItemPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem});
            this.pomocToolStripMenuItemPomoc.Name = "pomocToolStripMenuItemPomoc";
            this.pomocToolStripMenuItemPomoc.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItemPomoc.Text = "Pomoc";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.oToolStripMenuItem.Text = "O...";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 644);
            this.Controls.Add(this.groupBoxDzialania);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.labelrownasie);
            this.Controls.Add(this.textBoxliczba2);
            this.Controls.Add(this.textBoxliczba1);
            this.Controls.Add(this.buttonLiczenie);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormKalkulator";
            this.Text = "Kalkualtor";
            this.Load += new System.EventHandler(this.Kalkulator_Load);
            this.groupBoxDzialania.ResumeLayout(false);
            this.groupBoxDzialania.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtondodawanie;
        private System.Windows.Forms.Button buttonLiczenie;
        private System.Windows.Forms.TextBox textBoxliczba1;
        private System.Windows.Forms.TextBox textBoxliczba2;
        private System.Windows.Forms.Label labelrownasie;
        private System.Windows.Forms.RadioButton radioButtonodejmowanie;
        private System.Windows.Forms.RadioButton radioButtonMnozenie;
        private System.Windows.Forms.RadioButton radioButtondzielenie;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.GroupBox groupBoxDzialania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlik;
        private System.Windows.Forms.ToolStripMenuItem zerujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczbyToolStripMenuItemLiczby;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItemPomoc;
        private System.Windows.Forms.ToolStripMenuItem zamknijAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rzeczywisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

