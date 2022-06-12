using Opsive.UltimateInventorySystem.Core.AttributeSystem;
using Opsive.UltimateInventorySystem.Core.DataStructures;
using Opsive.UltimateInventorySystem.DropsAndPickups;
using Opsive.UltimateInventorySystem.ItemActions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class 1CustomItemAction : ItemAction
{
    [SerializeField] protected string m_AttributeName = "HealAmount";
    protected override bool CanInvokeInternal(ItemInfo itemInfo, ItemUser itemUser)
    {
        var _playerscript = itemUser.gameObject.GetCachedComponent<playerscript>();

        if (_playerscript == null)
        {
            return false;
        }

        if (itemInfo.Item.GetAttribute<Attribute<int>>(m_AttributeName) == null)
        {
            return false;
        }

        return false;
    }

    protected override void InvokeActionInternal(ItemInfo itemInfo, ItemUser itemUser)
    {
        var _playerscript = itemUser.gameObject.GetCachedComponent<playerscript>();
        _playerscript.Heal(itemInfo.Item.GetAttribute<Attribute<int>>(m_AttributeName).GetValue());
        itemInfo.Inventory.RemoveItem((1, itemInfo));
    }
}
