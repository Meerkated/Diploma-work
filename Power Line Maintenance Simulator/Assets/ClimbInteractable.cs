using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        XRBaseInteractor interactor = args.interactor;
        base.OnSelectEntered(args);
        Debug.Log("INNNN");
        if (interactor is XRDirectInteractor)
        {
            Climber.climbingHand = interactor.GetComponent<ActionBasedController>();
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        XRBaseInteractor interactor = args.interactor;
        base.OnSelectExited(args);
        Debug.Log("OUTTTT");
        if (Climber.climbingHand && Climber.climbingHand.name == interactor.name)
        {
            Climber.climbingHand = null;
        }
    }
}