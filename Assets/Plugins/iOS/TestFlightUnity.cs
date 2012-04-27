using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TestFlightUnity {
	
#if UNITY_IPHONE && !UNITY_EDITOR
	[DllImport ("__Internal")]
	private static extern void TestFlight_TakeOff (string token);

	[DllImport ("__Internal")]
	private static extern void TestFlight_PassCheckpoint (string checkpoint);
#endif

	public static void TakeOff(string token)
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		TestFlight_TakeOff(token);
#endif
	}

	public static void PassCheckpoint(string checkpoint)
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		TestFlight_PassCheckpoint(checkpoint);
#endif
	}
}
