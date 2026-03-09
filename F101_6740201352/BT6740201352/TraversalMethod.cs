using BinaryTreeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6740201352
{
    public class TraversalMethod
    {
        public void PreorderTraversal(Node current)
        {
            if (current != null)
            {
                Console.Write("{0} ", current.Value.ToString());
                PreorderTraversal(current.Left);
                PreorderTraversal(current.Right);
            }
        }
    }
}
