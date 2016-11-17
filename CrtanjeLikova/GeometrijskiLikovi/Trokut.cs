﻿using CrtanjeLikova.GeometrijskiLikovi;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrtanjeLikova
{
    class Trokut : GeometrijskiLik
    {
        float x1, x2, x3, y1, y2, y3;
        public Trokut(float x1, float y1, float x2, float y2, float x3, float y4) {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;

        }

        public override void Nacrtaj(System.Drawing.Graphics g)
        {

            using (Pen pero = new Pen(Color.Green)) {

                g.DrawLines(pero, new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x3, y3) }
                );
            }
 
        }

    }
}
