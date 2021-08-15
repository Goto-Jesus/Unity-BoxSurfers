using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Target;
    public float SmoothSpeed;
    public Vector3 CompensatePosition;
    public Vector3 CompensateRotation;

    private Camera _cam;
    public int _fieldOfView = 60;

    private void Start()
    {
        _cam = this.GetComponent<Camera>();
    }

    private void Update()
    {
        MoveCam();
        RotateCam();
        SeTFieldOfView();
    }

    void MoveCam()
    {
        Vector3 FollowPosition = Target.localPosition + CompensatePosition;
        Vector3 SmoothFollowPosition = Vector3.Lerp(this.transform.position, FollowPosition, SmoothSpeed * Time.deltaTime);
        transform.position = SmoothFollowPosition;
    }

    private Vector3 smoothLookAt;
    void RotateCam()
    {
        transform.LookAt(smoothLookAt);
        smoothLookAt = Vector3.Lerp(smoothLookAt, Target.position + CompensateRotation, SmoothSpeed * Time.deltaTime);

    }

    void SeTFieldOfView()
    {
        _cam.fieldOfView = Mathf.Lerp(_cam.fieldOfView, _fieldOfView, Time.deltaTime);
    }

}
