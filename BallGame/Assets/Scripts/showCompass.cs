using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showCompass : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public Animator anim;
    public Animator animFlecha;
    bool play=true;

    private void Awake()
    {
        anim.enabled=false;
        animFlecha.enabled = false;
    }
    private void Update()
    {
        SwipePc();
       
    }
    private void FixedUpdate()
    {
        if (!play && !isPlaying() && !isPlaying2())
        {
            anim.enabled = false;
            animFlecha.enabled = false;
            play = true;
        }
    }
    public void SwipePc()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();


            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && play)
            {
                anim.enabled = true;
                animFlecha.enabled = true;
                animFlecha.Play("flechaUp");
                anim.Play("ShowCompass");
                play = false;
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f&& play)
            {
                anim.enabled = true;
                animFlecha.enabled = true;
                animFlecha.Play("flechaDown");
                anim.Play("HideCompass");
                play = false;


            }
        }
    }
    
    bool isPlaying()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("ShowCompass") &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.9f)
            return true;
        else
            return false;
    }
    bool isPlaying2()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("HideCompass") &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.9f)
            return true;
        else
            return false;
    }
}
