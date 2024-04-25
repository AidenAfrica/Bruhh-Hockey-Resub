using UnityEngine;
using UnityEngine.EventSystems;
public class ScoringZone : MonoBehaviour
{
   

    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter(Collision collision)
    {
        Bally ball = collision.gameObject.GetComponent<Bally>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData (EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }

}