using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject enemy;
    public float curTime;
    public float coolTime;
    public float limiZ;

    void Start()
    {

    }

    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > coolTime)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            curTime = 0;
            float rnd = Random.Range(-limiZ, limiZ);
            transform.position = new Vector3(rnd, transform.position.y, transform.position.z);
        }
    }
}
