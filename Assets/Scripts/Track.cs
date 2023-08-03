using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    [SerializeField] GameObject mainObject;
    private void LateUpdate() {
        transform.position=mainObject.transform.position+new Vector3(0,0,-10);
    }
}
