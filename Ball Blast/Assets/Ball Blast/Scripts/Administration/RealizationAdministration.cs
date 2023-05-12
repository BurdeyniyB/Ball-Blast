using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Ball_Blast.Scripts
{
    internal class RealizationAdministration : Administration
    {
        private float _returnSpeed;
        public RealizationAdministration(float cannonSpeed,
                                         Rigidbody2D rb,
                                         Vector2 pos,
                                         bool isMoving) : base(cannonSpeed, rb, pos, isMoving) { }

        public override void Movement()
        {
            if (isMoving)
                rb.MovePosition(Vector2.Lerp(rb.position, pos, cannonSpeed * Time.fixedDeltaTime));
            else
                rb.velocity = Vector2.zero;
        }

        public override float Rotation()
        {
            if (isMoving)
            {
                if (pos.x > 0)
                {
                    _returnSpeed = Vector3.Distance(rb.position, pos) * 150f;
                }
                else
                {
                    _returnSpeed = -Vector3.Distance(rb.position, pos) * 150f;
                }
            }
            else
            {
                _returnSpeed = 0f;
            }

            return _returnSpeed;
        }
    }
}
