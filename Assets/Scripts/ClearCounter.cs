using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public void Interact()
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;
        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
