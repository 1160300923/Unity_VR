using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailSetting : MonoBehaviour
{
    public TweenPosition mailboxTween;
    public TweenPosition mailOneTween;
    public TweenPosition mailTwoTween;
    public TweenPosition mailThreeTween;
    public TweenPosition mailFourTween;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMailOneButtonClick()
    {
        mailboxTween.PlayForward();
        mailOneTween.PlayForward();
    }
    public void OnMailOneBackButtonClick()
    {
        mailboxTween.PlayReverse();
        mailOneTween.PlayReverse();
    }
    public void OnMailTwoButtonClick()
    {
        mailboxTween.PlayForward();
        mailTwoTween.PlayForward();
    }
    public void OnMailTwoBackButtonClick()
    {
        mailboxTween.PlayReverse();
        mailTwoTween.PlayReverse();
    }
    public void OnMailThreeButtonClick()
    {
        mailboxTween.PlayForward();
        mailThreeTween.PlayForward();
    }
    public void OnMailThreeBackButtonClick()
    {
        mailboxTween.PlayReverse();
        mailThreeTween.PlayReverse();
    }
    public void OnMailFourButtonClick()
    {
        mailboxTween.PlayForward();
        mailFourTween.PlayForward();
    }
    public void OnMailFourBackButtonClick()
    {
        mailboxTween.PlayReverse();
        mailFourTween.PlayReverse();
    }

}
