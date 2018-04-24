using System;

namespace sll
{
    class Node
    {
        private int val;
        private Node next = null;
        public Node()
        {
        }

        public Node(int val)
        {
            this.val = val;
        }

        public void setVal(int val)
        {
            this.val = val;
        }
        public int getVal()
        {
            return this.val;
        }

        public void setNext(Node node)
        {
            this.next = node;
        }

        public Node getNext()
        {
            return this.next;
        }
    }
}
