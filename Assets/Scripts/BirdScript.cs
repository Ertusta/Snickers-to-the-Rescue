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
        //1 saniyede bir fonksiyonu çaðýrýr
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
            //hedefin konumundan kendi konumunu çýkarýr
            Player = GameObject.FindWithTag("Player");
            targetPosition=Player.transform.position - gameObject.transform.position;

        
        //eðerki ikisi arasýndaki mesafe 10 dan küçükse x ve y uzaklýðýna göre hýz atamasý yapýlýr büyükse hýz sýfýrlanýr
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
