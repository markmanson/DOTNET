using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace CABApplication
{
    public partial class MainMenu : Form
    {
        private WorkItem m_workItem;
        private IWorkspace m_mdiWorkspace;       

        public MainMenu()
        {
            InitializeComponent();
        }
      
        [InjectionConstructor]
        public MainMenu(WorkItem workItem,IWorkItemTypeCatalogService workItemTypeCatalog) : this()
        {
            this.m_workItem = workItem;
            m_mdiWorkspace = new MdiWorkspace(this);
        }
        [CommandHandler("FileExit")]
        public void OnFileExit(object sender, EventArgs e)
        {
            Close();
        }

        [CommandHandler("FileRegistartionForm")]
        public void OnFileRegistration(object sender, EventArgs e)
        {
            RegistartionFormWorkItem registrationWorkItem = m_workItem.WorkItems.AddNew<RegistartionFormWorkItem>();
            registrationWorkItem.Show(ContentWorkspace);
        }
        [CommandHandler("FileListscreen")]
        public void OnFileListScreen(object sender, EventArgs e)
        {
            ListViewWorkItem  ListWorkItem = m_workItem.WorkItems.AddNew<ListViewWorkItem>();
            ListWorkItem.Show(ContentWorkspace);
        }
        public IWorkspace ContentWorkspace
        {
            get { return this.m_mdiWorkspace; }
        }
        
    }
}
