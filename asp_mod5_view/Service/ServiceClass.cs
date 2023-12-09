using System;
namespace razorSyntxWithDI.Service
{
	public class ServiceClass:iServiceInterface
	{
		public ServiceClass()
		{
		}

        public string GetString()
        {
            return "string from service";
        }
    }
}

