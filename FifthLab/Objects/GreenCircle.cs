using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLab.Objects
{
    class GreenCircle : BaseObject
    {
        //Конструктор
        public GreenCircle(float x, float y, float angle) : base(x, y, angle) { }

        //Отрисовка объекта
        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Green), -15, -15, 30, 30);
        }

        //Получение пути к объекту
        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }
    }
}
