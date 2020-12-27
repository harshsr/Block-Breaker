using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementByMouse : MonoBehaviour
{
    [SerializeField] float mainCameraWidth;
    [SerializeField] float colliderHalfX;
    float requiredXPosition;
    float requiredYPosition;
    float fixedXBoundaryLeft;
    float fixedXBoundaryRight;
    

    void Start()
    {
        requiredYPosition = transform.position.y;
        fixedXBoundaryLeft = (mainCameraWidth / 2) - mainCameraWidth + colliderHalfX;
        fixedXBoundaryRight = mainCameraWidth - (mainCameraWidth / 2) - colliderHalfX;
    }

    // Update is called once per frame
    void Update()
    {
        requiredXPosition = ((Input.mousePosition.x/Screen.width)*mainCameraWidth)-(mainCameraWidth/2);

        /*
        if(requiredXPosition<fixedXBoundaryLeft)
        {
            requiredXPosition = fixedXBoundaryLeft;
        }
        else if(requiredXPosition > fixedXBoundaryRight)
        {
            requiredXPosition = fixedXBoundaryRight;
        }
        */

        requiredXPosition = Mathf.Clamp(requiredXPosition, fixedXBoundaryLeft, fixedXBoundaryRight);
        transform.position = new Vector2(requiredXPosition,requiredYPosition);
    }
}
