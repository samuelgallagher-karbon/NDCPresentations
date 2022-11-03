namespace NewCSharpFeatures
{
    public enum EntityLinkType
    {
        UserProfile,
        Organization,
        ClientGroup,
        WorkItem
    }

    public class Address
    {
        public int StreetNumber;
        public string StreetName;
    }

    public class SwitchExpressions
    {

        private int SwitchStatement()
        {
            var type = EntityLinkType.UserProfile;

            switch (type)
            {
                case EntityLinkType.UserProfile:
                    return 1;
                case EntityLinkType.Organization:
                    return 2;
                case EntityLinkType.ClientGroup:
                    return 3;
                case EntityLinkType.WorkItem:
                    return 4;
                default:
                    return 5;
            }
        }

        private int SwitchExpression()
        {
            var type = EntityLinkType.UserProfile;

            return type switch
            {
                EntityLinkType.UserProfile  => 1,
                EntityLinkType.Organization => 2,
                EntityLinkType.ClientGroup  => 3,
                EntityLinkType.WorkItem     => 4,
                _                           => 5,
            };
        }

        private int ComplexSwitchExpression()
        {
            var type = EntityLinkType.UserProfile;
            var isValid = false;

            return (type, isValid) switch
            {
                (EntityLinkType.UserProfile, false)     => 1,
                (EntityLinkType.UserProfile, true)      => throw new ArgumentException(),
                (EntityLinkType.Organization, false)    => 2,
                (EntityLinkType.Organization, true)     => throw new ArgumentException(),
                _                                       => 5,
            };
        }

        private int SwitchingOnProperties()
        {
            var place = new Address
            {
                StreetName = "Fake St",
                StreetNumber = 123
            };

            return place switch
            {
                { StreetName: "Dodgy St" }                  => 1,
                { StreetNumber: 400 }                       => 2,
                { StreetName: "Fake St", StreetNumber: 123} => 10,
                _                                           => throw new ArgumentException(),
            };
        }

    }
}
