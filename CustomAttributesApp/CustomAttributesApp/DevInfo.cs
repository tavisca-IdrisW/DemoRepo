using System;

namespace CustomAttributesApp
{

    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class DevInfo : Attribute
    {
        private string CurTime;

        public DevInfo()
        {
            this.CurTime = DateTime.UtcNow.ToString();
        }

        public string CurrentTime
        {
            get
            {
                return CurTime;
            }
        }
    }
}