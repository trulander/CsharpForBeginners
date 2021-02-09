namespace MyListImplementation
{
    public class Queue
    {
        private Box _head;
        private Box _tail;
        private int _count;

        public Queue()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public object Current
        {
            get
            {
                return _head.Value;
            }
        }

        public bool MoveNext()
        {
            if (_head == null)
            {
                return false;
            }

            _head = _head.Next;

            return _head != null;
        }

        public void Enqueue(object value)
        {
            Box box = new Box(value);

            if (_head == null && _tail == null)
            {
                _head = box;
                _tail = box;
            }
            else
            {
                _tail.Next = box;
                _tail = box;
            }

            _count++;
        }

        public object Dequeue()
        {
            // сделать так, чтобы хвост не оставался.
            if (_head == null)
                return 0;

            if (_tail == _head)
            {
                _tail = null;
            }

            object value = _head.Value;
            _head = _head.Next;
            _count--;

            return value;
        }
    }
}
