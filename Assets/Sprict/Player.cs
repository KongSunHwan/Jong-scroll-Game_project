using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float cubeX;
    public float cubeZ;
    public float limitX;
    public float limitZ;
    public GameMgr gameMgr;


    void Awake()
    {

    }

    void Update()
    {
        if (transform.position.x > limitX)
        {
            transform.position = new Vector3(limitX, 0.5f, transform.position.z);
        }
        if (transform.position.x < -limitX)
        {
            transform.position = new Vector3(-limitX, 0.5f, transform.position.z);
        }
        if (transform.position.z > limitX)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, limitZ);
        }
        if (transform.position.z < -limitX)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, limitZ);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 0, z * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, 0, -z * Time.deltaTime);
        }
        void MoveRight()
        {
            gameObject.transform.Translate(x * Time.deltaTime, 0, 0);
        }

        void MoveLeft()
        {
            gameObject.transform.Translate(-x * Time.deltaTime, 0, 0);
        }
        void MoveUp()
        {
            gameObject.transform.Translate(0, 0, z * Time.deltaTime);
        }

        void MoveDown()
        {
            gameObject.transform.Translate(0, 0, -z * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            gameMgr.gameOver = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            gameMgr.gameOver = true;
            Score.score = 0;
        }
        if (other.gameObject.tag == "Coin")
        {
            Score.score += 5;
        }
        if (other.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
            gameMgr.gameOver = true;
            Score.score = 0;
        }
        if (other.gameObject.tag == "BossCoin")
        {
            Score.score += 50;
        }
    }
}

