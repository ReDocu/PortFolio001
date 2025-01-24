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
        // 플레이어를 바라보는 방향 계산
        Vector3 direction = (player.transform.position - transform.position).normalized;

        // 적이 플레이어를 바라보도록 회전
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // 적이 플레이어를 향해 이동
        transform.position += direction * speed * Time.deltaTime;

    }

    public void OnDamage()
    {
        Destroy(gameObject);
    }
}
