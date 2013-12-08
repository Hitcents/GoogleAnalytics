using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGoogleAnalyticsServices.a", 
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
	LinkerFlags = "-lz",
	Frameworks = "CoreData SystemConfiguration",
	WeakFrameworks = "AdSupport",
	ForceLoad = true)]
