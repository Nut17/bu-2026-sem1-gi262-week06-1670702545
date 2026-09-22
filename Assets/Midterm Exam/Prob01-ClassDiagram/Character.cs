using UnityEngine;

namespace MidtermExam.Prob01
{
    public class character
    {
        float health;
        public float speed;


        // TODO: Implement inheritance, fields and methods according to Class Diagram
        class Player : Character

        {
            public void Move()
            {
                // Implementation for player movement
            }


        }
        class Enemy : Character
        {


            public void Attack()
            {
                // Implementation for enemy attack
            }
        }

        class NPC : Character

        {
            public void Interact()
            {
                // Implementation for NPC interaction
            }
        }
    }
}


