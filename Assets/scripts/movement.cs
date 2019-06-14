using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movement : MonoBehaviour
{

    Rigidbody2D body;

    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        speed = 10;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy" || col.gameObject.tag == "double" || col.gameObject.tag == "triple")
        {
            Destroy(gameObject);
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        }
    }
    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position;
            newBullet.GetComponent<BulletMove>().shoot();
            //Physics2D.IgnoreCollision(newBullet.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        }
    }
}
