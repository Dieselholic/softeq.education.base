namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    public class DeviceAggregate
    {
        public DeviceAggregate(string id, string serialNumber, string model, DeviceType type, string firmwareVersion)
        {
            Id = id;
            SerialNumber = serialNumber;
            Model = model;
            Type = type;
            FirmwareVersion = firmwareVersion;
        }

        public string Id { get; private set; }
        public string SerialNumber { get; private set; }
        public string Model { get; private set; }
        public DeviceType Type { get; private set; }
        public string FirmwareVersion { get; private set; }
    }
}
