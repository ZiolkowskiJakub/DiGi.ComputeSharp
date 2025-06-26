// See https://aka.ms/new-console-template for more information

//using DiGi.ComputeSharp;
//using DiGi.ComputeSharp.Legacy.Classes;
//using DiGi.ComputeSharp.Legacy.Classes.Result;
//using DiGi.ComputeSharp.Legacy.Constans;
using ComputeSharp;
using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Classes;


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
//    double distance_Min = double.MaxValue;

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


//Line3 line_1 = new Line3(0, 0, 0, 10, 0, 0);
//Line3 line_2 = new Line3(1, -1, 0, 1, 1, 0);


//Line3Intersection line3Intersection = DiGi.ComputeSharp.Spatial.Create.Line3Intersection(line_1, line_2, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);


//Coordinate3 coordinate3 = line3Intersection.Point_1;

//IEnumerable<Line3Intersection> line3Intersections = DiGi.ComputeSharp.Spatial.Create.Line3Intersections(line_1, [line_2], DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

//foreach (Line3Intersection line3Intersection_Temp in line3Intersections)
//{
//    IGeometry3[] geometries = line3Intersection_Temp.GetIntersectionGeometries();
//    if(geometries != null && geometries.Length != 0)
//    {
//        foreach(IGeometry3 geometry3 in geometries)
//        {
//            Console.WriteLine(string.Format("{0}", geometry3.ToString()));
//        }
//    }
//}

//Triangle3 triangle3_1;
//Triangle3 triangle3_2;
//Triangle3Intersection triangle3Intersection;

//triangle3_1 = new Triangle3(true, 2, 2, 0, 2, 8, 0, 8, 2, 0);
//triangle3_2 = new Triangle3(true, 4, 4, 0, 4, 9, 0, 9, 4, 0);
//triangle3Intersection = DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(triangle3_1, triangle3_2, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

//triangle3_1 = new Triangle3(true, 2, 2, 0, 2, 8, 0, 8, 2, 0);
//triangle3_2 = new Triangle3(true, 5, 5, 0, 4, 9, 0, 9, 4, 0);
//triangle3Intersection = DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(triangle3_1, triangle3_2, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

//triangle3_1 = new Triangle3(true, 1, 1, 0, 1, 6, 0, 6, 1, 0);
//triangle3_2 = new Triangle3(true, 0, 5, 0, 5, 0, 0, 5, 5, 0);
//triangle3Intersection = DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(triangle3_1, triangle3_2, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);


//Triangle3 triangle3 = new Triangle3(new Bool(true), 0, 0, 0, 0, 10, 0, 10, 0, 0);
//Line3 line3 = new Line3(4, 4, 0, 11, 11, 0);

//Triangulation3 triangulation3 = DiGi.ComputeSharp.Spatial.Create.Triangulation3(triangle3, line3, DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

Triangle3 triangle3_1 = new Triangle3(new DiGi.ComputeSharp.Core.Classes.Bool(true), -1, -1, 0, 10, 10, 0, 10, -10, 0);
Triangle3 triangle3_2 = new Triangle3(new DiGi.ComputeSharp.Core.Classes.Bool(true), -1, -1, 1, 10, 10, 1, 10, -10, 1);
Triangle3 triangle3_3 = new Triangle3(new DiGi.ComputeSharp.Core.Classes.Bool(true), -1, -1, 0, 10, 10, 0, 10, -10, 0);
Line3 line3_1 = new Line3(0, 0, 0, 20, 0, 0);
Line3 line3_2 = new Line3(0, 0, 1, 20, 0, 1);
Line3 line3_3 = new Line3(0, 0, 2, 20, 0, 2);

List<bool> intersects = DiGi.ComputeSharp.Spatial.Query.Intersect([line3_2, line3_1, line3_3], [triangle3_1, triangle3_2, triangle3_3], DiGi.ComputeSharp.Core.Constans.Tolerance.Distance);

Console.WriteLine(string.Format("Finished: {0}", true ));








