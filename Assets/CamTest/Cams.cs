using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cams : MonoBehaviour
{
    [SerializeField] Image Cam1;
    [SerializeField] Image Cam2;

    [SerializeField] RawImage Cam1Image;
    [SerializeField] RawImage Cam2Image;

    WebCamTexture webCamTexture;
    WebCamTexture webCamTexture2;

    int Counter;

    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = new WebCamTexture();
        webCamTexture2 = new WebCamTexture();
        Cam1.GetComponent<Image>().material.mainTexture = webCamTexture;
        Cam2.GetComponent<Image>().material.mainTexture = webCamTexture2;
        webCamTexture.Play();
        Counter = 0;

        
    }

    public void TakePic()
    {
        StartCoroutine(SwitchCamera());
    }

    IEnumerator SwitchCamera()
    {
        if (Counter == 0)
        {
            Counter = 1;
            Cam2.gameObject.SetActive(true);
            Cam2Image.gameObject.SetActive(false);

            CaptureAndApplyTexture(webCamTexture, Cam1Image, Cam1);
            webCamTexture.Stop();
            yield return new WaitForEndOfFrame();
            webCamTexture2.Play();
        }
        else if (Counter == 1)
        {
            Counter = 2;
            CaptureAndApplyTexture(webCamTexture2, Cam2Image, Cam2);
            yield return new WaitForEndOfFrame();
            webCamTexture2.Stop();
        }
        else
        {
            Counter = 0;
            Cam1.gameObject.SetActive(true);
            Cam1Image.gameObject.SetActive(false);
            yield return new WaitForEndOfFrame();
            webCamTexture.Play();
        }        
    }

    public void CaptureAndApplyTexture(WebCamTexture texture, RawImage image, Image cam)
    {
        cam.gameObject.SetActive(false);
        image.gameObject.SetActive(true);

        Texture2D capturedTexture = new Texture2D(texture.width, texture.height);
        capturedTexture.SetPixels(texture.GetPixels());
        capturedTexture.Apply();

        image.texture = capturedTexture;
    }
}
