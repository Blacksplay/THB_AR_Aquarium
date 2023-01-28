using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickability : MonoBehaviour
{

    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    public GameObject Origin;

    [SerializeField]
    public GameObject panel;

    private ClickedObject clickedObject;

    private Infoscreen infos;

    private Vector2 touchposition = default;

    //sorgt dafür dass beim deaktivieren eines panels auch alles Children deaktiviert werden
    public void deactivatePanel()
    { 
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            var child = panel.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
        panel.SetActive(false);
    }

    //sorgt dafür dass beim aktivieren eines panels auch alles Children aktiviert werden
    public void activatePanel()
    {
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            var child = panel.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(true);
        }
        panel.SetActive(true);
    }


    // enthält die Funktion um mithilfe von Raycast Fische auszuwählen
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchposition = touch.position;

            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObj;
                if(Physics.Raycast(ray,out hitObj))
                {
                    clickedObject = hitObj.transform.GetComponent<ClickedObject>();
                    if(clickedObject != null)
                    {
                        panel.SetActive(true);
                        Origin.GetComponent<ClickedScreen>().clickedObject= clickedObject;
                    }

                    infos = hitObj.transform.GetComponent<Infoscreen>();
                    if (infos != null)
                    {
                        infos.Banner.SetActive(true);
                    }

                }
            }
        }
    }
}
