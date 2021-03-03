
namespace PhoneBook
{
    partial class PhoneBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneBookLabel = new System.Windows.Forms.Label();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.editContactButton = new System.Windows.Forms.Button();
            this.newContactButton = new System.Windows.Forms.Button();
            this.allContactsButton = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.allContactsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.operationsPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allContactsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.phoneBookLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 0;
            // 
            // phoneBookLabel
            // 
            this.phoneBookLabel.AutoSize = true;
            this.phoneBookLabel.Font = new System.Drawing.Font("Source Sans Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBookLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.phoneBookLabel.Location = new System.Drawing.Point(53, 26);
            this.phoneBookLabel.Name = "phoneBookLabel";
            this.phoneBookLabel.Size = new System.Drawing.Size(170, 38);
            this.phoneBookLabel.TabIndex = 0;
            this.phoneBookLabel.Text = "Phone Book";
            // 
            // operationsPanel
            // 
            this.operationsPanel.BackColor = System.Drawing.Color.White;
            this.operationsPanel.Controls.Add(this.deleteContactButton);
            this.operationsPanel.Controls.Add(this.exitButton);
            this.operationsPanel.Controls.Add(this.editContactButton);
            this.operationsPanel.Controls.Add(this.newContactButton);
            this.operationsPanel.Controls.Add(this.allContactsButton);
            this.operationsPanel.Location = new System.Drawing.Point(20, 106);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(192, 410);
            this.operationsPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(3, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 57);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitClick);
            // 
            // editContactButton
            // 
            this.editContactButton.BackColor = System.Drawing.Color.White;
            this.editContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editContactButton.FlatAppearance.BorderSize = 0;
            this.editContactButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editContactButton.Location = new System.Drawing.Point(3, 148);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(186, 57);
            this.editContactButton.TabIndex = 2;
            this.editContactButton.Text = "Edit Contact";
            this.editContactButton.UseVisualStyleBackColor = false;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // newContactButton
            // 
            this.newContactButton.BackColor = System.Drawing.Color.White;
            this.newContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newContactButton.FlatAppearance.BorderSize = 0;
            this.newContactButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newContactButton.Location = new System.Drawing.Point(3, 75);
            this.newContactButton.Name = "newContactButton";
            this.newContactButton.Size = new System.Drawing.Size(186, 57);
            this.newContactButton.TabIndex = 1;
            this.newContactButton.Text = "New Contact";
            this.newContactButton.UseVisualStyleBackColor = false;
            this.newContactButton.Click += new System.EventHandler(this.newContact_Click);
            // 
            // allContactsButton
            // 
            this.allContactsButton.BackColor = System.Drawing.Color.White;
            this.allContactsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allContactsButton.FlatAppearance.BorderSize = 0;
            this.allContactsButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allContactsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allContactsButton.Location = new System.Drawing.Point(3, 3);
            this.allContactsButton.Name = "allContactsButton";
            this.allContactsButton.Size = new System.Drawing.Size(186, 57);
            this.allContactsButton.TabIndex = 0;
            this.allContactsButton.Text = "All Contacts";
            this.allContactsButton.UseVisualStyleBackColor = false;
            this.allContactsButton.Click += new System.EventHandler(this.allContactsButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Controls.Add(this.searchLabel);
            this.viewPanel.Controls.Add(this.searchTextBox);
            this.viewPanel.Controls.Add(this.allContactsDataGridView);
            this.viewPanel.Location = new System.Drawing.Point(228, 106);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(556, 409);
            this.viewPanel.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(94, 25);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(319, 41);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // allContactsDataGridView
            // 
            this.allContactsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.allContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allContactsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.allContactsDataGridView.Location = new System.Drawing.Point(3, 75);
            this.allContactsDataGridView.Name = "allContactsDataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allContactsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.allContactsDataGridView.RowHeadersWidth = 50;
            this.allContactsDataGridView.RowTemplate.Height = 24;
            this.allContactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allContactsDataGridView.Size = new System.Drawing.Size(550, 331);
            this.allContactsDataGridView.TabIndex = 0;
            this.allContactsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allContactsDataGridView_CellClick);
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.BackColor = System.Drawing.Color.White;
            this.deleteContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteContactButton.FlatAppearance.BorderSize = 0;
            this.deleteContactButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteContactButton.Location = new System.Drawing.Point(3, 225);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(186, 57);
            this.deleteContactButton.TabIndex = 4;
            this.deleteContactButton.Text = "Delete Contact";
            this.deleteContactButton.UseVisualStyleBackColor = false;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(23, 34);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 22);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhoneBookForm";
            this.Text = "PhoneBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.operationsPanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allContactsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label phoneBookLabel;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Button newContactButton;
        private System.Windows.Forms.Button allContactsButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView allContactsDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Label searchLabel;
    }
}

