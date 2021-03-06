using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLab.Objects
{
    class Player : BaseObject
    {
        public Action<Marker>? OnMarkerOverlap;
        public Action<GreenCircle>? OnGreenCircleOverlap;
        public float vX, vY;
        public int Score = 0;

        //Конструктор
        public Player(float x, float y, float angle) : base(x, y, angle) { }

        //Отрисовка объекта
        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Cyan), -15, -15, 30, 30);
            g.DrawEllipse(new Pen(Color.Black, 2), -15, -15, 30, 30);
            g.DrawLine(new Pen(Color.Black, 2), 0, 0, 25, 0);
        }

        //Получение пути объекту
        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }

        //Пересечение с объектами
        public override void Overlap(BaseObject obj)
        {
            base.Overlap(obj);

            if (obj is Marker)
            {
                OnMarkerOverlap?.Invoke((Marker)obj);
            }
            if (obj is GreenCircle)
            {
                OnGreenCircleOverlap?.Invoke((GreenCircle)obj);
            }
        }
    }
}
