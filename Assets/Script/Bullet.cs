using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var nPos = transform.position;
        nPos.y += flySpeed * Time.deltaTime;
        transform.position = nPos;
    }
}
