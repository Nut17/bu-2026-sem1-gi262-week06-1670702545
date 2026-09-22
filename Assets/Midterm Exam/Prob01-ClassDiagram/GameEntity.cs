using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        // TODO: Implement fields and methods according to Class Diagram
        virtual public void Move(Vector3 direction)
        {
            
        }
        class Player : GameEntity
        {
            public void Move(Vector3 direction)
            {
                // Implementation for player movement
            }
        }
    }
}
