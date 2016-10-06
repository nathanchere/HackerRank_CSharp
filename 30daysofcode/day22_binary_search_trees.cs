// HackerRank "30 Days of Code" - Day 22 - Binary Search Trees

using System;
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

  static int getHeight(Node root)
  {
    return getHeight(root, 0);
  }

  static int getHeight(Node root, int total)
  {
    var leftTotal = root.left == null
    ? total
    : getHeight(root.left, total+1);

    var rightTotal = root.right == null
    ? total
    : getHeight(root.right, total+1);

    return Math.Max(leftTotal, rightTotal);
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
      int height=getHeight(root);
      Console.WriteLine(height);

  }
}
