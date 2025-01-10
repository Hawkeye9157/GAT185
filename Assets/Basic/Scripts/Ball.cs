using UnityEngine;

public class Ball : MonoBehaviour
{
    [Range(1,10)]public float speed = 5.0f;
    public GameObject prefab;
    private void Awake()
    {
        
    }
    void Start()
    {
    
    }
    void Update()
    {
        Vector3 position = transform.position;
        Vector3 velocity = Vector3.zero;
       
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(prefab,transform.position + Vector3.up,Quaternion.identity);
        }
        
        
        

        transform.position += velocity * speed * Time.deltaTime;
    }
}
