using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    
    public int süre;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (süre < 0)
        {
            Debug.Log("Geçersiz Saat");
            return;
        }


        switch (süre)
        {

            case 0:
                Debug.Log("Ücretsiz");
                break;

            case 1:
                Debug.Log("120 TL");
                break;

            case 2:
                Debug.Log("200 TL");
                break;

            case 3:
                Debug.Log("300 TL");
                break;

            case 4:
                Debug.Log("400 TL");
                break;

            default:
                Debug.Log("550 TL");
                break;


   
        }

      



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
