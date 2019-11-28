using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailSetting : MonoBehaviour
{
    public TweenPosition mailboxTween;
    public TweenPosition mailOneTween;
    
    public 
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
}
