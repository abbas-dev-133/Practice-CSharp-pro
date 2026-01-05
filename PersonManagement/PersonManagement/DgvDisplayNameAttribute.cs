using System;

namespace PersonManagement
{
    internal class DgvDisplayNameAttribute : Attribute
    {
        public string DisplayName { get; }
        public DgvDisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
