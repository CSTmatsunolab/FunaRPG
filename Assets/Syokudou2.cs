using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokudou2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="Quiz_ticket"){
            transform.position=new Vector3(10,-7.6f,0);
        }
         Data.Instance.referer="Syokudou2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
