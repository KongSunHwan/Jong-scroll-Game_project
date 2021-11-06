using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {
    public float speedZ;
    public GameObject hitEffect;
    public GameObject effect;

        void Start()
        {

        }

        void Update()
        {
            transform.Translate(0, 0, speedZ * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "enemy")
            {
            Instantiate(hitEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            Score.score += 10;
            }
        if (other.gameObject.tag == "Boss")
        {
            Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Score.score += 10;
        }
        if (other.gameObject.tag == "Player")
            {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
            }
        }
    }

