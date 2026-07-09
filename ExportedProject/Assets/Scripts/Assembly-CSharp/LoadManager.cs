using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using Technology.Distribution;
using UnityEngine;

[Token(Token = "0x20008F6")]
[ExecuteInEditMode]
[AutoInstantiate]
[Scope]
public class LoadManager : GameSingleton<LoadManager>
{
	[Token(Token = "0x20008F7")]
	private enum StateEnum
	{
		[Token(Token = "0x4003168")]
		Instantiated = 0,
		[Token(Token = "0x4003169")]
		Initializing = 1,
		[Token(Token = "0x400316A")]
		Ready = 2,
		[Token(Token = "0x400316B")]
		Refresh = 3,
		[Token(Token = "0x400316C")]
		LoadEnd = 4,
		[Token(Token = "0x400316D")]
		LoadCompleted = 5
	}

	[Serializable]
	[Token(Token = "0x20008F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596DC4", Offset = "0x596DC4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Bundle> _003C_003E9__73_0;

		[Token(Token = "0x4003170")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Bundle> _003C_003E9__75_0;

		[Token(Token = "0x6003993")]
		[Address(RVA = "0x8C1820", Offset = "0x8C1820", VA = "0x8C1820")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003994")]
		[Address(RVA = "0x8C1828", Offset = "0x8C1828", VA = "0x8C1828")]
		internal int _003CSetLevel_003Eb__73_0(Bundle x, Bundle y)
		{
			return default(int);
		}

		[Token(Token = "0x6003995")]
		[Address(RVA = "0x8C1854", Offset = "0x8C1854", VA = "0x8C1854")]
		internal bool _003CLoadOrderedAdditives_003Eb__75_0(Bundle x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400314D")]
	[FieldOffset(Offset = "0x48")]
	private StateEnum _state;

	[Token(Token = "0x4003150")]
	[FieldOffset(Offset = "0x60")]
	public List<Bundle> LevelBundles;

	[Token(Token = "0x4003151")]
	[FieldOffset(Offset = "0x68")]
	public bool Flatten;

	[Token(Token = "0x4003152")]
	[FieldOffset(Offset = "0x69")]
	public bool PrepareForPublishing;

	[Token(Token = "0x4003153")]
	[FieldOffset(Offset = "0x6A")]
	public bool ForceDisable;

	[Token(Token = "0x4003154")]
	[FieldOffset(Offset = "0x6B")]
	[SerializeField]
	private bool _isConfigured;

	[Token(Token = "0x4003155")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ABTest _abtest;

	[Token(Token = "0x4003156")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameConfiguration _gameConfiguration;

	[Token(Token = "0x4003157")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Queue<Bundle> _queue;

	[Token(Token = "0x4003158")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Dictionary<string, Bundle> _readyToLoadAdditives;

	[Token(Token = "0x4003159")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private LoadMeta _loadMeta;

	[Token(Token = "0x400315A")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private SceneGroupMeta _currentLoadMeta;

	[Token(Token = "0x400315B")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private bool _IsABTestingEnabled;

	[Token(Token = "0x400315C")]
	[FieldOffset(Offset = "0xA1")]
	[SerializeField]
	private bool _IsGameConfigurationDownloadEnabled;

	[Token(Token = "0x400315D")]
	[FieldOffset(Offset = "0xA2")]
	[SerializeField]
	private bool _isFlatteningReady;

	[Token(Token = "0x400315E")]
	[FieldOffset(Offset = "0xA3")]
	[SerializeField]
	private bool _isFlattening;

	[Token(Token = "0x400315F")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private int _sceneToLoadNb;

	[Token(Token = "0x4003160")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool _isFinal;

	[Token(Token = "0x4003161")]
	[FieldOffset(Offset = "0xA9")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BBA1C", Offset = "0x5BBA1C")]
	public bool EnableQuickPlay;

	[Token(Token = "0x4003162")]
	[FieldOffset(Offset = "0xAA")]
	public bool AddShaderManager;

	[Token(Token = "0x4003163")]
	[FieldOffset(Offset = "0xB0")]
	public Camera EnableCamera;

	[Token(Token = "0x4003164")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBA54", Offset = "0x5BBA54")]
	private Dictionary<string, Bundle> _003CPrefabBundles_003Ek__BackingField;

	[Token(Token = "0x4003165")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBA64", Offset = "0x5BBA64")]
	private Dictionary<string, Bundle> _003CScriptableBundles_003Ek__BackingField;

	[Token(Token = "0x1700073C")]
	public bool IsFinal
	{
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x9CA6C4", Offset = "0x9CA6C4", VA = "0x9CA6C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x9CA6CC", Offset = "0x9CA6CC", VA = "0x9CA6CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700073D")]
	public static LoadManager RootLoadManager
	{
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x9CA6D8", Offset = "0x9CA6D8", VA = "0x9CA6D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073E")]
	public bool IsGameConfigurationDownloadEnabled
	{
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x9CA748", Offset = "0x9CA748", VA = "0x9CA748")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003962")]
		[Address(RVA = "0x9CA750", Offset = "0x9CA750", VA = "0x9CA750")]
		set
		{
		}
	}

	[Token(Token = "0x1700073F")]
	public SceneGroupMeta CurrentLevelFolder
	{
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x9CA75C", Offset = "0x9CA75C", VA = "0x9CA75C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x9CA764", Offset = "0x9CA764", VA = "0x9CA764")]
		set
		{
		}
	}

	[Token(Token = "0x17000740")]
	public LoadMeta LoadMeta
	{
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x9CA76C", Offset = "0x9CA76C", VA = "0x9CA76C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000741")]
	public Dictionary<string, Bundle> PrefabBundles
	{
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x9CAB3C", Offset = "0x9CAB3C", VA = "0x9CAB3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245B0", Offset = "0x6245B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x9CAB44", Offset = "0x9CAB44", VA = "0x9CAB44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245C0", Offset = "0x6245C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000742")]
	public Dictionary<string, Bundle> ScriptableBundles
	{
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x9CAB4C", Offset = "0x9CAB4C", VA = "0x9CAB4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245D0", Offset = "0x6245D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x9CAB54", Offset = "0x9CAB54", VA = "0x9CAB54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245E0", Offset = "0x6245E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000743")]
	public GameConfiguration GameConfiguration
	{
		[Token(Token = "0x600396A")]
		[Address(RVA = "0x9CAB5C", Offset = "0x9CAB5C", VA = "0x9CAB5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000744")]
	public bool IsABTesting
	{
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x9CACA4", Offset = "0x9CACA4", VA = "0x9CACA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x9CACAC", Offset = "0x9CACAC", VA = "0x9CACAC")]
		set
		{
		}
	}

	[Token(Token = "0x140000AF")]
	public event Action OnLoadCompleted
	{
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x9CA444", Offset = "0x9CA444", VA = "0x9CA444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624570", Offset = "0x624570")]
		add
		{
		}
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x9CA4E4", Offset = "0x9CA4E4", VA = "0x9CA4E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624580", Offset = "0x624580")]
		remove
		{
		}
	}

	[Token(Token = "0x140000B0")]
	public event Action OnLevelLoadedIntoScene
	{
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x9CA584", Offset = "0x9CA584", VA = "0x9CA584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624590", Offset = "0x624590")]
		add
		{
		}
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x9CA624", Offset = "0x9CA624", VA = "0x9CA624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245A0", Offset = "0x6245A0")]
		remove
		{
		}
	}

	[Token(Token = "0x140000B1")]
	public event EventHandler OnLoadStart
	{
		[Token(Token = "0x600396B")]
		[Address(RVA = "0x9CAB64", Offset = "0x9CAB64", VA = "0x9CAB64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245F0", Offset = "0x6245F0")]
		add
		{
		}
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x9CAC04", Offset = "0x9CAC04", VA = "0x9CAC04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624600", Offset = "0x624600")]
		remove
		{
		}
	}

	[Token(Token = "0x600396F")]
	[Address(RVA = "0x9CA79C", Offset = "0x9CA79C", VA = "0x9CA79C")]
	public void Init()
	{
	}

	[Token(Token = "0x6003970")]
	[Address(RVA = "0x9CADE4", Offset = "0x9CADE4", VA = "0x9CADE4")]
	public void InitializeConfiguration()
	{
	}

	[Token(Token = "0x6003971")]
	[Address(RVA = "0x9CACE4", Offset = "0x9CACE4", VA = "0x9CACE4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003972")]
	[Address(RVA = "0x9CB4F4", Offset = "0x9CB4F4", VA = "0x9CB4F4")]
	public void Update()
	{
	}

	[Token(Token = "0x6003973")]
	[Address(RVA = "0x9CBC58", Offset = "0x9CBC58", VA = "0x9CBC58")]
	public void Load(SceneGroupMeta l_loadMeta)
	{
	}

	[Token(Token = "0x6003974")]
	[Address(RVA = "0x9CC04C", Offset = "0x9CC04C", VA = "0x9CC04C")]
	public void SetForFlattening(string groupName, bool save = false)
	{
	}

	[Token(Token = "0x6003975")]
	[Address(RVA = "0x9CC0DC", Offset = "0x9CC0DC", VA = "0x9CC0DC")]
	public void SetLevel(string groupName)
	{
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0x9CC1A4", Offset = "0x9CC1A4", VA = "0x9CC1A4")]
	public void PrepForPublishing()
	{
	}

	[Token(Token = "0x6003977")]
	[Address(RVA = "0x9CC1EC", Offset = "0x9CC1EC", VA = "0x9CC1EC")]
	public void Enqueue(Bundle bundle)
	{
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0x9CC25C", Offset = "0x9CC25C", VA = "0x9CC25C")]
	public void SaveSceneCopy()
	{
	}

	[Token(Token = "0x6003979")]
	[Address(RVA = "0x9CC260", Offset = "0x9CC260", VA = "0x9CC260", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600397A")]
	[Address(RVA = "0x9CC3B0", Offset = "0x9CC3B0", VA = "0x9CC3B0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600397B")]
	private static T LoadObject<T>(string id, IDictionary<string, Bundle> bundles) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600397C")]
	[Address(RVA = "0x9CC458", Offset = "0x9CC458", VA = "0x9CC458")]
	private GameObject LoadGameObject(string id)
	{
		return null;
	}

	[Token(Token = "0x600397D")]
	[Address(RVA = "0x9CC4B4", Offset = "0x9CC4B4", VA = "0x9CC4B4")]
	private ScriptableObject LoadScriptableObject(string id)
	{
		return null;
	}

	[Token(Token = "0x600397E")]
	[Address(RVA = "0x9CBF4C", Offset = "0x9CBF4C", VA = "0x9CBF4C")]
	private void LoadAdditives()
	{
	}

	[Token(Token = "0x600397F")]
	[Address(RVA = "0x9CBC84", Offset = "0x9CBC84", VA = "0x9CBC84")]
	private void SetLevel(SceneGroupMeta l_loadMeta)
	{
	}

	[Token(Token = "0x6003980")]
	[Address(RVA = "0x9CC594", Offset = "0x9CC594", VA = "0x9CC594")]
	private void OnStartLoading(Bundle bundle)
	{
	}

	[Token(Token = "0x6003981")]
	[Address(RVA = "0x9CB870", Offset = "0x9CB870", VA = "0x9CB870")]
	private void LoadOrderedAdditives()
	{
	}

	[Token(Token = "0x6003982")]
	[Address(RVA = "0x9CB768", Offset = "0x9CB768", VA = "0x9CB768")]
	private void AddEventHandlers(Bundle bundle)
	{
	}

	[Token(Token = "0x6003983")]
	[Address(RVA = "0x9CC5A4", Offset = "0x9CC5A4", VA = "0x9CC5A4")]
	private void RemoveEventHandlers(Bundle bundle)
	{
	}

	[Token(Token = "0x6003984")]
	[Address(RVA = "0x9CC66C", Offset = "0x9CC66C", VA = "0x9CC66C")]
	private void RemoteEventHandlerLoaded(Bundle bundle)
	{
	}

	[Token(Token = "0x6003985")]
	[Address(RVA = "0x9CB3E4", Offset = "0x9CB3E4", VA = "0x9CB3E4")]
	private void AddGCEventHandlers()
	{
	}

	[Token(Token = "0x6003986")]
	[Address(RVA = "0x9CB324", Offset = "0x9CB324", VA = "0x9CB324")]
	private void RemoveGCTestHandlers()
	{
	}

	[Token(Token = "0x6003987")]
	[Address(RVA = "0x9CC700", Offset = "0x9CC700", VA = "0x9CC700")]
	private void AddABTestEventHandlers()
	{
	}

	[Token(Token = "0x6003988")]
	[Address(RVA = "0x9CC7C0", Offset = "0x9CC7C0", VA = "0x9CC7C0")]
	private void RemoveABTestHandlers()
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0x9CC880", Offset = "0x9CC880", VA = "0x9CC880")]
	private void HandleBundleLoadedIntoScene(Bundle bundle)
	{
	}

	[Token(Token = "0x600398A")]
	[Address(RVA = "0x9CC8E4", Offset = "0x9CC8E4", VA = "0x9CC8E4")]
	private void HandleGCOnInitialized()
	{
	}

	[Token(Token = "0x600398B")]
	[Address(RVA = "0x9CCA14", Offset = "0x9CCA14", VA = "0x9CCA14")]
	private void HandleGCOnError()
	{
	}

	[Token(Token = "0x600398C")]
	[Address(RVA = "0x9CCA3C", Offset = "0x9CCA3C", VA = "0x9CCA3C")]
	private void HandleABTestOnInitialized()
	{
	}

	[Token(Token = "0x600398D")]
	[Address(RVA = "0x9CCA60", Offset = "0x9CCA60", VA = "0x9CCA60")]
	private void HandleABTestOnError()
	{
	}

	[Token(Token = "0x600398E")]
	[Address(RVA = "0x9CCA88", Offset = "0x9CCA88", VA = "0x9CCA88")]
	private void HandleBundleDownloaded(Bundle bundle)
	{
	}

	[Token(Token = "0x600398F")]
	[Address(RVA = "0x9CB4A4", Offset = "0x9CB4A4", VA = "0x9CB4A4")]
	private void LoadCurrentLevelGroup()
	{
	}

	[Token(Token = "0x6003990")]
	[Address(RVA = "0x9CCC94", Offset = "0x9CCC94", VA = "0x9CCC94")]
	private static void DisableLoadManager(LoadManager loadManager)
	{
	}

	[Token(Token = "0x6003991")]
	[Address(RVA = "0x9CCD48", Offset = "0x9CCD48", VA = "0x9CCD48")]
	public LoadManager()
	{
	}
}
