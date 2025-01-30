using StronglyTypedIds;

namespace MyData;

[StronglyTypedId(Template.Int)]
public partial struct RegionId
{

    public static RegionId operator ++(RegionId other)
    {
        return new(other.Value + 1);
    }
    public static RegionId operator +(RegionId left, RegionId right)
    {
        return new RegionId(left.Value + right.Value);
    }
    public static RegionId operator -(RegionId left, RegionId right)
    {
        return new RegionId(left.Value - right.Value);
    }
    public static RegionId operator +(RegionId left, int right)
    {
        return new RegionId(left.Value + right);
    }
    public static RegionId operator -(RegionId left, int right)
    {
        return new RegionId(left.Value - right);
    }

    public static RegionId operator +(int left, RegionId right)
    {
        return new RegionId(left + right.Value);
    }
    public static RegionId operator -(int left, RegionId right)
    {
        return new RegionId(left - right.Value);
    }

}
