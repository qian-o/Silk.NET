// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546")]
    [NativeName("Name", "IDirect3DVertexDeclaration9")]
    public unsafe partial struct IDirect3DVertexDeclaration9 : IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dd13c59c-36fa-4098-a8fb-c7ed39dc8546");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVertexDeclaration9 val)
            => Unsafe.As<IDirect3DVertexDeclaration9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVertexDeclaration9
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* pElement, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElements);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(Vertexelement9* pElement, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumElementsPtr = &pNumElements)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElementsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeclaration(ref Vertexelement9 pElement, uint* pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pElementPtr = &pElement)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElementPtr, pNumElements);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeclaration(ref Vertexelement9 pElement, ref uint pNumElements)
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Vertexelement9* pElementPtr = &pElement)
            {
                fixed (uint* pNumElementsPtr = &pNumElements)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElementPtr, pNumElementsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVertexDeclaration9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
