using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    //modyfikator prêdkoœci obrotu
    public float turnSpeed = 5f;

    //zakres obrotu kamery w stopniach
    public float turnAngle = 90;

    bool turningRight = !true;

  
    Transform cameraLens;
    void Start()
    {
        Transform cameraPosition = transform.Find("CameraPosition");
        cameraLens = cameraPosition.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9)*10-45, 0));

        CheckIfPlayerVisible();
    }

    void CheckIfPlayerVisible()
    {
        

}
