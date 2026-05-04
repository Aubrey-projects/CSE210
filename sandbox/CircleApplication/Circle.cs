class Circle
{
    public double _radius; // attribute

    public void SetRadius(double radius) // method (a function in a class)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }

    public double GetDiameter()
    {
        return _radius * 2;
    }
}