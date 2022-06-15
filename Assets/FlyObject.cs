using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //memanggil fungsi game over
        gameManager.GameOver();
    }
}
