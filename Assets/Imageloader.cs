using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foto : MonoBehaviour
{
    public string url = "https://www.google.com/imgres?imgurl=http://socs.binus.ac.id/files/2018/07/logo_jollybee.png&imgrefurl=https://socs.binus.ac.id/&tbnid=mpDvdBuRKi5FWM&vet=12ahUKEwjYwp31qeD4AhXKHbcAHa1WB6kQMygDegUIARC_AQ..i&docid=74-p7prVcqKvFM&w=557&h=539&q=binus SOCS&client=opera-gx&ved=2ahUKEwjYwp31qeD4AhXKHbcAHa1WB6kQMygDegUIARC_AQ";
    public Renderer thisRenderer;

    // automatically called when game started
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine()); // execute the section independently

        // the following will be called even before the load finished
        thisRenderer.material.color = Color.red;
    }

    // this section will be run independently
    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("Loading ....");
        WWW wwwLoader = new WWW(url);   // create WWW object pointing to the url
        yield return wwwLoader;         // start loading whatever in that url ( delay happens here )

        Debug.Log("Loaded");
        thisRenderer.material.color = Color.white;              // set white
        thisRenderer.material.mainTexture = wwwLoader.texture;  // set loaded image
    }
}
