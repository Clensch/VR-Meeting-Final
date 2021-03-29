using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSetting : MonoBehaviour
{
    public LayerMask layerMask;
    public GameObject panel;
    //Declare a LineRenderer to store the component attached to the GameObj.
    private LineRenderer rend;
    //Settings for the LineRenderer are stored as a Vaector3 array of points
    private Vector3[] points;
    //The maximum distance of the LineRenderer
    private readonly int rayDistance = 30;
    //The last selected button
    private Button lastBtn = null;
    //The initial colour of the last button
    private Color defaultBtnColor = new Color(0.22f, 0.18f, 0.18f);
    private Color highLightColor = new Color(0.25f, 0.25f, 0.25f);

    void Start()
    {
        //get the LineRenderer attached to the Gameobj.
        rend = gameObject.GetComponent<LineRenderer>();
        //initialize the LineRenderer
        points = new Vector3[2];
        //set the start point of the linerenderer to the position of the GameObj.
        points[0] = Vector3.zero;
        //set the end point 20 units away from the GO on the Z axis (pointing forward)
        points[1] = transform.position + new Vector3(0, 0, rayDistance);
        //set the positions array on the LineRenderer to the new value
        rend.SetPositions(points);
        rend.enabled = true;
    }

    private void Update()
    {
        if (AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0) 
        {
            lastBtn.onClick.Invoke();
        }
    }

    

    public bool AlignLineRenderer(LineRenderer rend)
    {
        Button btn;
        bool isHit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            btn = hit.collider.gameObject.GetComponent<Button>();
            lastBtn = btn;
            ChangeBtnColor(lastBtn, true);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            isHit = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, rayDistance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            isHit = false;
            if(lastBtn != null)
            {
                ChangeBtnColor(lastBtn, false);
            }
        }
        rend.material.color = rend.startColor;
        rend.SetPositions(points);
        return isHit;
    }
    private void ChangeBtnColor(Button btn, bool isHighlighted)
    {
        btn.GetComponent<Image>().color = isHighlighted ? highLightColor : defaultBtnColor;
    }
}

