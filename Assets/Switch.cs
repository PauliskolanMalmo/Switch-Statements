using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int points;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {

            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                print("50");
                break;
            case 100:
                print("100");
                break;
            default:
                print("You neeed 50 or 100 på print a messaage");
                break;
        }
    }

}
