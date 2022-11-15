<a name='assembly'></a>
# SweetLib

## Contents

- [BaseTypeExtensions](#T-SweetLib-Utils-Extensions-BaseTypeExtensions 'SweetLib.Utils.Extensions.BaseTypeExtensions')
  - [AsBool(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBool-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBool(System.Byte[])')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int16- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Int16)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt16- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.UInt16)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int32- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Int32)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt32- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.UInt32)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int64- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Int64)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt64- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.UInt64)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Single- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Single)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Double- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Double)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Boolean- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Boolean)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-DateTime- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.DateTime)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-String- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.String)')
  - [AsBytes(value)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Char- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsBytes(System.Char)')
  - [AsChar(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsChar-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsChar(System.Byte[])')
  - [AsDateTime(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsDateTime-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsDateTime(System.Byte[])')
  - [AsDouble(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsDouble-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsDouble(System.Byte[])')
  - [AsInt16(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt16-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsInt16(System.Byte[])')
  - [AsInt32(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt32-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsInt32(System.Byte[])')
  - [AsInt64(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt64-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsInt64(System.Byte[])')
  - [AsSingle(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsSingle-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsSingle(System.Byte[])')
  - [AsString(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsString-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsString(System.Byte[])')
  - [AsUInt16(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt16-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsUInt16(System.Byte[])')
  - [AsUInt32(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt32-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsUInt32(System.Byte[])')
  - [AsUInt64(bytes)](#M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt64-System-Byte[]- 'SweetLib.Utils.Extensions.BaseTypeExtensions.AsUInt64(System.Byte[])')
- [DateTimeExtensions](#T-SweetLib-Utils-Extensions-DateTimeExtensions 'SweetLib.Utils.Extensions.DateTimeExtensions')
  - [ToDateTime(timestamp)](#M-SweetLib-Utils-Extensions-DateTimeExtensions-ToDateTime-System-Double- 'SweetLib.Utils.Extensions.DateTimeExtensions.ToDateTime(System.Double)')
  - [ToUnixTimeStamp(date)](#M-SweetLib-Utils-Extensions-DateTimeExtensions-ToUnixTimeStamp-System-DateTime- 'SweetLib.Utils.Extensions.DateTimeExtensions.ToUnixTimeStamp(System.DateTime)')
- [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory')
  - [Archive(fullFileName)](#M-SweetLib-Utils-Logger-Memory-ILogMemory-Archive-System-String- 'SweetLib.Utils.Logger.Memory.ILogMemory.Archive(System.String)')
  - [Forget(message)](#M-SweetLib-Utils-Logger-Memory-ILogMemory-Forget-SweetLib-Utils-Logger-Message-LogMessage- 'SweetLib.Utils.Logger.Memory.ILogMemory.Forget(SweetLib.Utils.Logger.Message.LogMessage)')
  - [Remember(message)](#M-SweetLib-Utils-Logger-Memory-ILogMemory-Remember-SweetLib-Utils-Logger-Message-LogMessage- 'SweetLib.Utils.Logger.Memory.ILogMemory.Remember(SweetLib.Utils.Logger.Message.LogMessage)')
- [IStorer](#T-SweetLib-Classes-Storer-IStorer 'SweetLib.Classes.Storer.IStorer')
  - [DeleteKey(section,key)](#M-SweetLib-Classes-Storer-IStorer-DeleteKey-System-String,System-String- 'SweetLib.Classes.Storer.IStorer.DeleteKey(System.String,System.String)')
  - [DeleteSection(section)](#M-SweetLib-Classes-Storer-IStorer-DeleteSection-System-String- 'SweetLib.Classes.Storer.IStorer.DeleteSection(System.String)')
  - [HasKey(section,key)](#M-SweetLib-Classes-Storer-IStorer-HasKey-System-String,System-String- 'SweetLib.Classes.Storer.IStorer.HasKey(System.String,System.String)')
  - [ReadBool(section,key,defaultValue)](#M-SweetLib-Classes-Storer-IStorer-ReadBool-System-String,System-String,System-Boolean- 'SweetLib.Classes.Storer.IStorer.ReadBool(System.String,System.String,System.Boolean)')
  - [ReadInteger(section,key,defaultValue)](#M-SweetLib-Classes-Storer-IStorer-ReadInteger-System-String,System-String,System-Int32- 'SweetLib.Classes.Storer.IStorer.ReadInteger(System.String,System.String,System.Int32)')
  - [ReadString(section,key,defaultValue)](#M-SweetLib-Classes-Storer-IStorer-ReadString-System-String,System-String,System-String- 'SweetLib.Classes.Storer.IStorer.ReadString(System.String,System.String,System.String)')
  - [WriteBool(section,key,value)](#M-SweetLib-Classes-Storer-IStorer-WriteBool-System-String,System-String,System-Boolean- 'SweetLib.Classes.Storer.IStorer.WriteBool(System.String,System.String,System.Boolean)')
  - [WriteInteger(section,key,value)](#M-SweetLib-Classes-Storer-IStorer-WriteInteger-System-String,System-String,System-Int32- 'SweetLib.Classes.Storer.IStorer.WriteInteger(System.String,System.String,System.Int32)')
  - [WriteString(section,key,value)](#M-SweetLib-Classes-Storer-IStorer-WriteString-System-String,System-String,System-String- 'SweetLib.Classes.Storer.IStorer.WriteString(System.String,System.String,System.String)')
- [IniFileStorer](#T-SweetLib-Classes-Storer-IniFileStorer 'SweetLib.Classes.Storer.IniFileStorer')
  - [#ctor(fileName)](#M-SweetLib-Classes-Storer-IniFileStorer-#ctor-System-String- 'SweetLib.Classes.Storer.IniFileStorer.#ctor(System.String)')
  - [FileName](#P-SweetLib-Classes-Storer-IniFileStorer-FileName 'SweetLib.Classes.Storer.IniFileStorer.FileName')
- [LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel')
- [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage')
  - [#ctor(logLevel,message)](#M-SweetLib-Utils-Logger-Message-LogMessage-#ctor-SweetLib-Utils-Logger-LogLevel,System-String- 'SweetLib.Utils.Logger.Message.LogMessage.#ctor(SweetLib.Utils.Logger.LogLevel,System.String)')
  - [#ctor(logLevel,message,logDateTime)](#M-SweetLib-Utils-Logger-Message-LogMessage-#ctor-SweetLib-Utils-Logger-LogLevel,System-String,System-DateTime- 'SweetLib.Utils.Logger.Message.LogMessage.#ctor(SweetLib.Utils.Logger.LogLevel,System.String,System.DateTime)')
  - [LogDateTime](#P-SweetLib-Utils-Logger-Message-LogMessage-LogDateTime 'SweetLib.Utils.Logger.Message.LogMessage.LogDateTime')
  - [LogLevel](#P-SweetLib-Utils-Logger-Message-LogMessage-LogLevel 'SweetLib.Utils.Logger.Message.LogMessage.LogLevel')
  - [Message](#P-SweetLib-Utils-Logger-Message-LogMessage-Message 'SweetLib.Utils.Logger.Message.LogMessage.Message')
  - [ToString()](#M-SweetLib-Utils-Logger-Message-LogMessage-ToString 'SweetLib.Utils.Logger.Message.LogMessage.ToString')
  - [ToString(format,formatProvider)](#M-SweetLib-Utils-Logger-Message-LogMessage-ToString-System-String,System-IFormatProvider- 'SweetLib.Utils.Logger.Message.LogMessage.ToString(System.String,System.IFormatProvider)')
- [LogMessageFormatter](#T-SweetLib-Utils-Logger-Message-LogMessageFormatter 'SweetLib.Utils.Logger.Message.LogMessageFormatter')
  - [FormatterInstance](#P-SweetLib-Utils-Logger-Message-LogMessageFormatter-FormatterInstance 'SweetLib.Utils.Logger.Message.LogMessageFormatter.FormatterInstance')
  - [Instance](#P-SweetLib-Utils-Logger-Message-LogMessageFormatter-Instance 'SweetLib.Utils.Logger.Message.LogMessageFormatter.Instance')
  - [Format(format,arg,formatProvider)](#M-SweetLib-Utils-Logger-Message-LogMessageFormatter-Format-System-String,System-Object,System-IFormatProvider- 'SweetLib.Utils.Logger.Message.LogMessageFormatter.Format(System.String,System.Object,System.IFormatProvider)')
- [Logger](#T-SweetLib-Utils-Logger-Logger 'SweetLib.Utils.Logger.Logger')
  - [DefaultLogMemory](#P-SweetLib-Utils-Logger-Logger-DefaultLogMemory 'SweetLib.Utils.Logger.Logger.DefaultLogMemory')
  - [GlobalLogLevel](#P-SweetLib-Utils-Logger-Logger-GlobalLogLevel 'SweetLib.Utils.Logger.Logger.GlobalLogLevel')
  - [Debug(message)](#M-SweetLib-Utils-Logger-Logger-Debug-System-String- 'SweetLib.Utils.Logger.Logger.Debug(System.String)')
  - [Error(message)](#M-SweetLib-Utils-Logger-Logger-Error-System-String- 'SweetLib.Utils.Logger.Logger.Error(System.String)')
  - [Info(message)](#M-SweetLib-Utils-Logger-Logger-Info-System-String- 'SweetLib.Utils.Logger.Logger.Info(System.String)')
  - [Log(logLevel,message)](#M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String- 'SweetLib.Utils.Logger.Logger.Log(SweetLib.Utils.Logger.LogLevel,System.String)')
  - [Log(logLevel,message,logMemory)](#M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String,SweetLib-Utils-Logger-Memory-ILogMemory- 'SweetLib.Utils.Logger.Logger.Log(SweetLib.Utils.Logger.LogLevel,System.String,SweetLib.Utils.Logger.Memory.ILogMemory)')
  - [Log(message,logMemory)](#M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-Message-LogMessage,SweetLib-Utils-Logger-Memory-ILogMemory- 'SweetLib.Utils.Logger.Logger.Log(SweetLib.Utils.Logger.Message.LogMessage,SweetLib.Utils.Logger.Memory.ILogMemory)')
  - [Trace(message)](#M-SweetLib-Utils-Logger-Logger-Trace-System-String- 'SweetLib.Utils.Logger.Logger.Trace(System.String)')
  - [Warn(message)](#M-SweetLib-Utils-Logger-Logger-Warn-System-String- 'SweetLib.Utils.Logger.Logger.Warn(System.String)')
- [RegistryStorer](#T-SweetLib-Classes-Storer-RegistryStorer 'SweetLib.Classes.Storer.RegistryStorer')
  - [#ctor(appName)](#M-SweetLib-Classes-Storer-RegistryStorer-#ctor-System-String- 'SweetLib.Classes.Storer.RegistryStorer.#ctor(System.String)')
  - [#ctor(baseRegistryKey,appName)](#M-SweetLib-Classes-Storer-RegistryStorer-#ctor-Microsoft-Win32-RegistryKey,System-String- 'SweetLib.Classes.Storer.RegistryStorer.#ctor(Microsoft.Win32.RegistryKey,System.String)')
  - [OperatingRegistryKey](#P-SweetLib-Classes-Storer-RegistryStorer-OperatingRegistryKey 'SweetLib.Classes.Storer.RegistryStorer.OperatingRegistryKey')
- [RegistryStorerException](#T-SweetLib-Classes-Exceptions-RegistryStorerException 'SweetLib.Classes.Exceptions.RegistryStorerException')
  - [#ctor()](#M-SweetLib-Classes-Exceptions-RegistryStorerException-#ctor 'SweetLib.Classes.Exceptions.RegistryStorerException.#ctor')
  - [#ctor(message)](#M-SweetLib-Classes-Exceptions-RegistryStorerException-#ctor-System-String- 'SweetLib.Classes.Exceptions.RegistryStorerException.#ctor(System.String)')
- [SweetUtils](#T-SweetLib-Utils-SweetUtils 'SweetLib.Utils.SweetUtils')
  - [LegalizeFilename(fileName)](#M-SweetLib-Utils-SweetUtils-LegalizeFilename-System-String- 'SweetLib.Utils.SweetUtils.LegalizeFilename(System.String)')
  - [LegalizeFilename(fileName,replaceChar)](#M-SweetLib-Utils-SweetUtils-LegalizeFilename-System-String,System-Char- 'SweetLib.Utils.SweetUtils.LegalizeFilename(System.String,System.Char)')

<a name='T-SweetLib-Utils-Extensions-BaseTypeExtensions'></a>
## BaseTypeExtensions `type`

##### Namespace

SweetLib.Utils.Extensions

##### Summary

Defines extensions to some general classes.

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBool-System-Byte[]-'></a>
### AsBool(bytes) `method`

##### Summary

Converts a byte array into a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int16-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt16-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int32-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt32-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Int64-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-UInt64-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Single-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Double-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Boolean-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-DateTime-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-String-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to convert. |

##### Remarks

Using [UTF32Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.UTF32Encoding 'System.Text.UTF32Encoding') for converting.

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsBytes-System-Char-'></a>
### AsBytes(value) `method`

##### Summary

Converts a [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value into a byte array.

##### Returns

Byte array representation of the value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | Value to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsChar-System-Byte[]-'></a>
### AsChar(bytes) `method`

##### Summary

Converts a byte array into a [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsDateTime-System-Byte[]-'></a>
### AsDateTime(bytes) `method`

##### Summary

Converts a byte array into a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsDouble-System-Byte[]-'></a>
### AsDouble(bytes) `method`

##### Summary

Converts a byte array into a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt16-System-Byte[]-'></a>
### AsInt16(bytes) `method`

##### Summary

Converts a byte array into a [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt32-System-Byte[]-'></a>
### AsInt32(bytes) `method`

##### Summary

Converts a byte array into a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsInt64-System-Byte[]-'></a>
### AsInt64(bytes) `method`

##### Summary

Converts a byte array into a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsSingle-System-Byte[]-'></a>
### AsSingle(bytes) `method`

##### Summary

Converts a byte array into a [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsString-System-Byte[]-'></a>
### AsString(bytes) `method`

##### Summary

Converts a byte array into a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

##### Remarks

Using [UTF32Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.UTF32Encoding 'System.Text.UTF32Encoding') for converting.

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt16-System-Byte[]-'></a>
### AsUInt16(bytes) `method`

##### Summary

Converts a byte array into a [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt32-System-Byte[]-'></a>
### AsUInt32(bytes) `method`

##### Summary

Converts a byte array into a [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='M-SweetLib-Utils-Extensions-BaseTypeExtensions-AsUInt64-System-Byte[]-'></a>
### AsUInt64(bytes) `method`

##### Summary

Converts a byte array into a [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') type.

##### Returns

Converted value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte array representation to convert. |

<a name='T-SweetLib-Utils-Extensions-DateTimeExtensions'></a>
## DateTimeExtensions `type`

##### Namespace

SweetLib.Utils.Extensions

##### Summary

Defines extensions to classes which are related to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

<a name='M-SweetLib-Utils-Extensions-DateTimeExtensions-ToDateTime-System-Double-'></a>
### ToDateTime(timestamp) `method`

##### Summary

Converts an Unix timestamp into a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Returns

Converted [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timestamp | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Unix timestamp to convert. |

<a name='M-SweetLib-Utils-Extensions-DateTimeExtensions-ToUnixTimeStamp-System-DateTime-'></a>
### ToUnixTimeStamp(date) `method`

##### Summary

Converts a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') into an Unix timestamp.

##### Returns

Converted Unix timestamp.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') to convert into Unix timestamp. |

<a name='T-SweetLib-Utils-Logger-Memory-ILogMemory'></a>
## ILogMemory `type`

##### Namespace

SweetLib.Utils.Logger.Memory

##### Summary

Interface for a class to store and proceed [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') objects.

<a name='M-SweetLib-Utils-Logger-Memory-ILogMemory-Archive-System-String-'></a>
### Archive(fullFileName) `method`

##### Summary

Saves all remembered [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') objects into a persistent file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File name to store the [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') objects. |

<a name='M-SweetLib-Utils-Logger-Memory-ILogMemory-Forget-SweetLib-Utils-Logger-Message-LogMessage-'></a>
### Forget(message) `method`

##### Summary

Removes a [](#!-message 'message') from the [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [SweetLib.Utils.Logger.Message.LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') | [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') to be removed. |

##### Remarks

This might not have any effect depending on the [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') implementation.

<a name='M-SweetLib-Utils-Logger-Memory-ILogMemory-Remember-SweetLib-Utils-Logger-Message-LogMessage-'></a>
### Remember(message) `method`

##### Summary

Adds a [](#!-message 'message') into the [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [SweetLib.Utils.Logger.Message.LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') | [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') to be stored. |

<a name='T-SweetLib-Classes-Storer-IStorer'></a>
## IStorer `type`

##### Namespace

SweetLib.Classes.Storer

##### Summary

Interface, which provides several methods to store simple data.

<a name='M-SweetLib-Classes-Storer-IStorer-DeleteKey-System-String,System-String-'></a>
### DeleteKey(section,key) `method`

##### Summary

Deletes a key inside a [](#!-section 'section').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key to be deleted. |

<a name='M-SweetLib-Classes-Storer-IStorer-DeleteSection-System-String-'></a>
### DeleteSection(section) `method`

##### Summary

Deletes a section with all its keys.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section to be deleted. |

<a name='M-SweetLib-Classes-Storer-IStorer-HasKey-System-String,System-String-'></a>
### HasKey(section,key) `method`

##### Summary

Checks, if a key exists inside a section.

##### Returns

True, if [](#!-key 'key') is found inside [](#!-section 'section').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |

<a name='M-SweetLib-Classes-Storer-IStorer-ReadBool-System-String,System-String,System-Boolean-'></a>
### ReadBool(section,key,defaultValue) `method`

##### Summary

Reads a bool value.

##### Returns

Value of the [](#!-key 'key') in [](#!-section 'section').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| defaultValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Default value, if this value does not exist. |

<a name='M-SweetLib-Classes-Storer-IStorer-ReadInteger-System-String,System-String,System-Int32-'></a>
### ReadInteger(section,key,defaultValue) `method`

##### Summary

Reads an integer value.

##### Returns

Value of the [](#!-key 'key') in [](#!-section 'section').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| defaultValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Default value, if this value does not exist. |

<a name='M-SweetLib-Classes-Storer-IStorer-ReadString-System-String,System-String,System-String-'></a>
### ReadString(section,key,defaultValue) `method`

##### Summary

Reads a string value.

##### Returns

Value of the [](#!-key 'key') in [](#!-section 'section').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Default value, if this value does not exist. |

<a name='M-SweetLib-Classes-Storer-IStorer-WriteBool-System-String,System-String,System-Boolean-'></a>
### WriteBool(section,key,value) `method`

##### Summary

Writes a bool value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Value to be stored. |

<a name='M-SweetLib-Classes-Storer-IStorer-WriteInteger-System-String,System-String,System-Int32-'></a>
### WriteInteger(section,key,value) `method`

##### Summary

Writes an integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to be stored. |

<a name='M-SweetLib-Classes-Storer-IStorer-WriteString-System-String,System-String,System-String-'></a>
### WriteString(section,key,value) `method`

##### Summary

Writes a string value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the section in which the data is stored. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Represents the key of the stored data. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to be stored. |

<a name='T-SweetLib-Classes-Storer-IniFileStorer'></a>
## IniFileStorer `type`

##### Namespace

SweetLib.Classes.Storer

##### Summary

Implementation of an [IStorer](#T-SweetLib-Classes-Storer-IStorer 'SweetLib.Classes.Storer.IStorer') interface which stores the data inside an ini file.

<a name='M-SweetLib-Classes-Storer-IniFileStorer-#ctor-System-String-'></a>
### #ctor(fileName) `constructor`

##### Summary

Creates a new instance of [IniFileStorer](#T-SweetLib-Classes-Storer-IniFileStorer 'SweetLib.Classes.Storer.IniFileStorer') with a specified file name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file name of the ini file. |

<a name='P-SweetLib-Classes-Storer-IniFileStorer-FileName'></a>
### FileName `property`

##### Summary

Ini file path.

<a name='T-SweetLib-Utils-Logger-LogLevel'></a>
## LogLevel `type`

##### Namespace

SweetLib.Utils.Logger

##### Summary

Enum which contains the several log levels.

<a name='T-SweetLib-Utils-Logger-Message-LogMessage'></a>
## LogMessage `type`

##### Namespace

SweetLib.Utils.Logger.Message

##### Summary

[LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') contains all event log data which should be logged in as a single log message.

<a name='M-SweetLib-Utils-Logger-Message-LogMessage-#ctor-SweetLib-Utils-Logger-LogLevel,System-String-'></a>
### #ctor(logLevel,message) `constructor`

##### Summary

Creates a new [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') instance. [Now](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime.Now 'System.DateTime.Now') will be the [LogDateTime](#P-SweetLib-Utils-Logger-Message-LogMessage-LogDateTime 'SweetLib.Utils.Logger.Message.LogMessage.LogDateTime').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [SweetLib.Utils.Logger.LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel') | The log level of this event log. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of this event log. |

<a name='M-SweetLib-Utils-Logger-Message-LogMessage-#ctor-SweetLib-Utils-Logger-LogLevel,System-String,System-DateTime-'></a>
### #ctor(logLevel,message,logDateTime) `constructor`

##### Summary

Creates a new [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [SweetLib.Utils.Logger.LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel') | The log level of this event log. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of this event log. |
| logDateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') of this event log. |

<a name='P-SweetLib-Utils-Logger-Message-LogMessage-LogDateTime'></a>
### LogDateTime `property`

##### Summary

The date and time of this event log.

<a name='P-SweetLib-Utils-Logger-Message-LogMessage-LogLevel'></a>
### LogLevel `property`

##### Summary

The [LogLevel](#P-SweetLib-Utils-Logger-Message-LogMessage-LogLevel 'SweetLib.Utils.Logger.Message.LogMessage.LogLevel') of this event log.

<a name='P-SweetLib-Utils-Logger-Message-LogMessage-Message'></a>
### Message `property`

##### Summary

The message of this event log.

<a name='M-SweetLib-Utils-Logger-Message-LogMessage-ToString'></a>
### ToString() `method`

##### Summary

Generates a formatted [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of this event log. [DefaultFormatString](#P-SweetLib-Utils-Logger-Message-LogMessageFormatter-DefaultFormatString 'SweetLib.Utils.Logger.Message.LogMessageFormatter.DefaultFormatString') will be used to format this event log.

##### Returns

A formated [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of this event log.

##### Parameters

This method has no parameters.

<a name='M-SweetLib-Utils-Logger-Message-LogMessage-ToString-System-String,System-IFormatProvider-'></a>
### ToString(format,formatProvider) `method`

##### Summary

Generates a formatted [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of this event log with a given format.

##### Returns

A formated [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of this event log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format to be used. See [LogMessageFormatter](#T-SweetLib-Utils-Logger-Message-LogMessageFormatter 'SweetLib.Utils.Logger.Message.LogMessageFormatter') for more format information. |
| formatProvider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | Optional, an [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') interface to be used while formatting if needed. |

<a name='T-SweetLib-Utils-Logger-Message-LogMessageFormatter'></a>
## LogMessageFormatter `type`

##### Namespace

SweetLib.Utils.Logger.Message

##### Summary

A [ICustomFormatter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ICustomFormatter 'System.ICustomFormatter') which is used to format [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') objects.

##### Remarks

This class implements a singleton pattern.

<a name='P-SweetLib-Utils-Logger-Message-LogMessageFormatter-FormatterInstance'></a>
### FormatterInstance `property`

##### Summary

Accesses the global instance of the [LogMessageFormatter](#T-SweetLib-Utils-Logger-Message-LogMessageFormatter 'SweetLib.Utils.Logger.Message.LogMessageFormatter').

<a name='P-SweetLib-Utils-Logger-Message-LogMessageFormatter-Instance'></a>
### Instance `property`

##### Summary

The default format string which is used to format [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') objects, if no custom format string is provided.

<a name='M-SweetLib-Utils-Logger-Message-LogMessageFormatter-Format-System-String,System-Object,System-IFormatProvider-'></a>
### Format(format,arg,formatProvider) `method`

##### Summary

Formats a [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') object.

##### Returns

A formatted [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of the [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format string. If [](#!-null 'null'), [DefaultFormatString](#P-SweetLib-Utils-Logger-Message-LogMessageFormatter-DefaultFormatString 'SweetLib.Utils.Logger.Message.LogMessageFormatter.DefaultFormatString') will be used. |
| arg | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') object to be formatted. |
| formatProvider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | Optional, an [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') interface to be used while formatting if needed. |

##### Remarks

If [](#!-arg 'arg') is not a [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') object, it will either be returned the formatted string implemented by the type of [](#!-arg 'arg'), if [IFormattable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormattable 'System.IFormattable') is implemented by it, or the [](#!-arg-ToString-- 'arg.ToString()') result."

<a name='T-SweetLib-Utils-Logger-Logger'></a>
## Logger `type`

##### Namespace

SweetLib.Utils.Logger

##### Summary

Global logger class providing several methods to log events by the application.

##### Remarks

As [DefaultLogMemory](#P-SweetLib-Utils-Logger-Logger-DefaultLogMemory 'SweetLib.Utils.Logger.Logger.DefaultLogMemory') a [ArchivableConsoleLogMemory](#T-SweetLib-Utils-Logger-Memory-ArchivableConsoleLogMemory 'SweetLib.Utils.Logger.Memory.ArchivableConsoleLogMemory') will be used. You can change this to any other implementation at any time while runtime. 
Default log levels are set as bitflags in [GlobalLogLevel](#P-SweetLib-Utils-Logger-Logger-GlobalLogLevel 'SweetLib.Utils.Logger.Logger.GlobalLogLevel').

<a name='P-SweetLib-Utils-Logger-Logger-DefaultLogMemory'></a>
### DefaultLogMemory `property`

##### Summary

The default [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') which will be used for any logging action, if no custom [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') is set as parameter.

<a name='P-SweetLib-Utils-Logger-Logger-GlobalLogLevel'></a>
### GlobalLogLevel `property`

##### Summary

The global log level. Only messages with the set [LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel') will be procedered.

<a name='M-SweetLib-Utils-Logger-Logger-Debug-System-String-'></a>
### Debug(message) `method`

##### Summary

Will log a message with the [Debug](#F-SweetLib-Utils-Logger-LogLevel-Debug 'SweetLib.Utils.Logger.LogLevel.Debug') log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to log. |

<a name='M-SweetLib-Utils-Logger-Logger-Error-System-String-'></a>
### Error(message) `method`

##### Summary

Will log a message with the [Error](#F-SweetLib-Utils-Logger-LogLevel-Error 'SweetLib.Utils.Logger.LogLevel.Error') log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to log. |

<a name='M-SweetLib-Utils-Logger-Logger-Info-System-String-'></a>
### Info(message) `method`

##### Summary

Will log a message with the [Info](#F-SweetLib-Utils-Logger-LogLevel-Info 'SweetLib.Utils.Logger.LogLevel.Info') log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to log. |

<a name='M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String-'></a>
### Log(logLevel,message) `method`

##### Summary

Will log a message into the global [DefaultLogMemory](#P-SweetLib-Utils-Logger-Logger-DefaultLogMemory 'SweetLib.Utils.Logger.Logger.DefaultLogMemory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [SweetLib.Utils.Logger.LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel') | The log level of this message. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to log. |

<a name='M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String,SweetLib-Utils-Logger-Memory-ILogMemory-'></a>
### Log(logLevel,message,logMemory) `method`

##### Summary

Will log a message into the provided [](#!-logMemory 'logMemory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [SweetLib.Utils.Logger.LogLevel](#T-SweetLib-Utils-Logger-LogLevel 'SweetLib.Utils.Logger.LogLevel') | The log level of this message. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to log. |
| logMemory | [SweetLib.Utils.Logger.Memory.ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') | The [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') to store the [](#!-message 'message') into. |

<a name='M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-Message-LogMessage,SweetLib-Utils-Logger-Memory-ILogMemory-'></a>
### Log(message,logMemory) `method`

##### Summary

Will log a message into the provided [](#!-logMemory 'logMemory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [SweetLib.Utils.Logger.Message.LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') | A [LogMessage](#T-SweetLib-Utils-Logger-Message-LogMessage 'SweetLib.Utils.Logger.Message.LogMessage') object to store. |
| logMemory | [SweetLib.Utils.Logger.Memory.ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') | The [ILogMemory](#T-SweetLib-Utils-Logger-Memory-ILogMemory 'SweetLib.Utils.Logger.Memory.ILogMemory') to store the [](#!-message 'message') into. |

##### Remarks

In general use cases you should either use one of the [Log](#M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String- 'SweetLib.Utils.Logger.Logger.Log(SweetLib.Utils.Logger.LogLevel,System.String)') or [Log](#M-SweetLib-Utils-Logger-Logger-Log-SweetLib-Utils-Logger-LogLevel,System-String- 'SweetLib.Utils.Logger.Logger.Log(SweetLib.Utils.Logger.LogLevel,System.String)') methods which will generate a call to this method.

<a name='M-SweetLib-Utils-Logger-Logger-Trace-System-String-'></a>
### Trace(message) `method`

##### Summary

Will log a message with the [Trace](#F-SweetLib-Utils-Logger-LogLevel-Trace 'SweetLib.Utils.Logger.LogLevel.Trace') log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to log. |

<a name='M-SweetLib-Utils-Logger-Logger-Warn-System-String-'></a>
### Warn(message) `method`

##### Summary

Will log a message with the [Warn](#F-SweetLib-Utils-Logger-LogLevel-Warn 'SweetLib.Utils.Logger.LogLevel.Warn') log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message to log. |

<a name='T-SweetLib-Classes-Storer-RegistryStorer'></a>
## RegistryStorer `type`

##### Namespace

SweetLib.Classes.Storer

##### Summary

Implementation of an [IStorer](#T-SweetLib-Classes-Storer-IStorer 'SweetLib.Classes.Storer.IStorer') interface which stores the data inside the registry.

##### Remarks

Sections will be interpreted as subkeys on registry level.

<a name='M-SweetLib-Classes-Storer-RegistryStorer-#ctor-System-String-'></a>
### #ctor(appName) `constructor`

##### Summary

Creates a new instance of [RegistryStorer](#T-SweetLib-Classes-Storer-RegistryStorer 'SweetLib.Classes.Storer.RegistryStorer') with a specified application name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The applications base name. This will be used as name for a sub key inside the software key below the base key. |

##### Remarks

This will use current user as the base key.

<a name='M-SweetLib-Classes-Storer-RegistryStorer-#ctor-Microsoft-Win32-RegistryKey,System-String-'></a>
### #ctor(baseRegistryKey,appName) `constructor`

##### Summary

Creates a new instance of [RegistryStorer](#T-SweetLib-Classes-Storer-RegistryStorer 'SweetLib.Classes.Storer.RegistryStorer') with a specified application name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseRegistryKey | [Microsoft.Win32.RegistryKey](#T-Microsoft-Win32-RegistryKey 'Microsoft.Win32.RegistryKey') | Provide a key of [Registry](#T-Microsoft-Win32-Registry 'Microsoft.Win32.Registry'), e.G. . |
| appName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The applications base name. This will be used as name for a sub key inside the software key below the base key. |

<a name='P-SweetLib-Classes-Storer-RegistryStorer-OperatingRegistryKey'></a>
### OperatingRegistryKey `property`

##### Summary

The base registry key in which will be operated.

<a name='T-SweetLib-Classes-Exceptions-RegistryStorerException'></a>
## RegistryStorerException `type`

##### Namespace

SweetLib.Classes.Exceptions

##### Summary

Exception thrown by [RegistryStorer](#T-SweetLib-Classes-Storer-RegistryStorer 'SweetLib.Classes.Storer.RegistryStorer').

<a name='M-SweetLib-Classes-Exceptions-RegistryStorerException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new [RegistryStorerException](#T-SweetLib-Classes-Exceptions-RegistryStorerException 'SweetLib.Classes.Exceptions.RegistryStorerException').

##### Parameters

This constructor has no parameters.

<a name='M-SweetLib-Classes-Exceptions-RegistryStorerException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Creates a new [RegistryStorerException](#T-SweetLib-Classes-Exceptions-RegistryStorerException 'SweetLib.Classes.Exceptions.RegistryStorerException').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Exception message. |

<a name='T-SweetLib-Utils-SweetUtils'></a>
## SweetUtils `type`

##### Namespace

SweetLib.Utils

##### Summary

A generic class containing useful methods.

<a name='M-SweetLib-Utils-SweetUtils-LegalizeFilename-System-String-'></a>
### LegalizeFilename(fileName) `method`

##### Summary

Legalizes a file name with the [DefaultFileNameReplaceChar](#P-SweetLib-Utils-SweetUtils-DefaultFileNameReplaceChar 'SweetLib.Utils.SweetUtils.DefaultFileNameReplaceChar') character.

##### Returns

Legalized file name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File name to legalize. |

<a name='M-SweetLib-Utils-SweetUtils-LegalizeFilename-System-String,System-Char-'></a>
### LegalizeFilename(fileName,replaceChar) `method`

##### Summary

Legalizes a file name by a given replace character.

##### Returns

Legalized file name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File name to legalize. |
| replaceChar | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | Character to be used as replace character. |
