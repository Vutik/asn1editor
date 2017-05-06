namespace LipingShare.Asn1Editor
{
    partial class FormAsnPathAlias
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRegExp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxValueConvertType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValueAlias = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(289, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxRegExp
            // 
            this.textBoxRegExp.Location = new System.Drawing.Point(99, 40);
            this.textBoxRegExp.Name = "textBoxRegExp";
            this.textBoxRegExp.Size = new System.Drawing.Size(289, 20);
            this.textBoxRegExp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regexp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "value converter";
            // 
            // comboBoxValueConvertType
            // 
            this.comboBoxValueConvertType.FormattingEnabled = true;
            this.comboBoxValueConvertType.Items.AddRange(new object[] {
            "",
            "enum",
            "dec-hex"});
            this.comboBoxValueConvertType.Location = new System.Drawing.Point(99, 66);
            this.comboBoxValueConvertType.Name = "comboBoxValueConvertType";
            this.comboBoxValueConvertType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxValueConvertType.TabIndex = 5;
            this.comboBoxValueConvertType.SelectedIndexChanged += new System.EventHandler(this.comboBoxValueConvertType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value alias";
            // 
            // textBoxValueAlias
            // 
            this.textBoxValueAlias.Location = new System.Drawing.Point(99, 97);
            this.textBoxValueAlias.Multiline = true;
            this.textBoxValueAlias.Name = "textBoxValueAlias";
            this.textBoxValueAlias.Size = new System.Drawing.Size(289, 152);
            this.textBoxValueAlias.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxValueAlias, "example for type enum\r\n00 text1\r\n01 tex2");
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(312, 258);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAsnPathAlias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 293);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxValueAlias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxValueConvertType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegExp);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAsnPathAlias";
            this.Text = "FormAsnPathAlias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRegExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxValueConvertType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValueAlias;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}