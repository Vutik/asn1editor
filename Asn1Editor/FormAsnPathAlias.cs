using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LipingShare.LCLib.Asn1Processor;

namespace LipingShare.Asn1Editor
{
    public partial class FormAsnPathAlias : Form
    {
        public FormAsnPathAlias()
        {
            InitializeComponent();
        }

        public FormAsnPathAlias(AsnPathAlias alias_)
        {
           InitializeComponent();

            Alias = alias_;
            textBoxName.Text = Alias.Name;
            textBoxRegExp.Text = Alias.RegExpStr;
            comboBoxValueConvertType.SelectedIndex = 0;
            if (Alias.Valueconverter.Equals("enum"))
            {
                comboBoxValueConvertType.SelectedIndex = 1;
                textBoxValueAlias.Enabled = true;
            }
            else
            {
                textBoxValueAlias.Enabled = false;
            }
            String str = "";
            foreach (var item in alias_.ValueAlias)
            {
                str += item.Key + " " + item.Value + Environment.NewLine;
            }
            textBoxValueAlias.Text = str;
        }

        public FormAsnPathAlias(string path)
        {
            InitializeComponent();
            textBoxRegExp.Text = "^" + Regex.Escape(path) + "$";
            textBoxValueAlias.Enabled = false;
        }


        public AsnPathAlias Alias { get; set; } = new AsnPathAlias();
        private bool isOk = false;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string converter = "";
            var dct = new Dictionary<string, string>();
            if (comboBoxValueConvertType.SelectedIndex == 1)
            {
                converter = "enum";
                if (textBoxValueAlias.Lines.Length > 0)
                {
                    foreach (var line in textBoxValueAlias.Lines)
                    {
                        string[] world = line.Split(new Char[] {' '});
                        if(world.Length ==2)
                            dct.Add(world[0], world[1]);
                    }
                }
            }
            else if (
                comboBoxValueConvertType.SelectedIndex > 0
                && comboBoxValueConvertType.GetItemText(comboBoxValueConvertType.SelectedItem) != "")
            {
                converter = comboBoxValueConvertType.GetItemText(comboBoxValueConvertType.SelectedItem);
            }
            Alias = new AsnPathAlias(textBoxName.Text, textBoxRegExp.Text, converter, dct);
            this.isOk = true;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBoxValueConvertType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String s = comboBoxValueConvertType.GetItemText(comboBoxValueConvertType.SelectedItem);
            if (comboBoxValueConvertType.SelectedIndex == 1)
            {
                textBoxValueAlias.Enabled = true;
            }
            else
            {
                textBoxValueAlias.Text = "";
                textBoxValueAlias.Enabled = false;
            }
        }
    }
}
