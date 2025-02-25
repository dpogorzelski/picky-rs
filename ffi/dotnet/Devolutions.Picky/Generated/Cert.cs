// Automatically generated by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky;

#nullable enable

public partial class Cert: IDisposable
{
    private unsafe Raw.Cert* _inner;

    public CertType CertType
    {
        get
        {
            return GetCertType();
        }
    }

    public string IssuerName
    {
        get
        {
            return GetIssuerName();
        }
    }

    public PublicKey PublicKey
    {
        get
        {
            return GetPublicKey();
        }
    }

    public string SubjectKeyIdHex
    {
        get
        {
            return GetSubjectKeyIdHex();
        }
    }

    public string SubjectName
    {
        get
        {
            return GetSubjectName();
        }
    }

    public CertType Ty
    {
        get
        {
            return GetTy();
        }
    }

    public UtcDate ValidNotAfter
    {
        get
        {
            return GetValidNotAfter();
        }
    }

    public UtcDate ValidNotBefore
    {
        get
        {
            return GetValidNotBefore();
        }
    }

    /// <summary>
    /// Creates a managed <c>Cert</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// </remarks>
    /// <remarks>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe Cert(Raw.Cert* handle)
    {
        _inner = handle;
    }

    /// <summary>
    /// Parses a X509 certificate from its DER representation.
    /// </summary>
    /// <exception cref="PickyException"></exception>
    /// <returns>
    /// A <c>Cert</c> allocated on Rust side.
    /// </returns>
    public static Cert FromDer(byte[] der)
    {
        unsafe
        {
            nuint derLength = (nuint)der.Length;
            fixed (byte* derPtr = der)
            {
                IntPtr resultPtr = Raw.Cert.FromDer(derPtr, derLength);
                Raw.X509FfiResultBoxCertBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultBoxCertBoxPickyError>(resultPtr);
                Raw.X509FfiResultBoxCertBoxPickyError.Destroy(resultPtr);
                if (!result.isOk)
                {
                    throw new PickyException(new PickyError(result.Err));
                }
                Raw.Cert* retVal = result.Ok;
                return new Cert(retVal);
            }
        }
    }

    /// <summary>
    /// Extracts X509 certificate from PEM object.
    /// </summary>
    /// <exception cref="PickyException"></exception>
    /// <returns>
    /// A <c>Cert</c> allocated on Rust side.
    /// </returns>
    public static Cert FromPem(Pem pem)
    {
        unsafe
        {
            Raw.Pem* pemRaw;
            pemRaw = pem.AsFFI();
            if (pemRaw == null)
            {
                throw new ObjectDisposedException("Pem");
            }
            IntPtr resultPtr = Raw.Cert.FromPem(pemRaw);
            Raw.X509FfiResultBoxCertBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultBoxCertBoxPickyError>(resultPtr);
            Raw.X509FfiResultBoxCertBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            Raw.Cert* retVal = result.Ok;
            return new Cert(retVal);
        }
    }

    /// <summary>
    /// Exports the X509 certificate into a PEM object
    /// </summary>
    /// <exception cref="PickyException"></exception>
    /// <returns>
    /// A <c>Pem</c> allocated on Rust side.
    /// </returns>
    public Pem ToPem()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            IntPtr resultPtr = Raw.Cert.ToPem(_inner);
            Raw.X509FfiResultBoxPemBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultBoxPemBoxPickyError>(resultPtr);
            Raw.X509FfiResultBoxPemBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            Raw.Pem* retVal = result.Ok;
            return new Pem(retVal);
        }
    }

    /// <returns>
    /// A <c>CertType</c> allocated on C# side.
    /// </returns>
    public CertType GetTy()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            Raw.CertType retVal = Raw.Cert.GetTy(_inner);
            return (CertType)retVal;
        }
    }

    /// <returns>
    /// A <c>PublicKey</c> allocated on Rust side.
    /// </returns>
    public PublicKey GetPublicKey()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            Raw.PublicKey* retVal = Raw.Cert.GetPublicKey(_inner);
            return new PublicKey(retVal);
        }
    }

    /// <returns>
    /// A <c>CertType</c> allocated on C# side.
    /// </returns>
    public CertType GetCertType()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            Raw.CertType retVal = Raw.Cert.GetCertType(_inner);
            return (CertType)retVal;
        }
    }

    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public UtcDate GetValidNotBefore()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            Raw.UtcDate* retVal = Raw.Cert.GetValidNotBefore(_inner);
            return new UtcDate(retVal);
        }
    }

    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public UtcDate GetValidNotAfter()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            Raw.UtcDate* retVal = Raw.Cert.GetValidNotAfter(_inner);
            return new UtcDate(retVal);
        }
    }

    /// <exception cref="PickyException"></exception>
    public void GetSubjectKeyIdHex(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            IntPtr resultPtr = Raw.Cert.GetSubjectKeyIdHex(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <exception cref="PickyException"></exception>
    public string GetSubjectKeyIdHex()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.Cert.GetSubjectKeyIdHex(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
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
    public void GetSubjectName(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            IntPtr resultPtr = Raw.Cert.GetSubjectName(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <exception cref="PickyException"></exception>
    public string GetSubjectName()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.Cert.GetSubjectName(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
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
    public void GetIssuerName(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            IntPtr resultPtr = Raw.Cert.GetIssuerName(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
        }
    }

    /// <exception cref="PickyException"></exception>
    public string GetIssuerName()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("Cert");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            IntPtr resultPtr = Raw.Cert.GetIssuerName(_inner, &writeable);
            Raw.X509FfiResultVoidBoxPickyError result = Marshal.PtrToStructure<Raw.X509FfiResultVoidBoxPickyError>(resultPtr);
            Raw.X509FfiResultVoidBoxPickyError.Destroy(resultPtr);
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
    public unsafe Raw.Cert* AsFFI()
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

            Raw.Cert.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~Cert()
    {
        Dispose();
    }
}
