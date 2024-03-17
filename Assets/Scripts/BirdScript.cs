using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    GameObject Player;

    
    Vector2 targetPosition;

    public float xSpeed;
    public float ySpeed;

    public float speed=5;

    public float Distance;

    SpriteRenderer xnesne;


    void Start()
    {
        //1 saniyede bir fonksiyonu �a��r�r
        InvokeRepeating("Movement", 0.5f, 0.5f);
        xnesne = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        //hareket kodu
        transform.Translate(xSpeed*Time.deltaTime,ySpeed*Time.deltaTime,0);
    }



    void Movement()
    {
            //hedefin konumundan kendi konumunu ��kar�r
            Player = GameObject.FindWithTag("Player");
            targetPosition=Player.transform.position - gameObject.transform.position;

        
        //e�erki ikisi aras�ndaki mesafe 10 dan k���kse x ve y uzakl���na g�re h�z atamas� yap�l�r b�y�kse h�z s�f�rlan�r
        if (targetPosition.magnitude < Distance)
        {


            if (targetPosition.x > 0)
            {
                xSpeed = speed; 
                xnesne.flipX = true;
            }
            else
            {
                xSpeed = -speed;
                xnesne.flipX = false;
            }
            
            if (targetPosition.y > 0)
            {
                ySpeed = speed;
            }
            else
            {
                ySpeed = -speed;
            }

        }
        else
        {
            xSpeed = 0;
            ySpeed = 0;
        }
    }

}
