using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speedZ;
    public int enemyHP;
    public GameObject coin;
    public GameObject effect;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, 0, speedZ * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        enemyHP--;
        if (enemyHP <= 0)
        {
            Instantiate(coin, transform.position, transform.rotation);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
