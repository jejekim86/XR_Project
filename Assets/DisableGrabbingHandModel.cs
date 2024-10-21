using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DisableGrabbingHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    private void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);

    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if(args.interactableObject.transform.tag == "Left Hand")
            leftHandModel.SetActive(false);
        else if (args.interactableObject.transform.tag == "Right Hand")
            rightHandModel.SetActive(false);
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactableObject.transform.tag == "Left Hand")
            leftHandModel.SetActive(true);
        else if (args.interactableObject.transform.tag == "Right Hand")
            rightHandModel.SetActive(true);

    }
}
