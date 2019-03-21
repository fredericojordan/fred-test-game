using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkGround : MonoBehaviour
{
    private const float shrink_speed = 10.0F;
    private const float min_scale = 0.05F;

    void Update()
    {
        if (transform.localScale[0] >= min_scale) {
            float actual_speed = shrink_speed * 0.0001F;
            transform.localScale -= new Vector3(actual_speed, 0, actual_speed);
        }
    }
}
