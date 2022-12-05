using UnityEngine;

public class UIController : MonoBehaviour
{
    // [HCFunction(nameof(ActivateFirstButton))]
    // public HCFunction ActivateFirstButtonSubscribe = new HCFunction();
    //
    // [HCFunction(nameof(ActivateSecondButton))]
    // public HCFunction ActivateSecondButtonSubscribe = new HCFunction();
    // public delegate void UIEvent();
    // public event UIEvent FirstActivateButtonPressed;
    // public event UIEvent SecondActivateButtonPressed;
    //
    // public GameObject FirstActivator;
    // public GameObject SecondActivator;
    //
    // private Animator blueAnimator;
    // private Animator redAnimator;
    //
    // private void Start()
    // {
    //     blueAnimator = FirstActivator.GetComponentInChildren<Animator>();
    //     redAnimator = SecondActivator.GetComponentInChildren<Animator>();
    //     ActivateButtons();
    // }
    //
    // [ActionFunction]
    // public void ActivateFirstButton(EventParams p)
    // {
    //     FirstActivateButtonPressed?.Invoke();
    //     blueAnimator.SetTrigger("Pressed");
    // }
    //
    // [ActionFunction]
    // public void ActivateSecondButton(EventParams p)
    // {
    //     SecondActivateButtonPressed?.Invoke();
    //     redAnimator.SetTrigger("Pressed");
    // }
    //
    // public void ButtonsDisable()
    // {
    //     blueAnimator.SetTrigger("Off");
    //     redAnimator.SetTrigger("Off");
    // }
    // public void ActivateButtons()
    // {
    //     blueAnimator.SetTrigger("On");
    //     redAnimator.SetTrigger("On");
    // }
}
