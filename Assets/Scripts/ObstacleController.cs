using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float _speed;
    public int _damage;

    public GameObject _exposion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            other.GetComponent<PlayerController>().Hurt(_damage);
            Instantiate(_exposion, transform.position, Quaternion.identity);
            //other.GetComponent<HealthControllerUI>().DestroyHearth();
            Destroy(this.gameObject);
        }
    }
}
