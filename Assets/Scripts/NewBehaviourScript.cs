using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float steerspeed=1f;
    [SerializeField] float movespeed=0.01f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steer=Input.GetAxis("Horizontal")*steerspeed;
        float move=Input.GetAxis("Vertical")*movespeed;
        transform.Rotate(0,0,-steer);
        transform.Translate(0,move,0);
        
    }

}
