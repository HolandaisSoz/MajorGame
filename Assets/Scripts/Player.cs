using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gm;
    public WeaponManager WM;
    public List<string> dialogues;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            WM.CreateWeaponPrefab();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
    }
}
