using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class GameObject
    {
        private int _positionW, _positionH;
    }
    interface IMoveable
    {
        void Move(int posW, int posH);
    }
    interface ICollider
    {
        void ColliderReaction(GameObject obj1, GameObject obj2);
    }

    class Player : GameObject, IMoveable, ICollider
    {
        public int health;

        public void Move(int posW, int posH)
        {
            // obstacle check
            // WASD to move
        }
        public void ColliderReaction(GameObject player, GameObject obj)
        {
            // if player collides enemy health--
            // if player collides bonus -> health++
            // if player collides obstacle posW or posH blocked to move
        }
    }
    class Monster : GameObject, IMoveable, ICollider
    {
        public void Move(int posW, int posH)
        {
            // obstacle check
            // if posW != player.posW && posH != player.posH -> moveToPlayer()
        }
        public void MoveToPlayer()
        {
            // if posW != player.posW > this.posW -> this.posW++ (same with height)
        }
        public void ColliderReaction(GameObject player, GameObject obj)
        {
            // if moster collides obstacle posW or posH blocked to move
        }
    }
    class Bonus : GameObject, ICollider
    {
        // get position (pos != obstacle, player or monster)
        private static int BonusCount;

        private void GetBonusCount(/*Level lvl*/)
        {
            // count bonuses on level
        }
        public void ColliderReaction(GameObject player, GameObject obj)
        {
            // if player collides bonus -> bonus count--
            // this.delete
            // else if bonus count == 0 -> level cleared -> loadNext
        }
        class Obstacle : GameObject
        {
            // get position (pos != bonus, player or monster)

            public void ColliderReaction(GameObject player, GameObject obj)
            {
                // block path if collides object
            }
        }






        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
