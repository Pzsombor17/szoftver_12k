using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozossegi_oldal
{
    public class ModerationQueue
    {
        private List<IReportable> _toReview;
        public List<IReportable> ToReview { get { return _toReview; } }

        public ModerationQueue()
        {
            _toReview = new List<IReportable>();
        }

        public void ReportItem(IReportable item)
        {
            item.Report();
            
        }
    }
}
