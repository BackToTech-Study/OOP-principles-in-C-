namespace InheritanceDemo.Device;

public abstract class CoreDevice : IEquatable<CoreDevice>
{
    private static double counter;
    private readonly string _id;
    
    public virtual string GetId()
    {
        return _id;
    }
    
    protected CoreDevice()
    {
        _id = GenerateId();
    }
    
    private string GenerateId()
    {
        var date = DateTime.Now.ToString("yyyyMMdd");
        var unique = Guid.NewGuid().ToString();
        counter += 1;
        return $"{date}-{unique}-{counter}";
    }
    
    public virtual bool Equals(CoreDevice? other)
    {
        return other is not null && (ReferenceEquals(this, other) || GetId() == other.GetId()); 
    }
    
    public override bool Equals(object? obj)
    {
        return obj is CoreDevice other && Equals(other);
    }
    
    public override int GetHashCode()
    {
        return GetId().GetHashCode();
    }
    
    public static bool operator ==(CoreDevice? left, CoreDevice? right)
    {
        return Equals(left, right);
    }
    
    public static bool operator !=(CoreDevice? left, CoreDevice? right)
    {
        return !Equals(left, right);
    }
    
    public abstract string GetDeviceType();

    public string GetWelcomeMessage()
    {
        return $"Welcome to the {GetDeviceType()} with ID {GetId()}";
    }
}