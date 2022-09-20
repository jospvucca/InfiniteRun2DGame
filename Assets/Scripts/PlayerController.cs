using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    public float _yIncrement = 5.0f;

    private Vector2 _targetPosition;

    public float _maxHeight;
    public float _minHeight;

    public int _health = 5; //definat max(5) i min(1) vrijednost

    public GameObject _effect;
    //public GameObject _canvas;
    public Text _healthText;

    // Start is called before the first frame update
    void Start()
    {
        _healthText.text = "Health: " + _health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < _maxHeight) 
        {
            Instantiate(_effect, transform.position, Quaternion.identity);
            _targetPosition = new Vector2(transform.position.x, transform.position.y + _yIncrement);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > _minHeight) 
        {
            Instantiate(_effect, transform.position, Quaternion.identity);
            _targetPosition = new Vector2(transform.position.x, transform.position.y - _yIncrement);
        }
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Player health: " + _health.ToString());
        //_canvas.GetComponent<HealthControllerUI>().DestroyHearth();
        _healthText.text = "Health: " + _health.ToString();
    }
}
