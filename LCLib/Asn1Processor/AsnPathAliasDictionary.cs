using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LipingShare.LCLib.Asn1Processor
{
    [DataContract]
    public class AsnPathAliasDictionary
    {
        public bool Load(string filename)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(AsnPathAliasDictionary));
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
          
            dictionary_ = ((AsnPathAliasDictionary)dcs.ReadObject(reader)).dictionary_;
            fs.Close();
            return true;
        }

        public bool Save(string filename)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(AsnPathAliasDictionary));
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlDictionaryWriter wr = XmlDictionaryWriter.CreateTextWriter(fs, Encoding.UTF8);

           dcs.WriteObject(wr, this);
           wr.Flush();
           fs.Flush();
           fs.Close();
           return true;
        }

        public bool add(AsnPathAlias a)
        {
            if (dictionary_.ContainsKey(a.Name))
            {
                dictionary_.Remove(a.Name);
            }
            dictionary_.Add(a.Name, a);
            return true;
        }

        public bool find(string path, out AsnPathAlias res)
        {
            res = null;
            foreach (var item in dictionary_)
            {
                if (item.Value.checkMatch(path))
                {
                    res = item.Value;
                    return true;
                }
            }
            return false;
        }

        [DataMember]
        protected Dictionary<string, AsnPathAlias> dictionary_ = new Dictionary<string, AsnPathAlias>();

        public void del(AsnPathAlias @alias)
        {
            dictionary_.Remove(alias.Name);
        }
    }
}
