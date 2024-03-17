using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public float counter=0;

    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;  
    public GameObject menu4;
    public GameObject menu5;

    public  GameObject menu6;
    public void Basla()
    {
        if (counter == 0)
        {
            menu1.gameObject.SetActive(true);
            menu2.gameObject.SetActive(true);
            menu3.gameObject.SetActive(true);
            menu4.gameObject.SetActive(true);
            menu5.gameObject.SetActive(true);
            menu6.gameObject.SetActive(true);
        }
        else if(counter == 1) 
        {
             menu5.gameObject.SetActive(false); 
        }
        else if (counter == 2)
        {
            menu4.gameObject.SetActive(false);
        }
        else if (counter == 3)
        {
            menu3.gameObject.SetActive(false);
        }
        else if (counter == 4)
        {
            menu2.gameObject.SetActive(false);
        }
        else if (counter == 5)
        {
            menu1.gameObject.SetActive(false);
            SceneManager.LoadScene("Market");
        }



        counter += 1;
        
    }
    
    public void Cýkýs()
    {
        Application.Quit();
    }









}
