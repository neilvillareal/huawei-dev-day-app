using System;
using HDDPHDemo.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(HDDPHDemo.Droid.Services.CoreSafetyDetect))]
namespace HDDPHDemo.Droid.Services
{


    public class CoreSafetyDetect : ICoreSafetyDetect
    {
        
        public void InvokeSysIntegrity()
        {

            
        }
    }
}
