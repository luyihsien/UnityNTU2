using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private float TargetY;
    private GameObject sumNum;
    // Start is called before the first frame update
    public  void InitSkySun(float x,float y,float targetY)
    {
        transform.position=new Vector3(x,y,0);
        TargetY=targetY;
    }
}
