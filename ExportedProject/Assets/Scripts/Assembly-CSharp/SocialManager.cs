using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Facebook.Unity;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Core.Auth;
using Technology.Core.Common;
using Technology.Core.ServiceOperations;
using UnityEngine;

[Token(Token = "0x2000296")]
[Scope]
[AttributeAttribute(Name = "GameUpdateOrderAttribute", RVA = "0x592FE8", Offset = "0x592FE8")]
public class SocialManager : GameSingleton<SocialManager>
{
	[Token(Token = "0x2000297")]
	public enum SocialManagerStatus
	{
		[Token(Token = "0x4000EA3")]
		NotInitialized = 0,
		[Token(Token = "0x4000EA4")]
		Ready = 1,
		[Token(Token = "0x4000EA5")]
		LoginToFacebook = 2,
		[Token(Token = "0x4000EA6")]
		CloudSyncing = 3,
		[Token(Token = "0x4000EA7")]
		LoginToGameCenter = 4,
		[Token(Token = "0x4000EA8")]
		LoginToGooglePlayServices = 5,
		[Token(Token = "0x4000EA9")]
		CloudReconcile = 6,
		[Token(Token = "0x4000EAA")]
		CloudPropagate = 7,
		[Token(Token = "0x4000EAB")]
		CloudAutoReconcile = 8
	}

	[Token(Token = "0x2000298")]
	public enum SocialManagerLinkResult
	{
		[Token(Token = "0x4000EAD")]
		None = 0,
		[Token(Token = "0x4000EAE")]
		Failed = 1,
		[Token(Token = "0x4000EAF")]
		UserCanceled = 2,
		[Token(Token = "0x4000EB0")]
		LocalGamePersists = 3,
		[Token(Token = "0x4000EB1")]
		CloudGameReplaces = 4
	}

	[Token(Token = "0x2000299")]
	public class LinkEvent : EventArgs
	{
		[Token(Token = "0x200029A")]
		public enum ErrorCodeEnum
		{
			[Token(Token = "0x4000EB7")]
			NONE = 0,
			[Token(Token = "0x4000EB8")]
			OFFLINE = 1,
			[Token(Token = "0x4000EB9")]
			LOGIN_FAILURE = 2
		}

		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3AF4", Offset = "0x5B3AF4")]
		private ErrorCodeEnum _003CErrorCode_003Ek__BackingField;

		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B04", Offset = "0x5B3B04")]
		private SocialManagerLinkResult _003CResult_003Ek__BackingField;

		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B14", Offset = "0x5B3B14")]
		private AuthenticationType _003CAuthenticationType_003Ek__BackingField;

		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B24", Offset = "0x5B3B24")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x17000271")]
		public ErrorCodeEnum ErrorCode
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0xA4EF64", Offset = "0xA4EF64", VA = "0xA4EF64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615864", Offset = "0x615864")]
			get
			{
				return default(ErrorCodeEnum);
			}
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0xA4EF6C", Offset = "0xA4EF6C", VA = "0xA4EF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615874", Offset = "0x615874")]
			private set
			{
			}
		}

		[Token(Token = "0x17000272")]
		public SocialManagerLinkResult Result
		{
			[Token(Token = "0x6001000")]
			[Address(RVA = "0xA4EF74", Offset = "0xA4EF74", VA = "0xA4EF74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615884", Offset = "0x615884")]
			get
			{
				return default(SocialManagerLinkResult);
			}
			[Token(Token = "0x6001001")]
			[Address(RVA = "0xA4EF7C", Offset = "0xA4EF7C", VA = "0xA4EF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615894", Offset = "0x615894")]
			private set
			{
			}
		}

		[Token(Token = "0x17000273")]
		public AuthenticationType AuthenticationType
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0xA4EF84", Offset = "0xA4EF84", VA = "0xA4EF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6158A4", Offset = "0x6158A4")]
			get
			{
				return default(AuthenticationType);
			}
			[Token(Token = "0x6001003")]
			[Address(RVA = "0xA4EF8C", Offset = "0xA4EF8C", VA = "0xA4EF8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6158B4", Offset = "0x6158B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000274")]
		public string ErrorMessage
		{
			[Token(Token = "0x6001004")]
			[Address(RVA = "0xA4EF94", Offset = "0xA4EF94", VA = "0xA4EF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6158C4", Offset = "0x6158C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001005")]
			[Address(RVA = "0xA4EF9C", Offset = "0xA4EF9C", VA = "0xA4EF9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6158D4", Offset = "0x6158D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6001006")]
		[Address(RVA = "0xA4EFA4", Offset = "0xA4EFA4", VA = "0xA4EFA4")]
		public LinkEvent(SocialManagerLinkResult result, string errorMessage, AuthenticationType authenticationType, ErrorCodeEnum errorCode = ErrorCodeEnum.NONE)
		{
		}
	}

	[Token(Token = "0x200029B")]
	public class StatusEvent : EventArgs
	{
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x10")]
		public SocialManagerStatus NewStatus;

		[Token(Token = "0x6001007")]
		[Address(RVA = "0xA4F038", Offset = "0xA4F038", VA = "0xA4F038")]
		public StatusEvent()
		{
		}
	}

	[Token(Token = "0x200029C")]
	public enum PlayerProfilePicPref
	{
		[Token(Token = "0x4000EBC")]
		Default = 0,
		[Token(Token = "0x4000EBD")]
		Facebook = 1,
		[Token(Token = "0x4000EBE")]
		GameCenter = 2,
		[Token(Token = "0x4000EBF")]
		PlayGameService = 3
	}

	[Serializable]
	[Token(Token = "0x200029D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593030", Offset = "0x593030")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x8")]
		public static InitDelegate _003C_003E9__57_0;

		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__62_2;

		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__74_1;

		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x20")]
		public static Action _003C_003E9__96_0;

		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x28")]
		public static Action<SaveGameManager.ReconcileResult> _003C_003E9__100_0;

		[Token(Token = "0x6001009")]
		[Address(RVA = "0xA4CBF4", Offset = "0xA4CBF4", VA = "0xA4CBF4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600100A")]
		[Address(RVA = "0xA4CBFC", Offset = "0xA4CBFC", VA = "0xA4CBFC")]
		internal void _003COnApplicationPause_003Eb__57_0()
		{
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0xA4CC58", Offset = "0xA4CC58", VA = "0xA4CC58")]
		internal void _003CLoginToGooglePlayServices_003Eb__62_2()
		{
		}

		[Token(Token = "0x600100C")]
		[Address(RVA = "0xA4CC5C", Offset = "0xA4CC5C", VA = "0xA4CC5C")]
		internal void _003CFacebookLoginCompletion_003Eb__74_1()
		{
		}

		[Token(Token = "0x600100D")]
		[Address(RVA = "0xA4CD20", Offset = "0xA4CD20", VA = "0xA4CD20")]
		internal void _003CShowFacebookIncentiveConfirmation_003Eb__96_0()
		{
		}

		[Token(Token = "0x600100E")]
		[Address(RVA = "0xA4CF20", Offset = "0xA4CF20", VA = "0xA4CF20")]
		internal void _003CDisplaySaveReconciliation_003Eb__100_0(SaveGameManager.ReconcileResult res)
		{
		}
	}

	[Token(Token = "0x200029E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593040", Offset = "0x593040")]
	private sealed class _003CWaitForCompletedReconcile_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x20")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x17000275")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001012")]
			[Address(RVA = "0xA4EF14", Offset = "0xA4EF14", VA = "0xA4EF14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000276")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001014")]
			[Address(RVA = "0xA4EF5C", Offset = "0xA4EF5C", VA = "0xA4EF5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600100F")]
		[Address(RVA = "0xA4EE0C", Offset = "0xA4EE0C", VA = "0xA4EE0C")]
		[DebuggerHidden]
		public _003CWaitForCompletedReconcile_003Ed__65(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001010")]
		[Address(RVA = "0xA4EE38", Offset = "0xA4EE38", VA = "0xA4EE38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001011")]
		[Address(RVA = "0xA4EE3C", Offset = "0xA4EE3C", VA = "0xA4EE3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001013")]
		[Address(RVA = "0xA4EF1C", Offset = "0xA4EF1C", VA = "0xA4EF1C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200029F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593050", Offset = "0x593050")]
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x10")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x18")]
		public FacebookPersonalRecord fbinfo;

		[Token(Token = "0x6001015")]
		[Address(RVA = "0xA4DBB8", Offset = "0xA4DBB8", VA = "0xA4DBB8")]
		public _003C_003Ec__DisplayClass74_0()
		{
		}

		[Token(Token = "0x6001016")]
		[Address(RVA = "0xA4DBC0", Offset = "0xA4DBC0", VA = "0xA4DBC0")]
		internal void _003CFacebookLoginCompletion_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20002A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593060", Offset = "0x593060")]
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x10")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x18")]
		public Action<object, AuthenticationEvent> connectHandle;

		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x20")]
		public AuthenticationType authType;

		[Token(Token = "0x6001017")]
		[Address(RVA = "0xA4DC58", Offset = "0xA4DC58", VA = "0xA4DC58")]
		public _003C_003Ec__DisplayClass99_0()
		{
		}

		[Token(Token = "0x6001018")]
		[Address(RVA = "0xA4DC60", Offset = "0xA4DC60", VA = "0xA4DC60")]
		internal void _003COnCloudSynchronisation_003Eb__0()
		{
		}

		[Token(Token = "0x6001019")]
		[Address(RVA = "0xA4DD40", Offset = "0xA4DD40", VA = "0xA4DD40")]
		internal void _003COnCloudSynchronisation_003Eb__1(SaveGameManager.ReconcileResult res)
		{
		}
	}

	[Token(Token = "0x20002A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593070", Offset = "0x593070")]
	private sealed class _003C_003Ec__DisplayClass100_0
	{
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x10")]
		public Action<SaveGameManager.ReconcileResult> onDone;

		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x18")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x20")]
		public string remoteID;

		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x28")]
		public Action<SaveGameManager.ReconcileResult> onDoneInternal;

		[Token(Token = "0x600101A")]
		[Address(RVA = "0xA4CF24", Offset = "0xA4CF24", VA = "0xA4CF24")]
		public _003C_003Ec__DisplayClass100_0()
		{
		}

		[Token(Token = "0x600101B")]
		[Address(RVA = "0xA4CF2C", Offset = "0xA4CF2C", VA = "0xA4CF2C")]
		internal void _003CDisplaySaveReconciliation_003Eb__1(SaveGameManager.ReconcileResult res)
		{
		}

		[Token(Token = "0x600101C")]
		[Address(RVA = "0xA4CFA4", Offset = "0xA4CFA4", VA = "0xA4CFA4")]
		internal void _003CDisplaySaveReconciliation_003Eb__3(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> subAction)
		{
		}
	}

	[Token(Token = "0x20002A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593080", Offset = "0x593080")]
	private sealed class _003C_003Ec__DisplayClass100_1
	{
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpTransferFacebookId svcOp;

		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass100_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600101D")]
		[Address(RVA = "0xA4D040", Offset = "0xA4D040", VA = "0xA4D040")]
		public _003C_003Ec__DisplayClass100_1()
		{
		}

		[Token(Token = "0x600101E")]
		[Address(RVA = "0xA4D048", Offset = "0xA4D048", VA = "0xA4D048")]
		internal void _003CDisplaySaveReconciliation_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20002A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593090", Offset = "0x593090")]
	private sealed class _003C_003Ec__DisplayClass101_0
	{
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x10")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x18")]
		public Action<SaveGameManager.ReconcileResult> onDoneInternal;

		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x20")]
		public bool loadMenuOnReplaced;

		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x28")]
		public string remoteID;

		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x30")]
		public string onlineSaveString;

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ui;

		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x40")]
		public PopupOverlayViewBase previousPopup;

		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x48")]
		public Action _003C_003E9__1;

		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x50")]
		public Action _003C_003E9__2;

		[Token(Token = "0x600101F")]
		[Address(RVA = "0xA4D0E0", Offset = "0xA4D0E0", VA = "0xA4D0E0")]
		public _003C_003Ec__DisplayClass101_0()
		{
		}

		[Token(Token = "0x6001020")]
		[Address(RVA = "0xA4D0E8", Offset = "0xA4D0E8", VA = "0xA4D0E8")]
		internal void _003CDoDisplaySaveReconciliation_003Eb__0(SaveReconcileController.UserChoice choice)
		{
		}

		[Token(Token = "0x6001021")]
		[Address(RVA = "0xA4D7D8", Offset = "0xA4D7D8", VA = "0xA4D7D8")]
		internal void _003CDoDisplaySaveReconciliation_003Eb__1()
		{
		}

		[Token(Token = "0x6001022")]
		[Address(RVA = "0xA4D854", Offset = "0xA4D854", VA = "0xA4D854")]
		internal void _003CDoDisplaySaveReconciliation_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20002A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930A0", Offset = "0x5930A0")]
	private sealed class _003CDoDisplaySaveReconciliation_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x20")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x28")]
		public Action<SaveGameManager.ReconcileResult> onDoneInternal;

		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x30")]
		public bool loadMenuOnReplaced;

		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x38")]
		public string remoteID;

		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x40")]
		public string onlineSaveString;

		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x48")]
		public bool waitOneFrame;

		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x50")]
		private _003C_003Ec__DisplayClass101_0 _003C_003E8__1;

		[Token(Token = "0x17000277")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001026")]
			[Address(RVA = "0xA4EDBC", Offset = "0xA4EDBC", VA = "0xA4EDBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000278")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0xA4EE04", Offset = "0xA4EE04", VA = "0xA4EE04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001023")]
		[Address(RVA = "0xA4DEE0", Offset = "0xA4DEE0", VA = "0xA4DEE0")]
		[DebuggerHidden]
		public _003CDoDisplaySaveReconciliation_003Ed__101(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001024")]
		[Address(RVA = "0xA4DF0C", Offset = "0xA4DF0C", VA = "0xA4DF0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001025")]
		[Address(RVA = "0xA4DF10", Offset = "0xA4DF10", VA = "0xA4DF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0xA4EDC4", Offset = "0xA4EDC4", VA = "0xA4EDC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20002A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930B0", Offset = "0x5930B0")]
	private sealed class _003C_003Ec__DisplayClass111_0
	{
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x10")]
		public SharedProfile profile;

		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x18")]
		public EventHandler<SharedProfile.SharedProfileEvent> onProfileSetComplete;

		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x20")]
		public SocialManager _003C_003E4__this;

		[Token(Token = "0x6001029")]
		[Address(RVA = "0xA4D94C", Offset = "0xA4D94C", VA = "0xA4D94C")]
		public _003C_003Ec__DisplayClass111_0()
		{
		}

		[Token(Token = "0x600102A")]
		[Address(RVA = "0xA4D954", Offset = "0xA4D954", VA = "0xA4D954")]
		internal void _003CSubmitProfile_003Eb__0(object o, SharedProfile.SharedProfileEvent a)
		{
		}
	}

	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SaveReconcileUIPrefab;

	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x58")]
	private SocialManagerStatus _status;

	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x5C")]
	private SocialManagerLinkResult _linkResult;

	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x60")]
	private FacebookPersonalRecord _facebookRecordForGameReset;

	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x68")]
	private bool _displayRewardConfirmationOnConnectSuccess;

	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x69")]
	private bool _hasPendingFacebookLogin;

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x6A")]
	private bool _hasPendingGameCenterLogin;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x6B")]
	private bool _hasPendingGooglePlayServicesLogin;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x6C")]
	private bool _hasPendingFacebookLogout;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x6D")]
	private bool _hasPendingGameCenterLogout;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x6E")]
	private bool _hasPendingGooglePlayServicesLogout;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x6F")]
	private bool _hasPendingFacebookMigrate;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x70")]
	private bool _hasPendingGameCenterMigrate;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x71")]
	private bool _hasPendingGooglePlayServicesMigrate;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x78")]
	private readonly Timer _gamecenterLoginTimer;

	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x80")]
	private readonly Timer _googlePlayServicesLoginTimer;

	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x40")]
	public static bool CanAutoLogin;

	[Token(Token = "0x1700026E")]
	public SocialManagerStatus Status
	{
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0xA6549C", Offset = "0xA6549C", VA = "0xA6549C")]
		get
		{
			return default(SocialManagerStatus);
		}
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0xA654A4", Offset = "0xA654A4", VA = "0xA654A4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700026F")]
	private SocialManagerLinkResult LinkResult
	{
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0xA65598", Offset = "0xA65598", VA = "0xA65598")]
		get
		{
			return default(SocialManagerLinkResult);
		}
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0xA655A0", Offset = "0xA655A0", VA = "0xA655A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000270")]
	public bool IsReady
	{
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0xA66520", Offset = "0xA66520", VA = "0xA66520")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000040")]
	public static event EventHandler<LinkEvent> OnLinkConfirmed
	{
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0xA655A8", Offset = "0xA655A8", VA = "0xA655A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615674", Offset = "0x615674")]
		add
		{
		}
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0xA6569C", Offset = "0xA6569C", VA = "0xA6569C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615684", Offset = "0x615684")]
		remove
		{
		}
	}

	[Token(Token = "0x14000041")]
	public static event EventHandler<LinkEvent> OnLinkCancel
	{
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0xA65790", Offset = "0xA65790", VA = "0xA65790")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615694", Offset = "0x615694")]
		add
		{
		}
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0xA65888", Offset = "0xA65888", VA = "0xA65888")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156A4", Offset = "0x6156A4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000042")]
	public static event EventHandler<EventArgs> OnProfileRefreshed
	{
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0xA65980", Offset = "0xA65980", VA = "0xA65980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156B4", Offset = "0x6156B4")]
		add
		{
		}
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0xA65A78", Offset = "0xA65A78", VA = "0xA65A78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156C4", Offset = "0x6156C4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000043")]
	public static event EventHandler<StatusEvent> OnStatusChanged
	{
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0xA65B70", Offset = "0xA65B70", VA = "0xA65B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156D4", Offset = "0x6156D4")]
		add
		{
		}
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0xA65C68", Offset = "0xA65C68", VA = "0xA65C68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156E4", Offset = "0x6156E4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000044")]
	public static event EventHandler<AuthenticationEvent> OnGameCenterConfirmed
	{
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0xA65D60", Offset = "0xA65D60", VA = "0xA65D60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156F4", Offset = "0x6156F4")]
		add
		{
		}
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0xA65E58", Offset = "0xA65E58", VA = "0xA65E58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615704", Offset = "0x615704")]
		remove
		{
		}
	}

	[Token(Token = "0x14000045")]
	public static event EventHandler<AuthenticationEvent> OnGameCenterFailed
	{
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0xA65F50", Offset = "0xA65F50", VA = "0xA65F50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615714", Offset = "0x615714")]
		add
		{
		}
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0xA66048", Offset = "0xA66048", VA = "0xA66048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615724", Offset = "0x615724")]
		remove
		{
		}
	}

	[Token(Token = "0x14000046")]
	public static event EventHandler<AuthenticationEvent> OnGooglePlayServicesConfirmed
	{
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0xA66140", Offset = "0xA66140", VA = "0xA66140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615734", Offset = "0x615734")]
		add
		{
		}
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0xA66238", Offset = "0xA66238", VA = "0xA66238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615744", Offset = "0x615744")]
		remove
		{
		}
	}

	[Token(Token = "0x14000047")]
	public static event EventHandler<AuthenticationEvent> OnGooglePlayServicesFailed
	{
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0xA66330", Offset = "0xA66330", VA = "0xA66330")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615754", Offset = "0x615754")]
		add
		{
		}
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0xA66428", Offset = "0xA66428", VA = "0xA66428")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615764", Offset = "0x615764")]
		remove
		{
		}
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0xA66530", Offset = "0xA66530", VA = "0xA66530", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0xA6692C", Offset = "0xA6692C", VA = "0xA6692C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0xA66CF8", Offset = "0xA66CF8", VA = "0xA66CF8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0xA670F0", Offset = "0xA670F0", VA = "0xA670F0")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0xA67274", Offset = "0xA67274", VA = "0xA67274")]
	public void LoginToFacebook()
	{
	}

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0xA6727C", Offset = "0xA6727C", VA = "0xA6727C")]
	public void LoginToFacebook(bool displayRewardConfirmation)
	{
	}

	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0xA67554", Offset = "0xA67554", VA = "0xA67554")]
	public void LoginToFirstPartySocial()
	{
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0xA67694", Offset = "0xA67694", VA = "0xA67694")]
	public void LoginToGameCenter()
	{
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0xA67558", Offset = "0xA67558", VA = "0xA67558")]
	public void LoginToGooglePlayServices()
	{
	}

	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0xA673B0", Offset = "0xA673B0", VA = "0xA673B0")]
	private void Login(SocialManagerStatus status, bool isLoggedIn, AuthenticationType authType, ref bool hasPendingLogin, Timer timer)
	{
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0xA6777C", Offset = "0xA6777C", VA = "0xA6777C")]
	public void TrytoReconcileOnline(float startPauseTime, float reconcileMinimumTime)
	{
	}

	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0xA6786C", Offset = "0xA6786C", VA = "0xA6786C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615774", Offset = "0x615774")]
	private IEnumerator WaitForCompletedReconcile()
	{
		return null;
	}

	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0xA678D8", Offset = "0xA678D8", VA = "0xA678D8")]
	private void OnFacebookLogin(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0xA678F8", Offset = "0xA678F8", VA = "0xA678F8")]
	private void OnFacebookLoginSuccess()
	{
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0xA67A1C", Offset = "0xA67A1C", VA = "0xA67A1C")]
	private void OnGooglePlayServicesLogin(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0xA67A3C", Offset = "0xA67A3C", VA = "0xA67A3C")]
	private void OnGooglePlayServicesLoginSuccess(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0xA679C4", Offset = "0xA679C4", VA = "0xA679C4")]
	private void DoMigrateFacebook()
	{
	}

	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0xA67CC0", Offset = "0xA67CC0", VA = "0xA67CC0")]
	private void DoMigrateGameCenter()
	{
	}

	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0xA67BF4", Offset = "0xA67BF4", VA = "0xA67BF4")]
	private void DoMigrateGooglePlayServices()
	{
	}

	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0xA67C4C", Offset = "0xA67C4C", VA = "0xA67C4C")]
	private void MigrateAction(SocialManagerStatus status, AuthenticationType authType, bool isLoggedIn, ref bool hasPendingMigrate)
	{
	}

	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0xA67D18", Offset = "0xA67D18", VA = "0xA67D18")]
	private void FacebookLoginCompletion(FacebookPersonalRecord fbinfo)
	{
	}

	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0xA68198", Offset = "0xA68198", VA = "0xA68198")]
	private void OnGooglePlayServicesConnect(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0xA681BC", Offset = "0xA681BC", VA = "0xA681BC")]
	private void OnGooglePlayServicesConnectSuccess(AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0xA68680", Offset = "0xA68680", VA = "0xA68680")]
	private void OnFacebookConnect(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0xA686A4", Offset = "0xA686A4", VA = "0xA686A4")]
	private void OnFacebookConnectSuccess(AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0xA68294", Offset = "0xA68294", VA = "0xA68294")]
	private void OnConnectSuccess(AuthenticationEvent e, SocialManagerStatus status, bool hasIncentive, SaveGameManager.SaveGameFlags loggedIntoFlags, bool isLoggedInToSecondCloud, AuthenticationType authenticationType, AuthenticationType secondCloudAuthType, Action loginBackOnCloudGameReplaces)
	{
	}

	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0xA68C14", Offset = "0xA68C14", VA = "0xA68C14")]
	private void ProcessPendingRequests()
	{
	}

	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0xA678FC", Offset = "0xA678FC", VA = "0xA678FC")]
	private void OnFacebookLoginFailure(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0xA66A2C", Offset = "0xA66A2C", VA = "0xA66A2C")]
	private void OnGameCenterLoginFailure(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0xA66B6C", Offset = "0xA66B6C", VA = "0xA66B6C")]
	private void OnGooglePlayServicesLoginFailure(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0xA68D04", Offset = "0xA68D04", VA = "0xA68D04")]
	private void OnLoginFailure(AuthenticationEvent e, SocialManagerStatus status, bool isLoggedIn, AuthenticationType authType, Action removeIsLoggedFlag, ref bool hasPendingLogout)
	{
	}

	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0xA67698", Offset = "0xA67698", VA = "0xA67698")]
	private void OnLinkCallback(LinkEvent e)
	{
	}

	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0xA68F24", Offset = "0xA68F24", VA = "0xA68F24")]
	private void OnFacebookLogout(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0xA68F48", Offset = "0xA68F48", VA = "0xA68F48")]
	private void OnFacebookLogoutSuccess()
	{
	}

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0xA68F58", Offset = "0xA68F58", VA = "0xA68F58")]
	private void OnGooglePlayServicesLogout(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0xA69010", Offset = "0xA69010", VA = "0xA69010")]
	private void OnGooglePlayServicesLogoutSuccess(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0xA68F50", Offset = "0xA68F50", VA = "0xA68F50")]
	private void RemoveFacebookIsLoggedInFromSave()
	{
	}

	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0xA691F8", Offset = "0xA691F8", VA = "0xA691F8")]
	private void RemoveGameCenterIsLoggedInFromSave()
	{
	}

	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0xA690B4", Offset = "0xA690B4", VA = "0xA690B4")]
	private void RemoveGooglePlayServicesIsLoggedInFromSave()
	{
	}

	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0xA690BC", Offset = "0xA690BC", VA = "0xA690BC")]
	private void RemoveLoggedFlagInFromSave(SaveGameManager.SaveGameFlags flagToRemove)
	{
	}

	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0xA68EAC", Offset = "0xA68EAC", VA = "0xA68EAC")]
	private static bool IsLoggedWithCloundSync()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0xA6877C", Offset = "0xA6877C", VA = "0xA6877C")]
	private static void GiveFacebookIncentive()
	{
	}

	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0xA68ACC", Offset = "0xA68ACC", VA = "0xA68ACC")]
	private static void ShowFacebookIncentiveConfirmation()
	{
	}

	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0xA69200", Offset = "0xA69200", VA = "0xA69200")]
	private void OnFacebookCloudSynchronisation(string localID, string remoteID)
	{
	}

	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0xA69640", Offset = "0xA69640", VA = "0xA69640")]
	private void OnGooglePlayServicesCloudSynchronisation(string localID, string remoteID)
	{
	}

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0xA692B0", Offset = "0xA692B0", VA = "0xA692B0")]
	private void OnCloudSynchronisation(string localID, string remoteID, SocialManagerStatus status, AuthenticationType authType, Action<object, AuthenticationEvent> connectHandle)
	{
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0xA696F0", Offset = "0xA696F0", VA = "0xA696F0")]
	public void DisplaySaveReconciliation(string remoteID, bool loadMenuOnReplaced, Action<SaveGameManager.ReconcileResult> onDone)
	{
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0xA69B80", Offset = "0xA69B80", VA = "0xA69B80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6157D4", Offset = "0x6157D4")]
	private IEnumerator DoDisplaySaveReconciliation(string remoteID, string onlineSaveString, bool loadMenuOnReplaced, Action<SaveGameManager.ReconcileResult> onDoneInternal, bool waitOneFrame = false)
	{
		return null;
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0xA69C2C", Offset = "0xA69C2C", VA = "0xA69C2C")]
	public void ForceReloadMenu()
	{
	}

	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0xA69DC4", Offset = "0xA69DC4", VA = "0xA69DC4")]
	private static string GetCurrentChapterMissionIDs(JSONNode data, int availableContractsIndex)
	{
		return null;
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0xA69F04", Offset = "0xA69F04", VA = "0xA69F04")]
	private void UpdateSaveGameFromFacebook(FacebookPersonalRecord fbinfo)
	{
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0xA6A10C", Offset = "0xA6A10C", VA = "0xA6A10C")]
	private void OnResetAuthentication(object sender, AuthenticationEvent e)
	{
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0xA6A26C", Offset = "0xA6A26C", VA = "0xA6A26C")]
	private void CompleteReset()
	{
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0xA6A3F8", Offset = "0xA6A3F8", VA = "0xA6A3F8")]
	private void LoadBackToMenu(object sender, LinkEvent e)
	{
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0xA6A30C", Offset = "0xA6A30C", VA = "0xA6A30C")]
	private void BindLoadBackToMenu()
	{
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0xA6A41C", Offset = "0xA6A41C", VA = "0xA6A41C")]
	private void UnbindLoadBackToMenu()
	{
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0xA687EC", Offset = "0xA687EC", VA = "0xA687EC")]
	private void SubmitProfile()
	{
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0xA6A508", Offset = "0xA6A508", VA = "0xA6A508")]
	public void LogoutFirstPartySocial()
	{
	}

	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0xA6A558", Offset = "0xA6A558", VA = "0xA6A558")]
	public void StopLoginTimers()
	{
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0xA6A594", Offset = "0xA6A594", VA = "0xA6A594")]
	public SocialManager()
	{
	}

	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0xA6A65C", Offset = "0xA6A65C", VA = "0xA6A65C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615834", Offset = "0x615834")]
	private StatusEvent _003Cset_Status_003Eb__7_0()
	{
		return null;
	}

	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0xA6A6C8", Offset = "0xA6A6C8", VA = "0xA6A6C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615844", Offset = "0x615844")]
	private void _003CLoginToGooglePlayServices_003Eb__62_0(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0xA6A864", Offset = "0xA6A864", VA = "0xA6A864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615854", Offset = "0x615854")]
	private void _003CLoginToGooglePlayServices_003Eb__62_1(BlockingOnlineRequestManager.ReqHandle h)
	{
	}
}
