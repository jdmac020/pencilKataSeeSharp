using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk
{
    public class Pencil
    {
        public void Write(string note, Paper paper)
        {
            paper.Content = note;
        }
    }
}
