using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interweave_Nodes
{
	public class Node
	{
		public int data;
		public Node next;

		public Node(int data = 0, Node next = null)
		{
			this.data = data;
			this.next = next;
		}
	}
}
