// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/PokemonRarity.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Enums/PokemonRarity.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonRarityReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/PokemonRarity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonRarityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlFbnVtcy9Qb2tlbW9uUmFyaXR5LnByb3RvEgVFbnVtcyo2Cg1Qb2tlbW9u",
            "UmFyaXR5EgoKBk5PUk1BTBAAEg0KCUxFR0VOREFSWRABEgoKBk1ZVEhJQxAC",
            "Qh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PokemonGoDesktop.API.Proto.PokemonRarity), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonRarity {
    [pbr::OriginalName("NORMAL")] Normal = 0,
    [pbr::OriginalName("LEGENDARY")] Legendary = 1,
    [pbr::OriginalName("MYTHIC")] Mythic = 2,
  }

  #endregion

}

#endregion Designer generated code