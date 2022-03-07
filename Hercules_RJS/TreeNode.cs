using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpTreeLib;

namespace Hercules_RJS
{
    public class TreeNode
    {
        public String path { get; set; }
        public CShItem item { get; set; }

        public TreeNode(String SelPath, CShItem CSI)
        {
            path = SelPath;
            item = CSI;
        }

        public override String ToString()
        {
            return path;
        }
    }
}
