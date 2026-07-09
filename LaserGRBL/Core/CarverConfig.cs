//Copyright (c) 2016-2021 Diego Settimi - https://github.com/arkypita/

using System.Net;

namespace LaserGRBL
{
    public class CarverConfig
    {
        public string PcIP { get; set; } = "127.0.0.1";
        public int PcPort { get; set; } = 30002;
        public static LaserCommand laserCommand { get; set; }
        public CarverConfig()
        {
        }
    }
}