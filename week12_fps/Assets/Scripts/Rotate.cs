using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    private Vector3 val = new Vector3(12, 0, 0);
    private Vector3 pos;
    public bool enableSpin = true;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    this.gameObject.transform.Rotate( (enableSpin) ? new Vector3 (0,100,0) : Vector3.zero);
    this.gameObject.transform.position = pos + (val * Mathf.Sin(Time.timeSinceLevelLoad));
            
    }
}
