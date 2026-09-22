using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            for (LinkedListNode<int> node = list.First; node != null; node = node.Next)
            {
                for (LinkedListNode<int> innerNode = node.Next; innerNode != null; innerNode = innerNode.Next)
                {
                    if (node.Value > innerNode.Value)
                    {
                        int temp = node.Value;
                        node.Value = innerNode.Value;
                        innerNode.Value = temp;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            for (LinkedListNode<int> node = list.First; node != null; node = node.Next)
            {
                for (LinkedListNode<int> innerNode = node.Next; innerNode != null; innerNode = innerNode.Next)
                {
                    if (node.Value < innerNode.Value)
                    {
                        int temp = node.Value;
                        node.Value = innerNode.Value;
                        innerNode.Value = temp;
                    }
                }
            }
            return list;
        }
    }
}
