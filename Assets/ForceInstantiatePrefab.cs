namespace VRTK.Examples.Archery
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;


    public class ForceInstantiatePrefab : MonoBehaviour
    {

        public GameObject arrowPrefab;
        public float spawnDelay = 1f;

        private float spawnDelayTimer = 0f;

        private void Start()
        {
            spawnDelayTimer = 0f;
        }

        public void OnTriggerStay(Collider collider)
        {
            VRTK_InteractGrab grabbingController = (collider.gameObject.GetComponent<VRTK_InteractGrab>() ? collider.gameObject.GetComponent<VRTK_InteractGrab>() : collider.gameObject.GetComponentInParent<VRTK_InteractGrab>());
            if (CanGrab(grabbingController) && Time.time >= spawnDelayTimer)
            {
                GameObject newArrow = Instantiate(arrowPrefab);
                newArrow.name = "ArrowClone";
                grabbingController.GetComponent<VRTK_InteractTouch>().ForceTouch(newArrow);
                grabbingController.AttemptGrab();
                spawnDelayTimer = Time.time + spawnDelay;
            }
        }

        private bool CanGrab(VRTK_InteractGrab grabbingController)
        {
            return (grabbingController && grabbingController.GetGrabbedObject() == null && grabbingController.IsGrabButtonPressed());
        }


    }
}