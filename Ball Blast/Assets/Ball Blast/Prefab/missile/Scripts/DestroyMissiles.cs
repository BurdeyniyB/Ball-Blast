using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissiles : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "missile")
        {
            Destroy(collision.gameObject);
        }
    }
}
