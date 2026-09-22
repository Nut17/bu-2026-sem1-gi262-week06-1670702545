using UnityEngine;

namespace MidtermExam.Prob01
{
    public class InventoryItem
    {
        // TODO: Implement fields and methods according to Class Diagram
        string itemName;
        interface IUsable
        {
            void Use();
        }
        class HealthPotion : InventoryItem, IUsable
        {
            public void Use()
            {
                // Implement the logic for using a health potion
                Debug.Log("Using Health Potion");
            }
        }

    }
}

