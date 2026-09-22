using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        virtual public void Attack()
        {
            string attackType = "Basic Attack";
        }
        class HeroAttack : Hero
        {
            public void Attack()
            {
                string attackType = "Special Attack";
            }
        }
    }
}
