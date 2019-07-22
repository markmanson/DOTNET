using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CABApplication
{
    class MenuItemElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new MenuItemElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            MenuItemElement e = (MenuItemElement)element;
            return e.ID;
        }
    }
}
