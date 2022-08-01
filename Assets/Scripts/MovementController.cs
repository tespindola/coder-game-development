using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 2;
    public float liveTime = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGame", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.localScale = new Vector3(transform.localScale.x  * 2f, transform.localScale.y * 2f, transform.localScale.z * 2f);
        }
    }

    void Move(){
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void DestroyGame(){
        Destroy(gameObject);
    }
}
