using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20001EE")]
public class GeneralConfig : BaseConfig<GeneralConfig>
{
	[Serializable]
	[Token(Token = "0x20001EF")]
	public class OldSaveGameVersionPopupInfo
	{
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x10")]
		public int OldVersionID;

		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x18")]
		public OfferReference Offer;

		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x20")]
		public string PopupLocTitle;

		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x28")]
		public string PopupLocDescription;

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x873508", Offset = "0x873508", VA = "0x873508")]
		public OldSaveGameVersionPopupInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F0")]
	public class PossessSequence
	{
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Force;

		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x1C")]
		public float PauseDuration;

		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x20")]
		public float AppearFadeTime;

		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x24")]
		public float DisappearFadeTime;

		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x28")]
		public bool HaveGravity;

		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x29")]
		public bool SetBodyAsDominoKillInOneShoot;

		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x2C")]
		public float StopBodyAsDominoKillInOneShootDelay;

		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x30")]
		public LazyMaterial Image;

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x8735D4", Offset = "0x8735D4", VA = "0x8735D4")]
		public PossessSequence()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F1")]
	public class PinShotInfo
	{
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x10")]
		public GameObject PinPullerPrefab;

		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x18")]
		public float PinBreakForce;

		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x1C")]
		public float PinBreakTorque;

		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x20")]
		public float PinPullDuration;

		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x24")]
		public float PinPullImpulse;

		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x28")]
		public float PinPullYDirection;

		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x2C")]
		public float PinSpasmForce;

		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x30")]
		public float PinSpasmMinDelay;

		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x34")]
		public float PinSpasmMaxDelay;

		[Token(Token = "0x4000B4A")]
		[FieldOffset(Offset = "0x38")]
		public float PinSpasmScareRadius;

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x8735B4", Offset = "0x8735B4", VA = "0x8735B4")]
		public PinShotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F2")]
	public class PossessShotInfo
	{
		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x10")]
		public float PossessScale;

		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x14")]
		public float PossessDragOverwrite;

		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x18")]
		public float PossessStartDelay;

		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x1C")]
		public bool PossessIgnoreObstacleOnThrow;

		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x1D")]
		public bool PossessTargetOnlyEnemies;

		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x20")]
		public float PossessDetectionRadius;

		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x24")]
		public float PossessApparitionWaitingFadeTimeWaitingAppear;

		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x28")]
		public float PossessApparitionWaitingFadeTimeWaitingDisapear;

		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x30")]
		public PossessSequence PossessWaiting;

		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x38")]
		public PossessSequence PossessLift;

		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x40")]
		public PossessSequence PossessDrop;

		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x48")]
		public PossessSequence PossessThrow;

		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x50")]
		public LazyGameObject PossessBillboardPrefab;

		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x58")]
		public float PossessApparitionFadeRatio;

		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x5C")]
		public float PossessApparitionAlpha;

		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x60")]
		public float PossessExtraRayDistance;

		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x64")]
		public float PossessRayExtraHeight;

		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x68")]
		public GameObject PossessPrefab;

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x8735F4", Offset = "0x8735F4", VA = "0x8735F4")]
		public PossessShotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F3")]
	public class PushShotInfo
	{
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x10")]
		public int PushShotForce;

		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x14")]
		public bool PushShotSetBodyAsDominoKillInOneShoot;

		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x18")]
		public float PushShotSetBodyAsDominoKillInOneShootDelay;

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x873634", Offset = "0x873634", VA = "0x873634")]
		public PushShotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F4")]
	public class ImpaleShotInfo
	{
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x10")]
		public bool ImpaleShotSetBodyAsDominoKillInOneShoot;

		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x14")]
		public float ImpaleShotSetBodyAsDominoKillInOneShootDelay;

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x8734B0", Offset = "0x8734B0", VA = "0x8734B0")]
		public ImpaleShotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F5")]
	public class MortarShotInfo
	{
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x10")]
		public LazyGameObject BalisticAidPrefab;

		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x18")]
		public LazyGameObject BalisticBackAidPrefab;

		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 MortarOffset;

		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x2C")]
		public int MortalEffectPoints;

		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x30")]
		public float MortarEffectAnimationTime;

		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x34")]
		public float MortarEffectAnimationSizeRatio;

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x8734C8", Offset = "0x8734C8", VA = "0x8734C8")]
		public MortarShotInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F6")]
	public class BurnInfo
	{
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x10")]
		public LazyMaterial Material;

		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x18")]
		public float Duration;

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x873274", Offset = "0x873274", VA = "0x873274")]
		public BurnInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F7")]
	public class ObjectiveTagInfo
	{
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x10")]
		public LazyMaterial BlinkMaterialPrefab;

		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x18")]
		public float BlinkDuration;

		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x1C")]
		public float BlinkMinValue;

		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x20")]
		public float BlinkMaxValue;

		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x28")]
		public Trackable TrackablePrefab;

		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x30")]
		public Trackable MainTargetTrackablePrefab;

		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x38")]
		public Faction PlayerFaction;

		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x40")]
		public bool ShowNormalTagInTutorial;

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x8734F0", Offset = "0x8734F0", VA = "0x8734F0")]
		public ObjectiveTagInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001F8")]
	public class HyperlinkData
	{
		[Serializable]
		[Token(Token = "0x20001F9")]
		private struct LanguageMap
		{
			[Serializable]
			[Token(Token = "0x20001FA")]
			private struct Mapping
			{
				[Token(Token = "0x4000B76")]
				[FieldOffset(Offset = "0x0")]
				public string GameLanguage;

				[Token(Token = "0x4000B77")]
				[FieldOffset(Offset = "0x8")]
				public string WebsiteLanguage;
			}

			[Token(Token = "0x20001FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A0C", Offset = "0x592A0C")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x4000B78")]
				[FieldOffset(Offset = "0x10")]
				public string gameLangauge;

				[Token(Token = "0x6000C2A")]
				[Address(RVA = "0xA45C80", Offset = "0xA45C80", VA = "0xA45C80")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x6000C2B")]
				[Address(RVA = "0xA477E0", Offset = "0xA477E0", VA = "0xA477E0")]
				internal bool _003CGetMappedLanguage_003Eb__0(Mapping m)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x4000B74")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string _defaultValue;

			[Token(Token = "0x4000B75")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private List<Mapping> _mappings;

			[Token(Token = "0x6000C29")]
			[Address(RVA = "0xA45B80", Offset = "0xA45B80", VA = "0xA45B80")]
			public string GetMappedLanguage(string gameLangauge)
			{
				return null;
			}
		}

		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _urlFormat;

		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LanguageMap _langaugeMap;

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x873284", Offset = "0x873284", VA = "0x873284")]
		public string GetUrlForCurrentLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x873420", Offset = "0x873420", VA = "0x873420")]
		private bool IsNorthAmerica(string locale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x8734A8", Offset = "0x8734A8", VA = "0x8734A8")]
		public HyperlinkData()
		{
		}
	}

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x30")]
	public GUISkin Skin;

	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x38")]
	[Setting]
	public bool ShowFPSCounter;

	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x39")]
	[Setting]
	public bool ShowVersion;

	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x3A")]
	[Setting]
	public bool ShowSoundDebug;

	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x3C")]
	public float BeepOnDuration;

	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x40")]
	public SoundContainer VoiceOverBeepOn;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x48")]
	public SoundContainer VoiceOverBeepOff;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x50")]
	public float BloodFadeoutWait;

	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x54")]
	public float BloodFadeoutRate;

	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x58")]
	public float MinDeathTimeForDominoKills;

	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x60")]
	public List<OldSaveGameVersionPopupInfo> OldSaveGameVersionRewards;

	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x68")]
	public HyperlinkData PrivacyPolicyData;

	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x70")]
	public HyperlinkData TermsOfServiceData;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x78")]
	public float GamecenterLoginTimeoutInSeconds;

	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x80")]
	public PinShotInfo PinShot;

	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x88")]
	public PossessShotInfo PossessShot;

	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x90")]
	public PushShotInfo PushShot;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x98")]
	public ImpaleShotInfo ImpaleShot;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0xA0")]
	public MortarShotInfo MortarShot;

	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0xA8")]
	public BurnInfo Burn;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0xB0")]
	public ObjectiveTagInfo ObjectiveTag;

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0xD9D638", Offset = "0xD9D638", VA = "0xD9D638")]
	public GeneralConfig()
	{
	}
}
