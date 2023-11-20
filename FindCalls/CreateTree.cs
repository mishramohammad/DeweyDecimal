using System;
using System.Collections.Generic;
using System.Text;

namespace DeweySystem.FindCalls
{
    using System;
    using System.Collections.Generic;

    namespace DeweySystem.FindCalls
    {
        public class CreateTree
        {
            public TreeNode<CallNumbers> Root { get; private set; }

            public CreateTree(CallNumbers root)
            {
                Root = new TreeNode<CallNumbers>(root);
            }

            public void AddNode(CallNumbers parentCallNum, CallNumbers callNum)
            {
                var parentNode = FindNode(Root, parentCallNum);
                if (parentNode != null)
                {
                    parentNode.Children.Add(new TreeNode<CallNumbers>(callNum));
                }
            }

            private TreeNode<CallNumbers> FindNode(TreeNode<CallNumbers> node, CallNumbers callNum)
            {
                if (node.Data.CallNum == callNum.CallNum)
                {
                    return node;
                }

                foreach (var child in node.Children)
                {
                    var result = FindNode(child, callNum);
                    if (result != null)
                    {
                        return result;
                    }
                }

                return null;
            }
        }
    }
}


//Kini, M. 2020. Tree data structure. [Online]. [Accessed: 20 November 2023].
//reference: https://www.c-sharpcorner.com/article/tree-data-structure/