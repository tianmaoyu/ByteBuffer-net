﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBuffer
{

    /// <summary>
    /// 契约
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class BtyeContract : Attribute { }

    /// <summary>
    /// 成员
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ByteMember : Attribute
    {
        public int Order { get; set; }

        public ByteType ByteType { get; set; }

        public string TypeName { get; set; }
        public ByteMember(int order, ByteType tyteType,string typeName=null)
        {
            this.Order = order;
            this.ByteType = tyteType;
            this.TypeName = typeName;
        }
    }


    /// <summary>
    /// 类型  参考 TypeCode
    /// </summary>
    public enum ByteType
    {

        Bool=0,
        /// <summary>
        /// byte 无符号 8 位整数  0 到 255
        /// </summary>
        Int8 = 1,

        /// <summary>
        /// sbyte :-128 到 127  有符号 8 位整数
        /// </summary>
        UInt8 = 2,

        /// <summary>
        /// short 有符号 16 位整数  -32,768 到 32,767
        /// </summary>
        Int16 = 3,
        /// <summary>
        /// ushort 无符号 16 位整数  0 到 65,535
        /// </summary>
        UInt16 = 4,

       

        /// <summary>
        ///int 有符号 32 位整数  -2,147,483,648 到 2,147,483,647
        /// </summary>
        Int32 = 5,

        /// <summary>
        ///uint 无符号 32 位整数  0 到 4,294,967,295
        /// </summary>
        UInt32 = 6,

        /// <summary>
        /// 32 为 带小数类型 float
        /// </summary>
        Float32 = 7,
        /// <summary>
        /// 64 为 带 小数 类型  double
        /// </summary>
        Int64 = 8,

        String = 9,
        Object = 10,

        BoolArray=19,
        //数组
        Int8Array = 20,

        UInt8Array = 21,

        Int16Array = 23,

        UInt16Array = 24,

        Int32Array = 25,

        UInt32Array = 26,

        Float32Array = 27,

        Float64Array = 28,

        StringArray = 29,

        /// <summary>
        /// 使用这个时 一定要传第三个参数
        /// </summary>
        ObjectArray = 30,

        //新增int24
        Int24 = 31,
        UInt24 = 32,
        Int24Array = 33,
        UInt24Array = 34,

    }

}
