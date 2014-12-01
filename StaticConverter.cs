 public enum ByteUnits:byte
    {
        Bytes=0, KBytes=1,MBytes=2,GBytes=3,TBytes=4,PBytes=5
    }

    public enum BitUnits:byte
    {
        Bits=0, KBits=1, MBits=2, GBits=3, TBits=4, PBits=5
    }

    public static class Ext
    {
        public static long Convert(this ByteUnits bu,int size)
        {
            return StaticConverter.ConvertToBytes(size, bu);
        }
    }
    public static class StaticConverter
    {
  
        public static long ConvertToBytes(int size, ByteUnits targetUnits, ByteUnits sourceUnits= ByteUnits.Bytes)
        {
            byte pow = (byte)((byte)targetUnits - (byte)sourceUnits);
            return (long)(size*Math.Pow(1024, pow));
        }

        public static long MB(int size)
        {
            return ConvertToBytes(size, ByteUnits.MBytes);
        }

        public static long KB(int size)
        {
            return ConvertToBytes(size, ByteUnits.KBytes);

        }

        public static long GB(int size)
        {
            return ConvertToBytes(size, ByteUnits.GBytes);
        }

        public static long TB(int size)
        {
            return ConvertToBytes(size, ByteUnits.TBytes);
        }

    }
