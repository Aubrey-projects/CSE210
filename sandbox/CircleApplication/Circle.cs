class Circle
{
    double _radius; // attribute

    public void SetRadius(double radius) // method (a function in a class)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}