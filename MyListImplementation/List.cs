namespace MyListImplementation
{
    public class List
    {
        private Box _head;
        private Box _tail;
        private Box _current;
        private Box _prev;
        private int _count;

        public List()
        {
            _head = null;
            _tail = null;
            _prev = null;
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
                return _current.Value;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                return false;
            }

            _current = _current.Next;

            if (_current == null)
            {
                _current = _head;
                return false;
            }
            return true;
        }

        public void Add(object value)
        {
            Box box = new Box(value, _tail);

            if (_head == null && _tail == null)
            {
                _head = box;
                _current = box;
                _tail = box;
                _prev = box;
            }
            else
            {
                _tail.Next = box;
                 _tail = box;
            }

            _count++;
        }

        public bool Remove()
        {
            // реализовать логику удаления из листа
            if (_count > 0)
            {
                _count--;
                /* if i have next, i make next as current*/
                if (_current.Next != null)
                {
                    _current.Value = _current.Next.Value;
                    _current.Next.Prev = _current.Prev;
                    _current.Next = _current.Next.Next;

                }/* if i have prev, i remove from prev link to current and change pointer for head*/
                else if(_current.Prev != null)
                {
                    _tail = _current.Prev;
                    _current = _head;
                    _current.Next = null;

                }/* if i don't have anymore, i'l remove link everywhere*/
                else
                {
                    _head = null;
                    _current = null;
                    _prev = null;
                    _tail = null;
                }
                return true;
            }
            return false;
            

        }
    }
}
