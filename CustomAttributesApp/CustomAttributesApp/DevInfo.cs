using System;

/**
 * DevInfo is a Custom Attribute wich will track the access
 * timing of the method. It will store this data into the 
 * CurrentTime string.
 * 
 */
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