﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBulletScript : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            LiifeContrroller.CheckLifes15();
        }
    }
}
