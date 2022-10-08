using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public bool addTime; 
    public uint time = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Picked()
    {
        int sign;
        if (addTime) 
        {
            sign = 1;
        }
        else
        {
            sign = -1;
        }
        GameManager.gameManager.AddTime((int)time * sign);
        Destory(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}
