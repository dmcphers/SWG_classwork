using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public interface IItemRestriction
    {
        AddItemStatus AddItem(Item itemToAdd, Container container);
    }
}
