using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject weaponPrefab;
    public Transform weaponCreateTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateWeaponPrefab()
    {
        Instantiate(weaponPrefab, weaponCreateTransform.position + new Vector3(0,0.5f,0),Quaternion.identity,weaponCreateTransform);
    }
}
