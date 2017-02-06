﻿using System;
using System.Collections.Generic;

namespace App2
{
    public class SketchStroke
    {
        #region initializers

        public SketchStroke()
        {
            points = new List<SketchPoint>();
            timeStamp = new List<long>();
        }

        public SketchStroke(List<SketchPoint> ps, List<long> ts)
        {
            points = ps;
            timeStamp = ts;
        }

        #endregion

        #region modifiers

        public void AppendPoint(SketchPoint p)
        {
            points.Add(p);
        }

        public void AppendTime(long t)
        {
            timeStamp.Add(t);
        }

        #endregion

        #region static methods

        public static SketchStroke Reverse(SketchStroke sketchStroke)
        {
            List<SketchPoint> reversedPoints = new List<SketchPoint>();
            for (int i = sketchStroke.Points.Count - 1; i >= 0; i--) reversedPoints.Add(sketchStroke.Points[i]);
            return new App2.SketchStroke(reversedPoints, sketchStroke.TimeStamp);
        }

        #endregion

        #region properties

        public int PointsCount { get { return points.Count; } }
        public List<SketchPoint> Points { get { return points; } }
        public SketchPoint StartPoint { get { return points[0]; } }
        public SketchPoint EndPoint { get { return points[Points.Count - 1]; } }
        public List<long> TimeStamp { get { return timeStamp; } set { timeStamp = value; } }

        #endregion

        #region fields

        private List<SketchPoint> points;
        private List<long> timeStamp;

        #endregion
    }
}