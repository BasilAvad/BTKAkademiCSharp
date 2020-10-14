using System;

namespace Attributes
{
    internal class ToTableAttribute : Attribute
    {
        private string v;

        public ToTableAttribute(string v)
        {
            this.v = v;
        }
    }
}