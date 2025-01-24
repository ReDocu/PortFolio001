using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject body;
    [SerializeField] private Transform muzzle;

    [SerializeField] private GameObject bullet;

    public float jumpHeight = 7.0f;
    public float speed = 1f;
    private Rigidbody2D characterRigidbody;

    private void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        characterRigidbody.linearVelocityX = inputX *= speed;

        //float inputZ = Input.GetAxis("Vertical");
        //Vector2 velocity = new Vector2(inputX, inputZ);
        //velocity *= speed;
        //characterRigidbody.linearVelocity = velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterRigidbody.linearVelocityY = jumpHeight;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, muzzle.position,muzzle.rotation,null);
        }
    }
}
