using UnityEngine;
using System.Collections;

public class TouchHandler : MonoBehaviour {

    public bool leftTouch;
    public bool rightTouch;
    public bool upTouch;
    public bool downTouch;

    void Start()
    {
        leftTouch = false;
        rightTouch = false;
        upTouch = false;
        downTouch = false;
    }

    // LEFT TOUCH AREA //
    public void LeftTrue()
    {
        leftTouch = true;
    }

    public void LeftFalse()
    {
        leftTouch = false;
    }

    // RIGHT TOUCH AREA //
    public void RightTrue()
    {
        rightTouch = true;
    }
    public void RightFalse()
    {
        rightTouch = false;
    }

    // UP TOUCH AREA //

    public void UpTrue()
    {
        upTouch = true;
    }
    public void UpFalse()
    {
        upTouch = false;
    }

    //DOWN TOUCH AREA//

    public void DownTrue()
    {
        downTouch = true;
    }
    public void DownFalse()
    {
        downTouch = false;
    }

}
