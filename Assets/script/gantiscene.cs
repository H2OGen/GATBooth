using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gantiscene : MonoBehaviour
{
    public void chgscene(string namascene)
    {
        SceneManager.LoadScene(namascene);
    }
        

        
}
