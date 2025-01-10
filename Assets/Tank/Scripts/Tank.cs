using UnityEditor;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] float turnRate = 90.0f;
    [SerializeField] float maxSpeed = 10.0f;
    public GameObject prefab;
    void Start()
    {
        
    }

    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float speed = Input.GetAxis("Vertical");

        transform.rotation = transform.rotation * Quaternion.AngleAxis
            (rotation * turnRate * Time.deltaTime, Vector3.up);

        //transform.position += (transform.rotation * Vector3.forward)
        //* speed * maxSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * maxSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position + Vector3.up, transform.rotation);
            
            
        }
    }
}
