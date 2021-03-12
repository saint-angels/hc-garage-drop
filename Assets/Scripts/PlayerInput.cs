using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Transform levelHolder = null;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            levelHolder.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.RightArrow))
        {

            levelHolder.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
//        var clampedRotation = Mathf.Clamp(levelHolder.eulerAngles.z, -45f, 45f);
 //       levelHolder.eulerAngles = new Vector3(levelHolder.eulerAngles.x, levelHolder.eulerAngles.y, clampedRotation);
    }
}
