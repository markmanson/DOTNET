﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace CABApplication
{
    class MenuItemElement : ConfigurationElement
    {
        [ConfigurationProperty("commandname", IsRequired = false)]
        public string CommandName
        {
            get
            {
                return (string)this["commandname"];
            }
            set
            {
                this["commandname"] = value;
            }
        }

        [ConfigurationProperty("key", IsRequired = false)]
        public string Key
        {
            get
            {
                return (string)this["key"];
            }
            set
            {
                this["key"] = value;
            }
        }

        [ConfigurationProperty("id", IsRequired = false, IsKey = true)]
        public int ID
        {
            get
            {
                return (int)this["id"];
            }
            set
            {
                this["id"] = value;
            }
        }

        [ConfigurationProperty("label", IsRequired = true)]
        public string Label
        {
            get
            {
                return (string)this["label"];
            }
            set
            {
                this["label"] = value;
            }
        }

        [ConfigurationProperty("site", IsRequired = true)]
        public string Site
        {
            get
            {
                return (string)this["site"];
            }
            set
            {
                this["site"] = value;
            }
        }

        [ConfigurationProperty("register", IsRequired = false)]
        public bool Register
        {
            get
            {
                return (bool)this["register"];
            }
            set
            {
                this["register"] = value;
            }
        }

        [ConfigurationProperty("registrationsite", IsRequired = false)]
        public string RegistrationSite
        {
            get
            {
                return (string)this["registrationsite"];
            }
            set
            {
                this["registrationsite"] = value;
            }
        }

        public ToolStripMenuItem ToMenuItem()
        {
            ToolStripMenuItem result = new ToolStripMenuItem();
            result.Text = Label;

            if (!String.IsNullOrEmpty(Key))
                result.ShortcutKeys = (Keys)Enum.Parse(typeof(Keys), Key);

            return result;
        }
    }
}
