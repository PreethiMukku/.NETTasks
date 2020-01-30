using System;

namespace MyList
{
	/// <summary>
	/// Node class
	/// </summary>
	public class Node
	{
		public Node next;
		public int data;
		public Node(int d)
		{
			data = d;
			next = null;
		}
	}

	/// <summary>
	/// class for List operations
	/// </summary>
	public class ListOperations
	{
		private Node head = null;

		/// <summary>
		/// Method to add elements into list
		/// </summary>
		/// <param name="data">Takes integer type values</param>
		public void Add(int data)
		{
			Node newNode = new Node(data);
			
			if (head == null)
			{
				head = newNode;
				return;
			}
			else
			{
				Node current_Node = head;

				while (current_Node.next != null)
				{
					current_Node = current_Node.next;
				}
				current_Node.next = newNode;
			}
		}

		/// <summary>
		/// Method to Insert element at specific index
		/// </summary>
		/// <param name="data">Takes integer value</param>
		/// <param name="index">Takes integer value, which is position number</param>
		public void Insert(int data, int index)
		{
			Node newNode = new Node(data);
			
			if (index == 0)
			{
				newNode.next = head;
				head = newNode;
				return;
			}
			else
			{
				Node current_Node = head;
				Node nextNode = current_Node.next;
				int count = 0;

				while (current_Node.next != null && count != index-1)
				{
					current_Node = current_Node.next;
					nextNode = current_Node.next;
					count++;
				}
				current_Node.next = newNode;
				newNode.next = nextNode;
			}
		}

		/// <summary>
		/// Method to find position number of element
		/// </summary>
		/// <param name="data">Takes an integer value </param>
		/// <returns></returns>
		public Object Search(int data)
		{
			Node current_Node = head;
			int count = 0;

			while (current_Node.next != null)
			{
				if (current_Node.data == data)
					return count;

				current_Node = current_Node.next;
				count++;
			}
			return 0;
		}
		

	/// <summary>
	/// Method to check an element is in list or not
	/// </summary>
	/// <param name="element">Takes integer type value</param>
	/// <returns></returns>
		public bool Contains(int element)
		{
			Node current_Node = head;

			while (current_Node != null)
			{
				if (current_Node.data == element)
					return true;

				current_Node = current_Node.next;
			}
			return false;
		}

		/// <summary>
		/// Method to reverse the list
		/// </summary>
		public void Reverse()
		{
			Node currentNode = head;
			Node nextNode = null;
			Node prevNode = null;

			while (currentNode != null)
			{
				nextNode = currentNode.next;
				currentNode.next = prevNode;
				prevNode = currentNode;
				currentNode = nextNode;
			}
			head = prevNode;
		}

		/// <summary>
		/// Method to clear all contents of list
		/// </summary>
		public void clear()
		{
			head = null;
		}

		/// <summary>
		/// Method to remove a specific element
		/// </summary>
		/// <param name="element">Takes data of integer type</param>
		public void Remove(int element)
		{
			Node current_Node = head;

			if (current_Node.data == element && current_Node != null)
			{
				head = current_Node.next;
				return;
			}
			Node prev_Node = null;

			while (current_Node != null)
			{
				if (current_Node.data.Equals(element))
				{
					if (current_Node.next == null)
						prev_Node.next = null;
					else
						prev_Node.next = current_Node.next;

					Console.WriteLine("Element found and deleted");
					return;
				}
				prev_Node = current_Node;
				current_Node = current_Node.next;
			}
			Console.WriteLine("Element not found");
		}

		public void Sort()
		{
			Node temp1 = null, temp2 = null;
			int tempData;
			for (temp1 = head; temp1.next != null; temp1 = temp1.next)
			{
				for (temp2 = temp1.next; temp2 != null; temp2 = temp2.next)
				{
					if ((temp1.data) > temp2.data)
					{
						tempData = temp1.data;
						temp1.data = temp2.data;
						temp2.data = tempData;
					}
				}
			}
		}

		/// <summary>
		/// Method to print contents of the list
		/// </summary>
		public void ForEach()
		{
			Console.WriteLine("printing ...");

			Node current_Node = head;

			while (current_Node != null)
			{
				Console.WriteLine(current_Node.data);
				current_Node = current_Node.next;
			}
		}
	}

	class Program
	{
		static void Main()
		{

		}
	}
}
