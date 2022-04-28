using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories{
    public class InMemItemsRepository{
        private readonly List<Item> items = new() {
            new Item{ Id = Guid.NewGuid(), Name = "Item 1", Price = 10, CreatedDate =  DateTimeOffset.UtcNow },
            new Item{ Id = Guid.NewGuid(), Name = "Sword ", Price = 18, CreatedDate =  DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Knife", Price = 20, CreatedDate =  DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems(){
            return items;
        }

        public Item GetItem(Guid id){
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        
    }
}