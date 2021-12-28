using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] private Transform rotatedObject;

    private TouchControls touchControls;
    private Coroutine rotateRoutine;

    //NOTE: Add rotated obj to parent and control them axises separetely for correct rotation:
    //EXAMPLE : Y_axis for object and X_Axis for them parent
    private float yRotation;
    private float xRotation;

    private void Awake()
    {
        touchControls = new TouchControls();
    }
    private void Start()
    {
        touchControls.TouchMap.PrimaryFingerTouch.started += _ => StartRotate();
        touchControls.TouchMap.PrimaryFingerTouch.canceled += _ => EndRotate();
    }

    private void OnEnable()
    {
        touchControls.Enable();
    }
    private void OnDisable()
    {
        touchControls.Disable();
    }
    private void StartRotate()
    {
        rotateRoutine = StartCoroutine(ProcessRotation());
    }
    private void EndRotate()
    {
        if (rotateRoutine != null)
        {
            StopCoroutine(rotateRoutine);
        }
    }
    private IEnumerator ProcessRotation()
    {
        while (true)
        {
            Vector2 delta = touchControls.TouchMap.PrimaryFingerDelta.ReadValue<Vector2>();
            if (delta.normalized.x < 0f)
            {
                yRotation += 100f * Time.deltaTime;
            }
            else if(delta.normalized.x > 0f)
            {
                yRotation -= 100f * Time.deltaTime;    
            }

            if (delta.normalized.y > 0f)
            {
                xRotation += 100f * Time.deltaTime;
            }
            else if (delta.normalized.y < 0f)
            {
                xRotation -= 100f * Time.deltaTime;
            }

            rotatedObject.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

            Debug.Log(delta);
            yield return null;
        }
    }
}
