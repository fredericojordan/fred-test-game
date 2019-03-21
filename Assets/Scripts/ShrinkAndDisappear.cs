using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndDisappear : MonoBehaviour
{
    private const float shrink_speed = 10.0F;
    private const float min_scale = 0.01F;

    void Update()
    {
        float actual_speed = shrink_speed * 0.0001F;
        transform.localScale -= new Vector3(actual_speed, 0, actual_speed);

        if (transform.localScale[0] <= min_scale) {
            gameObject.SetActive(false);
        }
    }
}
