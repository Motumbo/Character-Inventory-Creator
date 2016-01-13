using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Character_Inventory_Administrator.Items;

namespace Character_Inventory_Administrator.Inventario
{
    class InventarioModel
    {
        List<ItemModel> inventarioEquipado = new List<ItemModel>();
        List<ItemModel> inventarioVest = new List<ItemModel>();
        List<ItemModel> inventarioPouch = new List<ItemModel>();
        List<ItemModel> inventarioBackpack = new List<ItemModel>();
    }
}
