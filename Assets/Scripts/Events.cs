using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Events
{
    public static BeerPongEvent CupHit = new BeerPongEvent();
    public static DestroyBallEvent CupH = new DestroyBallEvent(); 
}

public class BeerPongEvent : UnityEvent<Cup>
{
    
}

public class DestroyBallEvent : UnityEvent
{
    
}
