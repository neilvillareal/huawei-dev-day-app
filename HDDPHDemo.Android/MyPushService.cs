
using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Huawei.Hms.Support.Api.Push;

namespace HDDPHDemo.Droid
{
    [Service(Label = "MyPushService")]
    [IntentFilter(new String[] { "com.neilvillareal.hdd_ph_demo.MyPushService" })]
    public class MyPushService : PushReceiver
    {

        private static object objectLock = new object();


        public override void OnToken(Context p0, string p1)
        {
            base.OnToken(p0, p1);

            System.Diagnostics.Debug.WriteLine($"token received: {p1}");
        }

        public override void OnPushMsg(Context p0, byte[] p1, string p2)
        {
            base.OnPushMsg(p0, p1, p2);
            System.Diagnostics.Debug.WriteLine("log", $"Receive a push pass message with the message:{p2}");
        }


        private static void Callback(Intent intent)
        {
            lock (objectLock)
            {

            }
        }
    }

}
