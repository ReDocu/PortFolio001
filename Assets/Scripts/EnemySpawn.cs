using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    bool pointer = false;
    private void Awake()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {
        pointer = true;
        while (true)
        {
            if (pointer)
            {
                Instantiate(monster,transform.position,transform.rotation,null);

                yield return new WaitForSeconds(3.0f);
            }
        }
    }
}
