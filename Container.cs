namespace APBD_repo_2;

public class Container
{
    private double _weight; //of cargo in kg
    private double _height; //of cargo in cm
    private static double _containerWeight; // in kg 4k or 8k depending on size
    private double _depth; //of cargo in cm
    private string _serialNumber; //generated based on container type + number
    private double _maximumCapacity; //of the container in kg (30k or 60k)

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public double ContainerWeight
    {
        get => _containerWeight;
        set        {
            if (value == 4000 || value == 8000)
            {
                _containerWeight = value;
            }
            else
            {
                throw new ArgumentException("Maximum capacity of the container can be 4000 kg or 8000 kg. During creation of it choose 4000 or 8000 option.");
            }
        }
    }

    public double Depth
    {
        get => _depth;
        set => _depth = value;
    }

    public string SerialNumber
    {
        //overload this in derived classes
        get => _serialNumber;
        set => _serialNumber = value;
    }

    private double MaximumCapacity
    {
        get => _maximumCapacity;
        set
        {
            if (value == 30000 || value == 60000)
            {
                _maximumCapacity = value;
            }
            else
            {
                throw new ArgumentException("Maximum capacity of the container can be 30000 kg or 60000 kg. During creation of it choose 30000 or 60000 option.");
            }
        }
    }
    
    public Container(double weight, double height, double containerWeight, double depth, string serialNumber, double maximumCapacity)
    {
        Weight = weight;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaximumCapacity = maximumCapacity;
    }


    public void EmptyTheCargo()
    {
        
    }

    public void loadContainer(double weight)
    {
        Weight = weight;
        if (Weight > MaximumCapacity)
        {
            throw new OverfillException(
                "The cargo weight is bigger than the container maximum capacity. Please try to load less to the one container.");
        }
        else
        {
            
        }
    }
    
}

public class OverfillException : Exception
{
    public OverfillException(string s)
    {
        throw new Exception();
    }
}