using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum playOptions
{
    FlyOver,
    Walk,
    Plane
}

public class Menu : MonoBehaviour
{
    [SerializeField]
    private Util.Follow[] follows;

    [SerializeField]
    private DynamicTerain terain;

    [SerializeField]
    private bool shadows;

    [SerializeField]
    private Light myLight;

    [SerializeField]
    private Toggle lightToggle;

    [SerializeField]
    private Transform buttonContainer;

    [SerializeField]
    private RTSCam flyOverCamera;

    [SerializeField]
    private Transform walkTarget;

    [SerializeField]
    private Transform PlaneTarget;

    private string FlyOverInstroctions = "T : RESTART\n Y: TOGGLE UI\nM: MINIMAP \nW,A,S,D,R & F : MOVE\nRIGHT MOUSE BUTTON: LOOK ARROUND";

    [SerializeField]
    private Text instructionsText;

    [SerializeField]
    private Transform uiContainer;

    void Start()
    {
        if (shadows)
        {
            myLight.shadows = LightShadows.Soft;
            lightToggle.isOn = true;
        }
        else
        {
            myLight.shadows = LightShadows.None;
            lightToggle.isOn = false;
        }
    }

    public void PlayWalk()
    {
        PlayButton(playOptions.Walk);
    }
    public void PlayPlane()
    {
        PlayButton(playOptions.Plane);
    }
    public void PlayFlyOver()
    {
        PlayButton(playOptions.FlyOver);
    }

    /// <summary>
    /// Start One of the 3 play modes
    /// </summary>
    /// <param name="option"></param>
    private void PlayButton(playOptions option)
    {
        buttonContainer.gameObject.SetActive(false);
        Transform target;
        if (option == playOptions.FlyOver)
        {
            flyOverCamera.enabled = true;
            target = flyOverCamera.transform;
            instructionsText.text = FlyOverInstroctions;
        }
        else if (option == playOptions.Walk)
        {
            flyOverCamera.gameObject.SetActive(false);
            walkTarget.parent.gameObject.SetActive(true);
            target = walkTarget;
        }
        else
        {
            flyOverCamera.gameObject.SetActive(false);
            PlaneTarget.parent.parent.gameObject.SetActive(true);
            target = PlaneTarget;
        }

        foreach (Util.Follow follow in follows)
        {
            follow.Target = target;    
        }

        terain.Target = target;
    }

    void Update()
    {
        if (lightToggle.isOn != shadows)
        {
            shadows = !shadows;
            Start();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            uiContainer.gameObject.SetActive(!uiContainer.gameObject.activeSelf);
        }
    }
}
