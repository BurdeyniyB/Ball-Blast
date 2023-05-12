using UnityEngine;

namespace Assets.Ball_Blast.Scripts
{
    public abstract class Administration
    {
        protected float cannonSpeed;
        protected Rigidbody2D rb;
        protected Vector2 pos;
        protected bool isMoving;

        public Administration(float cannonSpeed, Rigidbody2D rb, Vector2 pos, bool isMoving)
        {
            this.cannonSpeed = cannonSpeed;
            this.rb = rb;
            this.pos = pos;
            this.isMoving = isMoving;
        }

        public abstract void Movement();
        public abstract float Rotation();
    }
}
