using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    public Health Healthhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            Healthhealth.TakeDamage(1);
        }
    }
}
