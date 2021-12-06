using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreDamage : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-3);
        }
    }
}