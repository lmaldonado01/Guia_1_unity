using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObjet robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RotateLeft()
    {
        robot.tranform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    public void RotateRight()
    {
        robot.tranform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }

    public void TranslateUp()
    {
        robot.tranform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);
    }
    public void TranslateDown()
    {
        robot.tranform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);
    }
    public void TranslateLeft()
    {
        robot.tranform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);
    }
    public void TranslateRight()
    {
        robot.tranform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
    }

    public void Scale(float magnitud)
    {
        Vector3 changerscale = new Vector3(magnitud, magnitud, magnitud);
        robot.tranform.localScale += changerscale;
    }


}
