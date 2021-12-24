using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder.Common
{
    public interface ICoder
    {
        string  Encode(string str);
        string Decode(string str);
    }
}
