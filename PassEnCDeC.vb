Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class PassEnCDeC
    Private ReadOnly _des As New TripleDESCryptoServiceProvider
    Private ReadOnly _uni As New UnicodeEncoding
    Private ReadOnly _key() As Byte
    Private ReadOnly _iv() As Byte

    Public Sub New(key() As Byte, iv() As Byte)
        _key = key
        _iv = iv
    End Sub

    Public Function Encrypt(input() As Byte) As Byte()
        Return CryptoTransform(input, _des.CreateEncryptor(_key, _iv))
    End Function

    Public Function Encrypt(text As String) As String
        Dim input() = _uni.GetBytes(text)
        Dim output() = CryptoTransform(input, _des.CreateEncryptor(_key, _iv))
        Return Convert.ToBase64String(output)
    End Function

    Public Function Decrypt(input() As Byte) As Byte()
        Return CryptoTransform(input, _des.CreateDecryptor(_key, _iv))
    End Function

    Public Function Decrypt(text As String) As String
        Dim input() = Convert.FromBase64String(text)
        Dim output() = CryptoTransform(input, _des.CreateDecryptor(_key, _iv))
        Return _uni.GetString(output)
    End Function

    Private Function CryptoTransform(input() As Byte, transform As ICryptoTransform) As Byte()
        Dim result As Byte()

        Using ms As New MemoryStream
            Using cs As New CryptoStream(ms, transform, CryptoStreamMode.Write)
                cs.Write(input, 0, input.Length)
                cs.FlushFinalBlock()
                ms.Position = 0
                result = ms.ToArray()
            End Using
        End Using

        Return result
    End Function
End Class
