﻿
namespace carvedrock.bl.Conventions.NamingConventions.PublicMembers
{
    public class ClimbingShoes
    {
        // Public properties
        public string? Name { get; set; }
        public bool Instock;

        // An event
        public event Action? EventCheckInventory;

        // Method
        public void StartCheckInventory()
        {
            // ...
        }
    }
}
