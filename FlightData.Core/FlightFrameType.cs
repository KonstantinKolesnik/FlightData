namespace FlightData.Core
{

    public enum FlightFrameType : byte
    {
        OSD = 1,
        HOME = 2,
        GIMBAL = 3,
        RC = 4,
        CUSTOM = 5,
        DEFORM = 6,
        CENTER_BATTERY = 7,
        SMART_BATTERY = 8,
        APP_TIP = 9,
        APP_WARN = 10,
        RC_GPS = 11,
        RC_DEBUG = 12,
        RECOVER = 13,
        APP_GPS = 14,
        FIRMWARE = 15,
        OFDM_DEBUG = 16,
        VISION_GROUP = 17,
        VISION_WARN = 18,
        MC_PARAM = 19,
        APP_OPERATION = 20,
        OTHER = 254,
        END = 255
    }
}
