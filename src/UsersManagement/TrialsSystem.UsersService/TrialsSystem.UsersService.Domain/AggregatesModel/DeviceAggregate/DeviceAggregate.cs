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

        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public DeviceType Type { get; set; }
        public string FirmwareVersion { get; set; }
    }
}
