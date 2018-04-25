using System;
// using System.Collections;

namespace sll
{
    class SLL
    {
        private Node head = null;
        private int length = 0;

        public SLL add(int val)
        {
            if (this.head == null)
            {
                this.head = new Node(val);
            }
            else
            {
                Node runner = this.head;
                while (runner.getNext() != null)
                {
                    runner = runner.getNext();
                }
                runner.setNext(new Node(val));
            }
            length++;
            return this;
        }

        public int[] printToArray()
        {
            int[] array = new int[this.length];
            Node runner = this.head;
            for (int i = 0; i < this.length; i++)
            {
                array[i] = runner.getVal();
                runner = runner.getNext();
            }
            return array;
        }

        public int size()
        {
            return this.length;
        }
    }
}
