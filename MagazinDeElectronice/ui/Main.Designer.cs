using MagazinDeElectronice.controller;
using MagazinDeElectronice.service;

namespace MagazinDeElectronice.ui
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ServiceProxy controller;

        public Main(ServiceProxy controller)
        {
            this.controller = controller;
            InitializeComponent();
            foreach(string categorie in controller.getCategorii())
                categoriiDataGridView.Rows.Add(categorie);
            label4.Text = controller.SayHello("narcis");
        }

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
            this.categoriiDataGridView = new System.Windows.Forms.DataGridView();
            this.Categorii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.crescatorRadioButton = new System.Windows.Forms.RadioButton();
            this.descrescatorRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cosDataGridView = new System.Windows.Forms.DataGridView();
            this.idProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateCumparata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.comandaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriiDataGridView
            // 
            this.categoriiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categorii});
            this.categoriiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.categoriiDataGridView.Name = "categoriiDataGridView";
            this.categoriiDataGridView.Size = new System.Drawing.Size(145, 148);
            this.categoriiDataGridView.TabIndex = 0;
            this.categoriiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriiDataGridView_CellContentClick);
            // 
            // Categorii
            // 
            this.Categorii.HeaderText = "Categorii";
            this.Categorii.Name = "Categorii";
            this.Categorii.ReadOnly = true;
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nume,
            this.cantitate,
            this.pret});
            this.produseDataGridView.Location = new System.Drawing.Point(163, 12);
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produseDataGridView.Size = new System.Drawing.Size(343, 148);
            this.produseDataGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nume
            // 
            this.nume.HeaderText = "nume";
            this.nume.Name = "nume";
            this.nume.ReadOnly = true;
            // 
            // cantitate
            // 
            this.cantitate.HeaderText = "cantitate";
            this.cantitate.Name = "cantitate";
            this.cantitate.ReadOnly = true;
            // 
            // pret
            // 
            this.pret.HeaderText = "pret";
            this.pret.Name = "pret";
            this.pret.ReadOnly = true;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(332, 168);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(75, 23);
            this.adaugaButton.TabIndex = 3;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantitate:";
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(226, 171);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantitateTextBox.TabIndex = 5;
            // 
            // crescatorRadioButton
            // 
            this.crescatorRadioButton.AutoSize = true;
            this.crescatorRadioButton.Checked = true;
            this.crescatorRadioButton.Location = new System.Drawing.Point(12, 187);
            this.crescatorRadioButton.Name = "crescatorRadioButton";
            this.crescatorRadioButton.Size = new System.Drawing.Size(70, 17);
            this.crescatorRadioButton.TabIndex = 6;
            this.crescatorRadioButton.TabStop = true;
            this.crescatorRadioButton.Text = "Crescator";
            this.crescatorRadioButton.UseVisualStyleBackColor = true;
            this.crescatorRadioButton.CheckedChanged += new System.EventHandler(this.crescatorRadioButton_CheckedChanged);
            // 
            // descrescatorRadioButton
            // 
            this.descrescatorRadioButton.AutoSize = true;
            this.descrescatorRadioButton.Location = new System.Drawing.Point(12, 210);
            this.descrescatorRadioButton.Name = "descrescatorRadioButton";
            this.descrescatorRadioButton.Size = new System.Drawing.Size(88, 17);
            this.descrescatorRadioButton.TabIndex = 7;
            this.descrescatorRadioButton.TabStop = true;
            this.descrescatorRadioButton.Text = "Descrescator";
            this.descrescatorRadioButton.UseVisualStyleBackColor = true;
            this.descrescatorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sorteaza dupa pret:";
            // 
            // cosDataGridView
            // 
            this.cosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdus,
            this.numeProdus,
            this.cantitateCumparata,
            this.pretProdus,
            this.total});
            this.cosDataGridView.Location = new System.Drawing.Point(512, 12);
            this.cosDataGridView.Name = "cosDataGridView";
            this.cosDataGridView.Size = new System.Drawing.Size(443, 148);
            this.cosDataGridView.TabIndex = 9;
            // 
            // idProdus
            // 
            this.idProdus.HeaderText = "idProdus";
            this.idProdus.Name = "idProdus";
            this.idProdus.ReadOnly = true;
            this.idProdus.Visible = false;
            // 
            // numeProdus
            // 
            this.numeProdus.HeaderText = "nume";
            this.numeProdus.Name = "numeProdus";
            this.numeProdus.ReadOnly = true;
            // 
            // cantitateCumparata
            // 
            this.cantitateCumparata.HeaderText = "cantitate cumparata";
            this.cantitateCumparata.Name = "cantitateCumparata";
            this.cantitateCumparata.ReadOnly = true;
            // 
            // pretProdus
            // 
            this.pretProdus.HeaderText = "pret";
            this.pretProdus.Name = "pretProdus";
            this.pretProdus.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Comanda:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(755, 175);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 11;
            this.totalTextBox.Text = "0";
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // comandaButton
            // 
            this.comandaButton.Location = new System.Drawing.Point(861, 172);
            this.comandaButton.Name = "comandaButton";
            this.comandaButton.Size = new System.Drawing.Size(75, 23);
            this.comandaButton.TabIndex = 12;
            this.comandaButton.Text = "Comanda";
            this.comandaButton.UseVisualStyleBackColor = true;
            this.comandaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comandaButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cosDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descrescatorRadioButton);
            this.Controls.Add(this.crescatorRadioButton);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.produseDataGridView);
            this.Controls.Add(this.categoriiDataGridView);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.categoriiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorii;
        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.RadioButton crescatorRadioButton;
        private System.Windows.Forms.RadioButton descrescatorRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cosDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateCumparata;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button comandaButton;
        private System.Windows.Forms.Label label4;
    }
}