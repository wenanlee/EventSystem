using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour,IEventHandler {
    //public void HandlerEvent(EventData eventid)
    //{
    //    foreach (var item in eventid.args)
    //    {
    //        print(item);
    //    }
    //    print(eventid.args);
    //}

    public void HandlerEvent(EventBase eventid)
    {
        
    }

    private void Start()
    {
        EventManager.Instance.Registration(HandlerEvent,ColorSpace.Linear,ColorGamut.DolbyHDR);
        EventData.CreateEvent(ColorSpace.Linear, 12,13).Send();
    }
}
