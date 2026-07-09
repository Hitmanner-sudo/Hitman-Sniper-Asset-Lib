using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x2000255")]
[Scope]
public class NotificationsManager : GameSingleton<NotificationsManager>
{
	[Token(Token = "0x2000256")]
	public class RegisterNotificationsEventArgs : EventArgs
	{
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x10")]
		private readonly TimeSpan _registrationTimeOfDay;

		[Token(Token = "0x17000242")]
		public TimeSpan RegistrationTimeOfDay
		{
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x8CCA78", Offset = "0x8CCA78", VA = "0x8CCA78")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x8CCA80", Offset = "0x8CCA80", VA = "0x8CCA80")]
		public RegisterNotificationsEventArgs(TimeSpan registrationTimeOfDay)
		{
		}
	}

	[Token(Token = "0x2000257")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592DAC", Offset = "0x592DAC")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x10")]
		public EventHandler<EventArgs> fadeOutDone;

		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x18")]
		public NotificationsManager _003C_003E4__this;

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x8CCA00", Offset = "0x8CCA00", VA = "0x8CCA00")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x8CCA08", Offset = "0x8CCA08", VA = "0x8CCA08")]
		internal void _003COnUIViewVariableChanged_003Eb__1(object _003Cp0_003E, EventArgs _003Cp1_003E)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000258")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592DBC", Offset = "0x592DBC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x8")]
		public static Func<InactivityNotificationData, int> _003C_003E9__20_0;

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x8CC9E0", Offset = "0x8CC9E0", VA = "0x8CC9E0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x8CC9E8", Offset = "0x8CC9E8", VA = "0x8CC9E8")]
		internal int _003CUnregisterNotPlayingNotification_003Eb__20_0(InactivityNotificationData n)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x48")]
	public readonly TriggerEvent<RegisterNotificationsEventArgs> OnRegisterNotifications;

	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<InactivityNotificationData> _notPlayingNotifications;

	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private LazyPopupNotificationPermission _popupNotificationPrefab;

	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x60")]
	private readonly ContinuousTimer _pauseTimer;

	[Token(Token = "0x4000CE1")]
	private const float MAX_PAUSE_SINGLE_SESSION = 3600f;

	[Token(Token = "0x4000CE2")]
	public const string NOTIFICATION_TYPE_KEY = "type";

	[Token(Token = "0x4000CE3")]
	private const string NOTIFICATION_NOTPLAYING_TYPE = "notplaying";

	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0x68")]
	private TimeSpan _lastSessionStartTimeOfDay;

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x9E6A40", Offset = "0x9E6A40", VA = "0x9E6A40", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x9E6B98", Offset = "0x9E6B98", VA = "0x9E6B98")]
	private void OnLanguageChanged(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x9E6C28", Offset = "0x9E6C28", VA = "0x9E6C28", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x9E6CB4", Offset = "0x9E6CB4", VA = "0x9E6CB4")]
	protected void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x9E6DE0", Offset = "0x9E6DE0", VA = "0x9E6DE0")]
	public void RegisterForNotifications(bool waitUntilMenu)
	{
	}

	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x9E6F68", Offset = "0x9E6F68", VA = "0x9E6F68")]
	private void OnUIViewVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x9E7154", Offset = "0x9E7154", VA = "0x9E7154")]
	private void ShowNotificationPermissionPopup()
	{
	}

	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x9E7234", Offset = "0x9E7234", VA = "0x9E7234")]
	public static void DoRegisterForNotifications()
	{
	}

	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x9E72E8", Offset = "0x9E72E8", VA = "0x9E72E8")]
	private static void CancelRegisterForNotifications()
	{
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x9E73B0", Offset = "0x9E73B0", VA = "0x9E73B0")]
	private void RegisterNotPlayingNotification(object sender, RegisterNotificationsEventArgs e)
	{
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x9E76F4", Offset = "0x9E76F4", VA = "0x9E76F4")]
	public static void RegisterLocalNotification(DateTime triggerDate, LocalNotificationData data, string type)
	{
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x9E75C4", Offset = "0x9E75C4", VA = "0x9E75C4")]
	private void UnregisterNotPlayingNotification()
	{
	}

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x9E78AC", Offset = "0x9E78AC", VA = "0x9E78AC")]
	public static void UnregisterLocalNotifications(string type, IEnumerable<int> ids)
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x9E7B44", Offset = "0x9E7B44", VA = "0x9E7B44")]
	public NotificationsManager()
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x9E7C68", Offset = "0x9E7C68", VA = "0x9E7C68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614EE4", Offset = "0x614EE4")]
	private void _003CStart_003Eb__11_0()
	{
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x9E7D58", Offset = "0x9E7D58", VA = "0x9E7D58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614EF4", Offset = "0x614EF4")]
	private void _003COnUIViewVariableChanged_003Eb__14_0()
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x9E7E58", Offset = "0x9E7E58", VA = "0x9E7E58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614F04", Offset = "0x614F04")]
	private void _003CShowNotificationPermissionPopup_003Eb__15_0()
	{
	}
}
