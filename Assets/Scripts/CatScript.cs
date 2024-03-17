using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementScript : MonoBehaviour
{
    public float Speed = 5;
    public float Distance = 2;
    SpriteRenderer xnesne;

    


    void Start()
    {
        //3 saniyede bir fonksiyonu �a��r�r
        InvokeRepeating("Movement", Distance, Distance);
        xnesne = GetComponent<SpriteRenderer>();
        xnesne.flipX = true;
    }

    void Update()
    {
        //hareket kodu
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }


    void Movement()
    {
        //h�z�n y�n� de�i�ir
        Speed = -Speed;

        if(xnesne.flipX == true)
        {
            xnesne.flipX = false;
        }
        else
        {
            xnesne.flipX = true;
        }
        

    }

}
