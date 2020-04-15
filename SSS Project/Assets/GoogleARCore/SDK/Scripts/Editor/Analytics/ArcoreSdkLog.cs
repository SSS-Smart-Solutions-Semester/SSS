// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: arcore_sdk_log.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbr = global::Google.Protobuf.Reflection;

namespace Assets.GoogleARCore.SDK.Scripts.Editor.Analytics {

  /// <summary>Holder for reflection information generated from arcore_sdk_log.proto</summary>
  public static partial class ArcoreSdkLogReflection {

    #region Descriptor
    /// <summary>File descriptor for arcore_sdk_log.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArcoreSdkLogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRhcmNvcmVfc2RrX2xvZy5wcm90bxIRY29tLmdvb2dsZS5hcmNvcmUi/QMK",
            "DEFyQ29yZVNka0xvZxIXCg9zZGtfaW5zdGFuY2VfaWQYASABKAkSFgoOc2Rr",
            "X3Nlc3Npb25faWQYBSABKAkSGgoSYXJjb3JlX3Nka192ZXJzaW9uGAIgASgJ",
            "EjkKCHNka190eXBlGAYgASgOMicuY29tLmdvb2dsZS5hcmNvcmUuQXJDb3Jl",
            "U2RrTG9nLlNES1R5cGUSEgoKb3NfdmVyc2lvbhgDIAEoCRI8CgV1bml0eRgE",
            "IAEoCzIrLmNvbS5nb29nbGUuYXJjb3JlLkFyQ29yZVNka0xvZy5Vbml0eUVu",
            "Z2luZUgAGrYBCgtVbml0eUVuZ2luZRIPCgd2ZXJzaW9uGAEgASgJEk0KDGVk",
            "aXRpb25fdHlwZRgCIAEoDjI3LmNvbS5nb29nbGUuYXJjb3JlLkFyQ29yZVNk",
            "a0xvZy5Vbml0eUVuZ2luZS5FZGl0aW9uVHlwZSJHCgtFZGl0aW9uVHlwZRIY",
            "ChRVTktOT1dOX0VESVRJT05fVFlQRRAAEgwKCFBFUlNPTkFMEAESEAoMUFJP",
            "RkVTU0lPTkFMEAIiUAoHU0RLVHlwZRIUChBVTktOT1dOX1NES19UWVBFEAAS",
            "DgoKQVJDT1JFX1NESxABEh8KG0FSRk9VTkRBVElPTl9FWFRFTlNJT05TX1NE",
            "SxACQggKBmVuZ2luZUIdqgIaR29vZ2xlQVJDb3JlSW50ZXJuYWwuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog), global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Parser, new[]{ "SdkInstanceId", "SdkSessionId", "ArcoreSdkVersion", "SdkType", "OsVersion", "Unity" }, new[]{ "Engine" }, new[]{ typeof(global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.SDKType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine), global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine.Parser, new[]{ "Version", "EditionType" }, null, new[]{ typeof(global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine.Types.EditionType) }, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message with log extension for ARCore SDK within development engines, like
  /// Unity and Unreal.
  ///
  /// Next ID: 7
  /// </summary>
  public sealed partial class ArCoreSdkLog : pb::IMessage<ArCoreSdkLog> {
    private static readonly pb::MessageParser<ArCoreSdkLog> _parser = new pb::MessageParser<ArCoreSdkLog>(() => new ArCoreSdkLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArCoreSdkLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArcoreSdkLogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArCoreSdkLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArCoreSdkLog(ArCoreSdkLog other) : this() {
      sdkInstanceId_ = other.sdkInstanceId_;
      sdkSessionId_ = other.sdkSessionId_;
      arcoreSdkVersion_ = other.arcoreSdkVersion_;
      sdkType_ = other.sdkType_;
      osVersion_ = other.osVersion_;
      switch (other.EngineCase) {
        case EngineOneofCase.Unity:
          Unity = other.Unity.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArCoreSdkLog Clone() {
      return new ArCoreSdkLog(this);
    }

    /// <summary>Field number for the "sdk_instance_id" field.</summary>
    public const int SdkInstanceIdFieldNumber = 1;
    private string sdkInstanceId_ = "";
    /// <summary>
    /// Unique identifier for a workstation running an engine, result of a SHA-512
    /// operation (hence a string and not a long). This ID will not be traceable
    /// back to an individual, and will be reset if the workstation is wiped out.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SdkInstanceId {
      get { return sdkInstanceId_; }
      set {
        sdkInstanceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sdk_session_id" field.</summary>
    public const int SdkSessionIdFieldNumber = 5;
    private string sdkSessionId_ = "";
    /// <summary>
    /// Session identifier to distinguish between events during the time a single
    /// Unity project is open continuously. When the project is closed or any
    /// other project is opened, a new identifier is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SdkSessionId {
      get { return sdkSessionId_; }
      set {
        sdkSessionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "arcore_sdk_version" field.</summary>
    public const int ArcoreSdkVersionFieldNumber = 2;
    private string arcoreSdkVersion_ = "";
    /// <summary>
    /// ARCore SDK version currently installed in the engine.
    /// For example: "1.5.0", "1.7.1".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ArcoreSdkVersion {
      get { return arcoreSdkVersion_; }
      set {
        arcoreSdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sdk_type" field.</summary>
    public const int SdkTypeFieldNumber = 6;
    private global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.SDKType sdkType_ = 0;
    /// <summary>
    /// Source SDK type the engine is using.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.SDKType SdkType {
      get { return sdkType_; }
      set {
        sdkType_ = value;
      }
    }

    /// <summary>Field number for the "os_version" field.</summary>
    public const int OsVersionFieldNumber = 3;
    private string osVersion_ = "";
    /// <summary>
    /// OS version where the engine is running.
    /// For example: "macOS 10.13.6", "Windows 10 Build 4872".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OsVersion {
      get { return osVersion_; }
      set {
        osVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unity" field.</summary>
    public const int UnityFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine Unity {
      get { return engineCase_ == EngineOneofCase.Unity ? (global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine) engine_ : null; }
      set {
        engine_ = value;
        engineCase_ = value == null ? EngineOneofCase.None : EngineOneofCase.Unity;
      }
    }

    private object engine_;
    /// <summary>Enum of possible cases for the "engine" oneof.</summary>
    public enum EngineOneofCase {
      None = 0,
      Unity = 4,
    }
    private EngineOneofCase engineCase_ = EngineOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EngineOneofCase EngineCase {
      get { return engineCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEngine() {
      engineCase_ = EngineOneofCase.None;
      engine_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArCoreSdkLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArCoreSdkLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SdkInstanceId != other.SdkInstanceId) return false;
      if (SdkSessionId != other.SdkSessionId) return false;
      if (ArcoreSdkVersion != other.ArcoreSdkVersion) return false;
      if (SdkType != other.SdkType) return false;
      if (OsVersion != other.OsVersion) return false;
      if (!object.Equals(Unity, other.Unity)) return false;
      if (EngineCase != other.EngineCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SdkInstanceId.Length != 0) hash ^= SdkInstanceId.GetHashCode();
      if (SdkSessionId.Length != 0) hash ^= SdkSessionId.GetHashCode();
      if (ArcoreSdkVersion.Length != 0) hash ^= ArcoreSdkVersion.GetHashCode();
      if (SdkType != 0) hash ^= SdkType.GetHashCode();
      if (OsVersion.Length != 0) hash ^= OsVersion.GetHashCode();
      if (engineCase_ == EngineOneofCase.Unity) hash ^= Unity.GetHashCode();
      hash ^= (int) engineCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SdkInstanceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SdkInstanceId);
      }
      if (ArcoreSdkVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ArcoreSdkVersion);
      }
      if (OsVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OsVersion);
      }
      if (engineCase_ == EngineOneofCase.Unity) {
        output.WriteRawTag(34);
        output.WriteMessage(Unity);
      }
      if (SdkSessionId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SdkSessionId);
      }
      if (SdkType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) SdkType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SdkInstanceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SdkInstanceId);
      }
      if (SdkSessionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SdkSessionId);
      }
      if (ArcoreSdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArcoreSdkVersion);
      }
      if (SdkType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SdkType);
      }
      if (OsVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OsVersion);
      }
      if (engineCase_ == EngineOneofCase.Unity) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArCoreSdkLog other) {
      if (other == null) {
        return;
      }
      if (other.SdkInstanceId.Length != 0) {
        SdkInstanceId = other.SdkInstanceId;
      }
      if (other.SdkSessionId.Length != 0) {
        SdkSessionId = other.SdkSessionId;
      }
      if (other.ArcoreSdkVersion.Length != 0) {
        ArcoreSdkVersion = other.ArcoreSdkVersion;
      }
      if (other.SdkType != 0) {
        SdkType = other.SdkType;
      }
      if (other.OsVersion.Length != 0) {
        OsVersion = other.OsVersion;
      }
      switch (other.EngineCase) {
        case EngineOneofCase.Unity:
          if (Unity == null) {
            Unity = new global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine();
          }
          Unity.MergeFrom(other.Unity);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SdkInstanceId = input.ReadString();
            break;
          }
          case 18: {
            ArcoreSdkVersion = input.ReadString();
            break;
          }
          case 26: {
            OsVersion = input.ReadString();
            break;
          }
          case 34: {
            global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine subBuilder = new global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine();
            if (engineCase_ == EngineOneofCase.Unity) {
              subBuilder.MergeFrom(Unity);
            }
            input.ReadMessage(subBuilder);
            Unity = subBuilder;
            break;
          }
          case 42: {
            SdkSessionId = input.ReadString();
            break;
          }
          case 48: {
            sdkType_ = (global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.SDKType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ArCoreSdkLog message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumeration with all existing Unity ARCore SDK types.
      /// For example, ARCore SDK for Unity vs AR Foundation Extensions.
      /// </summary>
      public enum SDKType {
        [pbr::OriginalName("UNKNOWN_SDK_TYPE")] UnknownSdkType = 0,
        [pbr::OriginalName("ARCORE_SDK")] ArcoreSdk = 1,
        [pbr::OriginalName("ARFOUNDATION_EXTENSIONS_SDK")] ArfoundationExtensionsSdk = 2,
      }

      /// <summary>
      /// Message with data logged about Unity usage.
      ///
      /// Next ID: 3
      /// </summary>
      public sealed partial class UnityEngine : pb::IMessage<UnityEngine> {
        private static readonly pb::MessageParser<UnityEngine> _parser = new pb::MessageParser<UnityEngine>(() => new UnityEngine());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<UnityEngine> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public UnityEngine() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public UnityEngine(UnityEngine other) : this() {
          version_ = other.version_;
          editionType_ = other.editionType_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public UnityEngine Clone() {
          return new UnityEngine(this);
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 1;
        private string version_ = "";
        /// <summary>
        /// Version of Unity being used.
        /// For example, "Unity 2017.4.4f1", "Unity 2018.2.7f1".
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Version {
          get { return version_; }
          set {
            version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "edition_type" field.</summary>
        public const int EditionTypeFieldNumber = 2;
        private global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine.Types.EditionType editionType_ = 0;
        /// <summary>
        /// Unity edition type being used.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine.Types.EditionType EditionType {
          get { return editionType_; }
          set {
            editionType_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as UnityEngine);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(UnityEngine other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Version != other.Version) return false;
          if (EditionType != other.EditionType) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Version.Length != 0) hash ^= Version.GetHashCode();
          if (EditionType != 0) hash ^= EditionType.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Version.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Version);
          }
          if (EditionType != 0) {
            output.WriteRawTag(16);
            output.WriteEnum((int) EditionType);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Version.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
          }
          if (EditionType != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EditionType);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(UnityEngine other) {
          if (other == null) {
            return;
          }
          if (other.Version.Length != 0) {
            Version = other.Version;
          }
          if (other.EditionType != 0) {
            EditionType = other.EditionType;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Version = input.ReadString();
                break;
              }
              case 16: {
                editionType_ = (global::Assets.GoogleARCore.SDK.Scripts.Editor.Analytics.ArCoreSdkLog.Types.UnityEngine.Types.EditionType) input.ReadEnum();
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the UnityEngine message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          /// <summary>
          /// Enumeration with all existing Unity edition types.
          /// For example, personal vs. professional.
          /// </summary>
          public enum EditionType {
            [pbr::OriginalName("UNKNOWN_EDITION_TYPE")] UnknownEditionType = 0,
            [pbr::OriginalName("PERSONAL")] Personal = 1,
            [pbr::OriginalName("PROFESSIONAL")] Professional = 2,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
