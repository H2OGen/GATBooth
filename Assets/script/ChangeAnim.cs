using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnim : MonoBehaviour
{
    public Animator m_Animator;
    public string AnimName1;
    public GameObject Button;
    public GameObject NPCMale;
    void Start()
    {
       
        m_Animator = NPCMale.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Click()
    {
        if(m_Animator.GetBool("Salute") == false)
        {
            m_Animator.SetTrigger(AnimName1);
        }
       else if(m_Animator.GetBool("Salute") == true)
        {
            m_Animator.ResetTrigger(AnimName1);
        }
        //Button.SetActive(false);


    }
   
}
