class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Volume()
    {
        return length * width * height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * length * height + 2 * width * height;
    }

    public double SurfaceArea()
    {
        return 2 * length * width + 2 * length * height + 2 * width * height;
    }
}
