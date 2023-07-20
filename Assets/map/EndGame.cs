using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private int leverPushedCount;
    // Start is called before the first frame update
    void Start()
    {
        leverPushedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(leverPushedCount == 3)
        {
            Debug.Log("End Game");
        }
    }

    public void CountLeversPushed()
    {
        leverPushedCount += 1;
    }
}
