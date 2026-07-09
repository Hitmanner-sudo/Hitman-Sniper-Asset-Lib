using System;
using Il2CppDummyDll;
using Technology;
using Technology.Core.ServiceOperations;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x200022D")]
[Scope]
public class CrashHandler : GameSingleton<CrashHandler>
{
	[Token(Token = "0x200022E")]
	private enum LastApplicationStatus
	{
		[Token(Token = "0x4000C40")]
		Started = 0,
		[Token(Token = "0x4000C41")]
		Quit = 1
	}

	[Token(Token = "0x200022F")]
	public class HandleUnityExceptionsEventArgs : EventArgs
	{
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x10")]
		public string Message;

		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x18")]
		public string StackTrace;

		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x20")]
		public LogType Type;

		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x865008", Offset = "0x865008", VA = "0x865008")]
		public HandleUnityExceptionsEventArgs()
		{
		}
	}

	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x48")]
	private string _fullFilePath;

	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x50")]
	private int _reportedAmount;

	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x58")]
	private string _loadedSceneName;

	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x60")]
	private string _installationID;

	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x68")]
	private string _deviceModel;

	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x70")]
	private string _gpuDeviceName;

	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x78")]
	private string _os;

	[Token(Token = "0x4000C38")]
	private const string SAVE_FILE = "/ANALYTICS_CRASH_DATA.txt";

	[Token(Token = "0x4000C39")]
	private const string NODE_NAME = "Error";

	[Token(Token = "0x4000C3A")]
	private const int MAX_LOG_TO_REPORT = 3;

	[Token(Token = "0x4000C3B")]
	private const int MAX_REPORTED_AMOUNT = 1;

	[Token(Token = "0x4000C3C")]
	private const string LAST_APPLICATION_STATUS = "CrashHandler: Last Application Status";

	[Token(Token = "0x14000028")]
	public static event EventHandler<HandleUnityExceptionsEventArgs> OnHandleUnityExceptions
	{
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0xD80D18", Offset = "0xD80D18", VA = "0xD80D18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614724", Offset = "0x614724")]
		add
		{
		}
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0xD80DD4", Offset = "0xD80DD4", VA = "0xD80DD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614734", Offset = "0x614734")]
		remove
		{
		}
	}

	[Token(Token = "0x14000029")]
	public static event EventHandler<UnhandledExceptionEventArgs> OnUnhandledException
	{
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0xD80E90", Offset = "0xD80E90", VA = "0xD80E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614744", Offset = "0x614744")]
		add
		{
		}
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0xD80F50", Offset = "0xD80F50", VA = "0xD80F50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614754", Offset = "0x614754")]
		remove
		{
		}
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0xD81010", Offset = "0xD81010", VA = "0xD81010", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0xD81210", Offset = "0xD81210", VA = "0xD81210")]
	private static void AddAsFirstHandler(UnhandledExceptionEventHandler handler)
	{
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0xD81370", Offset = "0xD81370", VA = "0xD81370", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0xD8149C", Offset = "0xD8149C", VA = "0xD8149C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0xD814CC", Offset = "0xD814CC", VA = "0xD814CC")]
	private static void UpdateLastApplicationStatus()
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0xD816F8", Offset = "0xD816F8", VA = "0xD816F8")]
	private void UnhandledException(object sender, UnhandledExceptionEventArgs args)
	{
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0xD818E0", Offset = "0xD818E0", VA = "0xD818E0")]
	private void OnLogMessageReceived(string message, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0xD81A58", Offset = "0xD81A58", VA = "0xD81A58")]
	protected void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0xD81A8C", Offset = "0xD81A8C", VA = "0xD81A8C", Slot = "15")]
	protected override void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000D01")]
	[Address(RVA = "0xD818B8", Offset = "0xD818B8", VA = "0xD818B8")]
	private void OnCrash(string message, string stackTrace, LogType type, bool unityHandledError)
	{
	}

	[Token(Token = "0x6000D02")]
	[Address(RVA = "0xD81CF0", Offset = "0xD81CF0", VA = "0xD81CF0")]
	public void CreateCrashReport(string message)
	{
	}

	[Token(Token = "0x6000D03")]
	[Address(RVA = "0xD81B04", Offset = "0xD81B04", VA = "0xD81B04")]
	private void CreateCrashReport(string message, string stackTrace, bool unityHandledError)
	{
	}

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0xD81518", Offset = "0xD81518", VA = "0xD81518")]
	private void ReportAnalyticsFromFile(bool sentFromStart)
	{
	}

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0xD82658", Offset = "0xD82658", VA = "0xD82658")]
	private void FlushAnalytics()
	{
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0xD8280C", Offset = "0xD8280C", VA = "0xD8280C")]
	private void FlushResponse(OSRequestState osRequestState)
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0xD82500", Offset = "0xD82500", VA = "0xD82500")]
	private void SaveToFile(CrashHandlerError crashHandlerError)
	{
	}

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0xD82824", Offset = "0xD82824", VA = "0xD82824")]
	private static GameStats GetGameStats()
	{
		return null;
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0xD81E74", Offset = "0xD81E74", VA = "0xD81E74")]
	private static string GetPlayerUID()
	{
		return null;
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0xD81EEC", Offset = "0xD81EEC", VA = "0xD81EEC")]
	private static float GetElapsedTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0xD8291C", Offset = "0xD8291C", VA = "0xD8291C")]
	private static Vector2 GetPlayerLookAt()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0xD820BC", Offset = "0xD820BC", VA = "0xD820BC")]
	private static bool GetPlayerIsInScope()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0xD821EC", Offset = "0xD821EC", VA = "0xD821EC")]
	private static GameEventsManager.State GetGameState()
	{
		return default(GameEventsManager.State);
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0xD822AC", Offset = "0xD822AC", VA = "0xD822AC")]
	private static string GetStringSha256Hash(string text)
	{
		return null;
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0xD82A4C", Offset = "0xD82A4C", VA = "0xD82A4C")]
	public CrashHandler()
	{
	}
}
