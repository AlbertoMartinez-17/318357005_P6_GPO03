using UnityEngine;
using UnityEngine.InputSystem;

public class Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(obj,transform.position, Quaternion.identity);
        }
    }
}
