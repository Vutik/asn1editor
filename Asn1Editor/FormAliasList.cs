using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LipingShare.LCLib.Asn1Processor;

namespace LipingShare.Asn1Editor
{
    public partial class FormAliasList : Form
    {
        private AsnPathAliasDictionary dict;
        public FormAliasList(AsnPathAliasDictionary dict_)
        {
            dict = dict_;
            InitializeComponent();
        }

        private void reload()
        {
            listView1.Items.Clear();
            foreach (var alias in dict.getAll().Values)
            {
                string name = alias.Name;
                string path = alias.RegExpStr;
                string conv = alias.Valueconverter;
                string aliasEnum = alias.ValueAlias.ToString();

                ListViewItem item = new ListViewItem(path);

                //item.SubItems.Add(new ListViewItem.ListViewSubItem(item, path));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, name));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, conv));
                //item.SubItems.Add(new ListViewItem.ListViewSubItem(item, aliasEnum));

                item.Tag = alias;
                listView1.Items.Add(item);
            }
        }

        private void FormAliasList_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void buttonAliasAdd_Click(object sender, EventArgs e)
        {
            FormAsnPathAlias f;
            f = new FormAsnPathAlias("");
            f.ShowDialog(this);
            if (f.DialogResult == DialogResult.OK)
            {
                dict.add(f.Alias);
                reload();
            }
        }

        private void buttonAliasEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;
            AsnPathAlias a = (AsnPathAlias)listView1.SelectedItems[0].Tag;
            FormAsnPathAlias f;
            f = new FormAsnPathAlias(a);
            f.ShowDialog(this);
            if (f.DialogResult == DialogResult.OK)
            {
                dict.add(f.Alias);
                reload();
            }
        }

        private void buttonAliasDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;
            AsnPathAlias a = (AsnPathAlias)listView1.SelectedItems[0].Tag;
            dict.del(a);
            reload();
        }
    }
}
