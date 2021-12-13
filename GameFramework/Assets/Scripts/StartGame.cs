using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject EnemyObj;
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("BtnStart").GetComponent<Button>().onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            EnemyObj.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
