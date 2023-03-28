using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rcurve : MonoBehaviour
{
    float time=0.0f;
    bool retrun;
    float cycle;
   [SerializeField] [Range(0, 1)] float slider;
   [SerializeField] Transform hands;
    [SerializeField] Transform curve;
    [SerializeField] Vector3 endpoint;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        cycle = 0.0f;
       retrun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            endpoint = transform.position;
            retrun = true;
        }
        if (retrun)
        {

            if (time < 1f)
            {
                transform.position = objectReturn(time, endpoint, curve.position, hands.position);
                time += Time.deltaTime*1.5f;
                Debug.Log(time);
            }
        }
    }
    Vector3  objectReturn(float t,Vector3 p0,Vector3 p1,Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        return (uu * p0) + (2 * u * t * p1) + (tt * p2);

       
    }

}
