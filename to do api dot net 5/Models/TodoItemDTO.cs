using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_api_dot_net_5.Models
{
    // added this new class for the TodoItemDTO - used to hide the secret field
    // DTO = the subset of a model is usually referred to as a DTO, aka Data Transfer Object (aka VIEW MODEL or INPUT MODEL).
    // DID NOT end up implementing the DTO in the ToDoItemsController.

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

