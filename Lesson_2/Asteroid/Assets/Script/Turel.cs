using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    public float speed;
    private Animator animvar;
    private Transform target;
    public GameObject effect;
    public float distance;
    private bool movingRight = true;
    public Transform groundedDetection;
    public float moveInput;
    public bool facingRight = true;
    void Start()
    {
        animvar = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        facingRight = !facingRight;
    }
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < 20)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        RaycastHit2D groundInfo = Physics2D.Raycast(groundedDetection.position, Vector2.down, distance);

        if (Vector3.Distance(target.position, transform.position) < 20)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (target.position.x > transform.position.x && !facingRight) 
                Flip();
            if (target.position.x < transform.position.x && facingRight)
                Flip();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("danger"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.gameObject.tag.Equals("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
