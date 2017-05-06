namespace LipingShare.Asn1Editor
{
    partial class FormAliasList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAliasAdd = new System.Windows.Forms.Button();
            this.buttonAliasEdit = new System.Windows.Forms.Button();
            this.buttonAliasDel = new System.Windows.Forms.Button();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPath,
            this.columnHeaderName,
            this.columnHeaderType});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(609, 299);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 205;
            // 
            // buttonAliasAdd
            // 
            this.buttonAliasAdd.Location = new System.Drawing.Point(382, 322);
            this.buttonAliasAdd.Name = "buttonAliasAdd";
            this.buttonAliasAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAliasAdd.TabIndex = 1;
            this.buttonAliasAdd.Text = "Add";
            this.buttonAliasAdd.UseVisualStyleBackColor = true;
            this.buttonAliasAdd.Click += new System.EventHandler(this.buttonAliasAdd_Click);
            // 
            // buttonAliasEdit
            // 
            this.buttonAliasEdit.Location = new System.Drawing.Point(464, 321);
            this.buttonAliasEdit.Name = "buttonAliasEdit";
            this.buttonAliasEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAliasEdit.TabIndex = 2;
            this.buttonAliasEdit.Text = "Edit";
            this.buttonAliasEdit.UseVisualStyleBackColor = true;
            this.buttonAliasEdit.Click += new System.EventHandler(this.buttonAliasEdit_Click);
            // 
            // buttonAliasDel
            // 
            this.buttonAliasDel.Location = new System.Drawing.Point(546, 320);
            this.buttonAliasDel.Name = "buttonAliasDel";
            this.buttonAliasDel.Size = new System.Drawing.Size(75, 23);
            this.buttonAliasDel.TabIndex = 3;
            this.buttonAliasDel.Text = "Delete";
            this.buttonAliasDel.UseVisualStyleBackColor = true;
            this.buttonAliasDel.Click += new System.EventHandler(this.buttonAliasDel_Click);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 170;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 180;
            // 
            // FormAliasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 355);
            this.Controls.Add(this.buttonAliasDel);
            this.Controls.Add(this.buttonAliasEdit);
            this.Controls.Add(this.buttonAliasAdd);
            this.Controls.Add(this.listView1);
            this.Name = "FormAliasList";
            this.Text = "FormAliasList";
            this.Load += new System.EventHandler(this.FormAliasList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.Button buttonAliasAdd;
        private System.Windows.Forms.Button buttonAliasEdit;
        private System.Windows.Forms.Button buttonAliasDel;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
    }
}