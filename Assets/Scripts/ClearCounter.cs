using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        // There is not kitchenObject here.
        {
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {

            }
        }
        // There is a kitchenObject here.
        else
        {
            if (player.HasKitchenObject())
            {

            }
            else
            // Player is not carrying anything.
            {
                kitchenObject.SetKitchenObjectParent(player);
            }
        }
    }
}
