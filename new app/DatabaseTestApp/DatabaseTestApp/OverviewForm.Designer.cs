namespace DatabaseTestApp
{
    partial class OverviewForm
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
            this.loadAllCustomersButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.PokemonPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.TextBox();
            this.PokemonTitle = new System.Windows.Forms.TextBox();
            this.PokemonDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadAllCustomersButton
            // 
            this.loadAllCustomersButton.Location = new System.Drawing.Point(663, 12);
            this.loadAllCustomersButton.Name = "loadAllCustomersButton";
            this.loadAllCustomersButton.Size = new System.Drawing.Size(94, 29);
            this.loadAllCustomersButton.TabIndex = 0;
            this.loadAllCustomersButton.Text = "Load All";
            this.loadAllCustomersButton.UseVisualStyleBackColor = true;
            this.loadAllCustomersButton.Click += new System.EventHandler(this.loadAllCustomersButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(663, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(663, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Enabled = false;
            this.viewButton.Location = new System.Drawing.Point(663, 82);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(94, 29);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // PokemonPicture
            // 
            this.PokemonPicture.Location = new System.Drawing.Point(375, 12);
            this.PokemonPicture.Name = "PokemonPicture";
            this.PokemonPicture.Size = new System.Drawing.Size(282, 260);
            this.PokemonPicture.TabIndex = 6;
            this.PokemonPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(-252, 47);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.Size = new System.Drawing.Size(425, 260);
            this.customerDataGridView.TabIndex = 2;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_EndEdit);
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(375, 313);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(125, 27);
            this.idLabel.TabIndex = 10;
            // 
            // PokemonTitle
            // 
            this.PokemonTitle.Location = new System.Drawing.Point(375, 284);
            this.PokemonTitle.Name = "PokemonTitle";
            this.PokemonTitle.Size = new System.Drawing.Size(125, 27);
            this.PokemonTitle.TabIndex = 11;
            // 
            // PokemonDesc
            // 
            this.PokemonDesc.Location = new System.Drawing.Point(506, 284);
            this.PokemonDesc.Multiline = true;
            this.PokemonDesc.Name = "PokemonDesc";
            this.PokemonDesc.Size = new System.Drawing.Size(151, 58);
            this.PokemonDesc.TabIndex = 12;
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 353);
            this.Controls.Add(this.PokemonDesc);
            this.Controls.Add(this.PokemonTitle);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PokemonPicture);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.loadAllCustomersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverviewForm";
            this.Text = "Customer Analysis and Registration Application";
            this.Load += new System.EventHandler(this.OverviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loadAllCustomersButton;
        private Button addButton;
        private Button deleteButton;
        private Button viewButton;
        private PictureBox PokemonPicture;
        private Button button1;
        private Button button2;
        private DataGridView customerDataGridView;
        private TextBox idLabel;
        private TextBox PokemonTitle;
        private TextBox PokemonDesc;
    }
}