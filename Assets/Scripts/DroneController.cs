using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    
    [SerializeField]
    private float _health;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        } else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
        } else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * _speed);
        } else if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.down * Time.deltaTime * _speed);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Obstacle" || other.name == "Obstacle(Clone)")
        {TakeDamage(10f);}
    }
    private void TakeDamage(float damage)
    {
        if (damage > _health)
        {
            _health = 0;
        } else if (damage <= _health)
        {
            _health -= damage;
        }
        
        if (_health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
