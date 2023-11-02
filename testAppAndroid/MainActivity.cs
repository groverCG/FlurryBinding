using Android.Content;
using Com.Flurry.Android;
using FlurryNewBindingDroid;
using static Java.Util.Jar.Attributes;

namespace testAppAndroid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        //FlurryAgent.Init(this, "4BJF5YPQ86R3GJR23ZSH");
        //FlurryAgent.SetCaptureUncaughtExceptions(true);
        //FlurryAgent.SetLogEnabled(true);

        var flurry = new FlurryAgent.Builder();

        flurry.WithDataSaleOptOut(false);
        flurry.WithCaptureUncaughtExceptions(true);
        flurry.WithIncludeBackgroundSessionsInMetrics(true);


        flurry.Build(this, "4BJF5YPQ86R3GJR23ZSH");

        if (FlurryAgent.IsSessionActive)
            FlurryAgent.LogEvent("It works");
    }
}

//New FlurryAgent.Builder()
//       .WithLogEnabled(True)
//       .Build(This, "4BJF5YPQ86R3GJR23ZSH");