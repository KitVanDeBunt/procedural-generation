using UnityEngine;
using System.Collections;

public class MiniMap : Util.Follow
{
    private Camera minimapCam;
    // Use this for initialization
    override public void Start()
    {
        base.Start();
        minimapCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.M))
        {
            minimapCam.enabled = !minimapCam.enabled;
        }
    }
}
