using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;

public class TiltOnZoom : MonoBehaviour
{

    public AbstractMap abmap;

   

    // Update is called once per frame
    void Update()
    {
        /* ####### Ran into some issues, revisit later ####### */

        //Debug.Log(abmap.Zoom);
        //float angleDiff = 90 - ((abmap.Zoom - 12) * (abmap.Zoom - 12));
        //transform.eulerAngles = new Vector3(angleDiff, 0, 0);
    }
}
