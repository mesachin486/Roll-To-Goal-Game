using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenname : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(addname());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator addname()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);

    }
}
