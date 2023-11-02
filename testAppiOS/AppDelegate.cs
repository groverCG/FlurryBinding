using FlurryAnalytics;
namespace testAppiOS;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();
		vc.View!.AddSubview (new UILabel (Window!.Frame) {
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = "Hello, iOS!",
			AutoresizingMask = UIViewAutoresizing.All,
		});
		Window.RootViewController = vc;


		//Flurry.Analytics.Portable.AnalyticsApi.LogEvent("UndoTimeOut");
		Flurry.LogEvent("something else");

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;

	}

    [Export("application:willFinishLaunchingWithOptions:")]
    public bool WillFinishLaunching(UIApplication application, NSDictionary launchOptions)
    {
		var builder = new FlurrySessionBuilder();
		builder.WithCrashReporting(true);
		builder.WithLogLevel(FlurryLogLevel.All);
		builder.WithIAPReportingEnabled(true);

		Flurry.StartSession("7YPPGHZVHZFT5647PM9Y", builder);
        //FlurryAgent.SetLogLevel(FlurryLogLevel.All);
        //FlurryAgent.SetEventLoggingEnabled(true);
        //FlurryAgent.SetDebugLogEnabled(true);
        //FlurryAgent.SetShowErrorInLogEnabled(true);
        //FlurryAgent.StartSession("7YPPGHZVHZFT5647PM9Y");
		return true;
    }
}

//let builder = FlurrySessionBuilder.init()
//   builder.build(crashReportingEnabled: true)
//   builder.build(logLevel: .all)
//Flurry.startSession("7YPPGHZVHZFT5647PM9Y", sessionBuilder: builder)