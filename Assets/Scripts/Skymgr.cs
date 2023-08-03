using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skymgr : MonoBehaviour
{
    public static Skymgr Instance;
    private float MinX=-7.72f;
    private float MaxX=4.32f;
    private float MaxY=5.36f;
    private float MinY=3.77f;
    public GameObject sunPre;
    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
        sunPre=Resources.Load<GameObject>("Sun");
        InvokeRepeating("CreateSum",2,5);
    }
    private void CreateSum(){
        GameObject go=GameObject.Instantiate(sunPre);
        Sun sun=go.GetComponent<Sun>();
        float X=Random.Range(MinX,MaxX);
        float Y=Random.Range(MinY,MaxY);
        sun.InitSkySun(X,transform.position.y,Y);
    }
}
