using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.WinForms;


namespace CABApplication
{
    public class UIElementBuilder
    {
        public static void LoadFromConfig(WorkItem workItem)
        {
            ShellItemsSection section = (ShellItemsSection)ConfigurationManager.GetSection("ShellItems");

            foreach (MenuItemElement menuItem in section.MenuItems)
            {
                ToolStripMenuItem uiMenuItem = menuItem.ToMenuItem();

                workItem.UIExtensionSites[menuItem.Site].Add(uiMenuItem);

                if (menuItem.Register == true)
                    workItem.UIExtensionSites.RegisterSite(menuItem.RegistrationSite, uiMenuItem.DropDownItems);

                if (!String.IsNullOrEmpty(menuItem.CommandName))
                    workItem.Commands[menuItem.CommandName].AddInvoker(uiMenuItem, "Click");
            }
        }
    }
}
