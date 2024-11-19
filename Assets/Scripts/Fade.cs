using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    void Start()
    {
        Invoke("FadeOut", 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeOut()
    {
        animator.Play("FadeOut");
    }
    public void FadeIn()
    {
        animator.Play("Fadein");
    }
    public void Fadelife()
    {
        animator.Play("Fadelife");
    }
    public void FadeM()
    {
        animator.Play("FadeM");
    }
    public void Fadecoin()
    {
        animator.Play("Fadecoin");
    }
}
