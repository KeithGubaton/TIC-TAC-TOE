using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class T_Class
    {
        private bool next = true;
        private int next_c = 0;

        public bool Next
        {
            get => next;
            set => next = value;
        }
        public int Next_c
        {
            get => next_c;
            set => next_c = value;
        }
    }
}
