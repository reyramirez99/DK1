using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject playerObject;
    public float lerpSpeed = 0.5f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //get the current offset between player and camera positions;
        offset = transform.position - playerObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, playerObject.transform.position + offset, lerpSpeed);   
    }
}
