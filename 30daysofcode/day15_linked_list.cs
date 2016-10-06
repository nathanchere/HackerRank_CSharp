// HackerRank "30 Days of Code" - Day 15 - Linked Lists

using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }

}
class Solution
{

// ------[ Solution code begins here ]------------------------------------------

	public static Node insert(Node head, int data)
	{
		var result = new Node(data);

		if(head == null) return result;

		Node current = head;
		while(current.next != null) current = current.next;
		current.next = result;

		return head;
	}

// ------[ Solution code ends here ]--------------------------------------------

  public static void display(Node head)
  {
    Node start=head;
    while(start!=null)
    {
      Console.Write(start.data+" ");
      start=start.next;
    }
  }

  static void Main(String[] args)
  {
    Node head=null;
    int T=Int32.Parse(Console.ReadLine());
    while(T-->0){
        int data=Int32.Parse(Console.ReadLine());
        head=insert(head,data);
    }
    display(head);
  }
}
