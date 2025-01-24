using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Transform tr;
    Rigidbody2D rb;

    public float power = 900f;
    Vector2 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        tr = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
        velocity = (Vector2.left * -1) * power;
        rb.AddRelativeForce(velocity);
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("여기 : " + collision.tag);


        if (collision.tag == "Enemy")
        {
            Debug.Log("충돌?");
            EnemyController enemy = collision.GetComponentInParent<EnemyController>();
            enemy.OnDamage();
        }
    }
}
