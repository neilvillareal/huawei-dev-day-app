using System;
using HDDPHDemo.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(HDDPHDemo.Droid.Services.PushService))]
namespace HDDPHDemo.Droid.Services
{
    public class PushService : IPushService
    {
        public PushService()
        {
        }

        public void GetToken()
        {
            
        }
    }
}
