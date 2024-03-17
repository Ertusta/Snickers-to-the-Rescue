using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI PointText;
    public TMPro.TextMeshProUGUI PointText1;

    public float kayit;
   				
    
    void Start()
    {
        Invoke("Info", 0.1f);
    }

    void Info()
    {
        if (CounterScript.Instance.point> PlayerPrefs.GetFloat("kayit"))
        {
            PlayerPrefs.SetFloat("kayit", CounterScript.Instance.point);
        }
        
        PointText.text = CounterScript.Instance.point.ToString();
        PointText1.text = PlayerPrefs.GetFloat("kayit").ToString();
    }

    public void Devam()
    {
        SceneManager.LoadScene("Market");
        CounterScript.Instance.point = 0;

    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
        CounterScript.Instance.point = 0;
    }

}
