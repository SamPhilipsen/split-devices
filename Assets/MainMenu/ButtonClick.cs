using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public Button hidenseekButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = hidenseekButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick() 
    {        
        Debug.Log ("Click click click");
    }
}
