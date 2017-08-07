using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CameraController : MonoBehaviour
{

    private Vector3 v3Offset;
    [SerializeField]
    private GameObject goPlayer;

    private float RotateSpeed = 5.0F;

    private float yMinLimit = 0;
    private float yMaxLimit = 80;
    private float xDeg = 0f;
    private float yDeg = 0f;
    void Start ()
	{
	    Vector3 angles = transform.eulerAngles;
	    xDeg = angles.x;
	    yDeg = angles.y;
	    v3Offset = transform.position - goPlayer.transform.position;
	}
	
	
	void LateUpdate ()
	{
	    //if (!CurrientPlayer.IsInvenotryOpen())
	    //{
	        //xDeg += Input.GetAxis("Mouse X") * RotateSpeed;
	        //yDeg -= Input.GetAxis("Mouse Y") * RotateSpeed;

	        //yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);

	        //Quaternion qRotation = Quaternion.Euler(yDeg, xDeg, 0);
	        //Quaternion qPlayerRotation = Quaternion.Euler(0, xDeg, 0);

	        //float fScrolling = Input.GetAxis("Mouse ScrollWheel");
	        //v3Offset += v3Offset * fScrolling;

	        //transform.rotation = qRotation;
	        //goPlayer.transform.rotation = Quaternion.Slerp(goPlayer.transform.rotation, qPlayerRotation, Time.deltaTime * 1.5F);
	        //transform.position = goPlayer.transform.position - (qRotation * Vector3.forward * v3Offset.magnitude);
        //}
	}


    float ClampAngle(float angle,float min,float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }

}
