// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PokemonMovementType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from PokemonMovementType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonMovementTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for PokemonMovementType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonMovementTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQb2tlbW9uTW92ZW1lbnRUeXBlLnByb3RvEhBQT0dPUHJvdG9zLkVudW1z",
            "Kq0BChNQb2tlbW9uTW92ZW1lbnRUeXBlEhMKD01PVkVNRU5UX1NUQVRJQxAA",
            "EhEKDU1PVkVNRU5UX0pVTVAQARIVChFNT1ZFTUVOVF9WRVJUSUNBTBACEhQK",
            "EE1PVkVNRU5UX1BTWUNISUMQAxIVChFNT1ZFTUVOVF9FTEVDVFJJQxAEEhMK",
            "D01PVkVNRU5UX0ZMWUlORxAFEhUKEU1PVkVNRU5UX0hPVkVSSU5HEAZiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PokemonMovementType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonMovementType {
    [pbr::OriginalName("MOVEMENT_STATIC")] MovementStatic = 0,
    [pbr::OriginalName("MOVEMENT_JUMP")] MovementJump = 1,
    [pbr::OriginalName("MOVEMENT_VERTICAL")] MovementVertical = 2,
    [pbr::OriginalName("MOVEMENT_PSYCHIC")] MovementPsychic = 3,
    [pbr::OriginalName("MOVEMENT_ELECTRIC")] MovementElectric = 4,
    [pbr::OriginalName("MOVEMENT_FLYING")] MovementFlying = 5,
    [pbr::OriginalName("MOVEMENT_HOVERING")] MovementHovering = 6,
  }

  #endregion

}

#endregion Designer generated code