﻿namespace DeweySystem.FindCalls
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T data)
        {
            Data = data;
            Children = new List<TreeNode<T>>();
        }
    }

}