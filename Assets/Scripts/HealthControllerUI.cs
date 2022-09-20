using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControllerUI : MonoBehaviour
{
    //neuspjeli pokusaj
    //public GameObject[] _healthUI;
    public List<GameObject> _healthUIList;
    public GameObject _player;
    public GameObject _healthImage;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _player.GetComponent<PlayerController>()._health; i++) 
        {
            //_healthUI[i].SetActive(true);
            GameObject tempHealth = null;
            tempHealth.transform.parent = gameObject.transform;
            tempHealth = Instantiate(_healthImage, transform.position, Quaternion.identity);
            _healthUIList.Add(_healthImage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyHearth()
    {
        int i = _healthUIList.Count;
        _healthUIList[i].SetActive(false);
    }
}
