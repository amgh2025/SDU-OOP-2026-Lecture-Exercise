string PointGetColor (Point p) {
    return p.color;
}

void PointSetColor (Point p, string color) {
    p.color = color;
}

double PointDist (Point a, Point b) {
    return Math.Sqrt((a.x-b.x)*(a.x-b.x) + (a.y-b.y)*(a.y-b.y));
}

Point p0 = new Point{x=0, y=0, color="black"};
Point p1 = new Point{x=1, y=1, color="red"};
PointSetColor(p1, "blue");

Console.WriteLine("dist between p0 and p1 is "+PointDist(p0, p1));
Console.WriteLine("p1 is "+PointGetColor(p1));

class Point {
    public double x;
    public double y;
    public string color;
}
