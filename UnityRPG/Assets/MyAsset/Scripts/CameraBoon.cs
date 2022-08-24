using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoon : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public Vector2 maxPos;
    public Vector2 minPos;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(transform.position != target.position)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            newPos.x = Mathf.Clamp(newPos.x, minPos.x, maxPos.x);
            newPos.y = Mathf.Clamp(newPos.y, minPos.y, maxPos.y);

            transform.position = newPos;
        }
    }
}
