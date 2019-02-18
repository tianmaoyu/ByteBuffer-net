﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
namespace BufferWriteAndRead
{
    public partial class CreateMsg
    {
        public byte[] Write()
        {
            var buffer = new byte[32];
            var offset = 0;
            foreach (var _byte in BitConverter.GetBytes(Convert.ToUInt16(this.UInt16)))
            {
                buffer[offset] = _byte;
                offset += 1;
            }
            buffer[offset] = Convert.ToByte(this.Char);
            offset += 1;
            buffer[offset] = Convert.ToByte(this.Bool);
            offset += 1;
            foreach (var _byte in BitConverter.GetBytes(Convert.ToInt16(this.Int16)))
            {
                buffer[offset] = _byte;
                offset += 1;
            }
            foreach (var _byte in BitConverter.GetBytes(this.Float))
            {
                buffer[offset] = _byte;
                offset += 1;
            }
            buffer[offset] = Convert.ToByte(this.Byte);
            offset += 1;
            buffer[offset] = Convert.ToByte(this.SByte);
            offset += 1;
            foreach (var _byte in BitConverter.GetBytes(Convert.ToUInt16(this.UShort)))
            {
                buffer[offset] = _byte;
                offset += 1;
            }
            var nameBytes = Encoding.UTF8.GetBytes(this.Name);
            buffer[offset] = (byte)nameBytes.Length;
            offset += 1;
            foreach (var _byte in nameBytes)
            {
                buffer[offset] = _byte;
                offset += 1;
            }
            return buffer;
        }
        public static CreateMsg Read(byte[] buffer, int offset)
        {
            var msg = new CreateMsg();
            msg.UInt16 = BitConverter.ToUInt16(buffer, offset);
            offset += 2;
            msg.Char = (Char)buffer[offset];
            offset++;
            msg.Bool = buffer[offset] == 1;
            offset++;
            msg.Int16 = BitConverter.ToInt16(buffer, offset);
            offset += 2;
            msg.Float = BitConverter.ToSingle(buffer, offset);
            offset += 4;
            msg.Byte = (Byte)buffer[offset];
            offset++;
            msg.SByte = (SByte)buffer[offset];
            offset++;
            msg.UShort = BitConverter.ToUInt16(buffer, offset);
            offset += 2;
            var strLength = buffer[offset];
            offset++;
            msg.Name = BitConverter.ToString(buffer, offset, strLength);
            offset += 8;
            return msg;
        }
    }
}