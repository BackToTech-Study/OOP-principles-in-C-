namespace InheritanceDemo.Device;

public class SmartTag : CoreDevice
{
    public string value;
    private string _tagId;
    
    public SmartTag(string value, string? id = null) 
        : base()
    {
        this.value = value;
        _tagId = id ?? string.Empty;
    }
    
    public override string GetId()
    {
        if (string.IsNullOrEmpty(_tagId))
        {
            _tagId = $"ST-{base.GetId()}";
        }
        return _tagId;
    }
    
    public string GetUniqueId()
    {
        return base.GetId();
    }

    public override string GetDeviceType()
    {
        return "SmartTag";
    }
    
    public override bool Equals(CoreDevice? other)
    {
        return other is not null && (ReferenceEquals(this, other) || GetId() == other.GetId()); 
    }
    
    public SmartTag Clone()
    {
        return new SmartTag(value, GetId());
    }
    
    public new string GetWelcomeMessage()
    {
        return $"Welcome to the {GetDeviceType()} with ID: {GetId()} and unique ID: {GetUniqueId()}";
    }
}