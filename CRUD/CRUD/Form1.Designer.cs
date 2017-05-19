using System;

namespace CRUD
{
    partial class Main
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmatuszakDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmatuszakDataSet = new CRUD.pmatuszakDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.klientTableAdapter = new CRUD.pmatuszakDataSetTableAdapters.klientTableAdapter();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new CRUD.pmatuszakDataSetTableAdapters.pracownikTableAdapter();
            this.imieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new CRUD.pmatuszakDataSetTableAdapters.produktTableAdapter();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenanettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenabruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sprzedazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprzedazTableAdapter = new CRUD.pmatuszakDataSetTableAdapters.sprzedazTableAdapter();
            this.nrParagonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktTableAdapter1 = new CRUD.pmatuszakDataSetTableAdapters.produktTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTak = new System.Windows.Forms.Button();
            this.btnNie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmatuszakDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmatuszakDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzedazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klienci";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwisko,
            this.telefon,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(610, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.pmatuszakDataSetBindingSource;
            // 
            // pmatuszakDataSetBindingSource
            // 
            this.pmatuszakDataSetBindingSource.DataSource = this.pmatuszakDataSet;
            this.pmatuszakDataSetBindingSource.Position = 0;
            // 
            // pmatuszakDataSet
            // 
            this.pmatuszakDataSet.DataSetName = "pmatuszakDataSet";
            this.pmatuszakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pracownicy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.emailDataGridViewTextBoxColumn1,
            this.pESELDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pracownikBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(610, 340);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(984, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produkty";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(984, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sprzedaż";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(984, 314);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Koszyk";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.btnNie);
            this.tabPage6.Controls.Add(this.btnTak);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(984, 314);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Zamknij Program";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "pracownik";
            this.pracownikBindingSource.DataSource = this.pmatuszakDataSetBindingSource;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // imieDataGridViewTextBoxColumn1
            // 
            this.imieDataGridViewTextBoxColumn1.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn1.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn1.Name = "imieDataGridViewTextBoxColumn1";
            this.imieDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nazwisko";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "telefon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 120;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.Width = 120;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Width = 150;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.cenanettoDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.cenabruttoDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.produktBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(610, 340);
            this.dataGridView3.TabIndex = 0;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "produkt";
            this.produktBindingSource.DataSource = this.pmatuszakDataSetBindingSource;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 120;
            // 
            // cenanettoDataGridViewTextBoxColumn
            // 
            this.cenanettoDataGridViewTextBoxColumn.DataPropertyName = "cena_netto";
            this.cenanettoDataGridViewTextBoxColumn.HeaderText = "Cena Netto";
            this.cenanettoDataGridViewTextBoxColumn.Name = "cenanettoDataGridViewTextBoxColumn";
            this.cenanettoDataGridViewTextBoxColumn.Width = 120;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.Width = 120;
            // 
            // cenabruttoDataGridViewTextBoxColumn
            // 
            this.cenabruttoDataGridViewTextBoxColumn.DataPropertyName = "cena_brutto";
            this.cenabruttoDataGridViewTextBoxColumn.HeaderText = "Cena Brutto";
            this.cenabruttoDataGridViewTextBoxColumn.Name = "cenabruttoDataGridViewTextBoxColumn";
            this.cenabruttoDataGridViewTextBoxColumn.Width = 120;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrParagonuDataGridViewTextBoxColumn,
            this.idpracownikDataGridViewTextBoxColumn,
            this.idklientDataGridViewTextBoxColumn,
            this.wartoscDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.sprzedazBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(610, 340);
            this.dataGridView4.TabIndex = 0;
            // 
            // sprzedazBindingSource
            // 
            this.sprzedazBindingSource.DataMember = "sprzedaz";
            this.sprzedazBindingSource.DataSource = this.pmatuszakDataSetBindingSource;
            // 
            // sprzedazTableAdapter
            // 
            this.sprzedazTableAdapter.ClearBeforeFill = true;
            // 
            // nrParagonuDataGridViewTextBoxColumn
            // 
            this.nrParagonuDataGridViewTextBoxColumn.DataPropertyName = "nrParagonu";
            this.nrParagonuDataGridViewTextBoxColumn.HeaderText = "Nr Paragonu";
            this.nrParagonuDataGridViewTextBoxColumn.Name = "nrParagonuDataGridViewTextBoxColumn";
            this.nrParagonuDataGridViewTextBoxColumn.Width = 120;
            // 
            // idpracownikDataGridViewTextBoxColumn
            // 
            this.idpracownikDataGridViewTextBoxColumn.DataPropertyName = "id_pracownik";
            this.idpracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.idpracownikDataGridViewTextBoxColumn.Name = "idpracownikDataGridViewTextBoxColumn";
            this.idpracownikDataGridViewTextBoxColumn.Width = 120;
            // 
            // idklientDataGridViewTextBoxColumn
            // 
            this.idklientDataGridViewTextBoxColumn.DataPropertyName = "id_klient";
            this.idklientDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.idklientDataGridViewTextBoxColumn.Name = "idklientDataGridViewTextBoxColumn";
            this.idklientDataGridViewTextBoxColumn.Width = 120;
            // 
            // wartoscDataGridViewTextBoxColumn
            // 
            this.wartoscDataGridViewTextBoxColumn.DataPropertyName = "wartosc";
            this.wartoscDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartoscDataGridViewTextBoxColumn.Name = "wartoscDataGridViewTextBoxColumn";
            this.wartoscDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 120;
            // 
            // produktTableAdapter1
            // 
            this.produktTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(202, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(639, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Czy na pewno chcesz zamknąć program?";
            // 
            // btnTak
            // 
            this.btnTak.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTak.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnTak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTak.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTak.ForeColor = System.Drawing.Color.White;
            this.btnTak.Location = new System.Drawing.Point(300, 158);
            this.btnTak.Name = "btnTak";
            this.btnTak.Size = new System.Drawing.Size(113, 56);
            this.btnTak.TabIndex = 1;
            this.btnTak.Text = "T A K";
            this.btnTak.UseVisualStyleBackColor = false;
            this.btnTak.Click += new System.EventHandler(this.btnTak_Click);
            // 
            // btnNie
            // 
            this.btnNie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNie.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnNie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNie.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNie.ForeColor = System.Drawing.Color.White;
            this.btnNie.Location = new System.Drawing.Point(600, 158);
            this.btnNie.Name = "btnNie";
            this.btnNie.Size = new System.Drawing.Size(113, 56);
            this.btnNie.TabIndex = 2;
            this.btnNie.Text = "N I E";
            this.btnNie.UseVisualStyleBackColor = false;
            this.btnNie.Click += new System.EventHandler(this.btnNie_Click);
            // 
            // Main
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmatuszakDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmatuszakDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzedazBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kliencieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeGraficzneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pmatuszakDataSetBindingSource;
        private pmatuszakDataSet pmatuszakDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private pmatuszakDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private pmatuszakDataSetTableAdapters.pracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private pmatuszakDataSetTableAdapters.produktTableAdapter produktTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenanettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenabruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource sprzedazBindingSource;
        private pmatuszakDataSetTableAdapters.sprzedazTableAdapter sprzedazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrParagonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private pmatuszakDataSetTableAdapters.produktTableAdapter produktTableAdapter1;
        private System.Windows.Forms.Button btnTak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNie;
    }
}

