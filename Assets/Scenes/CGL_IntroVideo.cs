using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CGL_IntroVideo : MonoBehaviour
{
    public RawImage RI;
    public VideoPlayer VP;
    public Animator A;
    public float waitTime;

    void Start()
    {       
        StartCoroutine(PlayVideo());
        StartCoroutine(fadeout());
    }
    IEnumerator PlayVideo()
    {
        VP.Prepare();
        while(!VP.isPrepared)
        {
            yield return new WaitForSeconds(1f);
            break;
        }
       
        RI.texture = VP.texture;
        VP.Play();
    }
    IEnumerator fadeout()
    {
        yield return new WaitForSeconds(waitTime);
        A.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
