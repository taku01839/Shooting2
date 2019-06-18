using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    public Slider _slider;
    [SerializeField]
    private GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾発射
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
