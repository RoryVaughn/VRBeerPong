using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Events
{
    public static BeerPongEvent CupHit = new BeerPongEvent();
}

public class BeerPongEvent : UnityEvent
{
    
}
