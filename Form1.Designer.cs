
namespace dbProj
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
            this.components = new System.ComponentModel.Container();
            this.Connection = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.KlassBox = new System.Windows.Forms.TextBox();
            this.KlassLabel = new System.Windows.Forms.Label();
            this.database5DataSet41 = new dbProj.Database5DataSet4();
            this.database5DataSet41BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database5DataSet41BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database5DataSet5 = new dbProj.Database5DataSet5();
            this.tabell1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabell1TableAdapter = new dbProj.Database5DataSet5TableAdapters.Tabell1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabell1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(12, 25);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(139, 51);
            this.Connection.TabIndex = 1;
            this.Connection.Text = "Test Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(204, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(124, 31);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Full Name:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(204, 139);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(124, 31);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone Num:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(204, 201);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(124, 31);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(357, 77);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(301, 31);
            this.NameBox.TabIndex = 9;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(357, 140);
            this.PhoneBox.Multiline = true;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(301, 31);
            this.PhoneBox.TabIndex = 10;
            this.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(357, 201);
            this.EmailBox.Multiline = true;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(301, 31);
            this.EmailBox.TabIndex = 11;
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone BOOOOK";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(690, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 31);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(690, 138);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(117, 31);
            this.DELETE.TabIndex = 16;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KlassBox
            // 
            this.KlassBox.Location = new System.Drawing.Point(357, 255);
            this.KlassBox.Multiline = true;
            this.KlassBox.Name = "KlassBox";
            this.KlassBox.Size = new System.Drawing.Size(301, 31);
            this.KlassBox.TabIndex = 21;
            this.KlassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KlassLabel
            // 
            this.KlassLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.KlassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KlassLabel.Location = new System.Drawing.Point(204, 255);
            this.KlassLabel.Name = "KlassLabel";
            this.KlassLabel.Size = new System.Drawing.Size(124, 31);
            this.KlassLabel.TabIndex = 20;
            this.KlassLabel.Text = "Klass:";
            // 
            // database5DataSet41
            // 
            this.database5DataSet41.DataSetName = "Database5DataSet4";
            this.database5DataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database5DataSet41BindingSource
            // 
            this.database5DataSet41BindingSource.DataSource = this.database5DataSet41;
            this.database5DataSet41BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.klassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabell1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(981, 194);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // database5DataSet41BindingSource1
            // 
            this.database5DataSet41BindingSource1.DataSource = this.database5DataSet41;
            this.database5DataSet41BindingSource1.Position = 0;
            // 
            // database5DataSet5
            // 
            this.database5DataSet5.DataSetName = "Database5DataSet5";
            this.database5DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabell1BindingSource
            // 
            this.tabell1BindingSource.DataMember = "Tabell1";
            this.tabell1BindingSource.DataSource = this.database5DataSet5;
            // 
            // tabell1TableAdapter
            // 
            this.tabell1TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // klassDataGridViewTextBoxColumn
            // 
            this.klassDataGridViewTextBoxColumn.DataPropertyName = "Klass";
            this.klassDataGridViewTextBoxColumn.HeaderText = "Klass";
            this.klassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.klassDataGridViewTextBoxColumn.Name = "klassDataGridViewTextBoxColumn";
            this.klassDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1005, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KlassBox);
            this.Controls.Add(this.KlassLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet41BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database5DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabell1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox KlassBox;
        private System.Windows.Forms.Label KlassLabel;
        private Database5DataSet4 database5DataSet41;
        private System.Windows.Forms.BindingSource database5DataSet41BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database5DataSet41BindingSource1;
        private Database5DataSet5 database5DataSet5;
        private System.Windows.Forms.BindingSource tabell1BindingSource;
        private Database5DataSet5TableAdapters.Tabell1TableAdapter tabell1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klassDataGridViewTextBoxColumn;
    }
}

