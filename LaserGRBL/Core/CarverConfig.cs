//Copyright (c) 2016-2021 Diego Settimi - https://github.com/arkypita/

using System.Net;

namespace LaserGRBL
{
    public class CarverConfig
    {
        public string PcIP { get; set; } = "172.31.1.130";
        public int PcPort { get; set; } = 30001;
        public CarverConfig()
        {
        }
    }
}