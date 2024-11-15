using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArScale : MonoBehaviour
{
    public Vector3 scale;
    public float startDistance;
    public GameObject SObject; // Object to scale

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Began || touch1.phase == TouchPhase.Began)
            {
                startDistance = Vector2.Distance(touch0.position, touch1.position);
                scale = SObject.transform.localScale; // Get current scale
            }
            else
            {
                Vector2 v1 = touch0.position;
                Vector2 v2 = touch1.position;

                float distance = Vector2.Distance(v1, v2);
                float factor = distance / startDistance;

                SObject.transform.localScale = scale * factor;
            }
        }
    }
}
