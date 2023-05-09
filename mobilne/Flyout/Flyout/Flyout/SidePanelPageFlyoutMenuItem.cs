using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyout
{
    public class SidePanelPageFlyoutMenuItem
    {
        public SidePanelPageFlyoutMenuItem()
        {
            TargetType = typeof(SidePanelPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string Icon { get; set; }
    }
}