using System.Collections.Generic;
using System.Configuration;

namespace CABApplication
{
    class ShellItemsSection :ConfigurationSection
    {
        [ConfigurationProperty("menuitems", IsDefaultCollection = true)]
        public MenuItemElementCollection MenuItems
        {
            get
            {
                return (MenuItemElementCollection)(this["menuitems"]);
            }
        }
    }
}
