// Automatically generated by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky;

#nullable enable

public partial class SshCert: IDisposable
{
    private unsafe Raw.SshCert* _inner;

    public SshCertType CertType
    {
        get
        {
            return GetCertType();
        }
    }

    public string Comment
    {
        get
        {
            return GetComment();
        }
    }

    public string KeyId
    {
        get
        {
            return GetKeyId();
        }
    }

    public SshPublicKey PublicKey
    {
        get
        {
            return GetPublicKey();
        }
    }

    public SshPublicKey SignatureKey
    {
        get
        {
            return GetSignatureKey();
        }
    }

    public SshCertKeyType SshKeyType
    {
        get
        {
            return GetSshKeyType();
        }
    }

    public ulong ValidAfter
    {
        get
        {
            return GetValidAfter();
        }
    }

    public ulong ValidBefore
    {
        get
        {
            return GetValidBefore();
        }
    }

    /// <summary>
    /// Creates a managed <c>SshCert</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// </remarks>
    /// <remarks>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe SshCert(Raw.SshCert* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>SshCertBuilder</c> allocated on Rust side.
    /// </returns>
    public static SshCertBuilder Builder()
    {
        unsafe
        {
            Raw.SshCertBuilder* retVal = Raw.SshCert.Builder();
            return new SshCertBuilder(retVal);
        }
    }

    /// <summary>
    /// Parses string representation of a SSH Certificate.
    /// </summary>
    /// <exception cref="PickyException"></exception>
    /// <returns>
    /// A <c>SshCert</c> allocated on Rust side.
    /// </returns>
    public static SshCert Parse(string repr)
    {
        unsafe
        {
            byte[] reprBuf = DiplomatUtils.StringToUtf8(repr);
            nuint reprBufLength = (nuint)reprBuf.Length;
            fixed (byte* reprBufPtr = reprBuf)
            {
                IntPtr resultPtr = Raw.SshCert.Parse(reprBufPtr, reprBufLength);
                Raw.SshFfiResultBoxSshCertBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultBoxSshCertBoxPickyError>(resultPtr);
                Raw.SshFfiResultBoxSshCertBoxPickyError.Destroy(resultPtr);
                if (!result.isOk)
                {
                    throw new PickyException(new PickyError(result.Err));
                }
                Raw.SshCert* retVal = result.Ok;
                return new SshCert(retVal);
            }
        }
    }

    /// <summary>
    /// Returns the SSH Certificate string representation.
    /// </summary>
    /// <exception cref="PickyException"></exception>
    public void ToRepr(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            IntPtr resultPtr = Raw.SshCert.ToRepr(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <summary>
    /// Returns the SSH Certificate string representation.
    /// </summary>
    /// <exception cref="PickyException"></exception>
    public string ToRepr()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.SshCert.ToRepr(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            string retVal = writeable.ToUnicode();
            writeable.Dispose();
            return retVal;
        }
    }

    /// <returns>
    /// A <c>SshPublicKey</c> allocated on Rust side.
    /// </returns>
    public SshPublicKey GetPublicKey()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            Raw.SshPublicKey* retVal = Raw.SshCert.GetPublicKey(_inner);
            return new SshPublicKey(retVal);
        }
    }

    /// <returns>
    /// A <c>SshCertKeyType</c> allocated on C# side.
    /// </returns>
    public SshCertKeyType GetSshKeyType()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            Raw.SshCertKeyType retVal = Raw.SshCert.GetSshKeyType(_inner);
            return (SshCertKeyType)retVal;
        }
    }

    /// <returns>
    /// A <c>SshCertType</c> allocated on C# side.
    /// </returns>
    public SshCertType GetCertType()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            Raw.SshCertType retVal = Raw.SshCert.GetCertType(_inner);
            return (SshCertType)retVal;
        }
    }

    public ulong GetValidAfter()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            ulong retVal = Raw.SshCert.GetValidAfter(_inner);
            return retVal;
        }
    }

    public ulong GetValidBefore()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            ulong retVal = Raw.SshCert.GetValidBefore(_inner);
            return retVal;
        }
    }

    /// <returns>
    /// A <c>SshPublicKey</c> allocated on Rust side.
    /// </returns>
    public SshPublicKey GetSignatureKey()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            Raw.SshPublicKey* retVal = Raw.SshCert.GetSignatureKey(_inner);
            return new SshPublicKey(retVal);
        }
    }

    /// <exception cref="PickyException"></exception>
    public void GetKeyId(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            IntPtr resultPtr = Raw.SshCert.GetKeyId(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <exception cref="PickyException"></exception>
    public string GetKeyId()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.SshCert.GetKeyId(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            string retVal = writeable.ToUnicode();
            writeable.Dispose();
            return retVal;
        }
    }

    /// <exception cref="PickyException"></exception>
    public void GetComment(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            IntPtr resultPtr = Raw.SshCert.GetComment(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <exception cref="PickyException"></exception>
    public string GetComment()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("SshCert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.SshCert.GetComment(_inner, &writeable);
            Raw.SshFfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.SshFfiResultVoidBoxPickyError>(resultPtr);
            Raw.SshFfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            string retVal = writeable.ToUnicode();
            writeable.Dispose();
            return retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.SshCert* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.SshCert.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~SshCert()
    {
        Dispose();
    }
}
