using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("sampleScene");
    }
}
