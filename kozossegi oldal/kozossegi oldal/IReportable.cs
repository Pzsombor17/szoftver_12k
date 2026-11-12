using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozossegi_oldal
{
    
    public interface IReportable
    {
        void Report();
        int ReportCount();
        string GetDescription();

    }
}

