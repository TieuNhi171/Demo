using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var wouldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        wouldPoint.z = 0;
        transform.position = wouldPoint;
    }
}
