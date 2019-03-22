using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IDrawable
    {
    }
    public class Figure : IDrawable
    {
        public List<IDrawable> FiguresArray = new List<IDrawable>();
        protected int startX;
        protected int startY;
        public virtual void Draw()
        { }
        public void PutInArray()
        {
            FiguresArray.Add(this);
        }
    }
}
