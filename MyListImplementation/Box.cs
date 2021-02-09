namespace MyListImplementation
{
    internal class Box
    {
        public Box(object value, Box prev = null)
        {
            Value = value;
            Next = null;
            Prev = prev;
        }

        public object Value { get; set; }
        public Box Prev { get; set; }
        public Box Next { get; set; }
    }
}
