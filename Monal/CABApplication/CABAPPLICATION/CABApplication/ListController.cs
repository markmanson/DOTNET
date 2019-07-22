using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.CompositeUI;

namespace CABApplication
{
  public class ListController:Controller
    {
        public ListViewWorkItem RegisterWorkItem
        {
            get { return base.WorkItem as ListViewWorkItem; }
        }
    }
}
