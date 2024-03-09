using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTest : MonoBehaviour
{
    [SerializeField] Image panel;

    [SerializeField] ColorPreset myPreset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        panel.color = myPreset.mainColor;
    }
}
