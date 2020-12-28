using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HarithmaSalesAppv2
{
    public class Functions
    {
        public List<Item> ItemList(int ItemID,string ItemName)
        {

            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                if (ItemID > 0)
                    return db.Items.Where(i => i.ItemID.Equals(ItemID)).ToList();
                else if (ItemName != "")
                    return db.Items.Where(i => i.ItemName.Contains(ItemName)).ToList();
                else
                    return db.Items.ToList();

            }
        }
    }
}
