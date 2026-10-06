using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int süre = 1;

        switch (süre)
        {
            case 1: print("120 TL");
                break;

            case 2: print("200 TL");
                break;

            case 3: print("300 TL");
                break;

            case 4: print("400 TL");
                break;


            
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
