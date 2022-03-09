// This file was generated by Tmds.DBus.Tool.
// Bluetoothctl was used to connect to a Bluetooth Low Energy device, then `dotnet dbus codegen --bus system --service org.bluez` was executed.
// After code generation, some `ObjectPath`s were manually replaced with the right interface types.
// For more context, see https://developers.redhat.com/blog/2017/09/18/connecting-net-core-d-bus/ or https://github.com/tmds/Tmds.DBus

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Tmds.DBus;

[assembly: InternalsVisibleTo(Connection.DynamicAssemblyName)]

namespace ProrepubliQ.DotNetBlueZ
{
    [DBusInterface("org.freedesktop.DBus.ObjectManager")]
    public interface IObjectManager : IDBusObject
    {
        Task<IDictionary<ObjectPath, IDictionary<string, IDictionary<string, object>>>> GetManagedObjectsAsync();

        Task<IDisposable> WatchInterfacesAddedAsync(
            Action<(ObjectPath @object, IDictionary<string, IDictionary<string, object>> interfaces)> handler,
            Action<Exception> onError = null);

        Task<IDisposable> WatchInterfacesRemovedAsync(Action<(ObjectPath @object, string[] interfaces)> handler,
            Action<Exception> onError = null);
    }

    [DBusInterface("org.bluez.AgentManager1")]
    public interface IAgentManager1 : IDBusObject
    {
        Task RegisterAgentAsync(ObjectPath Agent, string Capability);
        Task UnregisterAgentAsync(ObjectPath Agent);
        Task RequestDefaultAgentAsync(ObjectPath Agent);
    }

    [DBusInterface("org.bluez.ProfileManager1")]
    public interface IProfileManager1 : IDBusObject
    {
        Task RegisterProfileAsync(ObjectPath Profile, string UUID, IDictionary<string, object> Options);
        Task UnregisterProfileAsync(ObjectPath Profile);
    }

    [DBusInterface("org.bluez.Adapter1")]
    public interface IAdapter1 : IDBusObject
    {
        Task StartDiscoveryAsync();
        Task SetDiscoveryFilterAsync(IDictionary<string, object> Properties);
        Task StopDiscoveryAsync();
        Task RemoveDeviceAsync(ObjectPath Device);
        Task<string[]> GetDiscoveryFiltersAsync();
        Task<T> GetAsync<T>(string prop);
        Task<Adapter1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
        Task ConnectDeviceAsync(IDictionary<string, object> Properties);

    }

    [Dictionary]
    public class Adapter1Properties
    {
        public string Address { get; set; } = default;

        public string AddressType { get; set; } = default;

        public string Name { get; set; } = default;

        public string Alias { get; set; } = default;

        public uint Class { get; set; } = default;

        public bool Powered { get; set; } = default;

        public bool Discoverable { get; set; } = default;

        public uint DiscoverableTimeout { get; set; } = default;

        public bool Pairable { get; set; } = default;

        public uint PairableTimeout { get; set; } = default;

        public bool Discovering { get; set; } = default;

        public string[] UUIDs { get; set; } = default;

        public string Modalias { get; set; } = default;
    }

    public static class Adapter1Extensions
    {
        public static Task<string> GetAddressAsync(this IAdapter1 o)
        {
            return o.GetAsync<string>("Address");
        }

        public static Task<string> GetAddressTypeAsync(this IAdapter1 o)
        {
            return o.GetAsync<string>("AddressType");
        }

        public static Task<string> GetNameAsync(this IAdapter1 o)
        {
            return o.GetAsync<string>("Name");
        }

        public static Task<string> GetAliasAsync(this IAdapter1 o)
        {
            return o.GetAsync<string>("Alias");
        }

        public static Task<uint> GetClassAsync(this IAdapter1 o)
        {
            return o.GetAsync<uint>("Class");
        }

        public static Task<bool> GetPoweredAsync(this IAdapter1 o)
        {
            return o.GetAsync<bool>("Powered");
        }

        public static Task<bool> GetDiscoverableAsync(this IAdapter1 o)
        {
            return o.GetAsync<bool>("Discoverable");
        }

        public static Task<uint> GetDiscoverableTimeoutAsync(this IAdapter1 o)
        {
            return o.GetAsync<uint>("DiscoverableTimeout");
        }

        public static Task<bool> GetPairableAsync(this IAdapter1 o)
        {
            return o.GetAsync<bool>("Pairable");
        }

        public static Task<uint> GetPairableTimeoutAsync(this IAdapter1 o)
        {
            return o.GetAsync<uint>("PairableTimeout");
        }

        public static Task<bool> GetDiscoveringAsync(this IAdapter1 o)
        {
            return o.GetAsync<bool>("Discovering");
        }

        public static Task<string[]> GetUUIDsAsync(this IAdapter1 o)
        {
            return o.GetAsync<string[]>("UUIDs");
        }

        public static Task<string> GetModaliasAsync(this IAdapter1 o)
        {
            return o.GetAsync<string>("Modalias");
        }

        public static Task SetAliasAsync(this IAdapter1 o, string val)
        {
            return o.SetAsync("Alias", val);
        }

        public static Task SetPoweredAsync(this IAdapter1 o, bool val)
        {
            return o.SetAsync("Powered", val);
        }

        public static Task SetDiscoverableAsync(this IAdapter1 o, bool val)
        {
            return o.SetAsync("Discoverable", val);
        }

        public static Task SetDiscoverableTimeoutAsync(this IAdapter1 o, uint val)
        {
            return o.SetAsync("DiscoverableTimeout", val);
        }

        public static Task SetPairableAsync(this IAdapter1 o, bool val)
        {
            return o.SetAsync("Pairable", val);
        }

        public static Task SetPairableTimeoutAsync(this IAdapter1 o, uint val)
        {
            return o.SetAsync("PairableTimeout", val);
        }
    }

    [DBusInterface("org.bluez.GattManager1")]
    public interface IGattManager1 : IDBusObject
    {
        Task RegisterApplicationAsync(ObjectPath Application, IDictionary<string, object> Options);
        Task UnregisterApplicationAsync(ObjectPath Application);
    }

    [DBusInterface("org.bluez.LEAdvertisingManager1")]
    public interface ILEAdvertisingManager1 : IDBusObject
    {
        Task RegisterAdvertisementAsync(ObjectPath Advertisement, IDictionary<string, object> Options);
        Task UnregisterAdvertisementAsync(ObjectPath Service);
        Task<T> GetAsync<T>(string prop);
        Task<LEAdvertisingManager1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class LEAdvertisingManager1Properties
    {
        public byte ActiveInstances { get; set; } = default;

        public byte SupportedInstances { get; set; } = default;

        public string[] SupportedIncludes { get; set; } = default;
    }

    public static class LEAdvertisingManager1Extensions
    {
        public static Task<byte> GetActiveInstancesAsync(this ILEAdvertisingManager1 o)
        {
            return o.GetAsync<byte>("ActiveInstances");
        }

        public static Task<byte> GetSupportedInstancesAsync(this ILEAdvertisingManager1 o)
        {
            return o.GetAsync<byte>("SupportedInstances");
        }

        public static Task<string[]> GetSupportedIncludesAsync(this ILEAdvertisingManager1 o)
        {
            return o.GetAsync<string[]>("SupportedIncludes");
        }
    }

    [DBusInterface("org.bluez.Media1")]
    public interface IMedia1 : IDBusObject
    {
        Task RegisterEndpointAsync(ObjectPath Endpoint, IDictionary<string, object> Properties);
        Task UnregisterEndpointAsync(ObjectPath Endpoint);
        Task RegisterPlayerAsync(ObjectPath Player, IDictionary<string, object> Properties);
        Task UnregisterPlayerAsync(ObjectPath Player);
    }

    [DBusInterface("org.bluez.NetworkServer1")]
    public interface INetworkServer1 : IDBusObject
    {
        Task RegisterAsync(string Uuid, string Bridge);
        Task UnregisterAsync(string Uuid);
    }

    [DBusInterface("org.bluez.Device1")]
    public interface IDevice1 : IDBusObject
    {
        Task DisconnectAsync();
        Task ConnectAsync();
        Task ConnectProfileAsync(string UUID);
        Task DisconnectProfileAsync(string UUID);
        Task PairAsync();
        Task CancelPairingAsync();
        Task<T> GetAsync<T>(string prop);
        Task<Device1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class Device1Properties
    {
        public string Address { get; set; } = default;

        public string AddressType { get; set; } = default;

        public string Name { get; set; } = default;

        public string Alias { get; set; } = default;

        public uint Class { get; set; } = default;

        public ushort Appearance { get; set; } = default;

        public string Icon { get; set; } = default;

        public bool Paired { get; set; } = default;

        public bool Trusted { get; set; } = default;

        public bool Blocked { get; set; } = default;

        public bool LegacyPairing { get; set; } = default;

        public short RSSI { get; set; } = default;

        public bool Connected { get; set; } = default;

        public string[] UUIDs { get; set; } = default;

        public string Modalias { get; set; } = default;

        public ObjectPath Adapter { get; set; } = default;

        public IDictionary<ushort, object> ManufacturerData { get; set; } = default;

        public IDictionary<string, object> ServiceData { get; set; } = default;

        public short TxPower { get; set; } = default;

        public bool ServicesResolved { get; set; } = default;
    }

    public static class Device1Extensions
    {
        public static Task<string> GetAddressAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("Address");
        }

        public static Task<string> GetAddressTypeAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("AddressType");
        }

        public static Task<string> GetNameAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("Name");
        }

        public static Task<string> GetAliasAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("Alias");
        }

        public static Task<uint> GetClassAsync(this IDevice1 o)
        {
            return o.GetAsync<uint>("Class");
        }

        public static Task<ushort> GetAppearanceAsync(this IDevice1 o)
        {
            return o.GetAsync<ushort>("Appearance");
        }

        public static Task<string> GetIconAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("Icon");
        }

        public static Task<bool> GetPairedAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("Paired");
        }

        public static Task<bool> GetTrustedAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("Trusted");
        }

        public static Task<bool> GetBlockedAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("Blocked");
        }

        public static Task<bool> GetLegacyPairingAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("LegacyPairing");
        }

        public static Task<short> GetRSSIAsync(this IDevice1 o)
        {
            return o.GetAsync<short>("RSSI");
        }

        public static Task<bool> GetConnectedAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("Connected");
        }

        public static Task<string[]> GetUUIDsAsync(this IDevice1 o)
        {
            return o.GetAsync<string[]>("UUIDs");
        }

        public static Task<string> GetModaliasAsync(this IDevice1 o)
        {
            return o.GetAsync<string>("Modalias");
        }

        public static Task<IAdapter1> GetAdapterAsync(this IDevice1 o)
        {
            return o.GetAsync<IAdapter1>("Adapter");
        }

        public static Task<IDictionary<ushort, object>> GetManufacturerDataAsync(this IDevice1 o)
        {
            return o.GetAsync<IDictionary<ushort, object>>("ManufacturerData");
        }

        public static Task<IDictionary<string, object>> GetServiceDataAsync(this IDevice1 o)
        {
            return o.GetAsync<IDictionary<string, object>>("ServiceData");
        }

        public static Task<short> GetTxPowerAsync(this IDevice1 o)
        {
            return o.GetAsync<short>("TxPower");
        }

        public static Task<bool> GetServicesResolvedAsync(this IDevice1 o)
        {
            return o.GetAsync<bool>("ServicesResolved");
        }

        public static Task SetAliasAsync(this IDevice1 o, string val)
        {
            return o.SetAsync("Alias", val);
        }

        public static Task SetTrustedAsync(this IDevice1 o, bool val)
        {
            return o.SetAsync("Trusted", val);
        }

        public static Task SetBlockedAsync(this IDevice1 o, bool val)
        {
            return o.SetAsync("Blocked", val);
        }
    }

    [DBusInterface("org.bluez.Battery1")]
    public interface IBattery1 : IDBusObject
    {
        Task<T> GetAsync<T>(string prop);
        Task<Battery1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class Battery1Properties
    {
        public byte Percentage { get; set; } = default;
    }

    public static class Battery1Extensions
    {
        public static Task<byte> GetPercentageAsync(this IBattery1 o)
        {
            return o.GetAsync<byte>("Percentage");
        }
    }

    [DBusInterface("org.bluez.GattService1")]
    public interface IGattService1 : IDBusObject
    {
        Task<T> GetAsync<T>(string prop);
        Task<GattService1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class GattService1Properties
    {
        public string UUID { get; set; } = default;

        public ObjectPath Device { get; set; } = default;

        public bool Primary { get; set; } = default;

        public ObjectPath[] Includes { get; set; } = default;
    }

    public static class GattService1Extensions
    {
        public static Task<string> GetUUIDAsync(this IGattService1 o)
        {
            return o.GetAsync<string>("UUID");
        }

        public static Task<IDevice1> GetDeviceAsync(this IGattService1 o)
        {
            return o.GetAsync<IDevice1>("Device");
        }

        public static Task<bool> GetPrimaryAsync(this IGattService1 o)
        {
            return o.GetAsync<bool>("Primary");
        }

        public static Task<ObjectPath[]> GetIncludesAsync(this IGattService1 o)
        {
            return o.GetAsync<ObjectPath[]>("Includes");
        }
    }

    [DBusInterface("org.bluez.GattCharacteristic1")]
    public interface IGattCharacteristic1 : IDBusObject
    {
        Task<byte[]> ReadValueAsync(IDictionary<string, object> Options);
        Task WriteValueAsync(byte[] Value, IDictionary<string, object> Options);
        Task<(CloseSafeHandle fd, ushort mtu)> AcquireWriteAsync(IDictionary<string, object> Options);
        Task<(CloseSafeHandle fd, ushort mtu)> AcquireNotifyAsync(IDictionary<string, object> Options);
        Task StartNotifyAsync();
        Task StopNotifyAsync();
        Task<T> GetAsync<T>(string prop);
        Task<GattCharacteristic1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class GattCharacteristic1Properties
    {
        public string UUID { get; set; } = default;

        public ObjectPath Service { get; set; } = default;

        public byte[] Value { get; set; } = default;

        public bool Notifying { get; set; } = default;

        public string[] Flags { get; set; } = default;

        public bool WriteAcquired { get; set; } = default;

        public bool NotifyAcquired { get; set; } = default;
    }

    public static class GattCharacteristic1Extensions
    {
        public static Task<string> GetUUIDAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<string>("UUID");
        }

        public static Task<IGattService1> GetServiceAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<IGattService1>("Service");
        }

        public static Task<byte[]> GetValueAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<byte[]>("Value");
        }

        public static Task<bool> GetNotifyingAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<bool>("Notifying");
        }

        public static Task<string[]> GetFlagsAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<string[]>("Flags");
        }

        public static Task<bool> GetWriteAcquiredAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<bool>("WriteAcquired");
        }

        public static Task<bool> GetNotifyAcquiredAsync(this IGattCharacteristic1 o)
        {
            return o.GetAsync<bool>("NotifyAcquired");
        }
    }

    [DBusInterface("org.bluez.GattDescriptor1")]
    public interface IGattDescriptor1 : IDBusObject
    {
        Task<byte[]> ReadValueAsync(IDictionary<string, object> Options);
        Task WriteValueAsync(byte[] Value, IDictionary<string, object> Options);
        Task<T> GetAsync<T>(string prop);
        Task<GattDescriptor1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class GattDescriptor1Properties
    {
        public string UUID { get; set; } = default;

        public ObjectPath Characteristic { get; set; } = default;

        public byte[] Value { get; set; } = default;
    }

    public static class GattDescriptor1Extensions
    {
        public static Task<string> GetUUIDAsync(this IGattDescriptor1 o)
        {
            return o.GetAsync<string>("UUID");
        }

        public static Task<IGattCharacteristic1> GetCharacteristicAsync(this IGattDescriptor1 o)
        {
            return o.GetAsync<IGattCharacteristic1>("Characteristic");
        }

        public static Task<byte[]> GetValueAsync(this IGattDescriptor1 o)
        {
            return o.GetAsync<byte[]>("Value");
        }
    }

    [DBusInterface("org.bluez.MediaControl1")]
    public interface IMediaControl1 : IDBusObject
    {
        Task PlayAsync();
        Task PauseAsync();
        Task StopAsync();
        Task NextAsync();
        Task PreviousAsync();
        Task VolumeUpAsync();
        Task VolumeDownAsync();
        Task FastForwardAsync();
        Task RewindAsync();
        Task<T> GetAsync<T>(string prop);
        Task<MediaControl1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    public class MediaControl1Properties
    {
        public bool Connected { get; set; } = default;

        public ObjectPath Player { get; set; } = default;
    }

    public static class MediaControl1Extensions
    {
        public static Task<bool> GetConnectedAsync(this IMediaControl1 o)
        {
            return o.GetAsync<bool>("Connected");
        }

        public static Task<ObjectPath> GetPlayerAsync(this IMediaControl1 o)
        {
            return o.GetAsync<ObjectPath>("Player");
        }
    }
}