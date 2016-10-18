using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace LipingShare.LCLib.Asn1Processor
{
   [DataContract]
    public class AsnPathAlias
    {
        [DataMember]
        public string Name { get; set; }


        [DataMember]
        public string RegExpStr
        {
            get
            {
                return regexstr;
            }

            set
            {
                regexstr = value;
                Regex = new Regex(regexstr);
            }
        }

        protected Regex Regex
        {
            get
            {
                return regex;
            }

            set
            {
                regex = value;
            }
        }

        public string Valueconverter
        {
            get
            {
                return valueconverter;
            }

            set
            {
                valueconverter = value;
            }
        }

        public Dictionary<string, string> ValueAlias
        {
            get
            {
                return valueAlias;
            }

            set
            {
                valueAlias = value;
            }
        }

      
        protected Regex regex;


        
        protected string regexstr;

        [DataMember]
        private string valueconverter = "";

        [DataMember]
        private Dictionary<string, string> valueAlias = new Dictionary<string, string>();

      
        public AsnPathAlias(string name, string regExpStr, string valueconverter, Dictionary<string, string> valueAlias)
        {
            this.Name = name;
            this.RegExpStr = regExpStr;
            this.Valueconverter = valueconverter;
            this.ValueAlias = valueAlias;
            regex = new Regex(this.RegExpStr);
        }

       
        public AsnPathAlias()
        {
        }

       
        public bool checkMatch(string str)
        {
            return regex.IsMatch(str);
        }

       
        public string ConvertValue(string value)
        {
            if (Valueconverter.Equals(""))
                return value;
            else if (Valueconverter.Equals("enum"))
            {
                string al="";
                bool isAlias = ValueAlias.TryGetValue(value,out al);
                return (isAlias)? al:value;
            }
            else if (Valueconverter.Equals("dec-hex"))
            {
                string outs = "";
                for (int i = 0; i < value.Length;)
                {
                    if(i+1!= value.Length && value[i+1]!= 'F')
                        outs += value[i + 1];
                    if (i != value.Length && value[i] != 'F')
                        outs += value[i];
                    i += 2;
                }
                value = outs;
            }
            return value;
        }
         
    }
}
