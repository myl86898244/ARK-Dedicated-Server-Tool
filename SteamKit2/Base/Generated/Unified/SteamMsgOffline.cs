//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_offline.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetOfflineLogonTicket_Request")]
  public partial class COffline_GetOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
  {
    public COffline_GetOfflineLogonTicket_Request() {}
    

    private uint _priority = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetOfflineLogonTicket_Response")]
  public partial class COffline_GetOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
  {
    public COffline_GetOfflineLogonTicket_Response() {}
    

    private byte[] _serialized_ticket = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serialized_ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] serialized_ticket
    {
      get { return _serialized_ticket; }
      set { _serialized_ticket = value; }
    }

    private byte[] _signature = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] signature
    {
      get { return _signature; }
      set { _signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetUnsignedOfflineLogonTicket_Request")]
  public partial class COffline_GetUnsignedOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
  {
    public COffline_GetUnsignedOfflineLogonTicket_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_OfflineLogonTicket")]
  public partial class COffline_OfflineLogonTicket : global::ProtoBuf.IExtensible
  {
    public COffline_OfflineLogonTicket() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private uint _rtime32_creation_time = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rtime32_creation_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rtime32_creation_time
    {
      get { return _rtime32_creation_time; }
      set { _rtime32_creation_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetUnsignedOfflineLogonTicket_Response")]
  public partial class COffline_GetUnsignedOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
  {
    public COffline_GetUnsignedOfflineLogonTicket_Response() {}
    

    private COffline_OfflineLogonTicket _ticket = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public COffline_OfflineLogonTicket ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IOffline
    {
      COffline_GetOfflineLogonTicket_Response GetOfflineLogonTicket(COffline_GetOfflineLogonTicket_Request request);
    COffline_GetUnsignedOfflineLogonTicket_Response GetUnsignedOfflineLogonTicket(COffline_GetUnsignedOfflineLogonTicket_Request request);
    
    }
    
    
}
#pragma warning restore 1591
