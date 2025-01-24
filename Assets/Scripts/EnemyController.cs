using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rd;
    public float speed = 1f;



    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rd = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // �÷��̾ �ٶ󺸴� ���� ���
        Vector3 direction = (player.transform.position - transform.position).normalized;

        // ���� �÷��̾ �ٶ󺸵��� ȸ��
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // ���� �÷��̾ ���� �̵�
        transform.position += direction * speed * Time.deltaTime;

    }

    public void OnDamage()
    {
        Destroy(gameObject);
    }
}
