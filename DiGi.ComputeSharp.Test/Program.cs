// See https://aka.ms/new-console-template for more information

//using DiGi.ComputeSharp;
//using DiGi.ComputeSharp.Legacy.Classes;
//using DiGi.ComputeSharp.Legacy.Classes.Result;
//using DiGi.ComputeSharp.Legacy.Constans;
using DiGi.ComputeSharp;
using DiGi.ComputeSharp.Core;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using System;
using System.Collections.Generic;


#region LEGACY

//int threadsCount = 10;
//int itemsCount = 99;

//List<int> indexes = new List<int>();
//for(int i = 0; i< threadsCount; i++)
//{
//    int start = 0;
//    int end = 0;
//    if (threadsCount == -1)
//    {
//        start = 0;
//        end = itemsCount;
//    }
//    else
//    {
//        int length = (itemsCount / threadsCount) + 1;

//        int index = i;

//        start = index * length;
//        end = index * length + length;

//        for(int j = start; j < end; j++)
//        {
//            indexes.Add(j);
//        }
//    }
//}


//Line3 line = new Line3(new Point3(1, 10, 4), new Vector3(0, -1, 0));

//List<Line3> lines = new List<Line3>();
//for (int i = 0; i < 1000; i++)
//{
//    lines.Add(line);
//}

//List<Triangle3> triangles_Temp = 
//    [
//        new Triangle3(new Point3(0, 0, 0), new Point3(10, 0, 0), new Point3(0, 0, 10)),
//        new Triangle3(new Point3(0, 0, 0), new Point3(0, 0, 10), new Point3(10, 0, 10)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(0, 1, 10), new Point3(10, 1, 10)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(10, 1, 0), new Point3(0, 1, 10)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(0, 1, 10), new Point3(10, 1, 10)),
//        new Triangle3(new Point3(0, 0, 0), new Point3(0.5f, 0, 0), new Point3(0, 0, 0.5f)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(0, 1, 10), new Point3(10, 1, 10)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(10, 1, 0), new Point3(0, 1, 10)),
//        new Triangle3(new Point3(0, 1, 0), new Point3(0, 1, 10), new Point3(10, 1, 10)),
//        new Triangle3(new Point3(0, 0, 0), new Point3(0.5f, 0, 0), new Point3(0, 0, 0.5f)),
//    ];

//List<Triangle3> triangles = new List<Triangle3>();
//for(int i =0; i < 100000; i++)
//{
//    triangles.AddRange(triangles_Temp);
//}

//DateTime dateTime;
//TimeSpan timeSpan;

//List<LineIntersectionResult> lineIntersectionResults;

//dateTime = DateTime.Now;
//lineIntersectionResults = Create.LineIntersectionResults(line, triangles);
//timeSpan = DateTime.Now - dateTime;

//Console.WriteLine(string.Format("GPU intersection of 1 line and {0} triangles -> Time: {1}s", triangles.Count, timeSpan.TotalSeconds));

//dateTime = DateTime.Now;
//lineIntersectionResults = Create.LineIntersectionResults(lines, triangles);
//timeSpan = DateTime.Now - dateTime;

//Console.WriteLine(string.Format("GPU intersection of {0} lines and {1} triangles -> Time: {2}s", lines.Count, triangles.Count, timeSpan.TotalSeconds));

//dateTime = DateTime.Now;
//lineIntersectionResults = new List<LineIntersectionResult>();
//foreach (Triangle3 triangle in triangles)
//{
//    LineIntersectionResult lineIntersectionResult = Create.LineIntersectionResult(line, triangle, Tolerance.Distance);
//    if (lineIntersectionResult.IsNaN())
//    {
//        continue;
//    }

//    lineIntersectionResults.Add(lineIntersectionResult);
//}

//timeSpan = (DateTime.Now - dateTime);

//Console.WriteLine(string.Format("CPU intersection of 1 line and {0} triangles -> Time: {1}s", triangles.Count, timeSpan.TotalSeconds));

//dateTime = DateTime.Now;
//lineIntersectionResults = Enumerable.Repeat(new LineIntersectionResult(), lines.Count).ToList();

//Parallel.For(0, lines.Count, i => 
//{
//    float distance_Min = float.MaxValue;

//    foreach (Triangle3 triangle in triangles)
//    {
//        LineIntersectionResult lineIntersectionResult = Create.LineIntersectionResult(lines[i], triangle, Tolerance.Distance);
//        if (lineIntersectionResult.IsNaN())
//        {
//            continue;
//        }

//        if (lineIntersectionResult.Distance < distance_Min)
//        {
//            lineIntersectionResults[i] = lineIntersectionResult;
//        }
//    }
//});

//timeSpan = DateTime.Now - dateTime;

//Console.WriteLine(string.Format("CPU intersection of {0} lines and {1} triangles -> Time: {2}s", lines.Count, triangles.Count, timeSpan.TotalSeconds));

#endregion


Coordinate3 point3 = new Coordinate3();

bool isNaN = point3.IsNaN();

Coordinate3 point4 = new Coordinate3();


Line3 line_1 = new Line3(0, 0, 0, 10, 0, 0);
Line3 line_2 = new Line3(1, -1, 0, 1, 1, 0);


Line3Intersection line3Intersection = DiGi.ComputeSharp.Spatial.Create.Line3Intersection(line_1, line_2, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);


Coordinate3 coordinate3 = line3Intersection.Point_1;

IEnumerable<Line3Intersection> line3Intersections = DiGi.ComputeSharp.Spatial.Create.Line3Intersections(line_1, [line_2], DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

foreach (Line3Intersection line3Intersection_Temp in line3Intersections)
{
    IGeometry3[] geometries = line3Intersection_Temp.GetIntersectionGeometries();
    if(geometries != null && geometries.Length != 0)
    {
        foreach(IGeometry3 geometry3 in geometries)
        {
            Console.WriteLine(string.Format("{0}", geometry3.ToString()));
        }
    }
}

Console.WriteLine(string.Format("Finished: {0}", true ));








