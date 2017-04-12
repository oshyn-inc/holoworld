
// Copyright (c) Oshyn Inc. All rights reserved.
// For more information please visit http://www.oshyn.com/Services/holographic

using System;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class InputListener : MonoBehaviour, IFocusable, ISourceStateHandler, IInputHandler, IInputClickHandler, IHoldHandler, IManipulationHandler, INavigationHandler
{
    public void OnFocusEnter()
    {
        var eventName = "OnFocusEnter";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnFocusExit()
    {
        var eventName = "OnFocusExit";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnSourceDetected(SourceStateEventData eventData)
    {
        var eventName = "OnSourceDetected";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnSourceLost(SourceStateEventData eventData)
    {
        var eventName = "OnSourceLost";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnInputDown(InputEventData eventData)
    {
        var eventName = "OnInputDown";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnInputUp(InputEventData eventData)
    {
        var eventName = "OnInputUp";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        var eventName = "OnInputClicked";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnHoldStarted(HoldEventData eventData)
    {
        var eventName = "OnHoldStarted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnHoldCompleted(HoldEventData eventData)
    {
        var eventName = "OnHoldCompleted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnHoldCanceled(HoldEventData eventData)
    {
        var eventName = "OnHoldCanceled";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        var eventName = "OnManipulationStarted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        var eventName = "OnManipulationUpdated";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        var eventName = "OnManipulationCompleted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        var eventName = "OnManipulationCanceled";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnNavigationStarted(NavigationEventData eventData)
    {
        var eventName = "OnNavigationStarted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnNavigationUpdated(NavigationEventData eventData)
    {
        var eventName = "OnNavigationUpdated";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnNavigationCompleted(NavigationEventData eventData)
    {
        var eventName = "OnNavigationCompleted";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
    public void OnNavigationCanceled(NavigationEventData eventData)
    {
        var eventName = "OnNavigationCanceled";
        Debug.Log(string.Format("{0}:Triggered {1}", gameObject.name, eventName));
    }
}