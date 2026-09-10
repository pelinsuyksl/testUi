using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testUi.Models
{
    public class AddDeviceDto
    {
        public int UserId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
    }
    public class DeleteDeviceDto
    {
        public int UserId { get; set; }
        public int DevNum { get; set; }
    }
    public class ListDevicesDto
    {
        public int UserId { get; set; }
    }
}