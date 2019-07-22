using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

namespace CABApplication
{
    class CABApplicationModuleInit:ModuleInit
    {
        private WorkItem workItem;
        [InjectionConstructor]
        public CABApplicationModuleInit([ServiceDependency] WorkItem workItem)
        {
            this.workItem = workItem;
        }
        public override void AddServices()
        {
            base.AddServices();
        }
        public override void Load()
        {
            base.Load();
        }

    }
}
