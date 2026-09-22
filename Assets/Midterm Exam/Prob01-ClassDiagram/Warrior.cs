using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        class WarriorAttack : Warrior
        {
            public void Attack()
            {
                string attackType = "Warrior Attack";
            }
        }
        class WarriorDefense : Warrior
        {
            public void Defend()
            {
                string defenseType = "Warrior Defense";
            }
        }
    }
}
