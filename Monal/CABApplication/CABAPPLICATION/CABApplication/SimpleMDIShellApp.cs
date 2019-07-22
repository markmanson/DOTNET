using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.Services;


namespace CABApplication
{
    public class SimpleMDIShellApp :FormShellApplication<WorkItem,MainMenu>
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            new SimpleMDIShellApp().Run();
        }
        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();
            ToolStripMenuItem filemenuitem = (ToolStripMenuItem)Shell.MainMenuStrip.Items["fileToolStripMenuItem"];
            RootWorkItem.UIExtensionSites.RegisterSite("FileDropDown", filemenuitem.DropDown);
            StatusStrip statusStrip = (StatusStrip)Shell.statusStrip;
            RootWorkItem.UIExtensionSites.RegisterSite("StatusStrip", statusStrip);

            // Load the menu structure from App.config
            UIElementBuilder.LoadFromConfig(RootWorkItem);
        }
    }
}
