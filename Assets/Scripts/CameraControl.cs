using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
        offset.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        //float y = Mathf.Clamp(player.transform.position.y + 2.5f, 0, 10);
        float y = player.transform.position.y + offset.y;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, -10),3*Time.deltaTime);
        
    }

    
}
