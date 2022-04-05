using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public EFCore EFCore { get; set; }
        public int EFCoreId { get; set; }
    }
}
