using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.CompositeUI;

namespace CABApplication
{
   public class RegisterController:Controller
    {
        public RegistartionFormWorkItem RegisterWorkItem
        {
            get { return base.WorkItem as RegistartionFormWorkItem; }
        }
    }
}
