using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.CompositeUI.EventBroker;
using System.Drawing;

namespace CABApplication
{
   public class RegistartionFormWorkItem:WorkItem
    {
        private static Point pos = new Point(0, 0);
        private RegistrationViewForm m_RegisterFormView;
        private WindowSmartPartInfo m_smartPart;
        private static ToolStripLabel m_status;

        public void Show(IWorkspace parentWorkspace)
        {
            m_smartPart = new WindowSmartPartInfo();
            m_smartPart.ControlBox = true;
            m_smartPart.Location = pos;
            m_smartPart.Title = "Registration form";
            pos = Point.Add(pos, new Size(100, 100));
            m_RegisterFormView = Items.AddNew<RegistrationViewForm>();
            parentWorkspace.Show(m_RegisterFormView, m_smartPart);
            this.Activate();
        }

        private void DisplayStatus(string strStatus)
        {
            if (m_status == null)
            {
                m_status = new ToolStripLabel();
                RootWorkItem.UIExtensionSites["StatusStrip"].Add(m_status);
            }
            m_status.Text = strStatus;
        }


        protected override void OnActivated()
        {
            base.OnActivated();            
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }

        protected override void OnTerminated()
        {
            base.OnTerminated();
        }
    }
}
