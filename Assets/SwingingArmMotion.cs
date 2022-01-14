using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingArmMotion : MonoBehaviour
{
    //GameObjects
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject CenterEyeCamera;
    public GameObject ForwardDirection;

    //Vector3 position
    private Vector3 PositionPreviousFrameLeftHand;
    private Vector3 PositionPreviousFrameRightHand;
    private Vector3 PlayerPositionPreviousFrame;
    private Vector3 PlayerPositionThisFrame;
    private Vector3 PositionThisFrameLeftHand;
    private Vector3 PositionThisFrameRightHand;

    //Speed
    public float Speed = 70;
    private float HandSpeed;
    public float MoveButtonTreshold = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Set original Previous frame position at start up
        PlayerPositionPreviousFrame = transform.position;
        PositionPreviousFrameLeftHand = LeftHand.transform.position;
        PositionPreviousFrameRightHand = RightHand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

             //Button pressed test
    
        //Get forward direction from the center eye camera and set it to the forward direction object
        float yRotation = CenterEyeCamera.transform.eulerAngles.y;
        ForwardDirection.transform.eulerAngles = new Vector3(0, yRotation, 0);

        //Get current position of hands
        PositionThisFrameLeftHand = LeftHand.transform.position;
        PositionThisFrameRightHand = RightHand.transform.position;
        //Position of Player
        PlayerPositionThisFrame = transform.position;

        //Get distance the hands and player moved since the last frame
        var playerDistanceMoved = Vector3.Distance(PlayerPositionThisFrame, PlayerPositionPreviousFrame);
        var leftHandDistanceMoved = Vector3.Distance(PositionPreviousFrameLeftHand, PositionThisFrameLeftHand);
        var rightHandDistanceMoved = Vector3.Distance(PositionPreviousFrameRightHand, PositionThisFrameRightHand);

        //Add them up to get the handspeed from the ser minus the movemetn of the player to neglegt the movement of the playerfrom the equation
        HandSpeed = ((leftHandDistanceMoved - playerDistanceMoved) + (rightHandDistanceMoved - playerDistanceMoved));

        if(Time.timeSinceLevelLoad > 1f){


                 if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) >= MoveButtonTreshold & OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) >= MoveButtonTreshold){
            Debug.Log("A button pressed");
             transform.position += ForwardDirection.transform.forward * HandSpeed * Speed * Time.deltaTime;
        }
        }
      

   

        //Set previous position of hands for the next frame
        PositionPreviousFrameLeftHand = PositionThisFrameLeftHand;
        PositionPreviousFrameRightHand = PositionThisFrameRightHand;
        //Set player position previous frame
        PlayerPositionPreviousFrame = PlayerPositionThisFrame;

    }
}
