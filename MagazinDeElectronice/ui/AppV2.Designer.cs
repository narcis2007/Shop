using MagazinDeElectronice.controller;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagazinDeElectronice.ui
{
    partial class AppV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ProductController controller;

        public AppV2(ProductController controller)
        {
            this.controller = controller;
            InitializeComponent();

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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKprodusecategoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaButton = new System.Windows.Forms.Button();
            this.cantitateLabel = new System.Windows.Forms.Label();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazin_electroniceDataSet = new MagazinDeElectronice.magazin_electroniceDataSet();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriiTableAdapter = new MagazinDeElectronice.magazin_electroniceDataSetTableAdapters.categoriiTableAdapter();
            this.produseTableAdapter = new MagazinDeElectronice.magazin_electroniceDataSetTableAdapters.produseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprodusecategoriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazin_electroniceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(148, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn1,
            this.categorieidDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKprodusecategoriiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(166, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(448, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // fKprodusecategoriiBindingSource
            // 
            this.fKprodusecategoriiBindingSource.DataMember = "FK_produse_categorii";
            this.fKprodusecategoriiBindingSource.DataSource = this.categoriiBindingSource;
            // 
            // comandaButton
            // 
            this.comandaButton.Location = new System.Drawing.Point(529, 165);
            this.comandaButton.Name = "comandaButton";
            this.comandaButton.Size = new System.Drawing.Size(75, 23);
            this.comandaButton.TabIndex = 2;
            this.comandaButton.Text = "Comanda";
            this.comandaButton.UseVisualStyleBackColor = true;
            this.comandaButton.Click += new System.EventHandler(this.comandaButton_Click);
            // 
            // cantitateLabel
            // 
            this.cantitateLabel.AutoSize = true;
            this.cantitateLabel.Location = new System.Drawing.Point(337, 175);
            this.cantitateLabel.Name = "cantitateLabel";
            this.cantitateLabel.Size = new System.Drawing.Size(83, 13);
            this.cantitateLabel.TabIndex = 3;
            this.cantitateLabel.Text = "Cantitate Dorita:";
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(423, 168);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantitateTextBox.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            this.numeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categorieidDataGridViewTextBoxColumn
            // 
            this.categorieidDataGridViewTextBoxColumn.DataPropertyName = "categorie_id";
            this.categorieidDataGridViewTextBoxColumn.HeaderText = "categorie_id";
            this.categorieidDataGridViewTextBoxColumn.Name = "categorieidDataGridViewTextBoxColumn";
            this.categorieidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriiBindingSource
            // 
            this.categoriiBindingSource.DataMember = "categorii";
            this.categoriiBindingSource.DataSource = this.magazin_electroniceDataSet;
            // 
            // magazin_electroniceDataSet
            // 
            this.magazin_electroniceDataSet.DataSetName = "magazin_electroniceDataSet";
            this.magazin_electroniceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Categorii";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriiTableAdapter
            // 
            this.categoriiTableAdapter.ClearBeforeFill = true;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 261);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(this.cantitateLabel);
            this.Controls.Add(this.comandaButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprodusecategoriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazin_electroniceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private magazin_electroniceDataSet magazin_electroniceDataSet;
        private System.Windows.Forms.BindingSource categoriiBindingSource;
        private magazin_electroniceDataSetTableAdapters.categoriiTableAdapter categoriiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKprodusecategoriiBindingSource;
        private magazin_electroniceDataSetTableAdapters.produseTableAdapter produseTableAdapter;
        private System.Windows.Forms.Button comandaButton;
        private System.Windows.Forms.Label cantitateLabel;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categorieidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
    }
}