using System;

namespace SOLID.Models.OpenClosed
{
    public class Product
    {
        public string Name { get; }
        public Colors Color { get; }
        public Sizes Size { get; }

        public Product(string name, Colors color, Sizes size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name;
            Color = color;
            Size = size;
        }
    }
}