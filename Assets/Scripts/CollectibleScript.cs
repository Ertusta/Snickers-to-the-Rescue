using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        


        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

        }


    }
}
