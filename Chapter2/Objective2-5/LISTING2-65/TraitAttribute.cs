using System;

namespace Chapter2
{
    public class TraitAttribute : Attribute
    {
        private string v;
        private string value;

        public TraitAttribute(string v, string value)
        {
            this.v = v;
            this.value = value;
        }
    }
}