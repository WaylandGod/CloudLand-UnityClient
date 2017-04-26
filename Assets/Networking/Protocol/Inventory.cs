// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.Dragonet.Cloudland.Net.Protocol {

  /// <summary>Holder for reflection information generated from Inventory.proto</summary>
  public static partial class InventoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9JbnZlbnRvcnkucHJvdG8SI29yZy5kcmFnb25ldC5jbG91ZGxhbmQubmV0",
            "LnByb3RvY29sGg5NZXRhZGF0YS5wcm90byKGAQoOU2VyaWFsaXplZEl0ZW0S",
            "CgoCaWQYASABKAUSDAoEbWV0YRgCIAEoBRINCgVjb3VudBgDIAEoDRJLCgpi",
            "aW5hcnlNZXRhGAQgASgLMjcub3JnLmRyYWdvbmV0LmNsb3VkbGFuZC5uZXQu",
            "cHJvdG9jb2wuU2VyaWFsaXplZE1ldGFkYXRhIi0KHENsaWVudEhvdGJhclNl",
            "bGVjdGlvbk1lc3NhZ2USDQoFaW5kZXgYASABKBEiKwoXQ2xpZW50UGlja1Vw",
            "SXRlbU1lc3NhZ2USEAoIZW50aXR5SWQYASABKARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Org.Dragonet.Cloudland.Net.Protocol.MetadataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.SerializedItem), global::Org.Dragonet.Cloudland.Net.Protocol.SerializedItem.Parser, new[]{ "Id", "Meta", "Count", "BinaryMeta" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ClientHotbarSelectionMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ClientHotbarSelectionMessage.Parser, new[]{ "Index" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ClientPickUpItemMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ClientPickUpItemMessage.Parser, new[]{ "EntityId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SerializedItem : pb::IMessage<SerializedItem> {
    private static readonly pb::MessageParser<SerializedItem> _parser = new pb::MessageParser<SerializedItem>(() => new SerializedItem());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SerializedItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InventoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedItem(SerializedItem other) : this() {
      id_ = other.id_;
      meta_ = other.meta_;
      count_ = other.count_;
      BinaryMeta = other.binaryMeta_ != null ? other.BinaryMeta.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SerializedItem Clone() {
      return new SerializedItem(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "meta" field.</summary>
    public const int MetaFieldNumber = 2;
    private int meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Meta {
      get { return meta_; }
      set {
        meta_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 3;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "binaryMeta" field.</summary>
    public const int BinaryMetaFieldNumber = 4;
    private global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata binaryMeta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata BinaryMeta {
      get { return binaryMeta_; }
      set {
        binaryMeta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SerializedItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SerializedItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Meta != other.Meta) return false;
      if (Count != other.Count) return false;
      if (!object.Equals(BinaryMeta, other.BinaryMeta)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Meta != 0) hash ^= Meta.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (binaryMeta_ != null) hash ^= BinaryMeta.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Meta != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Meta);
      }
      if (Count != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Count);
      }
      if (binaryMeta_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BinaryMeta);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Meta != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Meta);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (binaryMeta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BinaryMeta);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SerializedItem other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Meta != 0) {
        Meta = other.Meta;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.binaryMeta_ != null) {
        if (binaryMeta_ == null) {
          binaryMeta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
        }
        BinaryMeta.MergeFrom(other.BinaryMeta);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Meta = input.ReadInt32();
            break;
          }
          case 24: {
            Count = input.ReadUInt32();
            break;
          }
          case 34: {
            if (binaryMeta_ == null) {
              binaryMeta_ = new global::Org.Dragonet.Cloudland.Net.Protocol.SerializedMetadata();
            }
            input.ReadMessage(binaryMeta_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientHotbarSelectionMessage : pb::IMessage<ClientHotbarSelectionMessage> {
    private static readonly pb::MessageParser<ClientHotbarSelectionMessage> _parser = new pb::MessageParser<ClientHotbarSelectionMessage>(() => new ClientHotbarSelectionMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientHotbarSelectionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InventoryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHotbarSelectionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHotbarSelectionMessage(ClientHotbarSelectionMessage other) : this() {
      index_ = other.index_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHotbarSelectionMessage Clone() {
      return new ClientHotbarSelectionMessage(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientHotbarSelectionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientHotbarSelectionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(Index);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Index);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientHotbarSelectionMessage other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Index = input.ReadSInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientPickUpItemMessage : pb::IMessage<ClientPickUpItemMessage> {
    private static readonly pb::MessageParser<ClientPickUpItemMessage> _parser = new pb::MessageParser<ClientPickUpItemMessage>(() => new ClientPickUpItemMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientPickUpItemMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InventoryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPickUpItemMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPickUpItemMessage(ClientPickUpItemMessage other) : this() {
      entityId_ = other.entityId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPickUpItemMessage Clone() {
      return new ClientPickUpItemMessage(this);
    }

    /// <summary>Field number for the "entityId" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private ulong entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientPickUpItemMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientPickUpItemMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0UL) hash ^= EntityId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EntityId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EntityId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EntityId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientPickUpItemMessage other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0UL) {
        EntityId = other.EntityId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            EntityId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code