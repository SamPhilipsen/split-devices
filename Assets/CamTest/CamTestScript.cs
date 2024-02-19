using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamTestScript : MonoBehaviour
{
    WebCamTexture webCamTexture;
    string path;
    RawImage rawImage;

    [SerializeField] bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        if (isPlaying)
        {
            webCamTexture.Play();
        }
    }

    public void Pauze()
    {
        if (webCamTexture.isPlaying)
        {
            webCamTexture.Stop();
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = webCamTexture;
            webCamTexture.Play();
        }
    }
}
