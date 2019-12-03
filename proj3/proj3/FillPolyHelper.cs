using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace proj3
{
    class FillPolyHelper
    {
        public static void FillPolygon(Action<int, int, double[,], double> SetColorFunc, List<Point> poly_list, double[,] filter, double filter_sum)
        {
            Point[] poly = new List<Point>(poly_list).ToArray();
            int[] idx = Enumerable.Range(0, poly.Length).ToArray();
            Array.Sort((Point[])poly.Clone(), idx, new YPointsComparer());
            int y_min = poly[idx[0]].Y, y_max = poly[idx[idx.Length - 1]].Y, next_idx = 0;
            List<EdgeBucket> AET = new List<EdgeBucket>();
            for (int curr_y = y_min; curr_y < y_max; curr_y++)
            {
                while (next_idx < poly.Length && poly[idx[next_idx]].Y == curr_y)
                {
                    int next_vertex = idx[next_idx] - 1 == -1 ? poly.Length - 1 : idx[next_idx] - 1;

                    //add or delete first edge from this vertex
                    if (poly[(idx[next_idx] + 1) % poly.Length].Y < curr_y)
                    {
                            EdgeBucket.DeleteEdgeFromAET(idx[next_idx], AET);
                    }
                    else if (poly[(idx[next_idx] + 1) % poly.Length].Y > curr_y)
                    {
                        AET.Add(new EdgeBucket(curr_y, poly[(idx[next_idx] + 1) % poly.Length].Y, poly[(idx[next_idx] + 1) % poly.Length].X - poly[idx[next_idx]].X,
                            poly[(idx[next_idx] + 1) % poly.Length].Y - poly[idx[next_idx]].Y, idx[next_idx], poly[idx[next_idx]].X));
                    }

                    //add or delete second edge from this vertex
                    if (poly[next_vertex].Y < curr_y)
                    {
                        EdgeBucket.DeleteEdgeFromAET(next_vertex, AET);
                    }
                    else if (poly[next_vertex].Y > curr_y)
                    {
                        AET.Add(new EdgeBucket(curr_y, poly[next_vertex].Y, poly[next_vertex].X - poly[idx[next_idx]].X,
                            poly[next_vertex].Y - poly[idx[next_idx]].Y, next_vertex, poly[idx[next_idx]].X)); ;
                    }
                    next_idx++;
                }
                AET.Sort(new XEdgesComparer());
                for (int i = 0; i < AET.Count; i += 2)
                {
                    int x = (int)Math.Round(AET[i].x) + 1;
                    while (x < (int)Math.Round(AET[i + 1].x))
                    {
                        SetColorFunc(x, curr_y, filter, filter_sum);
                        x++;
                    }
                    AET[i].IncrementX();
                    AET[i + 1].IncrementX();
                }
            }
        }
        public class YPointsComparer : IComparer<Point>
        {
            int IComparer<Point>.Compare(Point p1, Point p2)
            {
                if (p1.Y == p2.Y)
                    return 0;
                return p1.Y > p2.Y ? 1 : -1;
            }
        }
        public class XEdgesComparer : IComparer<EdgeBucket>
        {
            int IComparer<EdgeBucket>.Compare(EdgeBucket e1, EdgeBucket e2)
            {
                if (e1.x == e2.x)
                    return 0;
                return e1.x > e2.x ? 1 : -1;
            }
        }
        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
