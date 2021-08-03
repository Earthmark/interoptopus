// Automatically generated by Interoptopus.

// Debug - write_imports 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using My.Company;
using My.Company;
using My.Company.Common;

// Debug - write_namespace_context 
namespace My.Company
{

    // Debug - write_type_definition_composite 
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FFISliceFFIBool
    {
        IntPtr data;
        ulong len;
    }

    // Debug - write_pattern_slice 
    public partial struct FFISliceFFIBool : IEnumerable<FFIBool>
    {
        public FFISliceFFIBool(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public FFIBool this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(FFIBool));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                return Marshal.PtrToStructure<FFIBool>(ptr);
            }
        }
        public FFIBool[] Copied
        {
            get
            {
                var rval = new FFIBool[len];
                for (var i = 0; i < (int) len; i++) {
                    rval[i] = this[i];
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<FFIBool> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    // Debug - write_type_definition_composite 
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FFISliceu32
    {
        IntPtr data;
        ulong len;
    }

    // Debug - write_pattern_slice 
    public partial struct FFISliceu32 : IEnumerable<uint>
    {
        public FFISliceu32(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public uint this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(uint));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                return Marshal.PtrToStructure<uint>(ptr);
            }
        }
        public uint[] Copied
        {
            get
            {
                var rval = new uint[len];
                for (var i = 0; i < (int) len; i++) {
                    rval[i] = this[i];
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<uint> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    // Debug - write_type_definition_composite 
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FFISliceu8
    {
        IntPtr data;
        ulong len;
    }

    // Debug - write_pattern_slice 
    public partial struct FFISliceu8 : IEnumerable<byte>
    {
        public FFISliceu8(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public byte this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(byte));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                return Marshal.PtrToStructure<byte>(ptr);
            }
        }
        public byte[] Copied
        {
            get
            {
                var rval = new byte[len];
                for (var i = 0; i < (int) len; i++) {
                    rval[i] = this[i];
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<byte> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    // Debug - write_type_definition_composite 
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FFISliceMutu8
    {
        IntPtr data;
        ulong len;
    }

    // Debug - write_pattern_slice_mut 
    public partial struct FFISliceMutu8 : IEnumerable<byte>
    {
        public FFISliceMutu8(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public byte this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(byte));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                return Marshal.PtrToStructure<byte>(ptr);
            }
            set
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                var size = Marshal.SizeOf(typeof(byte));
                var ptr = new IntPtr(data.ToInt64() + i * size);
                Marshal.StructureToPtr<byte>(value, ptr, false);
            }
        }
        public byte[] Copied
        {
            get
            {
                var rval = new byte[len];
                for (var i = 0; i < (int) len; i++) {
                    rval[i] = this[i];
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<byte> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    // Debug - write_type_definition_ffibool 
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FFIBool
    {
        public static readonly FFIBool True = new FFIBool { value =  1 };
        public static readonly FFIBool False = new FFIBool { value =  0 };
        byte value;
        public bool Is => value == 1;
    }


    // Debug - write_type_definition_named_callback 
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte CallbackFFISlice(FFISliceu8 x0);

    // Debug - write_type_definition_named_callback 
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate Vec3f32 CallbackHugeVecSlice(FFISliceVec3f32 x0);

    // Debug - write_type_definition_named_callback 
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CallbackSliceMut(FFISliceMutu8 x0);

    // Debug - write_type_definition_named_callback 
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint MyCallback(uint x0);


}