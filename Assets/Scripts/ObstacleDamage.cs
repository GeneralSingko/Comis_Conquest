using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    private Health Healthhealth;
    public int damage = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            Healthhealth = collision.gameObject.GetComponent<Health>();

            if (Healthhealth != null)
            {
                Healthhealth.numOfHearts -= damage;

                Healthhealth.Hearts();
            }
        }

        Debug.Log("Collided with Player");
    }
}
