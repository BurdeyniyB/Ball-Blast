using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorStrike : MonoBehaviour
{
    [SerializeField] private MeteorLife _meteorLife;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "missile")
        { 
            _meteorLife.TakeDamage();
            Destroy(collision.gameObject); 
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

}
