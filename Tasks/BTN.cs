using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class BTN
    {
        int val;
        BTN left;
        BTN right;

        public int Val { get => val; set => val = value; }
        public BTN Left { get => left; set => left = value; }
        public BTN Right { get => right; set => right = value; }

        public bool Equals(BTN other)
        {
            return Equals(this, other);
        }

        private static bool Equals(BTN left, BTN right)
        {
            if(left == null && right == null) { return true; }
            if(left == null) { return false; }
            if(right == null) { return false; }

            if(Object.ReferenceEquals(left, right)) { return true; }

            if(left.Val != right.Val) { return false; }

            if(!Equals(left.Left, right.Left)) { return false; }

            if(!Equals(left.Right, right.Right)) { return false; }

            return true;
        }
    }
}
