using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynnSmithPortal
{
    public class StudentApplication
    {
        public int ApplicationId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string DesiredMajor { get; set; }
        public string References { get; set; }
        public byte[] EssayFile { get; set; } // Binary data of the essay
        public string EssayFileName { get; set; } // File name of the essay
        public string EssayFileType { get; set; } // MIME type (e.g., application/pdf)
    }
}
