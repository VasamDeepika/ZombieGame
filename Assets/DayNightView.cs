using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightView : MonoBehaviour
{
    [Tooltip("number of minutes per second that pass")]
    public float minutespersecond;
    private Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float anglePerFrame = Time.deltaTime / 360 *minutespersecond;
        transform.RotateAround(transform.position, Vector3.forward, anglePerFrame);

    }


}
