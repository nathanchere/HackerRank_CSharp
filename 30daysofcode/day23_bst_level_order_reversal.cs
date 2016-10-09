// HackerRank "30 Days of Code" - Day 23 - BST Level Order Traversal

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution
{

// ------[ Solution code begins here ]------------------------------------------

private static Queue<Node> _queue = new Queue<Node>();

static void levelOrder(Node root){
  _queue.Enqueue(root);

  while(_queue.Any())
  {
    var next = _queue.Dequeue();
    Console.Write(next.data + " ");
    if(next.left != null) _queue.Enqueue(next.left);
    if(next.right != null) _queue.Enqueue(next.right);
  }
}


// ------[ Solution code ends here ]--------------------------------------------

static Node insert(Node root, int data){
      if(root==null){
          return new Node(data);
      }
      else{
          Node cur;
          if(data<=root.data){
              cur=insert(root.left,data);
              root.left=cur;
          }
          else{
              cur=insert(root.right,data);
              root.right=cur;
          }
          return root;
      }
  }
  static void Main(String[] args){
      Node root=null;
      int T=Int32.Parse(Console.ReadLine());
      while(T-->0){
          int data=Int32.Parse(Console.ReadLine());
          root=insert(root,data);
      }
      levelOrder(root);

  }
}
